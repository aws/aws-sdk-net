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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the GetConnectionGroupByRoutingEndpoint operation.
    /// Gets information about a connection group by using the endpoint that you specify.
    /// </summary>
    public partial class GetConnectionGroupByRoutingEndpointRequest : AmazonCloudFrontRequest
    {
        private string _routingEndpoint;

        /// <summary>
        /// Gets and sets the property RoutingEndpoint. 
        /// <para>
        /// The routing endpoint for the target connection group, such as d111111abcdef8.cloudfront.net.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoutingEndpoint
        {
            get { return this._routingEndpoint; }
            set { this._routingEndpoint = value; }
        }

        // Check to see if RoutingEndpoint property is set
        internal bool IsSetRoutingEndpoint()
        {
            return this._routingEndpoint != null;
        }

    }
}