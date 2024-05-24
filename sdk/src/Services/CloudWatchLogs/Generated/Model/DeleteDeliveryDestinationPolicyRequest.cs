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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDeliveryDestinationPolicy operation.
    /// Deletes a delivery destination policy. For more information about these policies,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>.
    /// </summary>
    public partial class DeleteDeliveryDestinationPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _deliveryDestinationName;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationName. 
        /// <para>
        /// The name of the delivery destination that you want to delete the policy for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string DeliveryDestinationName
        {
            get { return this._deliveryDestinationName; }
            set { this._deliveryDestinationName = value; }
        }

        // Check to see if DeliveryDestinationName property is set
        internal bool IsSetDeliveryDestinationName()
        {
            return this._deliveryDestinationName != null;
        }

    }
}