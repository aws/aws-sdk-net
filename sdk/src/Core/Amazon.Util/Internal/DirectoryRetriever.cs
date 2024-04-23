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

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Wrapper class over <see cref="Directory"/> operations.
    /// This change was done for testability.
    /// </summary>
    public interface IDirectory
    {
        /// <inheritdoc cref="Directory.CreateDirectory(string)"/>
        DirectoryInfo CreateDirectory(string path);
        /// <inheritdoc cref="Directory.GetFiles(string, string)"/>
        string[] GetFiles(string path, string searchPattern);
    }

    /// <inheritdoc cref="IDirectory"/>
    public class DirectoryRetriever : IDirectory
    {
        public DirectoryInfo CreateDirectory(string path) => Directory.CreateDirectory(path);

        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);

    }
}