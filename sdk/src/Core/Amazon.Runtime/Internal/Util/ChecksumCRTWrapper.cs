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
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces.Internal;
using Amazon.RuntimeDependencies;
using Amazon.Util.Internal;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using ThirdParty.RuntimeBackports;

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
        private static bool? _isAvailable;
        private static readonly byte[] _emptyArray = new byte[0];

        /// <summary>
        /// Returns whether the CRT checksum implementation is available for the .NET SDK to use.
        /// </summary>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "The CRT may fail to load for several reasons so we need to catch all possible exceptions")]
        public static bool IsCrtAvailable()
        {
            if (_isAvailable != null)
            {
                return _isAvailable.Value;
            }

            lock (_lock)
            {
                if (_isAvailable != null)
                {
                    return _isAvailable.Value;
                }

                try
                {
                    // We cannot rely only on the dependency being available, the CRT may fail if native components are missing in customer's environments.
                    if (Instance != null)
                    {
                        // So we'll attempt to actually calculate a checksum to verify the CRT can be used.
                        Instance.Crc64NVME(_emptyArray);
                        _isAvailable = true;
                    }
                    else
                    {
                        _isAvailable = false;
                    }
                }
                catch (Exception ex)
                {
                    Logger.GetLogger(typeof(ChecksumCRTWrapper)).Debug(ex, "Unable to use the AWS Common Runtime checksum implementation: {0}", ex.Message);
                    _isAvailable = false;
                }

                return _isAvailable.Value;
            }
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075",
            Justification = "Reflection code is only used as a fallback in case the SDK was not trimmed. Trimmed scenarios should register dependencies with Amazon.RuntimeDependencyRegistry.GlobalRuntimeDependencyRegistry")]
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

        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <returns>CRC64NVME hash as a base64-encoded string</returns>
        public static string Crc64NVME(byte[] source)
        {
            return Instance.Crc64NVME(source);
        }

        /// <summary>
        /// Computes a CRC64NVME hash
        /// </summary>
        /// <param name="source">Data to hash</param>
        /// <param name="previous">Previous value of a rolling checksum</param>
        /// <returns>Updated CRC64NVME hash as 64-bit integer</returns>
        public static ulong Crc64NVME(byte[] source, ulong previous)
        {
            return Instance.Crc64NVME(source, previous);
        }
    }
}
