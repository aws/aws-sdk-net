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

namespace Microsoft.Extensions.DependencyInjection
{
    public class AWSOptions
    {
        public string Profile { get; set; }
        public string ProfilesLocation { get; set; }

        public RegionEndpoint Region { get; set; }

        public AWSOptions UseProfile(string profile)
        {
            this.Profile = profile;
            return this;
        }

        public AWSOptions UseRegion(RegionEndpoint region)
        {
            this.Region = region;
            return this;
        }
    }
}
