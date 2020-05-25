using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class STIGSTests
    {
        [Fact]
        public void Test_NewSTIGSIsValid()
        {
            STIGS stigs = new STIGS();

            // Testing
            Assert.False(stigs == null);
        }
    
        [Fact]
        public void Test_STIGSWithDataIsValid()
        {
            STIGS stigs = new STIGS();

            // Testing
            Assert.False(stigs.iSTIG == null);
        }
    }
}
