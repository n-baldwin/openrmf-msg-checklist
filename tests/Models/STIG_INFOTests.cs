using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class STIG_INFOTests
    {
        [Fact]
        public void Test_NewSTIG_INFOIsValid()
        {
            STIG_INFO stig_info = new STIG_INFO();

            // Testing
            Assert.False(stig_info == null);
        }
    
        [Fact]
        public void Test_STIG_INFOWithDataIsValid()
        {
            STIG_INFO stig_info = new STIG_INFO();

            stig_info.SI_DATA.Add(new SI_DATA());
            stig_info.SI_DATA.Add(new SI_DATA());

            // Testing
            Assert.True(stig_info.SI_DATA.Count == 2);
        }
    }
}
