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
    /// Container for the parameters to the PutDeliveryDestinationPolicy operation.
    /// Creates and assigns an IAM policy that grants permissions to CloudWatch Logs to deliver
    /// logs cross-account to a specified destination in this account. To configure the delivery
    /// of logs from an Amazon Web Services service in another account to a logs delivery
    /// destination in the current account, you must do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Create a delivery source, which is a logical object that represents the resource that
    /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a <i>delivery destination</i>, which is a logical object that represents the
    /// actual delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use this operation in the destination account to assign an IAM policy to the destination.
    /// This policy allows delivery to that destination. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a <i>delivery</i> by pairing exactly one delivery source and one delivery destination.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Only some Amazon Web Services services support being configured as a delivery source.
    /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
    /// logging from Amazon Web Services services.</a> 
    /// </para>
    ///  
    /// <para>
    /// The contents of the policy must include two statements. One statement enables general
    /// logs delivery, and the other allows delivery to the chosen destination. See the examples
    /// for the needed policies.
    /// </para>
    /// </summary>
    public partial class PutDeliveryDestinationPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _deliveryDestinationName;
        private string _deliveryDestinationPolicy;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationName. 
        /// <para>
        /// The name of the delivery destination to assign this policy to.
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

        /// <summary>
        /// Gets and sets the property DeliveryDestinationPolicy. 
        /// <para>
        /// The contents of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=51200)]
        public string DeliveryDestinationPolicy
        {
            get { return this._deliveryDestinationPolicy; }
            set { this._deliveryDestinationPolicy = value; }
        }

        // Check to see if DeliveryDestinationPolicy property is set
        internal bool IsSetDeliveryDestinationPolicy()
        {
            return this._deliveryDestinationPolicy != null;
        }

    }
}