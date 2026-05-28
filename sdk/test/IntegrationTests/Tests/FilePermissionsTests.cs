/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using Amazon.Util.Internal;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// Integration tests that verify actual file and directory permissions on Unix/macOS platforms.
    /// Tests requiring Unix APIs are automatically skipped on Windows via xUnit v3 SkipWhen.
    /// </summary>
    [Trait("Category", "Core")]
    public class FilePermissionsTests : IDisposable
    {
        private readonly string _testDirectory;

        public static bool IsWindows => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static bool IsNotWindows => !RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public FilePermissionsTests()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), $"aws-sdk-permissions-test-{Guid.NewGuid()}");
            Directory.CreateDirectory(_testDirectory);
        }

        public void Dispose()
        {
            try
            {
                if (Directory.Exists(_testDirectory))
                {
                    Directory.Delete(_testDirectory, true);
                }
            }
            catch
            {
                // Best effort cleanup
            }
        }

        [Fact(Skip = "Requires Unix file permission APIs", SkipWhen = nameof(IsWindows))]
        public void SetFileOwnerReadWrite_OnUnix_SetsPermissionsTo0600()
        {
            // Arrange
            var testFilePath = Path.Combine(_testDirectory, "test-token.json");
            File.WriteAllText(testFilePath, "{\"test\": \"data\"}");

            // Act
            FilePermissionHelper.SetFileOwnerReadWrite(testFilePath);

            // Assert - 0600 octal = 384 decimal
            var mode = GetUnixFilePermissions(testFilePath);
            Assert.Equal(0x180, mode & 0x1FF); // mask to lower 9 bits (rwxrwxrwx)
        }

        [Fact(Skip = "Requires Unix file permission APIs", SkipWhen = nameof(IsWindows))]
        public void SetDirectoryOwnerOnly_OnUnix_SetsPermissionsTo0700()
        {
            // Arrange
            var testSubDir = Path.Combine(_testDirectory, "cache");
            Directory.CreateDirectory(testSubDir);

            // Act
            FilePermissionHelper.SetDirectoryOwnerOnly(testSubDir);

            // Assert - 0700 octal = 448 decimal
            var mode = GetUnixFilePermissions(testSubDir);
            Assert.Equal(0x1C0, mode & 0x1FF); // mask to lower 9 bits (rwxrwxrwx)
        }

        [Fact(Skip = "Only runs on Windows", SkipWhen = nameof(IsNotWindows))]
        public void SetFileOwnerReadWrite_OnWindows_IsNoOp()
        {
            // Arrange
            var testFilePath = Path.Combine(_testDirectory, "test-token.json");
            File.WriteAllText(testFilePath, "{\"test\": \"data\"}");

            // Act & Assert - should not throw on Windows
            FilePermissionHelper.SetFileOwnerReadWrite(testFilePath);
        }

        [Fact(Skip = "Only runs on Windows", SkipWhen = nameof(IsNotWindows))]
        public void SetDirectoryOwnerOnly_OnWindows_IsNoOp()
        {
            // Arrange
            var testSubDir = Path.Combine(_testDirectory, "cache");
            Directory.CreateDirectory(testSubDir);

            // Act & Assert - should not throw on Windows
            FilePermissionHelper.SetDirectoryOwnerOnly(testSubDir);
        }

        [Fact(Skip = "Requires Unix file permission APIs", SkipWhen = nameof(IsWindows))]
        public void SetFileOwnerReadWrite_OnUnix_RemovesGroupAndOtherPermissions()
        {
            // Arrange - create file with world-readable permissions (0644)
            var testFilePath = Path.Combine(_testDirectory, "world-readable.json");
            File.WriteAllText(testFilePath, "{\"accessToken\": \"sensitive\"}");
            SetUnixPermissions(testFilePath, 0x1A4); // 0644 octal

            // Verify initial permissions are 0644
            var initialMode = GetUnixFilePermissions(testFilePath) & 0x1FF;
            Assert.Equal(0x1A4, initialMode); // 0644

            // Act
            FilePermissionHelper.SetFileOwnerReadWrite(testFilePath);

            // Assert - group and other permissions should be removed
            var finalMode = GetUnixFilePermissions(testFilePath) & 0x1FF;
            Assert.Equal(0x180, finalMode); // 0600
        }

        /// <summary>
        /// Gets the Unix file permission bits for the given path using NativeMethods.Chmod
        /// for setting and stat P/Invoke for reading.
        /// </summary>
        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Method is only called from tests guarded by SkipWhen = nameof(IsWindows)")]
        private static int GetUnixFilePermissions(string path)
        {
#if NET8_0_OR_GREATER
            return (int)File.GetUnixFileMode(path);
#else
            var buf = new StatBuffer();
            if (Stat(path, ref buf) != 0)
            {
                throw new IOException($"stat failed for '{path}'. errno: {Marshal.GetLastWin32Error()}");
            }
            return (int)(buf.st_mode & 0x1FF);
#endif
        }

        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Method is only called from tests guarded by SkipWhen = nameof(IsWindows)")]
        private static void SetUnixPermissions(string path, int mode)
        {
#if NET8_0_OR_GREATER
            File.SetUnixFileMode(path, (UnixFileMode)mode);
#else
            if (NativeMethods.Chmod(path, mode) != 0)
            {
                throw new IOException($"chmod failed for '{path}'. errno: {Marshal.GetLastWin32Error()}");
            }
#endif
        }

#if !NET8_0_OR_GREATER
        // On Linux, stat may be a macro that calls __xstat with version 1.
        // On macOS, stat is a direct function.
        [DllImport("libc", EntryPoint = "__xstat", SetLastError = true)]
        private static extern int XStat(int ver, string path, ref StatBuffer buf);

        [DllImport("libc", EntryPoint = "stat", SetLastError = true)]
        private static extern int StatDirect(string path, ref StatBuffer buf);

        private static int Stat(string path, ref StatBuffer buf)
        {
            try
            {
                return StatDirect(path, ref buf);
            }
            catch (EntryPointNotFoundException)
            {
                return XStat(1, path, ref buf);
            }
        }

        // Minimal stat buffer - layout varies by platform but st_mode is always near the start.
        // We use a large enough buffer to accommodate different platforms.
        [StructLayout(LayoutKind.Sequential)]
        private struct StatBuffer
        {
            public ulong st_dev;
            public ulong st_ino;
            public ulong st_nlink;
            public uint st_mode;
            public uint st_uid;
            public uint st_gid;
            public uint __pad0;
            public ulong st_rdev;
            public long st_size;
            public long st_blksize;
            public long st_blocks;
            public long st_atime_sec;
            public long st_atime_nsec;
            public long st_mtime_sec;
            public long st_mtime_nsec;
            public long st_ctime_sec;
            public long st_ctime_nsec;
            public long __unused0;
            public long __unused1;
            public long __unused2;
        }
#endif
    }
}
