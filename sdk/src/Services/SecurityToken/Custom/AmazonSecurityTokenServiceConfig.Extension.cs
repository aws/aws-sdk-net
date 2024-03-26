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
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken
{
    public partial class AmazonSecurityTokenServiceConfig : ClientConfig
    {
        private StsRegionalEndpointsValue? _stsRegionalEndpoints;
        private object _stsRegionalEndpointsLock = new object();

        /// <summary>
        /// The default value for StsRegionalEndpoints is <see cref="StsRegionalEndpointsValue.Regional"/>.
        /// 
        /// Get the Sts Regional Flag value by checking the environment variable, the shared credentials file field,
        /// or falling back to <see cref="IDefaultConfigurationProvider"/> and using <see cref="DefaultConfiguration.StsRegionalEndpoints"/>
        /// </summary>
        public StsRegionalEndpointsValue StsRegionalEndpoints 
        {
            get 
            {
                if (_stsRegionalEndpoints.HasValue)
                {
                    return _stsRegionalEndpoints.GetValueOrDefault();
                }

                lock (_stsRegionalEndpointsLock)
                {
                    if (_stsRegionalEndpoints.HasValue)
                    {
                        return _stsRegionalEndpoints.Value;
                    }

                    _stsRegionalEndpoints =
                        CheckSTSEnvironmentVariable() ??
                        CheckCredentialsFile() ??
                        DefaultConfiguration.StsRegionalEndpoints;
                    return _stsRegionalEndpoints.GetValueOrDefault();
                }
            }
            set
            {
                lock (_stsRegionalEndpointsLock)
                {
                    _stsRegionalEndpoints = value;
                }
            }
        }

        private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";

        private const string DefaultProfileName = "default";

        private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

        private static readonly CredentialProfileStoreChain _credentialProfileChain = new CredentialProfileStoreChain();

        // we cache this per execution process to avoid excessive file I/O
        private static CredentialProfile _profile;
        private static object _triedToResolveProfileLock = new object();
        private static bool _triedToResolveProfile = false;

        /// <summary>
        /// If the sts regional flag environment variable is set, then first validate that
        /// it is an acceptable value, if not, then throw an error. Then
        /// set the sts regional flag to that value.
        /// </summary>
        /// <returns> _isRegionalFlagSet: a boolean for whether or not
        /// the environment variable set the regional flag </returns>
        private static StsRegionalEndpointsValue? CheckSTSEnvironmentVariable()
        {
            string stsRegionalFlag = Environment.GetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable);
            if (!string.IsNullOrEmpty(stsRegionalFlag))
            {
                if (!Enum.TryParse<StsRegionalEndpointsValue>(stsRegionalFlag, true, out var stsRegionalFlagValue))
                {
                    throw new InvalidOperationException("Invalid value for AWS_STS_REGIONAL_ENDPOINTS environment variable. A string regional is expected.");
                }

                return stsRegionalFlagValue;
            }
            return null;
        }

        /// <summary>
        /// Check the credential file for an sts regional endpoints
        /// option. If it is set within the file, then set the sts
        /// regional flag to that value.
        /// </summary>
        /// <returns> _isRegionalFlagSet: A boolean for whether
        /// or not the credentials file set the regional flag </returns>
        private static StsRegionalEndpointsValue? CheckCredentialsFile()
        {
            if (_triedToResolveProfile)
            {
                return _profile?.StsRegionalEndpoints;
            }
            lock (_triedToResolveProfileLock)
            {
                if (!_triedToResolveProfile)
                {
                    var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                    _credentialProfileChain.TryGetProfile(profileName, out _profile);
                    _triedToResolveProfile = true;
                }
            }
            return _profile?.StsRegionalEndpoints;
        }
    }
}
