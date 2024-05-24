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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class GetTrafficPolicyResponse : AmazonWebServiceResponse
    {
        private TrafficPolicy _trafficPolicy;

        /// <summary>
        /// Gets and sets the property TrafficPolicy. 
        /// <para>
        /// A complex type that contains settings for the specified traffic policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrafficPolicy TrafficPolicy
        {
            get { return this._trafficPolicy; }
            set { this._trafficPolicy = value; }
        }

        // Check to see if TrafficPolicy property is set
        internal bool IsSetTrafficPolicy()
        {
            return this._trafficPolicy != null;
        }

    }
}