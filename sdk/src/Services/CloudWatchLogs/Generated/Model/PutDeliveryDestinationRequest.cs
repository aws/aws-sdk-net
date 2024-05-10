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
    /// Container for the parameters to the PutDeliveryDestination operation.
    /// Creates or updates a logical <i>delivery destination</i>. A delivery destination is
    /// an Amazon Web Services resource that represents an Amazon Web Services service that
    /// logs can be sent to. CloudWatch Logs, Amazon S3, and Firehose are supported as logs
    /// delivery destinations.
    /// 
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
    /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i>, which is
    /// a logical object that represents the actual delivery destination. 
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
    /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can configure a single delivery source to send logs to multiple destinations by
    /// creating multiple deliveries. You can also create multiple deliveries to configure
    /// multiple delivery sources to send logs to the same delivery destination.
    /// </para>
    ///  
    /// <para>
    /// Only some Amazon Web Services services support being configured as a delivery source.
    /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
    /// logging from Amazon Web Services services.</a> 
    /// </para>
    ///  
    /// <para>
    /// If you use this operation to update an existing delivery destination, all the current
    /// delivery destination parameters are overwritten with the new parameter values that
    /// you specify.
    /// </para>
    /// </summary>
    public partial class PutDeliveryDestinationRequest : AmazonCloudWatchLogsRequest
    {
        private DeliveryDestinationConfiguration _deliveryDestinationConfiguration;
        private string _name;
        private OutputFormat _outputFormat;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationConfiguration. 
        /// <para>
        /// A structure that contains the ARN of the Amazon Web Services resource that will receive
        /// the logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliveryDestinationConfiguration DeliveryDestinationConfiguration
        {
            get { return this._deliveryDestinationConfiguration; }
            set { this._deliveryDestinationConfiguration = value; }
        }

        // Check to see if DeliveryDestinationConfiguration property is set
        internal bool IsSetDeliveryDestinationConfiguration()
        {
            return this._deliveryDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for this delivery destination. This name must be unique for all delivery destinations
        /// in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The format for the logs that this delivery destination will receive.
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
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