namespace AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures
{
    /// <summary>
    /// Assembly-level fixture that creates one S3 bucket and one client shared by all
    /// object-operation test classes (PutObject, GetObject, ListObjects, etc.).
    /// <para>
    /// Registered via <c>[assembly: AssemblyFixture(typeof(SharedS3ObjectBucketFixture))]</c>
    /// in <see cref="AssemblyFixtures"/>.  Any test class that needs it declares a
    /// constructor parameter of this type — no <c>IClassFixture&lt;T&gt;</c> needed.
    /// </para>
    /// </summary>
    public class SharedS3ObjectBucketFixture : S3PublicAclBucketFixture { }
}
