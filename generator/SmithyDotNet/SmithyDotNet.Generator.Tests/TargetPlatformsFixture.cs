using SmithyDotNet.Generator.Generation;
using Xunit;

[assembly: AssemblyFixture(typeof(SmithyDotNet.Generator.Tests.TargetPlatformsFixture))]

namespace SmithyDotNet.Generator.Tests;

/// <summary>
/// Runs <see cref="TargetPlatforms.Initialize"/> once before any test. TargetPlatforms reads the
/// TFM set from a Directory.Build.props; TestData carries a minimal stand-in.
/// </summary>
public sealed class TargetPlatformsFixture
{
    public TargetPlatformsFixture()
    {
        TargetPlatforms.Initialize("TestData");
    }
}
