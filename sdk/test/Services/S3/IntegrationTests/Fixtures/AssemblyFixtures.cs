using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

// Assembly-level fixtures are created once before any test in the assembly runs
// and disposed after the last test finishes.  Any test class can inject them via
// a constructor parameter — no [Collection] or IClassFixture<T> needed.

[assembly: AssemblyFixture(typeof(SharedS3ObjectBucketFixture))]
[assembly: AssemblyFixture(typeof(TransferUtilityFixture))]
[assembly: AssemblyFixture(typeof(ChecksumMrapFixture))]
