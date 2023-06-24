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

namespace Amazon.Util.Internal
{
    /// <summary>
    /// Array extensions for cross compilation across different supported framework versions.
    /// </summary>
    static class ArrayEx
    {
        /// <summary>
        /// Returns an empty array.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array.</typeparam>
        /// <returns>An empty array.</returns>
        public static T[] Empty<T>()
        {
            return EmptyArray<T>.Value;
        }
        
        private static class EmptyArray<T>
        {
#pragma warning disable CA1825 // this is the implementation of ArrayEx.Empty<T>()
            internal static readonly T[] Value = new T[0];
#pragma warning restore CA1825
        }
    }
}