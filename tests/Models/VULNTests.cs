using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class VULNTests
    {
        [Fact]
        public void Test_NewVULNIsValid()
        {
            VULN vuln = new VULN();

            // Testing
            Assert.False(vuln == null);
        }
    
        [Fact]
        public void Test_VULNWithDataIsValid()
        {
            VULN vuln = new VULN();
            
            vuln.STIG_DATA.Add(new STIG_DATA());
            vuln.STIG_DATA.Add(new STIG_DATA());

            vuln.STATUS = "Alive";
            vuln.FINDING_DETAILS = "Living looking";
            vuln.COMMENTS = "Witty comment";
            vuln.SEVERITY_OVERRIDE = "No idea";
            vuln.SEVERITY_JUSTIFICATION = "Justified?";

            // Testing
            Assert.True(vuln.STIG_DATA.Count == 2);
            Assert.True(vuln.STATUS == "Alive");
            Assert.True(vuln.FINDING_DETAILS == "Living looking");
            Assert.True(vuln.COMMENTS == "Witty comment");
            Assert.True(vuln.SEVERITY_OVERRIDE == "No idea");
            Assert.True(vuln.SEVERITY_JUSTIFICATION == "Justified?");
        }
    }
}
