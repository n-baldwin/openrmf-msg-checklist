using Xunit;
using openrmf_msg_checklist.Models;
using System;

namespace tests.Models
{
    public class ASSETTests
    {
        [Fact]
        public void Test_NewASSETIsValid()
        {
            ASSET asset = new ASSET();

            // Testing
            Assert.False(asset == null);
        }
    
        [Fact]
        public void Test_ASSETWithDataIsValid()
        {
            ASSET asset = new ASSET();
    		asset.ROLE  = "myRole";
    		asset.ASSET_TYPE  = "myRole";
    		asset.HOST_NAME  = "myRole";
    		asset.HOST_IP  = "myRole";
    		asset.HOST_MAC  = "myRole";
    		asset.HOST_FQDN  = "myRole";
    		asset.TECH_AREA  = "myRole";
    		asset.TARGET_KEY  = "myRole";
    		asset.WEB_OR_DATABASE  = "myRole";
    		asset.WEB_DB_SITE  = "myRole";
    		asset.WEB_DB_INSTANCE  = "myRole";
            
            // Testing
            Assert.True(asset.ROLE == "myRole");
            Assert.True(asset.ASSET_TYPE == "myRole");
            Assert.True(asset.HOST_NAME == "myRole");
            Assert.True(asset.HOST_IP == "myRole");
            Assert.True(asset.HOST_MAC == "myRole");
            Assert.True(asset.HOST_FQDN == "myRole");
            Assert.True(asset.TECH_AREA == "myRole");
            Assert.True(asset.TARGET_KEY == "myRole");
            Assert.True(asset.WEB_OR_DATABASE == "myRole");
            Assert.True(asset.WEB_DB_SITE == "myRole");
            Assert.True(asset.WEB_DB_INSTANCE == "myRole");
        }
    }
}
