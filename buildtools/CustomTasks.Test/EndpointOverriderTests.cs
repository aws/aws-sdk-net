using Moq;
using NUnit.Framework;
using System;

namespace CustomTasks.Endpoint.Test
{
    public class EndpointOverriderTests
    {
        private const string BaseContentPath = "../../../Content";
        private readonly string ENDPOINT_SOURCE = $"{BaseContentPath}/endpoints-source.json";

        [Test]
        public void GivenARegularEndpointsJsonFile_WhenAnEndpointIsModifiedAndAPseudoRegionIsCreated_ThenTheEndpointsJsonFileIsCorrect()
        {
            var target = $"{BaseContentPath}/endpoints-target.json";
            var configuration = $"{BaseContentPath}/endpoints-override-us-east-1-regional.json";
            var fs = new Mock<IFileSystem>();
            var overrider = GetEndpointOverriderMock(ENDPOINT_SOURCE, configuration, fs);
            fs.Setup(f => f.WriteAllText(It.IsAny<string>(), It.IsAny<string>())).Verifiable();

            var output = overrider.ApplyOverrides(ENDPOINT_SOURCE, configuration);

            Assert.AreEqual(System.IO.File.ReadAllText(target), output);
            fs.Verify();
        }

        [Test]
        public void GivenARegularEndpointsJsonFile_WhenTheModificationRulesFileIsEmpty_ThenTheEndpointsJsonFileIsNotTouched()
        {
            var target = $"{BaseContentPath}/endpoints-source.json";
            var configuration = $"{BaseContentPath}/endpoints-override-empty-file.json";
            var fs = new Mock<IFileSystem>();
            var overrider = GetEndpointOverriderMock(ENDPOINT_SOURCE, configuration, fs);
            var output = overrider.ApplyOverrides(ENDPOINT_SOURCE, configuration);

            Assert.AreEqual(System.IO.File.ReadAllText(target), output);
            fs.Verify();
        }

        [Test]
        public void GivenARegularEndpointsJsonFile_WhenTheModificationFileIsNotEmptyButDoesNotContainsChanges_ThenTheEndpointsJsonFileIsNotTouched()
        {
            var target = $"{BaseContentPath}/endpoints-source.json";
            var configuration = $"{BaseContentPath}/endpoints-override-empty-nodes-exists.json";
            var fs = new Mock<IFileSystem>();
            var overrider = GetEndpointOverriderMock(ENDPOINT_SOURCE, configuration, fs);
            var output = overrider.ApplyOverrides(ENDPOINT_SOURCE, configuration);
            Assert.AreEqual(System.IO.File.ReadAllText(target), output);
            fs.Verify();
        }

        [Test]
        public void GivenARegularEndpointsJsonFile_WhenTheModificationRulesContainAWrongService_ThenAnInvalidOperationExceptionIsThrown()
        {
            var configuration = $"{BaseContentPath}/endpoints-override-add-unknown-service.json";
            var fs = new Mock<IFileSystem>();
            var overrider = GetEndpointOverriderMock(ENDPOINT_SOURCE, configuration, fs);
            Assert.Throws<InvalidOperationException>(() => overrider.ApplyOverrides(ENDPOINT_SOURCE, configuration));
            fs.Verify();
        }

        [Test]
        public void GivenARegularEndpointsJsonFile_WhenTheModificationRulesContainADuplicateEndpoint_ThenTheEndpointsJsonFileIsCorrect()
        {
            var configuration = $"{BaseContentPath}/endpoints-override-add-duplicate.json";
            var fs = new Mock<IFileSystem>();
            var overrider = GetEndpointOverriderMock(ENDPOINT_SOURCE, configuration, fs);
            Assert.Throws<InvalidOperationException>(() => overrider.ApplyOverrides(ENDPOINT_SOURCE, configuration));
            fs.Verify();
        }

        private EndpointOverrider GetEndpointOverriderMock(string source, string configuration, Mock<IFileSystem> fs)
        {
            var content = System.IO.File.ReadAllText(source);
            fs.Setup(f => f.ReadAllText(source)).Returns(content).Verifiable();
            content = System.IO.File.ReadAllText(configuration);
            fs.Setup(f => f.ReadAllText(configuration)).Returns(content).Verifiable();
            var overrider = new EndpointOverrider(fs.Object);
            return overrider;
        }
    }
}