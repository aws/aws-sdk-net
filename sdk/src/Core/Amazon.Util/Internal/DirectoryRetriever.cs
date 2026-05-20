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

using System.IO;
using Amazon.Runtime.Internal;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Wrapper class over <see cref="Directory"/> operations.
    /// This change was done for testability.
    /// </summary>
    [AWSIsBackwardsCompatible]
    public interface IDirectory
    {
        /// <inheritdoc cref="Directory.Exists(string)"/>
        bool Exists(string path);

        /// <inheritdoc cref="Directory.CreateDirectory(string)"/>
        DirectoryInfo CreateDirectory(string path);
        /// <inheritdoc cref="Directory.GetFiles(string, string)"/>
        string[] GetFiles(string path, string searchPattern);

        /// <inheritdoc cref="Directory.Delete(string)"/>
        void Delete(string path);

        /// <summary>
        /// Sets directory permissions to owner read/write/execute only (0700) on Unix/macOS. No-op on Windows.
        /// </summary>
        void SetDirectoryOwnerOnly(string path);
    }

    /// <inheritdoc cref="IDirectory"/>
    public class DirectoryRetriever : IDirectory
    {
        public bool Exists(string path) => Directory.Exists(path);

        public DirectoryInfo CreateDirectory(string path) => Directory.CreateDirectory(path);

        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);

        public void Delete(string path) => Directory.Delete(path);

        public void SetDirectoryOwnerOnly(string path) => FilePermissionHelper.SetDirectoryOwnerOnly(path);
    }
}
