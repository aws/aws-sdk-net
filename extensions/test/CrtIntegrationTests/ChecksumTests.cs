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

using AWSSDK.Extensions.CrtIntegration;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CrtIntegrationTests
{
    /// <summary>
    /// Tests for the CRT checksum wrapper
    /// </summary>
    public class ChecksumTests
    {
        public static IEnumerable<object[]> Crc32TestCases => new List<object[]>
        {
            new object[] { "", "AAAAAA=="},
            new object[] {"abc", "NSRBwg=="},
            new object[] {"Hello world", "i9aeUg=="}
        };

        public static IEnumerable<object[]> Crc32CTestCases => new List<object[]>
        {
            new object[] { "", "AAAAAA=="},
            new object[] {"abc", "Nks/tw=="},
            new object[] {"Hello world", "crUfeA=="}
        };

        public static IEnumerable<object[]> Crc64NVMETestCases => new List<object[]>
        {
            new object[] { "", "AAAAAAAAAAA=" },
            new object[] { "abc", "BeXKuz/B+us=" },
            new object[] { "Hello world", "OOJZ0D8xKts=" },
        };

        [Theory]
        [MemberData(nameof(Crc32TestCases))]
        public void Crc32Test(string content, string expectedHash)
        {
            Assert.Equal(expectedHash, new CrtChecksums().Crc32(Encoding.Default.GetBytes(content)));
        }

        [Theory]
        [MemberData(nameof(Crc32TestCases))]
        public void RollingCrc32Test(string content, string expectedHash)
        {
            uint rollingChecksum = 0;
            var crtChecksum = new CrtChecksums();

            foreach (var c in content)
            {
                rollingChecksum = crtChecksum.Crc32(Encoding.Default.GetBytes(new char[] { c }), rollingChecksum);
            }

            var bytes = BitConverter.GetBytes(rollingChecksum);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            Assert.Equal(expectedHash, Convert.ToBase64String(bytes));
        }

        [Theory]
        [MemberData(nameof(Crc32CTestCases))]
        public void Crc32CTest(string content, string expectedHash)
        {
            Assert.Equal(expectedHash, new CrtChecksums().Crc32C(Encoding.Default.GetBytes(content)));
        }

        [Theory]
        [MemberData(nameof(Crc32CTestCases))]
        public void RollingCrc32CTest(string content, string expectedHash)
        {
            uint rollingChecksum = 0;
            var crtChecksum = new CrtChecksums();

            foreach (var c in content)
            {
                rollingChecksum = crtChecksum.Crc32C(Encoding.Default.GetBytes(new char[] { c }), rollingChecksum);
            }

            var bytes = BitConverter.GetBytes(rollingChecksum);

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            Assert.Equal(expectedHash, Convert.ToBase64String(bytes));
        }

        [Theory]
        [MemberData(nameof(Crc64NVMETestCases))]
        public void Crc64NVMETest(string content, string expectedHash)
        {
            Assert.Equal(expectedHash, new CrtChecksums().Crc64NVME(Encoding.Default.GetBytes(content)));
        }

        [Theory]
        [MemberData(nameof(Crc64NVMETestCases))]
        public void RollingCrc64NVMETest(string content, string expectedHash)
        {
            ulong rollingChecksum = 0;
            var crtChecksum = new CrtChecksums();

            foreach (var c in content)
            {
                rollingChecksum = crtChecksum.Crc64NVME(Encoding.Default.GetBytes(new char[] { c }), rollingChecksum);
            }

            var bytes = BitConverter.GetBytes(rollingChecksum);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            Assert.Equal(expectedHash, Convert.ToBase64String(bytes));
        }
    }
}
