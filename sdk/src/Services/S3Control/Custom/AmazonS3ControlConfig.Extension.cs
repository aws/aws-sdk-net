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
using Amazon.Runtime.CredentialManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3Control
{
    public partial class AmazonS3ControlConfig : ClientConfig
    {
        private const string UseArnRegionEnvName = "AWS_S3_USE_ARN_REGION";
        private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";
        private const string DefaultProfileName = "default";
        private static CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();

        // we cache this per execution process to avoid excessive file I/O
        private static CredentialProfile _profile;
        private static object _triedToResolveProfileLock = new object();
        private static bool _triedToResolveProfile = false;

        bool? _useArnRegion;
        private object _useArnRegionLock = new object();
        /// <summary>
        /// If set to true and the service package supports it the region identified in the arn for a resource
        /// will be used when making the service request.
        /// </summary>
        public bool UseArnRegion
        {
            get
            {
                if (_useArnRegion.HasValue)
                {
                    return _useArnRegion.GetValueOrDefault();
                }

                if (!_triedToResolveProfile)
                {
                    lock (_triedToResolveProfileLock)
                    {
                        if (!_triedToResolveProfile)
                        {
                            var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                            credentialProfileChain.TryGetProfile(profileName, out _profile);
                            _triedToResolveProfile = true;
                        }
                    }
                }

                lock (_useArnRegionLock)
                {
                    if (_useArnRegion.HasValue)
                    {
                        return _useArnRegion.Value;
                    }

                    _useArnRegion = _profile?.S3UseArnRegion;

                    if (!_useArnRegion.HasValue && !string.IsNullOrEmpty(Environment.GetEnvironmentVariable(UseArnRegionEnvName)))
                    {
                        if (bool.TryParse(Environment.GetEnvironmentVariable(UseArnRegionEnvName), out var value))
                        {
                            _useArnRegion = value;
                        }
                    }

                    if (!_useArnRegion.HasValue)
                    {
                        // To maintain consistency with buckets default UseArnRegion to true when client configured for us-east-1.
                        _useArnRegion = RegionEndpoint?.SystemName == RegionEndpoint.USEast1.SystemName;
                    }

                    return _useArnRegion.Value;
                }
            }

            set
            {
                lock (_useArnRegionLock)
                {
                    _useArnRegion = value;
                }
            }
        }
    }
}
