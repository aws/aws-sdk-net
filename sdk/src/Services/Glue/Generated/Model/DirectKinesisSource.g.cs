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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a direct Amazon Kinesis data source.
    /// </summary>
    public partial class DirectKinesisSource
    {
        /// <summary>
        /// Gets and sets the property DataPreviewOptions. 
        /// <para>
        /// Additional options for data preview.
        /// </para>
        /// </summary>
        public StreamingDataPreviewOptions DataPreviewOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataPreviewOptions property is set.
        /// </summary>
        internal bool IsSetDataPreviewOptions() => this.DataPreviewOptions != null;

        /// <summary>
        /// Gets and sets the property DetectSchema. 
        /// <para>
        /// Whether to automatically determine the schema from the incoming data.
        /// </para>
        /// </summary>
        public bool? DetectSchema { get; set; }

        /// <summary>
        /// Checks to see if the DetectSchema property is set.
        /// </summary>
        internal bool IsSetDetectSchema() => this.DetectSchema.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StreamingOptions. 
        /// <para>
        /// Additional options for the Kinesis streaming data source.
        /// </para>
        /// </summary>
        public KinesisStreamingSourceOptions StreamingOptions { get; set; }

        /// <summary>
        /// Checks to see if the StreamingOptions property is set.
        /// </summary>
        internal bool IsSetStreamingOptions() => this.StreamingOptions != null;

        /// <summary>
        /// Gets and sets the property WindowSize. 
        /// <para>
        /// The amount of time to spend processing each micro batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? WindowSize { get; set; }

        /// <summary>
        /// Checks to see if the WindowSize property is set.
        /// </summary>
        internal bool IsSetWindowSize() => this.WindowSize.HasValue;
    }
}
