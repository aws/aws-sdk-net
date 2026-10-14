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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// When you configure the application input, you specify the streaming source, the in-application
    /// stream name that is created, and the mapping between the two. For more information,
    /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
    /// Application Input</a>.
    /// </summary>
    public partial class Input
    {
        /// <summary>
        /// Gets and sets the property InputParallelism. 
        /// <para>
        /// Describes the number of in-application streams to create. 
        /// </para>
        ///  
        /// <para>
        /// Data from your source is routed to these in-application input streams.
        /// </para>
        ///  
        /// <para>
        ///  (see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>.
        /// </para>
        /// </summary>
        public InputParallelism InputParallelism { get; set; }

        /// <summary>
        /// Checks to see if the InputParallelism property is set.
        /// </summary>
        internal bool IsSetInputParallelism() => this.InputParallelism != null;

        /// <summary>
        /// Gets and sets the property InputProcessingConfiguration. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputProcessingConfiguration.html">InputProcessingConfiguration</a>
        /// for the input. An input processor transforms records as they are received from the
        /// stream, before the application's SQL code executes. Currently, the only input processing
        /// configuration available is <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputLambdaProcessor.html">InputLambdaProcessor</a>.
        /// </para>
        /// </summary>
        public InputProcessingConfiguration InputProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetInputProcessingConfiguration() => this.InputProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns in the in-application stream that is being created.
        /// </para>
        ///  
        /// <para>
        /// Also used to describe the format of the reference data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceSchema InputSchema { get; set; }

        /// <summary>
        /// Checks to see if the InputSchema property is set.
        /// </summary>
        internal bool IsSetInputSchema() => this.InputSchema != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseInput. 
        /// <para>
        /// If the streaming source is an Amazon Kinesis Firehose delivery stream, identifies
        /// the delivery stream's ARN and an IAM role that enables Amazon Kinesis Analytics to
        /// access the stream on your behalf.
        /// </para>
        ///  
        /// <para>
        /// Note: Either <c>KinesisStreamsInput</c> or <c>KinesisFirehoseInput</c> is required.
        /// </para>
        /// </summary>
        public KinesisFirehoseInput KinesisFirehoseInput { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseInput property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseInput() => this.KinesisFirehoseInput != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamsInput. 
        /// <para>
        /// If the streaming source is an Amazon Kinesis stream, identifies the stream's Amazon
        /// Resource Name (ARN) and an IAM role that enables Amazon Kinesis Analytics to access
        /// the stream on your behalf.
        /// </para>
        ///  
        /// <para>
        /// Note: Either <c>KinesisStreamsInput</c> or <c>KinesisFirehoseInput</c> is required.
        /// </para>
        /// </summary>
        public KinesisStreamsInput KinesisStreamsInput { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamsInput property is set.
        /// </summary>
        internal bool IsSetKinesisStreamsInput() => this.KinesisStreamsInput != null;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// Name prefix to use when creating an in-application stream. Suppose that you specify
        /// a prefix "MyInApplicationStream." Amazon Kinesis Analytics then creates one or more
        /// (as per the <c>InputParallelism</c> count you specified) in-application streams with
        /// names "MyInApplicationStream_001," "MyInApplicationStream_002," and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;
    }
}
