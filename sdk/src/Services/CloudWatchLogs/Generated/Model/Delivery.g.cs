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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This structure contains information about one <i>delivery</i> in your account. 
    /// 
    ///  
    /// <para>
    /// A delivery is a connection between a logical <i>delivery source</i> and a logical
    /// <i>delivery destination</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
    /// </para>
    ///  
    /// <para>
    /// To update an existing delivery configuration, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>.
    /// </para>
    /// </summary>
    public partial class Delivery
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this delivery.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationArn. 
        /// <para>
        /// The ARN of the delivery destination that is associated with this delivery.
        /// </para>
        /// </summary>
        public string DeliveryDestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryDestinationArn property is set.
        /// </summary>
        internal bool IsSetDeliveryDestinationArn() => this.DeliveryDestinationArn != null;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationType. 
        /// <para>
        /// Displays whether the delivery destination associated with this delivery is CloudWatch
        /// Logs, Amazon S3, Firehose, or X-Ray.
        /// </para>
        /// </summary>
        public DeliveryDestinationType DeliveryDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryDestinationType property is set.
        /// </summary>
        internal bool IsSetDeliveryDestinationType() => this.DeliveryDestinationType != null;

        /// <summary>
        /// Gets and sets the property DeliverySourceName. 
        /// <para>
        /// The name of the delivery source that is associated with this delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string DeliverySourceName { get; set; }

        /// <summary>
        /// Checks to see if the DeliverySourceName property is set.
        /// </summary>
        internal bool IsSetDeliverySourceName() => this.DeliverySourceName != null;

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// The field delimiter that is used between record fields when the final output format
        /// of a delivery is in <c>Plain</c>, <c>W3C</c>, or <c>Raw</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public string FieldDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the FieldDelimiter property is set.
        /// </summary>
        internal bool IsSetFieldDelimiter() => this.FieldDelimiter != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID that identifies this delivery in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RecordFields. 
        /// <para>
        /// The record fields used in this delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public List<string> RecordFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecordFields property is set.
        /// </summary>
        internal bool IsSetRecordFields() => this.RecordFields != null && (this.RecordFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3DeliveryConfiguration. 
        /// <para>
        /// This structure contains delivery configurations that apply only when the delivery
        /// destination resource is an S3 bucket.
        /// </para>
        /// </summary>
        public S3DeliveryConfiguration S3DeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3DeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetS3DeliveryConfiguration() => this.S3DeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that have been assigned to this delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
