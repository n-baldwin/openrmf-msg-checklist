using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class SettingsTests
    {
        [Fact]
        public void Test_NewSettingsIsValid()
        {
            Settings settings = new Settings();
            
            // Testing
            Assert.False(settings == null);
        }
    
        [Fact]
        public void Test_SettingsWithDataIsValid()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "myConnection";
            settings.Database = "user=x; database=x; password=x;";

            // Testing
            Assert.True(settings.ConnectionString == "myConnection");
            Assert.True(settings.Database == "user=x; database=x; password=x;");
        }
    }
}
