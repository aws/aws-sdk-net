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
    /// For a SQL-based Kinesis Data Analytics application, describes updates to the output
    /// configuration identified by the <c>OutputId</c>.
    /// </summary>
    public partial class OutputUpdate
    {
        /// <summary>
        /// Gets and sets the property DestinationSchemaUpdate. 
        /// <para>
        /// Describes the data format when records are written to the destination. 
        /// </para>
        /// </summary>
        public DestinationSchema DestinationSchemaUpdate { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSchemaUpdate property is set.
        /// </summary>
        internal bool IsSetDestinationSchemaUpdate() => this.DestinationSchemaUpdate != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseOutputUpdate. 
        /// <para>
        /// Describes a Kinesis Data Firehose delivery stream as the destination for the output.
        /// </para>
        /// </summary>
        public KinesisFirehoseOutputUpdate KinesisFirehoseOutputUpdate { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseOutputUpdate property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseOutputUpdate() => this.KinesisFirehoseOutputUpdate != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamsOutputUpdate. 
        /// <para>
        /// Describes a Kinesis data stream as the destination for the output.
        /// </para>
        /// </summary>
        public KinesisStreamsOutputUpdate KinesisStreamsOutputUpdate { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamsOutputUpdate property is set.
        /// </summary>
        internal bool IsSetKinesisStreamsOutputUpdate() => this.KinesisStreamsOutputUpdate != null;

        /// <summary>
        /// Gets and sets the property LambdaOutputUpdate. 
        /// <para>
        /// Describes an Amazon Lambda function as the destination for the output.
        /// </para>
        /// </summary>
        public LambdaOutputUpdate LambdaOutputUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LambdaOutputUpdate property is set.
        /// </summary>
        internal bool IsSetLambdaOutputUpdate() => this.LambdaOutputUpdate != null;

        /// <summary>
        /// Gets and sets the property NameUpdate. 
        /// <para>
        /// If you want to specify a different in-application stream for this output configuration,
        /// use this field to specify the new in-application stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NameUpdate { get; set; }

        /// <summary>
        /// Checks to see if the NameUpdate property is set.
        /// </summary>
        internal bool IsSetNameUpdate() => this.NameUpdate != null;

        /// <summary>
        /// Gets and sets the property OutputId. 
        /// <para>
        /// Identifies the specific output configuration that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string OutputId { get; set; }

        /// <summary>
        /// Checks to see if the OutputId property is set.
        /// </summary>
        internal bool IsSetOutputId() => this.OutputId != null;
    }
}
