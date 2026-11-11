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
    /// Describes the HTTP endpoint destination.
    /// </summary>
    public partial class HttpEndpointDestinationDescription
    {
        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// Describes buffering options that can be applied to the data before it is delivered
        /// to the HTTPS endpoint destination. Firehose teats these options as hints, and it might
        /// choose to use more optimal values. The <c>SizeInMBs</c> and <c>IntervalInSeconds</c>
        /// parameters are optional. However, if specify a value for one of them, you must also
        /// provide a value for the other. 
        /// </para>
        /// </summary>
        public HttpEndpointBufferingHints BufferingHints { get; set; }

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
        /// Gets and sets the property EndpointConfiguration. 
        /// <para>
        /// The configuration of the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointDescription EndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetEndpointConfiguration() => this.EndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RequestConfiguration. 
        /// <para>
        /// The configuration of request sent to the HTTP endpoint specified as the destination.
        /// </para>
        /// </summary>
        public HttpEndpointRequestConfiguration RequestConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RequestConfiguration property is set.
        /// </summary>
        internal bool IsSetRequestConfiguration() => this.RequestConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// Describes the retry behavior in case Firehose is unable to deliver data to the specified
        /// HTTP endpoint destination, or if it doesn't receive a valid acknowledgment of receipt
        /// from the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// Firehose uses this IAM role for all the permissions that the delivery stream needs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Describes the S3 bucket backup options for the data that Kinesis Firehose delivers
        /// to the HTTP endpoint destination. You can back up all documents (<c>AllData</c>) or
        /// only the documents that Firehose could not deliver to the specified HTTP endpoint
        /// destination (<c>FailedDataOnly</c>).
        /// </para>
        /// </summary>
        public HttpEndpointS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3DestinationDescription.
        /// </summary>
        public S3DestinationDescription S3DestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationDescription property is set.
        /// </summary>
        internal bool IsSetS3DestinationDescription() => this.S3DestinationDescription != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerConfiguration. 
        /// <para>
        ///  The configuration that defines how you access secrets for HTTP Endpoint destination.
        /// 
        /// </para>
        /// </summary>
        public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerConfiguration property is set.
        /// </summary>
        internal bool IsSetSecretsManagerConfiguration() => this.SecretsManagerConfiguration != null;
    }
}
