using SmithyDotNet.Generator.Writers.ProjectFiles;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.ProjectFiles;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceSpecificSolutionFileWriterTests : IDisposable
{
    private readonly string _slnxFile;

    // Temp SDK-layout root the constructor seeds; deleted in Dispose so a changed TestData fixture
    // isn't shadowed by a stale copy left over from a previous run.
    private readonly string _seededSdkRoot;

    public ServiceSpecificSolutionFileWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new ServiceSpecificSolutionFileWriter(fixture.Context);
        // The writer resolves both the service csprojs and the sibling test projects by walking up
        // from the service folder to the "sdk" root, so mirror the real on-disk layout
        // (sdk/src/Services/{Service} and sdk/test/UnitTests) under a temp root rather than touching
        // the generator's real output. The root must be named "sdk" for the walk-up to find it.
        _seededSdkRoot = Utils.PathCombineAlt(Path.GetTempPath(), "SmithyDotNetSlnxTest", "sdk");
        var serviceDirectory = Utils.PathCombineAlt(_seededSdkRoot, "src", "Services", "CloudTrailData");
        Directory.CreateDirectory(serviceDirectory);
        File.Copy(Utils.PathCombineAlt("TestData", "AWSSDK.CloudTrailData.NetStandard.xml"),
            Utils.PathCombineAlt(serviceDirectory, "AWSSDK.CloudTrailData.NetStandard.csproj"), overwrite: true);
        File.Copy(Utils.PathCombineAlt("TestData", "AWSSDK.CloudTrailData.NetFramework.xml"),
            Utils.PathCombineAlt(serviceDirectory, "AWSSDK.CloudTrailData.NetFramework.csproj"), overwrite: true);

        // AddTestDependencyProjects reads AWSSDK.UnitTests.Core.csproj at sdk/test/UnitTests, found by
        // walking up to the "sdk" root. Seed it there.
        var unitTestsCoreDirectory = Utils.PathCombineAlt(_seededSdkRoot, "test", "UnitTests");
        Directory.CreateDirectory(unitTestsCoreDirectory);
        File.Copy(Utils.PathCombineAlt("TestData", "AWSSDK.UnitTests.Core.xml"),
            Utils.PathCombineAlt(unitTestsCoreDirectory, "AWSSDK.UnitTests.Core.csproj"), overwrite: true);

        _slnxFile = writer.Write(serviceDirectory);
    }

    public void Dispose()
    {
        if (Directory.Exists(_seededSdkRoot))
        {
            Directory.Delete(_seededSdkRoot, recursive: true);
        }
    }

    [Fact]
    public void SlnxContainsCoreProjects()
    {
        AssertHelper("""<Folder Name="/Core/">""");
        AssertHelper("""<Project Path="../../Core/AWSSDK.Core.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../../Core/AWSSDK.Core.NetStandard.csproj" />""");
    }

    [Fact]
    public void SlnxContainsOwnCsproj()
    {
        AssertHelper("""<Folder Name="/Services/CloudTrailData/">""");
        AssertHelper("""<Project Path="AWSSDK.CloudTrailData.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="AWSSDK.CloudTrailData.NetStandard.csproj" />""");
    }

    [Fact]
    public void SlnxContainsTestFolderDependencies()
    {
        AssertHelper("""<Folder Name="/Test/">""");
        AssertHelper("""<Project Path="../../../../generator/ServiceClientGeneratorLib/ServiceClientGeneratorLib.csproj" />""");
        AssertHelper("""<Project Path="../../../test/Common/AWSSDK.CommonTest.csproj" />""");
        AssertHelper("""<Project Path="../../../test/IntegrationTests/AWSSDK.IntegrationTestUtilities.csproj" />""");
        AssertHelper("""<Project Path="../../../test/Services/CloudTrailData/UnitTests/AWSSDK.UnitTests.CloudTrailData.csproj" />""");
        AssertHelper("""<Project Path="../../../test/UnitTests/AWSSDK.UnitTests.Core.csproj" />""");
        AssertHelper("""<Project Path="../../../test/UnitTests/Custom/AWSSDK.UnitTestUtilities.csproj" />""");
    }

    [Fact]
    public void SlnxContainsTestDependencies()
    {
        AssertHelper("""<Folder Name="/TestDependencies/">""");
        AssertHelper("""<Project Path="../../../../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../../../../extensions/src/AWSSDK.Extensions.CrtIntegration/AWSSDK.Extensions.CrtIntegration.NetStandard.csproj" />""");
        AssertHelper("""<Project Path="../DynamoDBv2/AWSSDK.DynamoDBv2.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../DynamoDBv2/AWSSDK.DynamoDBv2.NetStandard.csproj" />""");
        AssertHelper("""<Project Path="../S3/AWSSDK.S3.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../S3/AWSSDK.S3.NetStandard.csproj" />""");
        AssertHelper("""<Project Path="../SecurityToken/AWSSDK.SecurityToken.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../SecurityToken/AWSSDK.SecurityToken.NetStandard.csproj" />""");
        AssertHelper("""<Project Path="../SimpleNotificationService/AWSSDK.SimpleNotificationService.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../SimpleNotificationService/AWSSDK.SimpleNotificationService.NetStandard.csproj" />""");
        AssertHelper("""<Project Path="../SQS/AWSSDK.SQS.NetFramework.csproj" />""");
        AssertHelper("""<Project Path="../SQS/AWSSDK.SQS.NetStandard.csproj" />""");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _slnxFile);
    }
}
