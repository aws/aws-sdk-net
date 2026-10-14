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
    /// Describes updates to a specific input configuration (identified by the <c>InputId</c>
    /// of an application).
    /// </summary>
    public partial class InputUpdate
    {
        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// Input ID of the application input to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string InputId { get; set; }

        /// <summary>
        /// Checks to see if the InputId property is set.
        /// </summary>
        internal bool IsSetInputId() => this.InputId != null;

        /// <summary>
        /// Gets and sets the property InputParallelismUpdate. 
        /// <para>
        /// Describes the parallelism updates (the number in-application streams Amazon Kinesis
        /// Analytics creates for the specific streaming source).
        /// </para>
        /// </summary>
        public InputParallelismUpdate InputParallelismUpdate { get; set; }

        /// <summary>
        /// Checks to see if the InputParallelismUpdate property is set.
        /// </summary>
        internal bool IsSetInputParallelismUpdate() => this.InputParallelismUpdate != null;

        /// <summary>
        /// Gets and sets the property InputProcessingConfigurationUpdate. 
        /// <para>
        /// Describes updates for an input processing configuration.
        /// </para>
        /// </summary>
        public InputProcessingConfigurationUpdate InputProcessingConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the InputProcessingConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetInputProcessingConfigurationUpdate() => this.InputProcessingConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property InputSchemaUpdate. 
        /// <para>
        /// Describes the data format on the streaming source, and how record elements on the
        /// streaming source map to columns of the in-application stream that is created.
        /// </para>
        /// </summary>
        public InputSchemaUpdate InputSchemaUpdate { get; set; }

        /// <summary>
        /// Checks to see if the InputSchemaUpdate property is set.
        /// </summary>
        internal bool IsSetInputSchemaUpdate() => this.InputSchemaUpdate != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseInputUpdate. 
        /// <para>
        /// If an Amazon Kinesis Firehose delivery stream is the streaming source to be updated,
        /// provides an updated stream ARN and IAM role ARN.
        /// </para>
        /// </summary>
        public KinesisFirehoseInputUpdate KinesisFirehoseInputUpdate { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseInputUpdate property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseInputUpdate() => this.KinesisFirehoseInputUpdate != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamsInputUpdate. 
        /// <para>
        /// If an Amazon Kinesis stream is the streaming source to be updated, provides an updated
        /// stream Amazon Resource Name (ARN) and IAM role ARN.
        /// </para>
        /// </summary>
        public KinesisStreamsInputUpdate KinesisStreamsInputUpdate { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamsInputUpdate property is set.
        /// </summary>
        internal bool IsSetKinesisStreamsInputUpdate() => this.KinesisStreamsInputUpdate != null;

        /// <summary>
        /// Gets and sets the property NamePrefixUpdate. 
        /// <para>
        /// Name prefix for in-application streams that Amazon Kinesis Analytics creates for the
        /// specific streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NamePrefixUpdate { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefixUpdate property is set.
        /// </summary>
        internal bool IsSetNamePrefixUpdate() => this.NamePrefixUpdate != null;
    }
}
