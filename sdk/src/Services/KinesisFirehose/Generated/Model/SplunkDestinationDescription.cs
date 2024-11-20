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
    /// Describes a destination in Splunk.
    /// </summary>
    public partial class SplunkDestinationDescription
    {
        private SplunkBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private int? _hecAcknowledgmentTimeoutInSeconds;
        private string _hecEndpoint;
        private HECEndpointType _hecEndpointType;
        private string _hecToken;
        private ProcessingConfiguration _processingConfiguration;
        private SplunkRetryOptions _retryOptions;
        private SplunkS3BackupMode _s3BackupMode;
        private S3DestinationDescription _s3DestinationDescription;
        private SecretsManagerConfiguration _secretsManagerConfiguration;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, the default values for Splunk are
        /// used.
        /// </para>
        /// </summary>
        public SplunkBufferingHints BufferingHints
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
        /// <para>
        /// The Amazon CloudWatch logging options for your Firehose stream.
        /// </para>
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
        /// Gets and sets the property HECAcknowledgmentTimeoutInSeconds. 
        /// <para>
        /// The amount of time that Firehose waits to receive an acknowledgment from Splunk after
        /// it sends it data. At the end of the timeout period, Firehose either tries to send
        /// the data again or considers it an error, based on your retry settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=180, Max=600)]
        public int? HECAcknowledgmentTimeoutInSeconds
        {
            get { return this._hecAcknowledgmentTimeoutInSeconds; }
            set { this._hecAcknowledgmentTimeoutInSeconds = value; }
        }

        // Check to see if HECAcknowledgmentTimeoutInSeconds property is set
        internal bool IsSetHECAcknowledgmentTimeoutInSeconds()
        {
            return this._hecAcknowledgmentTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HECEndpoint. 
        /// <para>
        /// The HTTP Event Collector (HEC) endpoint to which Firehose sends your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string HECEndpoint
        {
            get { return this._hecEndpoint; }
            set { this._hecEndpoint = value; }
        }

        // Check to see if HECEndpoint property is set
        internal bool IsSetHECEndpoint()
        {
            return this._hecEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HECEndpointType. 
        /// <para>
        /// This type can be either "Raw" or "Event."
        /// </para>
        /// </summary>
        public HECEndpointType HECEndpointType
        {
            get { return this._hecEndpointType; }
            set { this._hecEndpointType = value; }
        }

        // Check to see if HECEndpointType property is set
        internal bool IsSetHECEndpointType()
        {
            return this._hecEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HECToken. 
        /// <para>
        /// A GUID you obtain from your Splunk cluster when you create a new HEC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string HECToken
        {
            get { return this._hecToken; }
            set { this._hecToken = value; }
        }

        // Check to see if HECToken property is set
        internal bool IsSetHECToken()
        {
            return this._hecToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
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
        /// The retry behavior in case Firehose is unable to deliver data to Splunk or if it doesn't
        /// receive an acknowledgment of receipt from Splunk.
        /// </para>
        /// </summary>
        public SplunkRetryOptions RetryOptions
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
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Defines how documents should be delivered to Amazon S3. When set to <c>FailedDocumentsOnly</c>,
        /// Firehose writes any data that could not be indexed to the configured Amazon S3 destination.
        /// When set to <c>AllDocuments</c>, Firehose delivers all incoming records to Amazon
        /// S3, and also writes failed documents to Amazon S3. Default value is <c>FailedDocumentsOnly</c>.
        /// 
        /// </para>
        /// </summary>
        public SplunkS3BackupMode S3BackupMode
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
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// The Amazon S3 destination.&gt;
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for Splunk. 
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