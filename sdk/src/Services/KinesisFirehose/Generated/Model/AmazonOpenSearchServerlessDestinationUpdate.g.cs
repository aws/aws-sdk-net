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
    /// Describes an update for a destination in the Serverless offering for Amazon OpenSearch
    /// Service.
    /// </summary>
    public partial class AmazonOpenSearchServerlessDestinationUpdate
    {
        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, AmazonopensearchBufferingHints object
        /// default values are used.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// The endpoint to use when communicating with the collection in the Serverless offering
        /// for Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string CollectionEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CollectionEndpoint property is set.
        /// </summary>
        internal bool IsSetCollectionEndpoint() => this.CollectionEndpoint != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The Serverless offering for Amazon OpenSearch Service index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Firehose is unable to deliver documents to the Serverless
        /// offering for Amazon OpenSearch Service. The default value is 300 (5 minutes).
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Firehose for calling
        /// the Serverless offering for Amazon OpenSearch Service Configuration API and for indexing
        /// documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3Update.
        /// </summary>
        public S3DestinationUpdate S3Update { get; set; }

        /// <summary>
        /// Checks to see if the S3Update property is set.
        /// </summary>
        internal bool IsSetS3Update() => this.S3Update != null;
    }
}
