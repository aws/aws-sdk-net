/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon;
using Amazon.Runtime;

using AWSSDK.Extensions.NETCore.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public class AWSOptions
    {
        public string Profile { get; set; }

        public string ProfilesLocation { get; set; }

        public RegionEndpoint Region { get; set; }


        private ClientConfig _defaultClientConfig;
        public ClientConfig DefaultClientConfig
        {
            get
            {
                if (this._defaultClientConfig == null)
                    this._defaultClientConfig = new DefaultClientConfig();

                return this._defaultClientConfig;
            }
        }

        internal bool IsDefaultClientConfigSet
        {
            get
            {
                return this._defaultClientConfig != null;
            }
        }

        public AWSOptions UseProfile(string profile)
        {
            this.Profile = profile;
            return this;
        }

        public AWSOptions UseProfilesLocation(string profilesLocation)
        {
            this.ProfilesLocation = profilesLocation;
            return this;
        }

        public AWSOptions UseRegion(RegionEndpoint region)
        {
            this.Region = region;
            return this;
        }
    }
}
