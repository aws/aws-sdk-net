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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDestination operation.
    /// Updates the specified destination of the specified delivery stream.
    /// 
    ///  
    /// <para>
    /// Use this operation to change the destination type (for example, to replace the Amazon
    /// S3 destination with Amazon Redshift) or change the parameters associated with a destination
    /// (for example, to change the bucket name of the Amazon S3 destination). The update
    /// might not occur immediately. The target delivery stream remains active while the configurations
    /// are updated, so data writes to the delivery stream can continue during this process.
    /// The updated configurations are usually effective within a few minutes.
    /// </para>
    ///  
    /// <para>
    /// Switching between Amazon ES and other services is not supported. For an Amazon ES
    /// destination, you can only update to another Amazon ES destination.
    /// </para>
    ///  
    /// <para>
    /// If the destination type is the same, Kinesis Data Firehose merges the configuration
    /// parameters specified with the destination configuration that already exists on the
    /// delivery stream. If any of the parameters are not specified in the call, the existing
    /// values are retained. For example, in the Amazon S3 destination, if <a>EncryptionConfiguration</a>
    /// is not specified, then the existing <code>EncryptionConfiguration</code> is maintained
    /// on the destination.
    /// </para>
    ///  
    /// <para>
    /// If the destination type is not the same, for example, changing the destination from
    /// Amazon S3 to Amazon Redshift, Kinesis Data Firehose does not merge any parameters.
    /// In this case, all parameters must be specified.
    /// </para>
    ///  
    /// <para>
    /// Kinesis Data Firehose uses <code>CurrentDeliveryStreamVersionId</code> to avoid race
    /// conditions and conflicting merges. This is a required field, and the service updates
    /// the configuration only if the existing configuration has a version ID that matches.
    /// After the update is applied successfully, the version ID is updated, and can be retrieved
    /// using <a>DescribeDeliveryStream</a>. Use the new version ID to set <code>CurrentDeliveryStreamVersionId</code>
    /// in the next call.
    /// </para>
    /// </summary>
    public partial class UpdateDestinationRequest : AmazonKinesisFirehoseRequest
    {
        private AmazonOpenSearchServerlessDestinationUpdate _amazonOpenSearchServerlessDestinationUpdate;
        private AmazonopensearchserviceDestinationUpdate _amazonopensearchserviceDestinationUpdate;
        private string _currentDeliveryStreamVersionId;
        private string _deliveryStreamName;
        private string _destinationId;
        private ElasticsearchDestinationUpdate _elasticsearchDestinationUpdate;
        private ExtendedS3DestinationUpdate _extendedS3DestinationUpdate;
        private HttpEndpointDestinationUpdate _httpEndpointDestinationUpdate;
        private RedshiftDestinationUpdate _redshiftDestinationUpdate;
        private S3DestinationUpdate _s3DestinationUpdate;
        private SplunkDestinationUpdate _splunkDestinationUpdate;

        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in the Serverless offering for Amazon OpenSearch
        /// Service.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationUpdate AmazonOpenSearchServerlessDestinationUpdate
        {
            get { return this._amazonOpenSearchServerlessDestinationUpdate; }
            set { this._amazonOpenSearchServerlessDestinationUpdate = value; }
        }

        // Check to see if AmazonOpenSearchServerlessDestinationUpdate property is set
        internal bool IsSetAmazonOpenSearchServerlessDestinationUpdate()
        {
            return this._amazonOpenSearchServerlessDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationUpdate AmazonopensearchserviceDestinationUpdate
        {
            get { return this._amazonopensearchserviceDestinationUpdate; }
            set { this._amazonopensearchserviceDestinationUpdate = value; }
        }

        // Check to see if AmazonopensearchserviceDestinationUpdate property is set
        internal bool IsSetAmazonopensearchserviceDestinationUpdate()
        {
            return this._amazonopensearchserviceDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentDeliveryStreamVersionId. 
        /// <para>
        /// Obtain this value from the <code>VersionId</code> result of <a>DeliveryStreamDescription</a>.
        /// This value is required, and helps the service perform conditional operations. For
        /// example, if there is an interleaving update and this value is null, then the update
        /// destination fails. After the update is successful, the <code>VersionId</code> value
        /// is updated. The service then performs a merge of the old configuration with the new
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string CurrentDeliveryStreamVersionId
        {
            get { return this._currentDeliveryStreamVersionId; }
            set { this._currentDeliveryStreamVersionId = value; }
        }

        // Check to see if CurrentDeliveryStreamVersionId property is set
        internal bool IsSetCurrentDeliveryStreamVersionId()
        {
            return this._currentDeliveryStreamVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
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
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon ES.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationUpdate ElasticsearchDestinationUpdate
        {
            get { return this._elasticsearchDestinationUpdate; }
            set { this._elasticsearchDestinationUpdate = value; }
        }

        // Check to see if ElasticsearchDestinationUpdate property is set
        internal bool IsSetElasticsearchDestinationUpdate()
        {
            return this._elasticsearchDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon S3.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationUpdate ExtendedS3DestinationUpdate
        {
            get { return this._extendedS3DestinationUpdate; }
            set { this._extendedS3DestinationUpdate = value; }
        }

        // Check to see if ExtendedS3DestinationUpdate property is set
        internal bool IsSetExtendedS3DestinationUpdate()
        {
            return this._extendedS3DestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationUpdate. 
        /// <para>
        /// Describes an update to the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationUpdate HttpEndpointDestinationUpdate
        {
            get { return this._httpEndpointDestinationUpdate; }
            set { this._httpEndpointDestinationUpdate = value; }
        }

        // Check to see if HttpEndpointDestinationUpdate property is set
        internal bool IsSetHttpEndpointDestinationUpdate()
        {
            return this._httpEndpointDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftDestinationUpdate RedshiftDestinationUpdate
        {
            get { return this._redshiftDestinationUpdate; }
            set { this._redshiftDestinationUpdate = value; }
        }

        // Check to see if RedshiftDestinationUpdate property is set
        internal bool IsSetRedshiftDestinationUpdate()
        {
            return this._redshiftDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationUpdate. 
        /// <para>
        /// [Deprecated] Describes an update for a destination in Amazon S3.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use ExtendedS3DestinationUpdate instead.")]
        public S3DestinationUpdate S3DestinationUpdate
        {
            get { return this._s3DestinationUpdate; }
            set { this._s3DestinationUpdate = value; }
        }

        // Check to see if S3DestinationUpdate property is set
        internal bool IsSetS3DestinationUpdate()
        {
            return this._s3DestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property SplunkDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Splunk.
        /// </para>
        /// </summary>
        public SplunkDestinationUpdate SplunkDestinationUpdate
        {
            get { return this._splunkDestinationUpdate; }
            set { this._splunkDestinationUpdate = value; }
        }

        // Check to see if SplunkDestinationUpdate property is set
        internal bool IsSetSplunkDestinationUpdate()
        {
            return this._splunkDestinationUpdate != null;
        }

    }
}