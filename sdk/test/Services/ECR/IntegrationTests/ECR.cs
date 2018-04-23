using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.ECR;
using Amazon.ECR.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ECR : TestBase<AmazonECRClient>
    {
        [TestMethod]
        [TestCategory("ECR")]
        public void TestRepos()
        {
            var repoName = Utils.UtilityMethods.GenerateName("ecs-repo-");
            var repo = Client.CreateRepository(new CreateRepositoryRequest { RepositoryName = repoName }).Repository;

            var repos = Client.DescribeRepositories(new DescribeRepositoriesRequest { });

            Assert.IsTrue(repos.Repositories
                            .Select(r => r.RepositoryName)
                            .Contains(repo.RepositoryName));

            var images = Client.ListImages(new ListImagesRequest { RegistryId = repo.RegistryId, RepositoryName = repo.RepositoryName}).ImageIds;

            Assert.IsFalse(images.Any());

            Client.DeleteRepository(new DeleteRepositoryRequest { RegistryId = repo.RegistryId, RepositoryName = repo.RepositoryName });
        }
    }
}
