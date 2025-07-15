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
using System.Collections.Concurrent;
using System.Formats.Cbor;
using System.Threading;

namespace Amazon.Extensions.CborProtocol.Internal
{
    public static class CborWriterPool
    {
        // Internal pool storage using thread-safe collection
        private static readonly ConcurrentBag<CborWriter> _pool = new ConcurrentBag<CborWriter>();

        // Maximum number of CborWriter instances the pool can hold
        private static int _maxPoolSize = 16;

        /// <summary>
        /// Gets or sets the maximum size of the writer pool.
        /// Minimum value is 1.
        /// </summary>
        public static int MaxPoolSize
        {
            get => Volatile.Read(ref _maxPoolSize);
            set => Volatile.Write(ref _maxPoolSize, Math.Max(1, value));
        }

        /// <summary>
        /// Retrieves a CborWriter from the pool, or creates a new one if the pool is empty.
        /// </summary>
        public static CborWriter Rent()
        {
            if (_pool.TryTake(out var writer))
            {
                return writer;
            }
            // Create a new CborWriter if the pool is empty
            return new CborWriter(CborConformanceMode.Canonical, true);
        }

        /// <summary>
        /// Returns a CborWriter to the pool for reuse.
        /// If the pool is already full then the writer will be discard.
        /// </summary>
        public static void Return(CborWriter writer)
        {
            if (_pool.Count >= Volatile.Read(ref _maxPoolSize))
                return;

            writer.Reset(); // Ensure the writer is in a clean state before pooling
            _pool.Add(writer);
        }
    }
}
