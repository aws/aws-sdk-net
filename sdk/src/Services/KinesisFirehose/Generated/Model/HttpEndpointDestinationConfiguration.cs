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
    /// Describes the configuration of the HTTP endpoint destination.
    /// </summary>
    public partial class HttpEndpointDestinationConfiguration
    {
        private HttpEndpointBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private HttpEndpointConfiguration _endpointConfiguration;
        private ProcessingConfiguration _processingConfiguration;
        private HttpEndpointRequestConfiguration _requestConfiguration;
        private HttpEndpointRetryOptions _retryOptions;
        private string _roleARN;
        private HttpEndpointS3BackupMode _s3BackupMode;
        private S3DestinationConfiguration _s3Configuration;
        private SecretsManagerConfiguration _secretsManagerConfiguration;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options that can be used before data is delivered to the specified destination.
        /// Firehose treats these options as hints, and it might choose to use more optimal values.
        /// The <c>SizeInMBs</c> and <c>IntervalInSeconds</c> parameters are optional. However,
        /// if you specify a value for one of them, you must also provide a value for the other.
        /// 
        /// </para>
        /// </summary>
        public HttpEndpointBufferingHints BufferingHints
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
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The configuration of the HTTP endpoint selected as the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HttpEndpointConfiguration EndpointConfiguration
        {
            get { return this._endpointConfiguration; }
            set { this._endpointConfiguration = value; }
        }

        // Check to see if EndpointConfiguration property is set
        internal bool IsSetEndpointConfiguration()
        {
            return this._endpointConfiguration != null;
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
        /// Gets and sets the property RequestConfiguration. 
        /// <para>
        /// The configuration of the request sent to the HTTP endpoint that is specified as the
        /// destination.
        /// </para>
        /// </summary>
        public HttpEndpointRequestConfiguration RequestConfiguration
        {
            get { return this._requestConfiguration; }
            set { this._requestConfiguration = value; }
        }

        // Check to see if RequestConfiguration property is set
        internal bool IsSetRequestConfiguration()
        {
            return this._requestConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// Describes the retry behavior in case Firehose is unable to deliver data to the specified
        /// HTTP endpoint destination, or if it doesn't receive a valid acknowledgment of receipt
        /// from the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointRetryOptions RetryOptions
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
        /// Firehose uses this IAM role for all the permissions that the delivery stream needs.
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
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Describes the S3 bucket backup options for the data that Firehose delivers to the
        /// HTTP endpoint destination. You can back up all documents (<c>AllData</c>) or only
        /// the documents that Firehose could not deliver to the specified HTTP endpoint destination
        /// (<c>FailedDataOnly</c>).
        /// </para>
        /// </summary>
        public HttpEndpointS3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3DestinationConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for HTTP Endpoint destination.
        /// 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration
        {
            get { return this._secretsManagerConfiguration; }
            set { this._secretsManagerConfiguration = value; }
        }

        // Check to see if SecretsManagerConfiguration property is set
        internal bool IsSetSecretsManagerConfiguration()
        {
            return this._secretsManagerConfiguration != null;
        }

    }
}