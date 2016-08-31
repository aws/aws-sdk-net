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

using Amazon.Runtime;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// Default ClientConfig used as a holder for settings specified in configuration system. 
    /// </summary>
    internal class DefaultClientConfig : ClientConfig
    {
        internal DefaultClientConfig()
        {

        }

        public override string RegionEndpointServiceName
        {
            get
            {
                return null;
            }
        }

        public override string ServiceVersion
        {
            get
            {
                return null;
            }
        }

        public override string UserAgent
        {
            get
            {
                return null;
            }
        }
    }
}
