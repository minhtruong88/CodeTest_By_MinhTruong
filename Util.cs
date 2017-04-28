using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace CodeTest_MinhTruong
{
    public class Util
    {
        public T Deserialize<T>(string data)
        {   
            T result = default(T);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            result = serializer.Deserialize<T>(data);
            return result;
        }

        public string GetConfigValue(string name)
        {
            string result = "";
            try
            {
                result = System.Configuration.ConfigurationManager.AppSettings[name];
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}
