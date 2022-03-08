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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces.Internal;
using Amazon.Util.Internal;
using System.Globalization;
using System.IO;

namespace AWSSDK.Runtime.Internal.Util
{
    /// <summary>
    /// Wrapper for checksum algorithms provided by the AWS Common Runtime
    /// </summary>
    public static class ChecksumCRTWrapper
    {
        private const string CRT_WRAPPER_ASSEMBLY_NAME = "AWSSDK.Extensions.CrtIntegration";
        private const string CRT_WRAPPER_NUGET_PACKAGE_NAME = "AWSSDK.Extensions.CrtIntegration";
        private const string CRT_WRAPPER_CLASS_NAME = "AWSSDK.Extensions.CrtIntegration.CrtChecksums";

        private static readonly object _lock = new object();
        private static volatile IChecksumProvider _instance;

        private static IChecksumProvider Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        try
                        {
                            var crtWrapperTypeInfo = ServiceClientHelpers.LoadTypeFromAssembly(CRT_WRAPPER_ASSEMBLY_NAME, CRT_WRAPPER_CLASS_NAME);
                            var constructor = crtWrapperTypeInfo.GetConstructor(new ITypeInfo[] { });

                            _instance = constructor.Invoke(null) as IChecksumProvider;
                        }
                        catch (FileNotFoundException)
                        {
                            throw new AWSCommonRuntimeException
                            (
                                string.Format(CultureInfo.InvariantCulture,
                                    "Attempting to handle a request that requires additional checksums. Add a reference " +
                                    $"to the {CRT_WRAPPER_NUGET_PACKAGE_NAME} NuGet package to your project to include the AWS Common Runtime checksum implementation.")
                            );
                        }
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32 hash as a base64-encoded string</returns>
        public static string Crc32(byte[] source)
        {
            return Instance.Crc32(source);
        }

        /// <summary>
        /// Computes a CRC32 hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32 hash as 32-bit integer</returns>
        public static uint Crc32(byte[] source, uint previous)
        {
            return Instance.Crc32(source, previous);
        }

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC32c hash as a base64-encoded string</returns>
        public static string Crc32C(byte[] source)
        {
            return Instance.Crc32C(source);
        }

        /// <summary>
        /// Computes a CRC32C hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC32C hash as 32-bit integer</returns>
        public static uint Crc32C(byte[] source, uint previous)
        {
            return Instance.Crc32C(source, previous);
        }
    }
}
