using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interop.SolidEdge.Merge
{
    class ILClassDeclaration
    {
        private string _ilPath;

        public ILClassDeclaration(string ilPath)
        {
            _ilPath = ilPath;
        }

        public List<string> Lines = new List<string>();

        public string FullName
        {
            get
            {
                if (Lines.Count == 0) return null;

                string line = Lines[0];
                int lastSpace = line.LastIndexOf(' ');
                return line.Substring(++lastSpace);
            }
        }

        public string ILPath { get { return _ilPath; } }

        public string Name
        {
            get
            {
                if (FullName == null) return null;

                string[] tokens = FullName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                return tokens[tokens.Length - 1];
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
