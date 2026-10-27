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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application, describes the application output
    /// configuration, which includes the in-application stream name and the destination where
    /// the stream data is written. The destination can be a Kinesis data stream or a Kinesis
    /// Data Firehose delivery stream.
    /// </summary>
    public partial class OutputDescription
    {
        /// <summary>
        /// Gets and sets the property DestinationSchema. 
        /// <para>
        /// The data format used for writing data to the destination.
        /// </para>
        /// </summary>
        public DestinationSchema DestinationSchema { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSchema property is set.
        /// </summary>
        internal bool IsSetDestinationSchema() => this.DestinationSchema != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseOutputDescription. 
        /// <para>
        /// Describes the Kinesis Data Firehose delivery stream that is configured as the destination
        /// where output is written.
        /// </para>
        /// </summary>
        public KinesisFirehoseOutputDescription KinesisFirehoseOutputDescription { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseOutputDescription property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseOutputDescription() => this.KinesisFirehoseOutputDescription != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamsOutputDescription. 
        /// <para>
        /// Describes the Kinesis data stream that is configured as the destination where output
        /// is written.
        /// </para>
        /// </summary>
        public KinesisStreamsOutputDescription KinesisStreamsOutputDescription { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamsOutputDescription property is set.
        /// </summary>
        internal bool IsSetKinesisStreamsOutputDescription() => this.KinesisStreamsOutputDescription != null;

        /// <summary>
        /// Gets and sets the property LambdaOutputDescription. 
        /// <para>
        /// Describes the Lambda function that is configured as the destination where output is
        /// written.
        /// </para>
        /// </summary>
        public LambdaOutputDescription LambdaOutputDescription { get; set; }

        /// <summary>
        /// Checks to see if the LambdaOutputDescription property is set.
        /// </summary>
        internal bool IsSetLambdaOutputDescription() => this.LambdaOutputDescription != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the in-application stream that is configured as output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputId. 
        /// <para>
        /// A unique identifier for the output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string OutputId { get; set; }

        /// <summary>
        /// Checks to see if the OutputId property is set.
        /// </summary>
        internal bool IsSetOutputId() => this.OutputId != null;
    }
}
