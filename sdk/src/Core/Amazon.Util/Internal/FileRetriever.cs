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
using System.IO;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Wrapper class over <see cref="File"/> operations.
    /// This change was done for testability.
    /// </summary>
    public interface IFile
    {
        /// <inheritdoc cref="File.Exists"/>
        bool Exists(string path);

        /// <inheritdoc cref="File.ReadAllText(string)"/>
        string ReadAllText(string path);
        /// <inheritdoc cref="File.WriteAllText(string, string)"/>
        void WriteAllText(string path, string contents);

#if AWS_ASYNC_API
        /// <inheritdoc cref="File.ReadAllText(string)"/>
        Task<string> ReadAllTextAsync(string path, CancellationToken token = default);
        /// <inheritdoc cref="File.WriteAllText(string, string)"/>
        Task WriteAllTextAsync(string path, string contents, CancellationToken token = default);
#endif
    }

    /// <inheritdoc cref="IFile"/>
    public class FileRetriever : IFile
    {
        public bool Exists(string path) => File.Exists(path);

        public string ReadAllText(string path) => File.ReadAllText(path);
        public void WriteAllText(string path, string contents) => File.WriteAllText(path, contents);

#if AWS_ASYNC_API
        public async Task<string> ReadAllTextAsync(string path, CancellationToken token = default)
        {
            using (var fs = File.OpenRead(path))
            using (var reader = new StreamReader(fs))
                return await reader.ReadToEndAsync().ConfigureAwait(false);
                
        }

        public async Task WriteAllTextAsync(string path, string contents, CancellationToken token = default)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(fs))
                await writer.WriteAsync(contents).ConfigureAwait(false);

        }
#endif
    }
}

