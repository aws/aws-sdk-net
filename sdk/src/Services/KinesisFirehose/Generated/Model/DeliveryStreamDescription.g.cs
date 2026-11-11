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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Contains information about a Firehose stream.
    /// </summary>
    public partial class DeliveryStreamDescription
    {
        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time that the Firehose stream was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeliveryStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Firehose stream. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string DeliveryStreamARN { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamARN property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamARN() => this.DeliveryStreamARN != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamEncryptionConfiguration. 
        /// <para>
        /// Indicates the server-side encryption (SSE) status for the Firehose stream.
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionConfiguration DeliveryStreamEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamEncryptionConfiguration() => this.DeliveryStreamEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DeliveryStreamName { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamName property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamName() => this.DeliveryStreamName != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamStatus. 
        /// <para>
        /// The status of the Firehose stream. If the status of a Firehose stream is <c>CREATING_FAILED</c>,
        /// this status doesn't change, and you can't invoke <c>CreateDeliveryStream</c> again
        /// on it. However, you can invoke the <a>DeleteDeliveryStream</a> operation to delete
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliveryStreamStatus DeliveryStreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamStatus property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamStatus() => this.DeliveryStreamStatus != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamType. 
        /// <para>
        /// The Firehose stream type. This can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DirectPut</c>: Provider applications access the Firehose stream directly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KinesisStreamAsSource</c>: The Firehose stream uses a Kinesis data stream as a
        /// source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliveryStreamType DeliveryStreamType { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamType property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamType() => this.DeliveryStreamType != null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destinations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DestinationDescription> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationDescription>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// Provides details in case one of the following operations fails due to an error related
        /// to KMS: <a>CreateDeliveryStream</a>, <a>DeleteDeliveryStream</a>, <a>StartDeliveryStreamEncryption</a>,
        /// <a>StopDeliveryStreamEncryption</a>.
        /// </para>
        /// </summary>
        public FailureDescription FailureDescription { get; set; }

        /// <summary>
        /// Checks to see if the FailureDescription property is set.
        /// </summary>
        internal bool IsSetFailureDescription() => this.FailureDescription != null;

        /// <summary>
        /// Gets and sets the property HasMoreDestinations. 
        /// <para>
        /// Indicates whether there are more destinations available to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? HasMoreDestinations { get; set; }

        /// <summary>
        /// Checks to see if the HasMoreDestinations property is set.
        /// </summary>
        internal bool IsSetHasMoreDestinations() => this.HasMoreDestinations.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The date and time that the Firehose stream was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// If the <c>DeliveryStreamType</c> parameter is <c>KinesisStreamAsSource</c>, a <a>SourceDescription</a>
        /// object describing the source Kinesis data stream.
        /// </para>
        /// </summary>
        public SourceDescription Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Each time the destination is updated for a Firehose stream, the version ID is changed,
        /// and the current version ID is required when updating the destination. This is so that
        /// the service knows it is applying the changes to the correct version of the delivery
        /// stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
