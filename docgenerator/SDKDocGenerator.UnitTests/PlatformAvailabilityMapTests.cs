using System;
using System.Collections.Generic;
using Xunit;
using SDKDocGenerator.PlatformMap;

namespace SDKDocGenerator.UnitTests
{
    public class PlatformAvailabilityMapTests
    {
        #region Test Helpers

        /// <summary>
        /// Creates a PlatformAvailabilityMap with hand-crafted entries for testing
        /// query behavior without loading any real SDK assemblies.
        /// </summary>
        private static PlatformAvailabilityMap CreateTestMap(
            Dictionary<string, PlatformMemberEntry> memberIndex,
            HashSet<string> allPlatforms,
            string primaryPlatform = "net472",
            string serviceName = "TestService")
        {
            return new PlatformAvailabilityMap(
                serviceName,
                primaryPlatform,
                memberIndex,
                allPlatforms,
                new List<PlatformAssemblyContext>());
        }

        private static PlatformMemberEntry CreateEntry(string signature, string declaringType, params string[] platforms)
        {
            var entry = new PlatformMemberEntry(signature, declaringType);
            foreach (var p in platforms)
                entry.Platforms.Add(p);
            return entry;
        }

        #endregion

        #region Universal Member Queries

        [Fact]
        public void UniversalMember_IsAvailableOnAllPlatforms()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                ["M:Ns.Type.Method()"] = CreateEntry("M:Ns.Type.Method()", "Ns.Type", "net472", "net8.0")
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472", "net8.0" };

            using var map = CreateTestMap(index, platforms);

            Assert.True(map.IsMemberAvailableOnAllPlatforms("M:Ns.Type.Method()"));
            Assert.False(map.IsMemberPlatformRestricted("M:Ns.Type.Method()"));
            Assert.True(map.IsMemberAvailableOnPlatform("M:Ns.Type.Method()", "net472"));
            Assert.True(map.IsMemberAvailableOnPlatform("M:Ns.Type.Method()", "net8.0"));
        }

        #endregion

        #region Exclusive Member Queries (Core Feature)

        [Fact]
        public void ExclusiveMember_AvailableOnSupplemental_NotOnPrimary()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                ["M:Ns.Client.StartTranscription(Ns.Request)"] = CreateEntry(
                    "M:Ns.Client.StartTranscription(Ns.Request)", "Ns.Client", "net8.0")
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472", "net8.0" };

            using var map = CreateTestMap(index, platforms);

            Assert.True(map.IsMemberAvailableOnPlatform("M:Ns.Client.StartTranscription(Ns.Request)", "net8.0"));
            Assert.False(map.IsMemberAvailableOnPlatform("M:Ns.Client.StartTranscription(Ns.Request)", "net472"));
            Assert.False(map.IsMemberAvailableOnAllPlatforms("M:Ns.Client.StartTranscription(Ns.Request)"));
            Assert.True(map.IsMemberPlatformRestricted("M:Ns.Client.StartTranscription(Ns.Request)"));
        }

        #endregion

        #region Statistics

        [Fact]
        public void Statistics_CorrectlyCountUniversalAndRestricted()
        {
            var universal = CreateEntry("M:Ns.Type.Both()", "Ns.Type", "net472", "net8.0");
            var restricted = CreateEntry("M:Ns.Type.OnlyNet8()", "Ns.Type", "net8.0");

            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                [universal.Signature] = universal,
                [restricted.Signature] = restricted
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472", "net8.0" };

            using var map = CreateTestMap(index, platforms);

            Assert.Equal(2, map.MemberCount);
            Assert.Equal(1, map.UniversalMemberCount);
            Assert.Equal(1, map.PlatformRestrictedMemberCount);
        }

        [Fact]
        public void GetExclusiveMemberCount_CountsMembersOnOnlyOnePlatform()
        {
            var exclusive = CreateEntry("M:Ns.Type.OnlyNet8()", "Ns.Type", "net8.0");
            var shared = CreateEntry("M:Ns.Type.Both()", "Ns.Type", "net472", "net8.0");

            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                [exclusive.Signature] = exclusive,
                [shared.Signature] = shared
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472", "net8.0" };

            using var map = CreateTestMap(index, platforms);

            Assert.Equal(1, map.GetExclusiveMemberCount("net8.0"));
            Assert.Equal(0, map.GetExclusiveMemberCount("net472"));
        }

        #endregion

        #region Platform Queries

        [Fact]
        public void GetMembersForPlatform_ReturnsMembersOnThatPlatform()
        {
            var both = CreateEntry("M:Ns.Type.Both()", "Ns.Type", "net472", "net8.0");
            var net8Only = CreateEntry("M:Ns.Type.Net8Only()", "Ns.Type", "net8.0");

            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                [both.Signature] = both,
                [net8Only.Signature] = net8Only
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472", "net8.0" };

            using var map = CreateTestMap(index, platforms);

            var net472Members = map.GetMembersForPlatform("net472");
            var net8Members = map.GetMembersForPlatform("net8.0");

            Assert.Single(net472Members);
            Assert.Equal(2, net8Members.Count);
        }

        [Fact]
        public void Queries_ReturnEmpty_WhenNotFound()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472" };

            using var map = CreateTestMap(index, platforms);

            Assert.Empty(map.GetPlatformsForMember("M:Ns.Type.DoesNotExist()"));
            Assert.Empty(map.GetMembersForPlatform("netstandard2.0"));
        }

        #endregion

        #region Platform Case Insensitivity

        [Fact]
        public void PlatformQueries_AreCaseInsensitive()
        {
            var entry = CreateEntry("M:Ns.Type.Method()", "Ns.Type", "net8.0");

            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal)
            {
                [entry.Signature] = entry
            };
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net8.0" };

            using var map = CreateTestMap(index, platforms);

            // Query with different casing should work due to OrdinalIgnoreCase
            Assert.True(map.IsMemberAvailableOnPlatform("M:Ns.Type.Method()", "NET8.0"));
            Assert.True(map.IsMemberAvailableOnPlatform("M:Ns.Type.Method()", "Net8.0"));
        }

        #endregion

        #region Disposal

        [Fact]
        public void ThrowsObjectDisposedException_AfterDispose()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472" };

            var map = CreateTestMap(index, platforms);
            map.Dispose();

            Assert.Throws<ObjectDisposedException>(() => map.GetPlatformsForMember("M:Ns.Type.Method()"));
            Assert.Throws<ObjectDisposedException>(() => map.IsMemberAvailableOnPlatform("M:Ns.Type.Method()", "net472"));
            Assert.Throws<ObjectDisposedException>(() => map.IsMemberAvailableOnAllPlatforms("M:Ns.Type.Method()"));
            Assert.Throws<ObjectDisposedException>(() => map.GetMembersForPlatform("net472"));
        }

        [Fact]
        public void DoubleDispose_DoesNotThrow()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472" };

            var map = CreateTestMap(index, platforms);
            map.Dispose();
            map.Dispose(); // Should not throw
        }

        #endregion
    }
}
