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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.SharedInterfaces.Internal;
using Amazon.RuntimeDependencies;
using Amazon.Util.Internal;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;

namespace AWSSDK.Runtime.Internal.Util
{
    /// <summary>
    /// Wrapper for checksum algorithms provided by the AWS Common Runtime
    /// </summary>
    public static class ChecksumCRTWrapper
    {
        internal const string CRT_WRAPPER_ASSEMBLY_NAME = "AWSSDK.Extensions.CrtIntegration";
        private const string CRT_WRAPPER_NUGET_PACKAGE_NAME = "AWSSDK.Extensions.CrtIntegration";
        internal const string CRT_WRAPPER_CLASS_NAME = "AWSSDK.Extensions.CrtIntegration.CrtChecksums";

        private static readonly object _lock = new object();
        private static volatile IChecksumProvider _instance;


#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
#endif
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
                        _instance = GlobalRuntimeDependencyRegistry.Instance.GetInstance<IChecksumProvider>(CRT_WRAPPER_ASSEMBLY_NAME, CRT_WRAPPER_CLASS_NAME, new CreateInstanceContext(new CheckSumProviderContext()));
                        if(_instance != null)
                        {
                            return _instance;
                        }

                        try
                        {
                            var crtWrapperType = ServiceClientHelpers.LoadTypeFromAssembly(CRT_WRAPPER_ASSEMBLY_NAME, CRT_WRAPPER_CLASS_NAME);
                            var constructor = crtWrapperType.GetConstructor(new Type[] { });

                            _instance = constructor.Invoke(null) as IChecksumProvider;
                        }
                        catch(Exception e)
                        {
                            if(InternalSDKUtils.IsRunningNativeAot())
                            {
                                throw new MissingRuntimeDependencyException(CRT_WRAPPER_NUGET_PACKAGE_NAME, CRT_WRAPPER_CLASS_NAME, nameof(GlobalRuntimeDependencyRegistry.RegisterChecksumProvider));
                            }
                            else if(e is FileNotFoundException)
                            {
                                throw new AWSCommonRuntimeException
                                  (
                                      string.Format(CultureInfo.InvariantCulture,
                                          "Attempting to handle a request that requires additional checksums. Add a reference " +
                                          $"to the {CRT_WRAPPER_NUGET_PACKAGE_NAME} NuGet package to your project to include the AWS Common Runtime checksum implementation.")
                                  );
                            }

                            throw;
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
