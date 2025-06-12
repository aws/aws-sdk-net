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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
        private DateTime? _createTimestamp;
        private string _deliveryStreamARN;
        private DeliveryStreamEncryptionConfiguration _deliveryStreamEncryptionConfiguration;
        private string _deliveryStreamName;
        private DeliveryStreamStatus _deliveryStreamStatus;
        private DeliveryStreamType _deliveryStreamType;
        private List<DestinationDescription> _destinations = AWSConfigs.InitializeCollections ? new List<DestinationDescription>() : null;
        private FailureDescription _failureDescription;
        private bool? _hasMoreDestinations;
        private DateTime? _lastUpdateTimestamp;
        private SourceDescription _source;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time that the Firehose stream was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Firehose stream. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DeliveryStreamARN
        {
            get { return this._deliveryStreamARN; }
            set { this._deliveryStreamARN = value; }
        }

        // Check to see if DeliveryStreamARN property is set
        internal bool IsSetDeliveryStreamARN()
        {
            return this._deliveryStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamEncryptionConfiguration. 
        /// <para>
        /// Indicates the server-side encryption (SSE) status for the Firehose stream.
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionConfiguration DeliveryStreamEncryptionConfiguration
        {
            get { return this._deliveryStreamEncryptionConfiguration; }
            set { this._deliveryStreamEncryptionConfiguration = value; }
        }

        // Check to see if DeliveryStreamEncryptionConfiguration property is set
        internal bool IsSetDeliveryStreamEncryptionConfiguration()
        {
            return this._deliveryStreamEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamStatus. 
        /// <para>
        /// The status of the Firehose stream. If the status of a Firehose stream is <c>CREATING_FAILED</c>,
        /// this status doesn't change, and you can't invoke <c>CreateDeliveryStream</c> again
        /// on it. However, you can invoke the <a>DeleteDeliveryStream</a> operation to delete
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliveryStreamStatus DeliveryStreamStatus
        {
            get { return this._deliveryStreamStatus; }
            set { this._deliveryStreamStatus = value; }
        }

        // Check to see if DeliveryStreamStatus property is set
        internal bool IsSetDeliveryStreamStatus()
        {
            return this._deliveryStreamStatus != null;
        }

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
        [AWSProperty(Required=true)]
        public DeliveryStreamType DeliveryStreamType
        {
            get { return this._deliveryStreamType; }
            set { this._deliveryStreamType = value; }
        }

        // Check to see if DeliveryStreamType property is set
        internal bool IsSetDeliveryStreamType()
        {
            return this._deliveryStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destinations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DestinationDescription> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureDescription. 
        /// <para>
        /// Provides details in case one of the following operations fails due to an error related
        /// to KMS: <a>CreateDeliveryStream</a>, <a>DeleteDeliveryStream</a>, <a>StartDeliveryStreamEncryption</a>,
        /// <a>StopDeliveryStreamEncryption</a>.
        /// </para>
        /// </summary>
        public FailureDescription FailureDescription
        {
            get { return this._failureDescription; }
            set { this._failureDescription = value; }
        }

        // Check to see if FailureDescription property is set
        internal bool IsSetFailureDescription()
        {
            return this._failureDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HasMoreDestinations. 
        /// <para>
        /// Indicates whether there are more destinations available to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? HasMoreDestinations
        {
            get { return this._hasMoreDestinations; }
            set { this._hasMoreDestinations = value; }
        }

        // Check to see if HasMoreDestinations property is set
        internal bool IsSetHasMoreDestinations()
        {
            return this._hasMoreDestinations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The date and time that the Firehose stream was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp; }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// If the <c>DeliveryStreamType</c> parameter is <c>KinesisStreamAsSource</c>, a <a>SourceDescription</a>
        /// object describing the source Kinesis data stream.
        /// </para>
        /// </summary>
        public SourceDescription Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Each time the destination is updated for a Firehose stream, the version ID is changed,
        /// and the current version ID is required when updating the destination. This is so that
        /// the service knows it is applying the changes to the correct version of the delivery
        /// stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}