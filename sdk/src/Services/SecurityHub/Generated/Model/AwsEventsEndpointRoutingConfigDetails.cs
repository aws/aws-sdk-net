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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the routing configuration of the endpoint.
    /// </summary>
    public partial class AwsEventsEndpointRoutingConfigDetails
    {
        private AwsEventsEndpointRoutingConfigFailoverConfigDetails _failoverConfig;

        /// <summary>
        /// Gets and sets the property FailoverConfig. 
        /// <para>
        ///  The failover configuration for an endpoint. This includes what triggers failover
        /// and what happens when it's triggered.
        /// </para>
        /// </summary>
        public AwsEventsEndpointRoutingConfigFailoverConfigDetails FailoverConfig
        {
            get { return this._failoverConfig; }
            set { this._failoverConfig = value; }
        }

        // Check to see if FailoverConfig property is set
        internal bool IsSetFailoverConfig()
        {
            return this._failoverConfig != null;
        }

    }
}