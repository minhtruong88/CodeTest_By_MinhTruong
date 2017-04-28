using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeTest_MinhTruong
{
    public interface IJsonTag
    {
        string GenerateTwoMatchTagNamePair(string data);

        string GenerateTwoMatchTagNamePair(Recipients recipients);

        string GenerateTwoMatchTag_By_FilePath(string filePath);
    }
}
