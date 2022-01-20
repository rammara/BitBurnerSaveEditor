using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitBurnerSaveEditor
{
    public class SaveDataTree
    {   
        private readonly JsonSerializer _serializer;
        private readonly SaveDataTreeNode _root;

        public SaveDataTree(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Conenct cannot be null");
            }
            using var treader = new StringReader(content);
            using var jreader = new JsonTextReader(treader);
            _serializer = JsonSerializer.Create();
            var rootobj = (JObject)_serializer.Deserialize(jreader);
            _root = new(rootobj);
        } // SaveDataTree Ctor

        public SaveDataTreeNode this[string name]
        {
            get { return _root[name]; }
        }
        public SaveDataTreeNode Root => _root;
        public override string ToString() => _root.ToString();
    } // class SaveDataTree
} // namespace
