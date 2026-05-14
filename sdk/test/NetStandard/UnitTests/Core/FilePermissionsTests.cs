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

namespace AWSSDK.UnitTests.Core
{
    /// <summary>
    /// Tests for file and directory permission helpers used by SSO/Login token caches.
    /// On Unix/macOS these verify that chmod is applied correctly.
    /// On Windows these verify the methods are safe no-ops.
    /// </summary>
    public class FilePermissionsTests : IDisposable
    {
        private readonly string _tempDir;

        public FilePermissionsTests()
        {
            _tempDir = Path.Combine(Path.GetTempPath(), "aws-sdk-permissions-test-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_tempDir);
        }

        public void Dispose()
        {
            try { Directory.Delete(_tempDir, true); } catch { }
        }

        [Fact]
        public void SetFileOwnerReadWrite_DoesNotThrow()
        {
            var filePath = Path.Combine(_tempDir, "test-file.json");
            File.WriteAllText(filePath, "{}");

            FilePermissionHelper.SetFileOwnerReadWrite(filePath);

            // Verify file still exists and is readable
            Assert.True(File.Exists(filePath));
            Assert.Equal("{}", File.ReadAllText(filePath));
        }

        [Fact]
        public void SetDirectoryOwnerOnly_DoesNotThrow()
        {
            var dirPath = Path.Combine(_tempDir, "test-dir");
            Directory.CreateDirectory(dirPath);

            FilePermissionHelper.SetDirectoryOwnerOnly(dirPath);

            // Verify directory still exists
            Assert.True(Directory.Exists(dirPath));
        }

#if NET8_0_OR_GREATER
        [Fact]
        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Test is guarded by RuntimeInformation.IsOSPlatform check")]
        public void SetFileOwnerReadWrite_OnUnix_SetsPermissionsTo0600()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return; // Only runs on Linux/macOS where chmod is applied

            var filePath = Path.Combine(_tempDir, "test-0600.json");
            File.WriteAllText(filePath, "{}");

            // Set wide-open permissions first
            File.SetUnixFileMode(filePath, UnixFileMode.UserRead | UnixFileMode.UserWrite |
                                           UnixFileMode.GroupRead | UnixFileMode.OtherRead);

            FilePermissionHelper.SetFileOwnerReadWrite(filePath);

            var mode = File.GetUnixFileMode(filePath);
            Assert.Equal(UnixFileMode.UserRead | UnixFileMode.UserWrite, mode);
        }

        [Fact]
        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Test is guarded by RuntimeInformation.IsOSPlatform check")]
        public void SetDirectoryOwnerOnly_OnUnix_SetsPermissionsTo0700()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return; // Only runs on Linux/macOS where chmod is applied

            var dirPath = Path.Combine(_tempDir, "test-0700");
            Directory.CreateDirectory(dirPath);

            FilePermissionHelper.SetDirectoryOwnerOnly(dirPath);

            var mode = File.GetUnixFileMode(dirPath);
            Assert.Equal(UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute, mode);
        }

        [Fact]
        [SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Test is guarded by RuntimeInformation.IsOSPlatform check")]
        public void SetFileOwnerReadWrite_OnUnix_RemovesGroupAndOtherPermissions()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return; // Only runs on Linux/macOS where chmod is applied

            var filePath = Path.Combine(_tempDir, "test-remove-perms.json");
            File.WriteAllText(filePath, "sensitive-data");

            // Set 0644 (world-readable) - the problematic default
            File.SetUnixFileMode(filePath, UnixFileMode.UserRead | UnixFileMode.UserWrite |
                                           UnixFileMode.GroupRead | UnixFileMode.OtherRead);

            FilePermissionHelper.SetFileOwnerReadWrite(filePath);

            var mode = File.GetUnixFileMode(filePath);

            // Verify no group or other permissions remain
            Assert.Equal(UnixFileMode.None, mode & UnixFileMode.GroupRead);
            Assert.Equal(UnixFileMode.None, mode & UnixFileMode.GroupWrite);
            Assert.Equal(UnixFileMode.None, mode & UnixFileMode.OtherRead);
            Assert.Equal(UnixFileMode.None, mode & UnixFileMode.OtherWrite);
        }
#endif
    }
}
