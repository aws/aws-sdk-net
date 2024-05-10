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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Specifies an Apache Kafka data store.
    /// </summary>
    public partial class DirectKafkaSource
    {
        private StreamingDataPreviewOptions _dataPreviewOptions;
        private bool? _detectSchema;
        private string _name;
        private KafkaStreamingSourceOptions _streamingOptions;
        private int? _windowSize;

        /// <summary>
        /// Gets and sets the property DataPreviewOptions. 
        /// <para>
        /// Specifies options related to data preview for viewing a sample of your data.
        /// </para>
        /// </summary>
        public StreamingDataPreviewOptions DataPreviewOptions
        {
            get { return this._dataPreviewOptions; }
            set { this._dataPreviewOptions = value; }
        }

        // Check to see if DataPreviewOptions property is set
        internal bool IsSetDataPreviewOptions()
        {
            return this._dataPreviewOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DetectSchema. 
        /// <para>
        /// Whether to automatically determine the schema from the incoming data.
        /// </para>
        /// </summary>
        public bool? DetectSchema
        {
            get { return this._detectSchema; }
            set { this._detectSchema = value; }
        }

        // Check to see if DetectSchema property is set
        internal bool IsSetDetectSchema()
        {
            return this._detectSchema.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingOptions. 
        /// <para>
        /// Specifies the streaming options.
        /// </para>
        /// </summary>
        public KafkaStreamingSourceOptions StreamingOptions
        {
            get { return this._streamingOptions; }
            set { this._streamingOptions = value; }
        }

        // Check to see if StreamingOptions property is set
        internal bool IsSetStreamingOptions()
        {
            return this._streamingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property WindowSize. 
        /// <para>
        /// The amount of time to spend processing each micro batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? WindowSize
        {
            get { return this._windowSize; }
            set { this._windowSize = value; }
        }

        // Check to see if WindowSize property is set
        internal bool IsSetWindowSize()
        {
            return this._windowSize.HasValue; 
        }

    }
}