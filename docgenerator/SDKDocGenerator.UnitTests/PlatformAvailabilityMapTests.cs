using System;
using System.Collections.Generic;
using Xunit;
using SDKDocGenerator.PlatformMap;

namespace SDKDocGenerator.UnitTests
{
    public class PlatformAvailabilityMapTests
    {
        #region Test Helpers

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

        #endregion

        #region Disposal

        [Fact]
        public void ThrowsObjectDisposedException_AfterDispose()
        {
            var index = new Dictionary<string, PlatformMemberEntry>(StringComparer.Ordinal);
            var platforms = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "net472" };

            var map = CreateTestMap(index, platforms);
            map.Dispose();

            // IEnumerable methods are lazy — must enumerate to trigger ThrowIfDisposed
            Assert.Throws<ObjectDisposedException>(() => map.GetExclusiveMethodsForType("Ns.Type").GetEnumerator().MoveNext());
            Assert.Throws<ObjectDisposedException>(() => map.GetTypesWithExclusiveMembers().GetEnumerator().MoveNext());
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
