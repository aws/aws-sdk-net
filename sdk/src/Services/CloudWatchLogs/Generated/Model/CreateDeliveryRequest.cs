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
    /// Container for the parameters to the CreateDelivery operation.
    /// Creates a <i>delivery</i>. A delivery is a connection between a logical <i>delivery
    /// source</i> and a logical <i>delivery destination</i> that you have already created.
    /// 
    ///  
    /// <para>
    /// Only some Amazon Web Services services support being configured as a delivery source
    /// using this operation. These services are listed as <b>Supported [V2 Permissions]</b>
    /// in the table at <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
    /// logging from Amazon Web Services services.</a> 
    /// </para>
    ///  
    /// <para>
    /// A delivery destination can represent a log group in CloudWatch Logs, an Amazon S3
    /// bucket, or a delivery stream in Firehose.
    /// </para>
    ///  
    /// <para>
    /// To configure logs delivery between a supported Amazon Web Services service and a destination,
    /// you must do the following:
    /// </para>
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
    /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
    /// in the destination account to assign an IAM policy to the destination. This policy
    /// allows delivery to that destination. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
    /// source and one delivery destination. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can configure a single delivery source to send logs to multiple destinations by
    /// creating multiple deliveries. You can also create multiple deliveries to configure
    /// multiple delivery sources to send logs to the same delivery destination.
    /// </para>
    ///  
    /// <para>
    /// You can't update an existing delivery. You can only create and delete deliveries.
    /// </para>
    /// </summary>
    public partial class CreateDeliveryRequest : AmazonCloudWatchLogsRequest
    {
        private string _deliveryDestinationArn;
        private string _deliverySourceName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationArn. 
        /// <para>
        /// The ARN of the delivery destination to use for this delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliveryDestinationArn
        {
            get { return this._deliveryDestinationArn; }
            set { this._deliveryDestinationArn = value; }
        }

        // Check to see if DeliveryDestinationArn property is set
        internal bool IsSetDeliveryDestinationArn()
        {
            return this._deliveryDestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverySourceName. 
        /// <para>
        /// The name of the delivery source to use for this delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string DeliverySourceName
        {
            get { return this._deliverySourceName; }
            set { this._deliverySourceName = value; }
        }

        // Check to see if DeliverySourceName property is set
        internal bool IsSetDeliverySourceName()
        {
            return this._deliverySourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}