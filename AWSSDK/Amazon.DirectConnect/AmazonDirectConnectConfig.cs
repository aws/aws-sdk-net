/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DirectConnect
{

    /// <summary>
    /// Configuration for accessing  service
    /// </summary>
    public class AmazonDirectConnectConfig : ClientConfig
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonDirectConnectConfig()
        {
            this.ServiceURL = "https://directconnect.us-east-1.amazonaws.com/";
            this.AuthenticationServiceName = "directconnect";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        internal override string RegionEndpointServiceName
        {
            get
            {
                return "directconnect";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2012-10-25";
            }
        }
    }
}

    
