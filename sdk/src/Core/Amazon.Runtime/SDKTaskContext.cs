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
using System.Collections.Concurrent;
using System.Threading;

namespace Amazon.Runtime
{
    /// <summary>
    /// This class is used to store state data used by the SDK that is scoped within the .NET Task that is calling
    /// the SDK.
    /// </summary>
    public class SDKTaskContext
    {
        private static SDKTaskContext _default = new SDKTaskContext();

        /// <summary>
        /// The default instance of the <see cref="SDKTaskContext"/> used by the SDK.
        /// </summary>
        public static SDKTaskContext Default => _default;

        private AsyncLocal<ConcurrentDictionary<string, object>> _context = new AsyncLocal<ConcurrentDictionary<string, object>>();

        /// <summary>
        /// Store the value identified by the key in the current Task context.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(string key, object value)
        {
            if (_context.Value == null)
            {
                _context.Value = new ConcurrentDictionary<string, object>();
            }
            _context.Value[key] = value;
        }

        /// <summary>
        /// Retrieve the value identified by the key from the current Task context.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.DynamicDependency(nameof(Set), typeof(SDKTaskContext))]
#endif
        public object Get(string key)
        {
            if (_context.Value != null && _context.Value.TryGetValue(key, out var value))
            {
                return value;
            }
            return null;
        }
    }
}
