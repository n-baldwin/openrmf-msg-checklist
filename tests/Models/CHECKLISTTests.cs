using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class CHECKLISTTests
    {
        [Fact]
        public void Test_NewCHECKLISTIsValid()
        {
            CHECKLIST checklist = new CHECKLIST();

            // Testing
            Assert.False(checklist == null);
        }
    
        [Fact]
        public void Test_CHECKLISTWithDataIsValid()
        {
            CHECKLIST checklist = new CHECKLIST();

            checklist.ASSET = new ASSET();
            checklist.STIGS = new STIGS();

            // Testing
            Assert.False(checklist.ASSET == null);
            Assert.False(checklist.STIGS == null);
        }
    }
}
