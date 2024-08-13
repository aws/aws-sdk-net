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
    /// A complex type that contains information about the resource record sets that Amazon
    /// Route 53 created based on a specified traffic policy.
    /// </summary>
    public partial class GetTrafficPolicyInstanceCountResponse : AmazonWebServiceResponse
    {
        private int? _trafficPolicyInstanceCount;

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceCount. 
        /// <para>
        /// The number of traffic policy instances that are associated with the current Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TrafficPolicyInstanceCount
        {
            get { return this._trafficPolicyInstanceCount; }
            set { this._trafficPolicyInstanceCount = value; }
        }

        // Check to see if TrafficPolicyInstanceCount property is set
        internal bool IsSetTrafficPolicyInstanceCount()
        {
            return this._trafficPolicyInstanceCount.HasValue; 
        }

    }
}