using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitBurnerSaveEditor
{
    public partial class MainForm : Form
    {
        private static readonly System.Globalization.CultureInfo _fp = System.Globalization.CultureInfo.InvariantCulture;
        private SaveObject _SaveFile;
        private SaveDataTree _Tree;
        private string _OpenedFile;
        public MainForm()
        {
            InitializeComponent();
            DgvFactionsView.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.InvariantCulture;
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        } // MenuFileOpen_Click

        private void OpenFile()
        {
            using OpenFileDialog dlg = new() { Filter = "Json files|*.json|All files|*.*", Title = "Choose a file to open" };
            var ret = dlg.ShowDialog();
            if (DialogResult.OK != ret) return;

            try
            {
                var content = File.ReadAllText(dlg.FileName);
                var decodedBytes = Convert.FromBase64String(content);
                var decoded = Encoding.UTF8.GetString(decodedBytes);
                TextRaw.Text = decoded;
                _SaveFile = new SaveObject(decoded);
                _Tree = new SaveDataTree(decoded);
                _SaveFile.Updated += Savefile_Updated;
                RefreshInterfaceData();
                PopulateObjectTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // OpenFile

        private void Savefile_Updated(object sender, EventArgs e)
        {
            this.TextRaw.Text = _SaveFile.RawData;
        } // Savefile_Updated

        bool IsUpdating = false;
        private void RefreshInterfaceData()
        {
            IsUpdating = true;
            if (_SaveFile is null)
            {
                foreach(var txt in new TextBox[] { TextMoney, TextHack, TextStr, TextDef, TextDex, TextAgi, TextCha, TextInt,
                                                    TextHackExp, TextStrExp, TextDefExp, TextDexExp, TextAgiExp, TextChaExp, TextIntExp, 
                                                    TextRaw})
                {
                    txt.Clear();
                }
                DgvFactionsView.DataSource = null;
                return;
            }
            
            TextMoney.Text = _SaveFile.Player.Money.ToString("0.000", _fp);
            TextHack.Text = _SaveFile.Player.Hacking.ToString("0", _fp);
            TextStr.Text = _SaveFile.Player.Strength.ToString("0", _fp);
            TextDef.Text = _SaveFile.Player.Defense.ToString("0", _fp);
            TextDex.Text = _SaveFile.Player.Dexterity.ToString("0", _fp);
            TextAgi.Text = _SaveFile.Player.Agility.ToString("0", _fp);
            TextCha.Text = _SaveFile.Player.Charisma.ToString("0", _fp);
            TextInt.Text = _SaveFile.Player.Intelligence.ToString("0", _fp);

            TextHackExp.Text = _SaveFile.Player.HackingExp.ToString("0.000", _fp);
            TextStrExp.Text = _SaveFile.Player.StengthExp.ToString("0.000", _fp);
            TextDefExp.Text = _SaveFile.Player.DefenseExp.ToString("0.000", _fp);
            TextDexExp.Text = _SaveFile.Player.DexterityExp.ToString("0.000", _fp);
            TextAgiExp.Text = _SaveFile.Player.AgilityExp.ToString("0.000", _fp);
            TextChaExp.Text = _SaveFile.Player.CharismaExp.ToString("0.000", _fp);
            TextIntExp.Text = _SaveFile.Player.IntelligenceExp.ToString("0.000", _fp);

            CheckWSEaccount.Checked = _SaveFile.Player.HasWseAccount;
            CheckTixApi.Checked = _SaveFile.Player.HasTixApiAccess;
            Check4SData.Checked = _SaveFile.Player.Has4SData;
            Check4STixApi.Checked = _SaveFile.Player.Has4SDataTixApi;

            DgvFactionsView.AutoGenerateColumns = false;
            DgvBBSkills.AutoGenerateColumns = false;
            DgvFactionsView.DataSource = _SaveFile.Factions.Factions;
            if (_SaveFile.Player.BladeBurnerData is not null)
            {
                if (!TabControlMain.TabPages.Contains(TabBladeburner)) TabControlMain.TabPages.Insert(2, TabBladeburner);
                TextBBRank.Text = _SaveFile.Player.BladeBurnerData.Rank.ToString("0.000", _fp);
                TextBBStamina.Text = _SaveFile.Player.BladeBurnerData.Stamina.ToString("0.000", _fp);
                TextBBSkillPoints.Text = _SaveFile.Player.BladeBurnerData.SkillPoints.ToString("0", _fp);
                DgvBBSkills.DataSource = _SaveFile.Player.BladeBurnerData.Skills;
                ComboBBKnownSkills.Items.AddRange(_SaveFile.Player.BladeBurnerData.MissingSkills.ToArray());
                BBUpdateReadOnlyValues();
                _SaveFile.Player.BladeBurnerData.Updated += BB_SkillsUpdated;
            }
            else
            {
                TabControlMain.TabPages.Remove(TabBladeburner);
            }
            
            IsUpdating = false;
        } // RefreshInterfaceData
        private void PopulateObjectTree(TreeNode startFrom = null)
        {
            bool isroot = false;
            SaveDataTreeNode _currentObject = null;
            TreeViewMain.Nodes.Clear();
            if (startFrom is null)
            {
                startFrom = new() { Tag = _Tree, Text = "ROOT" };
                _currentObject = _Tree.Root;
                isroot = true;
            }
            else if (startFrom.Tag is SaveDataTreeNode objData)
            {
                _currentObject = objData;
            }
            if (_currentObject is not null)
            {
                foreach (var child in _currentObject)
                {
                    TreeNode childTN = new() { Tag = child, Text = child.ToString() };
                    PopulateObjectTree(childTN);
                    startFrom.Nodes.Add(childTN);
                } // foreach    
            }
            if (isroot)
            {
                TreeViewMain.Nodes.Add(startFrom);
            }
        }
        private void BB_SkillsUpdated(object sender, EventArgs e)
        {
            BBUpdateReadOnlyValues();
        } // BB_SkillsUpdated
        private void BBUpdateReadOnlyValues()
        {
            LabelBBMaxRank.Text = _SaveFile.Player.BladeBurnerData.MaxRank.ToString("0.000", _fp);
            LabelBBMaxStamina.Text = _SaveFile.Player.BladeBurnerData.MaxStamina.ToString("0.000", _fp);
            LabelBBTotalSkillPoints.Text = _SaveFile.Player.BladeBurnerData.TotalSkillPoints.ToString("0", _fp);
        } // BBUpdateReadOnlyValues
        private void Stats_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdating) return;
            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;
            var txt = sender as TextBox;
            var statName = txt.Tag.ToString();
            string textToParse = txt.Text;
            if (textToParse.ToLower().EndsWith("e")) textToParse += '0';
            if(!double.TryParse(textToParse, ns, fp,  out double newValue))
            {
                txt.Focus();
                MessageBox.Show("Value format is invalid", "Invalid value format");
                return;
            }
            _SaveFile.Player.UpdateValue(statName, newValue);
        } // Stats_TextChanged
        private void Save(bool DisplayDialog = false)
        {
            if (_SaveFile is null) return;
            if (string.IsNullOrEmpty(_OpenedFile) || DisplayDialog)
            {
                using SaveFileDialog dlg = new() { Filter = "Json files|*.json" };
                var ret = dlg.ShowDialog();
                if (DialogResult.OK != ret) return;
                _OpenedFile = dlg.FileName;
            }
            try
            {
                var rawBytes = Encoding.UTF8.GetBytes(_SaveFile.RawData);
                var encoded = Convert.ToBase64String(rawBytes);
                File.WriteAllText(_OpenedFile, encoded);
                MessageBox.Show("File saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SaveFile.Changed = false;
            } // try
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // catch
        } // Save
        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            Save();
        } // MenuFileSave_Click
        private void MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            Save(DisplayDialog: true);
        } // MenuFileSaveAs_Click
        private void MenuFileClose_Click(object sender, EventArgs e)
        {
            if (_SaveFile is not null && _SaveFile.Changed)
            {
                DialogResult ret = MessageBox.Show("Save the data before closing?", "Unsaved changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult.Cancel == ret)
                {
                    return;
                }
                if (DialogResult.Yes == ret)
                {
                    Save();
                }
            }
            _SaveFile = null;
            RefreshInterfaceData(); 
        } // MenuFileClose_Click
        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // MenuFileExit_Click
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_SaveFile is not null && _SaveFile.Changed)
            {
                DialogResult ret = MessageBox.Show("Save the data before closing?", "Unsaved changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult.Cancel == ret)
                {
                    e.Cancel = true;
                    return;
                }
                if (DialogResult.Yes == ret)
                {
                    Save();
                }
            }
        } // MainForm_FormClosing
        private void DgvFactionsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (IsUpdating || _SaveFile is null) return;
            _SaveFile.Factions.OnValueChanged();
        } // DgvFactionsView_CellValueChanged
        private void BBTextBoxRank_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdating) return;

            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;
            var txt = sender as TextBox;

            string textToParse = txt.Text;
            if (textToParse.ToLower().EndsWith("e")) textToParse += '0';
            if (!double.TryParse(textToParse, ns, fp, out double newValue))
            {
                txt.Focus();
                MessageBox.Show("Value format is invalid", "Invalid value format");
                return;
            }
            _SaveFile.Player.BladeBurnerData.Rank = newValue;
        } // BBTextBoxRank_TextChanged

        private void BBTextBoxStamina_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdating) return;

            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;
            var txt = sender as TextBox;

            string textToParse = txt.Text;
            if (textToParse.ToLower().EndsWith("e")) textToParse += '0';
            if (!double.TryParse(textToParse, ns, fp, out double newValue))
            {
                txt.Focus();
                MessageBox.Show("Value format is invalid", "Invalid value format");
                return;
            }
            _SaveFile.Player.BladeBurnerData.Stamina = newValue;
        } // BBTextBoxStamina_TextChanged

        private void BBTextBoxSkillPoints_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdating) return;

            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;
            var txt = sender as TextBox;

            string textToParse = txt.Text;
            if (!int.TryParse(textToParse, ns, fp, out int newValue))
            {
                txt.Focus();
                MessageBox.Show("Value format is invalid", "Invalid value format");
                return;
            }
            _SaveFile.Player.BladeBurnerData.SkillPoints = newValue;
        } // BBTextBoxSkillPoints_TextChanged
        private void CheckBoxStockExch_CheckedChanged(object sender, EventArgs e)
        {
            if (IsUpdating) return;
            var chk = sender as CheckBox;
            var statName = chk.Tag.ToString();
            _SaveFile.Player.UpdateValue(statName, chk.Checked);
        } // CheckBoxStockExch_CheckedChanged
        private void ButtonMasterExp_Click(object sender, EventArgs e)
        {
            if (_SaveFile is null) return;
            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;

            if (!double.TryParse(TextMasterExp.Text, ns, fp, out double number)) return; 

            IsUpdating = true;
            foreach(var txt in new TextBox[] { TextMoney, TextHackExp, TextStrExp, TextDefExp, TextDexExp, TextAgiExp, TextChaExp })
            {
                txt.Text = number.ToString("0.000", fp);
                var propName = txt.Tag.ToString();
                _SaveFile.Player.UpdateValue(propName, number);
            }
            IsUpdating = false;
        } // ButtonMasterExp_Click

        private void ButtonMasterRep_Click(object sender, EventArgs e)
        {
            if (_SaveFile is null) return;
            var fp = System.Globalization.CultureInfo.InvariantCulture;
            var ns = System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowExponent | System.Globalization.NumberStyles.AllowTrailingWhite | System.Globalization.NumberStyles.AllowLeadingWhite;
            if (!double.TryParse(TextMasterRep.Text, ns, fp, out double number)) return;
            IsUpdating = true;
            foreach(var fact in _SaveFile.Factions.Factions)
            {
                fact.Reputation = number;
            } // foreach
            DgvFactionsView.DataSource = _SaveFile.Factions.Factions;
        } // ButtonMasterRep_Click

        private void ComboBBKnownSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonBBAddMissingSkill.Enabled = ComboBBKnownSkills.SelectedItem is not null;
        } // ComboBBKnownSkills_SelectedIndexChanged

        private void ButtonBBAddMissingSkill_Click(object sender, EventArgs e)
        {
            var skillName = ComboBBKnownSkills.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(skillName)) return;
            _SaveFile.Player.BladeBurnerData.AddMissingSkill(skillName);
            ComboBBKnownSkills.Items.Clear();
            ComboBBKnownSkills.Items.AddRange(_SaveFile.Player.BladeBurnerData.MissingSkills.ToArray());
        } // ButtonBBAddMissingSkill_Click
    } // class MainForm
} // namespace
