using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class SI_DATATests
    {
        [Fact]
        public void Test_NewSI_DATAIsValid()
        {
            SI_DATA si_data = new SI_DATA();

            // Testing
            Assert.False(si_data == null);
        }
    
        [Fact]
        public void Test_SI_DATAWithDataIsValid()
        {
            SI_DATA si_data = new SI_DATA();

            si_data.SID_DATA = "mydata";
            si_data.SID_NAME = "myName";

            // Testing
            Assert.True(si_data.SID_DATA == "mydata");
            Assert.True(si_data.SID_NAME == "myName");
        }
    }
}
