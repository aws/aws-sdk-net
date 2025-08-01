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
    /// This structure contains information about one <i>delivery destination</i> in your
    /// account. A delivery destination is an Amazon Web Services resource that represents
    /// an Amazon Web Services service that logs can be sent to. CloudWatch Logs, Amazon S3,
    /// Firehose, and X-Ray are supported as delivery destinations.
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
    /// Create a <i>delivery destination</i>, which is a logical object that represents the
    /// actual delivery destination. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
    /// in the destination account to assign an IAM policy to the destination. This policy
    /// allows delivery to that destination. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a <i>delivery</i> by pairing exactly one delivery source and one delivery destination.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can configure a single delivery source to send logs to multiple destinations by
    /// creating multiple deliveries. You can also create multiple deliveries to configure
    /// multiple delivery sources to send logs to the same delivery destination.
    /// </para>
    /// </summary>
    public partial class DeliveryDestination
    {
        private string _arn;
        private DeliveryDestinationConfiguration _deliveryDestinationConfiguration;
        private DeliveryDestinationType _deliveryDestinationType;
        private string _name;
        private OutputFormat _outputFormat;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this delivery destination.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryDestinationConfiguration. 
        /// <para>
        /// A structure that contains the ARN of the Amazon Web Services resource that will receive
        /// the logs.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeliveryDestinationType. 
        /// <para>
        /// Displays whether this delivery destination is CloudWatch Logs, Amazon S3, Firehose,
        /// or X-Ray.
        /// </para>
        /// </summary>
        public DeliveryDestinationType DeliveryDestinationType
        {
            get { return this._deliveryDestinationType; }
            set { this._deliveryDestinationType = value; }
        }

        // Check to see if DeliveryDestinationType property is set
        internal bool IsSetDeliveryDestinationType()
        {
            return this._deliveryDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this delivery destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
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
        /// The format of the logs that are sent to this delivery destination. 
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
        /// The tags that have been assigned to this delivery destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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