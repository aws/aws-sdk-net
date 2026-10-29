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
    /// Describes the configuration of a destination in Splunk.
    /// </summary>
    public partial class SplunkDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, the default values for Splunk are
        /// used.
        /// </para>
        /// </summary>
        public SplunkBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The Amazon CloudWatch logging options for your Firehose stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property HECAcknowledgmentTimeoutInSeconds. 
        /// <para>
        /// The amount of time that Firehose waits to receive an acknowledgment from Splunk after
        /// it sends it data. At the end of the timeout period, Firehose either tries to send
        /// the data again or considers it an error, based on your retry settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 180, Max = 600)]
        public int? HECAcknowledgmentTimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HECAcknowledgmentTimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetHECAcknowledgmentTimeoutInSeconds() => this.HECAcknowledgmentTimeoutInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HECEndpoint. 
        /// <para>
        /// The HTTP Event Collector (HEC) endpoint to which Firehose sends your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string HECEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HECEndpoint property is set.
        /// </summary>
        internal bool IsSetHECEndpoint() => this.HECEndpoint != null;

        /// <summary>
        /// Gets and sets the property HECEndpointType. 
        /// <para>
        /// This type can be either "Raw" or "Event."
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HECEndpointType HECEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the HECEndpointType property is set.
        /// </summary>
        internal bool IsSetHECEndpointType() => this.HECEndpointType != null;

        /// <summary>
        /// Gets and sets the property HECToken. 
        /// <para>
        /// This is a GUID that you obtain from your Splunk cluster when you create a new HEC
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string HECToken { get; set; }

        /// <summary>
        /// Checks to see if the HECToken property is set.
        /// </summary>
        internal bool IsSetHECToken() => this.HECToken != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Firehose is unable to deliver data to Splunk, or if it
        /// doesn't receive an acknowledgment of receipt from Splunk.
        /// </para>
        /// </summary>
        public SplunkRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Defines how documents should be delivered to Amazon S3. When set to <c>FailedEventsOnly</c>,
        /// Firehose writes any data that could not be indexed to the configured Amazon S3 destination.
        /// When set to <c>AllEvents</c>, Firehose delivers all incoming records to Amazon S3,
        /// and also writes failed documents to Amazon S3. The default value is <c>FailedEventsOnly</c>.
        /// </para>
        ///  
        /// <para>
        /// You can update this backup mode from <c>FailedEventsOnly</c> to <c>AllEvents</c>.
        /// You can't update it from <c>AllEvents</c> to <c>FailedEventsOnly</c>.
        /// </para>
        /// </summary>
        public SplunkS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration for the backup Amazon S3 location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for Splunk. 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerConfiguration property is set.
        /// </summary>
        internal bool IsSetSecretsManagerConfiguration() => this.SecretsManagerConfiguration != null;
    }
}
