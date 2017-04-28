using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTest_MinhTruong
{
    public static class Factory_CodeTest
    {
        public static IJsonTag Create_JsonTag(Util util)
        {
            IJsonTag result = null;
            result = new JsonTag_Test(Create_Util());
            return result;
        }

        public static Util Create_Util()
        {
            Util result = new Util();

            return result;
        }
    }
}
