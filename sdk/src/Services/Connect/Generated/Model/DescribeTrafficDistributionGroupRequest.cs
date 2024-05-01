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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTrafficDistributionGroup operation.
    /// Gets details and status of a traffic distribution group.
    /// </summary>
    public partial class DescribeTrafficDistributionGroupRequest : AmazonConnectRequest
    {
        private string _trafficDistributionGroupId;

        /// <summary>
        /// Gets and sets the property TrafficDistributionGroupId. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN if
        /// the API is being called in the Region where the traffic distribution group was created.
        /// The ARN must be provided if the call is from the replicated Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrafficDistributionGroupId
        {
            get { return this._trafficDistributionGroupId; }
            set { this._trafficDistributionGroupId = value; }
        }

        // Check to see if TrafficDistributionGroupId property is set
        internal bool IsSetTrafficDistributionGroupId()
        {
            return this._trafficDistributionGroupId != null;
        }

    }
}