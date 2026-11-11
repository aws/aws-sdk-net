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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannel operation. Creates a channel that
    /// delivers records from a Kinesis data stream to a destination. A channel reads records
    /// from the specified stream and writes them to streaming tables on Apache Iceberg (Amazon
    /// S3 Tables) or to a general purpose Amazon S3 bucket. <para> You must specify either
    /// <c>S3DestinationConfiguration</c> or <c>S3TablesDestinationConfiguration</c>, but
    /// not both. </para> <para> To use this operation, you must have permission to pass the
    /// specified service execution IAM role to Amazon Kinesis Data Streams (the <c>iam:PassRole</c>
    /// permission on that role). </para> <para> Creating a channel is an asynchronous operation.
    /// Upon receiving the request, Amazon Kinesis Data Streams returns immediately with the
    /// channel in the <c>CREATING</c> state. After provisioning is complete, Amazon Kinesis
    /// Data Streams sets the state to <c>ACTIVE</c>. You can use <a>DescribeChannel</a> to
    /// check the current state. </para> <para> This operation is only supported for data
    /// streams with the on-demand capacity mode. </para> <para> This operation has a call
    /// limit of 5 transactions per second (TPS) for each Amazon Web Services account. Exceeding
    /// 5 TPS results in a <c>LimitExceededException</c>. </para>
    /// </summary>
    public partial class CreateChannelRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel. The name is unique within your Amazon Web Services account
        /// and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The server-side encryption configuration that uses an Amazon Web Services KMS key
        /// to encrypt data delivered to the destination.
        /// </para>
        /// </summary>
        public ChannelEncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Amazon CloudWatch Logs configuration for the channel.
        /// </para>
        /// </summary>
        public ChannelLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// The configuration for delivery to a general purpose Amazon S3 bucket. Specify this
        /// parameter when <c>S3TablesDestinationConfiguration</c> is not specified.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetS3DestinationConfiguration() => this.S3DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3TablesDestinationConfiguration. 
        /// <para>
        /// The configuration for delivery to streaming tables on Apache Iceberg in Amazon S3
        /// Tables. Specify this parameter when <c>S3DestinationConfiguration</c> is not specified.
        /// </para>
        /// </summary>
        public S3TablesDestinationConfiguration S3TablesDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetS3TablesDestinationConfiguration() => this.S3TablesDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Kinesis Data Streams assumes
        /// to write records to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ServiceExecutionRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleARN property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleARN() => this.ServiceExecutionRoleARN != null;

        /// <summary>
        /// Gets and sets the property StreamConfigurationList. 
        /// <para>
        /// The source stream configuration for the channel. Currently, one stream is supported
        /// per channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public List<ChannelStreamConfiguration> StreamConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<ChannelStreamConfiguration>() : null;

        /// <summary>
        /// Checks to see if the StreamConfigurationList property is set.
        /// </summary>
        internal bool IsSetStreamConfigurationList() => this.StreamConfigurationList != null && (this.StreamConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key-value pairs to assign to the channel. A tag consists of a required key
        /// and an optional value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
