using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MerchantsGuide.Tests
{
    public class LineProcessorTest
    {
        [Fact]
        public static void ShouldProcessSlangLine()
        {
            LineProcessor lineProcessor = new LineProcessor();
            lineProcessor.Execute("glob is I");

            string SlangWord = "glob";
            string SlangWordMappedRomanValue = "I";

            Assert.True(LineProcessor.SlangWordMapping.ContainsKey(SlangWord));
            Assert.True(LineProcessor.SlangWordMapping.ContainsValue(SlangWordMappedRomanValue));

        }


    }
}
