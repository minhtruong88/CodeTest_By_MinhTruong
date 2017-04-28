using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeTest_MinhTruong
{
    internal class JsonTag_Test : IJsonTag
    {
        #region "private properties"
        private Util Utility
        {
            get;
            set;
        }

        private void Initialize(Util util)
        {
            Utility = util;
        }

        #endregion

        #region "constructor"

        public JsonTag_Test(Util util)
        {
            Initialize(util);
        }

        #endregion

        #region "public methods"

        public string GenerateTwoMatchTagNamePair(string data)
        {
            Recipients recipient = Utility.Deserialize<Recipients>(data);
            return GenerateTwoMatchTagNamePair(recipient);
        }

        public string GenerateTwoMatchTagNamePair(Recipients recipients)
        {
            StringBuilder result = new StringBuilder();
            result = Process_Input(result, recipients);
            return result.ToString();
        }

        public string GenerateTwoMatchTag_By_FilePath(string filePath)
        {
            return GenerateTwoMatchTagNamePair(File.ReadAllText(filePath));
        }

        #endregion

        #region "private methods"

        private StringBuilder Process_Input(StringBuilder result, Recipients data)
        {
            int length = data.recipients.Length;
            //length = 0;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    result = Compare_Person_Tag(result, data.recipients[i], data.recipients[j]);
                }
            }
            if (result.Length > 0)
            {
                result.Length = result.Length - 1;
            }
            return result;
        }

        private StringBuilder Compare_Person_Tag(StringBuilder result, Person one, Person two)
        {
            if (TagMatchTwo(one.tags.Distinct().ToArray(), two.tags.Distinct().ToArray()))
            {
                result.Append(Build_Name_Pair(one.name, two.name));
            }
            return result;
        }

        private string Build_Name_Pair(string name1, string name2)
        {
            StringBuilder result = new StringBuilder();
            //result.Append(Environment.NewLine);
            result.Append(name1 + ", " + name2 + "|");
            return result.ToString();
        }

        private bool TagMatchTwo(string[] one, string[] two)
        {
            bool result = false;
            int counter = 0;
            foreach (string itemOne in one)
            {
                foreach (string itemTwo in two)
                {
                    if (itemOne == itemTwo)
                    {
                        counter++;
                    }
                }
            }
            result = counter > 1;
            return result;
        }

        #endregion
    }
}
