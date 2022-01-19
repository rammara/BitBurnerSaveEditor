using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace BitBurnerSaveEditor
{
    public abstract class SaveObjectBase
    {
        public event EventHandler Updated;
        public void OnValueChanged()
        {
            UpdateRawData();
            this.Updated?.Invoke(this, new());
        }
        protected JObject _obj;
        private readonly JsonSerializer jd;
        
        public string RawData { get; protected set; }
        public SaveObjectBase(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Conenct cannot be null");
            }
            RawData = content;
            using var treader = new StringReader(content);
            using var jreader = new JsonTextReader(treader);
            jd = JsonSerializer.Create();
            _obj = (JObject)jd.Deserialize(jreader);
        } // SaveObjectBase ctor

        protected void UpdateRawData()
        {
            var sb = new StringBuilder();
            using var twriter = new StringWriter(sb);
            using var jwriter = new JsonTextWriter(twriter);
            jd.Serialize(jwriter, _obj);
            RawData = sb.ToString();
        } // UpdateRawData

    } // class SaveObjectBase

    public class SaveObject: SaveObjectBase
    {
        public PlayerObject Player { get; init; }
        public bool Changed { get; set; }
        public FactionsObject Factions { get; init; }
        public SaveObject(string content) : base(content)
        {
            Player = new(_obj["data"]["PlayerSave"].ToString());
            Factions = new(_obj["data"]["FactionsSave"].ToString());
            Player.Updated += Player_Updated;
            Factions.Updated += Factions_Updated;
            Changed = false;
        } // SaveObject ctor;

        private void Factions_Updated(object sender, EventArgs e)
        {
            _obj["data"]["FactionsSave"] = Factions.RawData;
            Changed = true;
            OnValueChanged();
        } // Factions_Updated

        private void Player_Updated(object sender, EventArgs e)
        {
            _obj["data"]["PlayerSave"] = Player.RawData;
            Changed = true;
            OnValueChanged();
        } // Player_Updated
    } // SaveObject


    public class PlayerObject : SaveObjectBase
    {
        public double Hacking { get; set; }
        public double Strength { get; set; }
        public double Defense { get; set; }
        public double Dexterity { get; set; }
        public double Agility { get; set; }
        public double Charisma { get; set; }
        public double Intelligence { get; set; }
        public double Money { get; set; }
        public double HackingExp { get; set; }
        public double StengthExp { get; set; }
        public double DefenseExp { get; set; }
        public double DexterityExp { get; set; }
        public double AgilityExp { get; set; }
        public double CharismaExp { get; set; }
        public double IntelligenceExp { get; set; }
        public bool HasWseAccount { get; set; } // hasWseAccount
        public bool HasTixApiAccess { get; set; } // hasTixApiAccess
        public bool Has4SData { get; set; } // has4SData
        public bool Has4SDataTixApi { get; set; }// has4SDataTixApi
        public BladeBurnerInfo BladeBurnerData {get; protected set;}
        public PlayerObject(string content) : base(content)
        {
            SetPropertyValues();
        } // PlayerObject ctor

        public void UpdateValue(string statName, double value)
        {
            var data = _obj["data"];
            data[statName] = value;
            OnValueChanged();
        } // UpdateValue

        private void SetPropertyValues()
        {
            var data = _obj["data"];

            Hacking = Convert.ToDouble(data["hacking"]);
            Strength = Convert.ToDouble(data["strength"]);
            Defense = Convert.ToDouble(data["defense"]);
            Dexterity = Convert.ToDouble(data["dexterity"]);
            Agility = Convert.ToDouble(data["agility"]);
            Charisma = Convert.ToDouble(data["charisma"]);
            Intelligence = Convert.ToDouble(data["intelligence"]);
            Money = Convert.ToDouble(data["money"]);
            HackingExp = Convert.ToDouble(data["hacking_exp"]);
            StengthExp = Convert.ToDouble(data["strength_exp"]);
            DefenseExp = Convert.ToDouble(data["defense_exp"]);
            DexterityExp = Convert.ToDouble(data["dexterity_exp"]);
            AgilityExp = Convert.ToDouble(data["agility_exp"]);
            CharismaExp = Convert.ToDouble(data["charisma_exp"]);
            IntelligenceExp = Convert.ToDouble(data["intelligence_exp"]);
            HasWseAccount = Convert.ToBoolean(data["hasWseAccount"]);
            HasTixApiAccess = Convert.ToBoolean(data["hasTixApiAccess"]);
            Has4SData = Convert.ToBoolean(data["has4SData"]);
            Has4SDataTixApi = Convert.ToBoolean(data["has4SDataTixApi"]);
            if (data["bladeburner"] is not null)
            {
                var bbObj = (JObject)data["bladeburner"]["data"];
                BladeBurnerData = new(bbObj);
            }
        }
    } // class PlayerObject

    public class FactionsObject : SaveObjectBase
    {
        public BindingList<FactionDataObject> Factions = new();
        public FactionsObject(string content) :base(content)
        {
            foreach(var prop in _obj.Properties())
            {
                var fdo = new FactionDataObject(prop.Name, prop.Value.ToString());
                fdo.PropertyChanged += Fdo_PropertyChanged;
                Factions.Add(fdo);
            }
        } // FactionsObject ctor

        private void Fdo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FactionDataObject fdo = sender as FactionDataObject;
            _obj[fdo.Name] = fdo.GetDataObject();
            OnValueChanged();
        }
    } // class FactionsObject

    public class FactionDataObject : SaveObjectBase, INotifyPropertyChanged
    {
        private string _name;
        private bool _invited;
        private bool _banned;
        private double _reputation;
        private double _favor;
        private bool _isMember;

        public string Name { get => _name; set { _name = value; } }
        public bool Invited { get => _invited; set { _invited = value; OnPropertyChanged(nameof(Invited));  } }
        public bool Banned { get => _banned; set { _banned = value; OnPropertyChanged(nameof(Banned)); } }
        public double Reputation { get => _reputation; set { _reputation = value; OnPropertyChanged(nameof(Reputation)); } }
        public double Favor { get => _favor; set { _favor = value; OnPropertyChanged(nameof(Favor)); } }
        public bool IsMember { get => _isMember; set { _isMember = value; OnPropertyChanged(nameof(IsMember));  } }

        public JObject GetDataObject() => _obj;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventArgs e = new(propertyName);
            switch(propertyName)
            {
                case nameof(Invited):
                    _obj["data"]["alreadyInvited"] = Invited;
                    break;
                case nameof(Banned):
                    _obj["data"]["isBanned"] = Banned;
                    break;
                case nameof(Reputation):
                    _obj["data"]["playerReputation"] = Reputation;
                    break;
                case nameof(Favor):
                    _obj["data"]["favor"] = Favor;
                    break;
                case nameof(IsMember):
                    _obj["data"]["isMember"] = IsMember;
                    break;
                default:
                    break;
            }
            this.PropertyChanged?.Invoke(this, e);
        } // OnPropertyChanged

        public FactionDataObject(string name, string content) : base(content)
        {
            Name = name;
            Invited = Convert.ToBoolean(_obj["data"]["alreadyInvited"]);
            Banned = Convert.ToBoolean(_obj["data"]["isBanned"]);
            Reputation = Convert.ToDouble(_obj["data"]["playerReputation"]);
            Favor = Convert.ToDouble(_obj["data"]["favor"]);
            IsMember = Convert.ToBoolean(_obj["data"]["isMember"]);
        } // FactionDataObject

        public event PropertyChangedEventHandler PropertyChanged;
    } // class FactionDataObject

    public class BladeBurnerInfo
    {
        public BladeBurnerInfo(JObject bbObject)
        {
            Stamina = Convert.ToDouble(bbObject["stamina"]);
            Rank = Convert.ToDouble(bbObject["rank"]);
            SkillPoints = Convert.ToInt32(bbObject["skillPoints"]);
        }
        public double Stamina { get; set; }
        public double Rank { get; set; }
        public int SkillPoints { get; set; }
    }
} // namespace
