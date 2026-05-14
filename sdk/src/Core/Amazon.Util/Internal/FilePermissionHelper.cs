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
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Shared helper for setting restrictive file/directory permissions on newly created
    /// credential cache files and directories on Unix/macOS platforms.
    /// </summary>
    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Cleanup catch blocks intentionally suppress all exceptions to allow the primary exception to propagate")]
    public static class FilePermissionHelper
    {
        /// <summary>
        /// On non-Windows platforms, sets the file permissions to owner read/write only (Unix mode 0600).
        /// On Windows, this is a no-op.
        /// </summary>
        /// <param name="path">The path of the file to set permissions on.</param>
        public static void SetFileOwnerReadWrite(string path)
        {
#if !BCL
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
#if NET8_0_OR_GREATER
                File.SetUnixFileMode(path, UnixFileMode.UserRead | UnixFileMode.UserWrite);
#else
                // S_IRUSR | S_IWUSR = 0x100 | 0x80 = 0600 (octal)
                const int ownerReadWrite = 0x180; // 0600 in octal
                if (NativeMethods.Chmod(path, ownerReadWrite) != 0)
                {
                    var errno = Marshal.GetLastWin32Error();
                    throw new IOException($"Failed to set file permissions on '{path}'. errno: {errno} ({new Win32Exception(errno).Message})");
                }
#endif
            }
#endif
        }

        /// <summary>
        /// On non-Windows platforms, sets the directory permissions to owner read/write/execute only (Unix mode 0700).
        /// On Windows, this is a no-op.
        /// </summary>
        /// <param name="path">The path of the directory to set permissions on.</param>
        public static void SetDirectoryOwnerOnly(string path)
        {
#if !BCL
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
#if NET8_0_OR_GREATER
                File.SetUnixFileMode(path, UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute);
#else
                // S_IRWXU = 0x1C0 = 0700 (octal) - owner read/write/execute
                const int ownerOnly = 0x1C0; // 0700 in octal
                if (NativeMethods.Chmod(path, ownerOnly) != 0)
                {
                    var errno = Marshal.GetLastWin32Error();
                    throw new IOException($"Failed to set directory permissions on '{path}'. errno: {errno} ({new Win32Exception(errno).Message})");
                }
#endif
            }
#endif
        }

        /// <summary>
        /// Sets owner-only permissions (0700) on a newly created directory. If permissions cannot be set,
        /// the directory is deleted to avoid leaving a world-readable directory containing credentials.
        /// </summary>
        /// <param name="directory">Directory abstraction for filesystem operations (used for cleanup deletion only).</param>
        /// <param name="directoryPath">Path to the directory to secure.</param>
        /// <param name="isNewDirectory">Whether the directory was newly created (permissions are only set for new directories).</param>
        /// <param name="logger">Optional logger. If null, logging is skipped.</param>
        public static void SetDirectoryPermissionsOrCleanup(IDirectory directory, string directoryPath, bool isNewDirectory, Logger logger)
        {
            if (AWSConfigs.RestrictFilePermissions == FilePermission.USER_READ_WRITE && isNewDirectory)
            {
                try
                {
                    directory.SetDirectoryOwnerOnly(directoryPath);
                }
                catch (Exception e)
                {
                    if (logger != null)
                    {
                        logger.Error(e,
                            "Failed to set owner-only permissions on directory '{0}'. " +
                            "The directory will be removed to prevent insecure credential storage. " +
                            "To disable permission enforcement, set AWSConfigs.RestrictFilePermissions to FilePermission.UNRESTRICTED " +
                            "or set the environment variable AWS_RESTRICT_FILE_PERMISSIONS=UNRESTRICTED.",
                        directoryPath);
                    }
                    Exception cleanupException = null;
                    try { directory.Delete(directoryPath); }
                    catch (Exception deleteEx)
                    {
                        cleanupException = deleteEx;
                        if (logger != null)
                        {
                            logger.Error(deleteEx, "Failed to delete directory '{0}' during cleanup after permission failure.", directoryPath);
                        }
                    }
                    if (cleanupException != null)
                    {
#if BCL35
                        throw new InvalidOperationException(
                            "Failed to set directory permissions and cleanup also failed. " +
                            "Cleanup error: " + cleanupException.Message, e);
#else
                        throw new AggregateException(e, cleanupException);
#endif
                    }
                    throw;
                }
            }
        }

        /// <summary>
        /// Sets owner-only read/write permissions (0600) on a newly created file. If permissions cannot be set,
        /// the file is deleted to avoid leaving world-readable credentials on disk.
        /// </summary>
        /// <param name="file">File abstraction for filesystem operations (used for cleanup deletion only).</param>
        /// <param name="filePath">Path to the file to secure.</param>
        /// <param name="isNewFile">Whether the file was newly created (permissions are only set for new files).</param>
        /// <param name="logger">Optional logger. If null, logging is skipped.</param>
        public static void SetFilePermissionsOrCleanup(IFile file, string filePath, bool isNewFile, Logger logger)
        {
            if (AWSConfigs.RestrictFilePermissions == FilePermission.USER_READ_WRITE && isNewFile)
            {
                try
                {
                    file.SetFileOwnerReadWrite(filePath);
                }
                catch (Exception e)
                {
                    if (logger != null)
                    {
                        logger.Error(e,
                            "Failed to set owner-only permissions on file '{0}'. " +
                            "The file will be removed to prevent insecure credential storage. " +
                            "To disable permission enforcement, set AWSConfigs.RestrictFilePermissions to FilePermission.UNRESTRICTED " +
                            "or set the environment variable AWS_RESTRICT_FILE_PERMISSIONS=UNRESTRICTED.",
                        filePath);
                    }
                    Exception cleanupException = null;
                    try { file.Delete(filePath); }
                    catch (Exception deleteEx)
                    {
                        cleanupException = deleteEx;
                        if (logger != null)
                        {
                            logger.Error(deleteEx, "Failed to delete file '{0}' during cleanup after permission failure.", filePath);
                        }
                    }
                    if (cleanupException != null)
                    {
#if BCL35
                        throw new InvalidOperationException(
                            "Failed to set file permissions and cleanup also failed. " +
                            "Cleanup error: " + cleanupException.Message, e);
#else
                        throw new AggregateException(e, cleanupException);
#endif
                    }
                    throw;
                }
            }
        }
    }
}
