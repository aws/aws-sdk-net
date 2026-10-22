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
using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utilities for dealing with Guids
    /// </summary>
    public static class GuidUtils
    {
        private const int GuidSize = 16;
        private const int GuidsPerBatch = 64;
        private const string LambdaInitializationTypeVariable = "AWS_LAMBDA_INITIALIZATION_TYPE";
        private const string SnapStartInitializationType = "snap-start";
        private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

        // Lambda SnapStart restores many execution environments from one memory snapshot, so random
        // bytes buffered before the snapshot would be handed out again by every restored environment.
        // Under SnapStart every Guid comes straight from Guid.NewGuid() instead.
        private static bool _isSnapStart = IsSnapStartInitialization();

        [ThreadStatic]
        private static byte[] _randomBatch;
        [ThreadStatic]
        private static int _randomBatchOffset;

        /// <summary>
        /// Returns a random (RFC 4122 version 4) Guid, like <see cref="Guid.NewGuid"/>.
        /// Random bytes come from a cryptographic RNG in per-thread batches, which avoids
        /// a system call per Guid on platforms where <see cref="Guid.NewGuid"/> makes one.
        /// Under Lambda SnapStart, where buffered random bytes would survive a snapshot,
        /// it calls <see cref="Guid.NewGuid"/>.
        /// </summary>
        internal static Guid NewRandomGuid()
        {
            if (_isSnapStart)
                return Guid.NewGuid();

            var batch = _randomBatch;
            var offset = _randomBatchOffset;
            if (batch == null)
            {
                batch = _randomBatch = new byte[GuidSize * GuidsPerBatch];
                offset = batch.Length;
            }
            if (offset >= batch.Length)
            {
                _rng.GetBytes(batch);
                offset = 0;
            }
            _randomBatchOffset = offset + GuidSize;

            return FromRandomBytes(batch, offset);
        }

        /// <summary>
        /// Builds a version 4, variant 1 Guid from 16 random bytes at <paramref name="offset"/>, with the
        /// same byte layout as <c>new Guid(byte[])</c>.
        /// </summary>
        internal static Guid FromRandomBytes(byte[] random, int offset)
        {
            int a = random[offset] | (random[offset + 1] << 8) | (random[offset + 2] << 16) | (random[offset + 3] << 24);
            short b = (short)(random[offset + 4] | (random[offset + 5] << 8));
            short c = (short)(random[offset + 6] | (((random[offset + 7] & 0x0F) | 0x40) << 8));
            byte d = (byte)((random[offset + 8] & 0x3F) | 0x80);
            return new Guid(a, b, c, d, random[offset + 9], random[offset + 10], random[offset + 11],
                random[offset + 12], random[offset + 13], random[offset + 14], random[offset + 15]);
        }

        /// <summary>
        /// Re-reads AWS_LAMBDA_INITIALIZATION_TYPE. Used by tests that set the variable at runtime.
        /// </summary>
        internal static void ResetIsSnapStart()
        {
            _isSnapStart = IsSnapStartInitialization();
        }

        internal static bool IsSnapStart => _isSnapStart;

        private static bool IsSnapStartInitialization()
        {
            return string.Equals(Environment.GetEnvironmentVariable(LambdaInitializationTypeVariable),
                SnapStartInitializationType, StringComparison.Ordinal);
        }

        public static bool TryParseNullableGuid(string value, out Guid? result)
        {
            Guid guid;
            if (TryParseGuid(value, out guid))
            {
                result = guid;
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public static bool TryParseGuid(string value, out Guid result)
        {
            try
            {
                result = new Guid(value);
                return true;
            }
            catch (Exception)
            {
                result = Guid.Empty;
                return false;
            }
        }
    }
}
