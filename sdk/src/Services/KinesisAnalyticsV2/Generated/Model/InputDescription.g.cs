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
    /// Describes the application input configuration for a SQL-based Kinesis Data Analytics
    /// application.
    /// </summary>
    public partial class InputDescription
    {
        /// <summary>
        /// Gets and sets the property InAppStreamNames. 
        /// <para>
        /// Returns the in-application stream names that are mapped to the stream source. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InAppStreamNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InAppStreamNames property is set.
        /// </summary>
        internal bool IsSetInAppStreamNames() => this.InAppStreamNames != null && (this.InAppStreamNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// The input ID that is associated with the application input. This is the ID that Kinesis
        /// Data Analytics assigns to each input configuration that you add to your application.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string InputId { get; set; }

        /// <summary>
        /// Checks to see if the InputId property is set.
        /// </summary>
        internal bool IsSetInputId() => this.InputId != null;

        /// <summary>
        /// Gets and sets the property InputParallelism. 
        /// <para>
        /// Describes the configured parallelism (number of in-application streams mapped to the
        /// streaming source). 
        /// </para>
        /// </summary>
        public InputParallelism InputParallelism { get; set; }

        /// <summary>
        /// Checks to see if the InputParallelism property is set.
        /// </summary>
        internal bool IsSetInputParallelism() => this.InputParallelism != null;

        /// <summary>
        /// Gets and sets the property InputProcessingConfigurationDescription. 
        /// <para>
        /// The description of the preprocessor that executes on records in this input before
        /// the application's code is run. 
        /// </para>
        /// </summary>
        public InputProcessingConfigurationDescription InputProcessingConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the InputProcessingConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetInputProcessingConfigurationDescription() => this.InputProcessingConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns in the in-application stream that is being created.
        /// 
        /// </para>
        /// </summary>
        public SourceSchema InputSchema { get; set; }

        /// <summary>
        /// Checks to see if the InputSchema property is set.
        /// </summary>
        internal bool IsSetInputSchema() => this.InputSchema != null;

        /// <summary>
        /// Gets and sets the property InputStartingPositionConfiguration. 
        /// <para>
        /// The point at which the application is configured to read from the input stream.
        /// </para>
        /// </summary>
        public InputStartingPositionConfiguration InputStartingPositionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputStartingPositionConfiguration property is set.
        /// </summary>
        internal bool IsSetInputStartingPositionConfiguration() => this.InputStartingPositionConfiguration != null;

        /// <summary>
        /// Gets and sets the property KinesisFirehoseInputDescription. 
        /// <para>
        /// If a Kinesis Data Firehose delivery stream is configured as a streaming source, provides
        /// the delivery stream's ARN. 
        /// </para>
        /// </summary>
        public KinesisFirehoseInputDescription KinesisFirehoseInputDescription { get; set; }

        /// <summary>
        /// Checks to see if the KinesisFirehoseInputDescription property is set.
        /// </summary>
        internal bool IsSetKinesisFirehoseInputDescription() => this.KinesisFirehoseInputDescription != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamsInputDescription. 
        /// <para>
        /// If a Kinesis data stream is configured as a streaming source, provides the Kinesis
        /// data stream's Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        public KinesisStreamsInputDescription KinesisStreamsInputDescription { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamsInputDescription property is set.
        /// </summary>
        internal bool IsSetKinesisStreamsInputDescription() => this.KinesisStreamsInputDescription != null;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// The in-application name prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;
    }
}
