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
    /// Container for the parameters to the DeleteTrafficDistributionGroup operation.
    /// Deletes a traffic distribution group. This API can be called only in the Region where
    /// the traffic distribution group is created.
    /// 
    ///  
    /// <para>
    /// For more information about deleting traffic distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/delete-traffic-distribution-groups.html">Delete
    /// traffic distribution groups</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteTrafficDistributionGroupRequest : AmazonConnectRequest
    {
        private string _trafficDistributionGroupId;

        /// <summary>
        /// Gets and sets the property TrafficDistributionGroupId. 
        /// <para>
        /// The identifier of the traffic distribution group. This can be the ID or the ARN of
        /// the traffic distribution group.
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