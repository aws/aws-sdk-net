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
        bool? _useArnRegion;
        /// <summary>
        /// If set to true and the service package supports it the region identified in the arn for a resource
        /// will be used when making the service request.
        /// </summary>
        public bool UseArnRegion
        {
            get
            {
                if (!this._useArnRegion.HasValue)
                {
                    var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
                    if (credentialProfileChain.TryGetProfile(profileName, out var profile))
                    {
                        this._useArnRegion = profile.S3UseArnRegion;
                    }

                    if (!this._useArnRegion.HasValue && !string.IsNullOrEmpty(Environment.GetEnvironmentVariable(UseArnRegionEnvName)))
                    {
                        if (bool.TryParse(Environment.GetEnvironmentVariable(UseArnRegionEnvName), out var value))
                        {
                            this._useArnRegion = value;
                        }
                    }

                    if (!this._useArnRegion.HasValue)
                    {
                        // To maintain consistency with buckets default UseArnRegion to true when client configured for us-east-1.
                        this._useArnRegion = this.RegionEndpoint == RegionEndpoint.USEast1;
                    }
                }

                return this._useArnRegion.GetValueOrDefault();
            }

            set { this._useArnRegion = value; }
        }
    }
}
