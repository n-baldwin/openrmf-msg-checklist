using Xunit;
using System;
using System.Threading.Tasks;
using openrmf_msg_checklist.Models;
using openrmf_msg_checklist.Data;
using MongoDB.Bson;

/*
 *  Do note:
 *  These tests will fail without a proper
 *  MongoDB setup locally. Refer to the README
 *  in this repo or https://github.com/Cingulara/openrmf-docs/blob/master/create-users-by-hand.md
 */

namespace tests.Data
{
    public class ArtifactRepositoryTests
    {
        private readonly ArtifactRepository _artifactRepository;

        public ArtifactRepositoryTests()
        {
            Settings settings = new Settings();

            settings.ConnectionString = "mongodb://openrmf:openrmf1234!@localhost/openrmf?authSource=admin";
            settings.Database = "openrmf";

            _artifactRepository = new ArtifactRepository(settings); 
        }

        [Fact]
        public async Task Test_ArtifactRepositoryIsValid()
        {
            // Testing
            Assert.False(_artifactRepository == null);

            await _artifactRepository.GetArtifact("id");
            await _artifactRepository.GetSystemArtifacts("systemid");
        }
    }
}
