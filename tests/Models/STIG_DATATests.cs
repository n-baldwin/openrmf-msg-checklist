using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class STIG_DATATests
    {
        [Fact]
        public void Test_NewSTIG_DATAIsValid()
        {
            STIG_DATA stig_data = new STIG_DATA();

            // Testing
            Assert.False(stig_data == null);
        }
    
        [Fact]
        public void Test_STIG_DATAWithDataIsValid()
        {
            STIG_DATA stig_data = new STIG_DATA();

            stig_data.VULN_ATTRIBUTE = "my attribute";
            stig_data.ATTRIBUTE_DATA = "my data";

            // Testing
            Assert.True(stig_data.VULN_ATTRIBUTE == "my attribute");
            Assert.True(stig_data.ATTRIBUTE_DATA == "my data");
        }
    }
}
