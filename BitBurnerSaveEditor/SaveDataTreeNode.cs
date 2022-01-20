using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace BitBurnerSaveEditor
{
    public class SaveDataTreeNode : IEnumerable<SaveDataTreeNode>
    {
        JToken _obj;
        public string Name { get; set; }
        public SaveDataTreeNode Parent { get; init; }
        protected List<SaveDataTreeNode> _children = new();

        public SaveDataTreeNode(JToken jObj)
        {
            _obj = jObj;
            if (JTokenType.Property == _obj.Type)
            {
                Name = (_obj as JProperty).Name;
            }
            if (_obj.HasValues)
            {
                foreach(var childObj in _obj.Children())
                {
                    _children.Add(new(childObj));
                }
            }
        } // SaveDataTree ctor

        public SaveDataTreeNode this[string name]
        {
            get
            {
                if (_children is null) return null;
                var elem = _children.Where(c => c.Name == name).FirstOrDefault();
                return elem;
            } // get
        } // this[string]

        public override string ToString()
        {
            if (JTokenType.Property == _obj.Type) return Name;
            return _obj.Type.ToString();
        } // ToString

        public IEnumerator<SaveDataTreeNode> GetEnumerator()
        {
            return ((IEnumerable<SaveDataTreeNode>)_children).GetEnumerator();
        } // GetEnumerator

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_children).GetEnumerator();
        } // GetEnumerator
    } // class SaveDataTreeNode
} // namespace
