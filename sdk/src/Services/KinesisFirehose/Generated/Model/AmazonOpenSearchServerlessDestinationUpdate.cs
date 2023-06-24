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
    /// Describes an update for a destination in the Serverless offering for Amazon OpenSearch
    /// Service.
    /// </summary>
    public partial class AmazonOpenSearchServerlessDestinationUpdate
    {
        private AmazonOpenSearchServerlessBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _collectionEndpoint;
        private string _indexName;
        private ProcessingConfiguration _processingConfiguration;
        private AmazonOpenSearchServerlessRetryOptions _retryOptions;
        private string _roleARN;
        private S3DestinationUpdate _s3Update;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, AmazonopensearchBufferingHints object
        /// default values are used.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessBufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// The endpoint to use when communicating with the collection in the Serverless offering
        /// for Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string CollectionEndpoint
        {
            get { return this._collectionEndpoint; }
            set { this._collectionEndpoint = value; }
        }

        // Check to see if CollectionEndpoint property is set
        internal bool IsSetCollectionEndpoint()
        {
            return this._collectionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The Serverless offering for Amazon OpenSearch Service index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Kinesis Data Firehose is unable to deliver documents to
        /// the Serverless offering for Amazon OpenSearch Service. The default value is 300 (5
        /// minutes).
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose
        /// for calling the Serverless offering for Amazon OpenSearch Service Configuration API
        /// and for indexing documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3Update.
        /// </summary>
        public S3DestinationUpdate S3Update
        {
            get { return this._s3Update; }
            set { this._s3Update = value; }
        }

        // Check to see if S3Update property is set
        internal bool IsSetS3Update()
        {
            return this._s3Update != null;
        }

    }
}