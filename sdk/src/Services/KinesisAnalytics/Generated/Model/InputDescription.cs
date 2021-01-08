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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the application input configuration. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
    /// Application Input</a>.
    /// </summary>
    public partial class InputDescription
    {
        private List<string> _inAppStreamNames = new List<string>();
        private string _inputId;
        private InputParallelism _inputParallelism;
        private InputProcessingConfigurationDescription _inputProcessingConfigurationDescription;
        private SourceSchema _inputSchema;
        private InputStartingPositionConfiguration _inputStartingPositionConfiguration;
        private KinesisFirehoseInputDescription _kinesisFirehoseInputDescription;
        private KinesisStreamsInputDescription _kinesisStreamsInputDescription;
        private string _namePrefix;

        /// <summary>
        /// Gets and sets the property InAppStreamNames. 
        /// <para>
        /// Returns the in-application stream names that are mapped to the stream source.
        /// </para>
        /// </summary>
        public List<string> InAppStreamNames
        {
            get { return this._inAppStreamNames; }
            set { this._inAppStreamNames = value; }
        }

        // Check to see if InAppStreamNames property is set
        internal bool IsSetInAppStreamNames()
        {
            return this._inAppStreamNames != null && this._inAppStreamNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// Input ID associated with the application input. This is the ID that Amazon Kinesis
        /// Analytics assigns to each input configuration you add to your application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        // Check to see if InputId property is set
        internal bool IsSetInputId()
        {
            return this._inputId != null;
        }

        /// <summary>
        /// Gets and sets the property InputParallelism. 
        /// <para>
        /// Describes the configured parallelism (number of in-application streams mapped to the
        /// streaming source).
        /// </para>
        /// </summary>
        public InputParallelism InputParallelism
        {
            get { return this._inputParallelism; }
            set { this._inputParallelism = value; }
        }

        // Check to see if InputParallelism property is set
        internal bool IsSetInputParallelism()
        {
            return this._inputParallelism != null;
        }

        /// <summary>
        /// Gets and sets the property InputProcessingConfigurationDescription. 
        /// <para>
        /// The description of the preprocessor that executes on records in this input before
        /// the application's code is run.
        /// </para>
        /// </summary>
        public InputProcessingConfigurationDescription InputProcessingConfigurationDescription
        {
            get { return this._inputProcessingConfigurationDescription; }
            set { this._inputProcessingConfigurationDescription = value; }
        }

        // Check to see if InputProcessingConfigurationDescription property is set
        internal bool IsSetInputProcessingConfigurationDescription()
        {
            return this._inputProcessingConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns in the in-application stream that is being created.
        /// 
        /// </para>
        /// </summary>
        public SourceSchema InputSchema
        {
            get { return this._inputSchema; }
            set { this._inputSchema = value; }
        }

        // Check to see if InputSchema property is set
        internal bool IsSetInputSchema()
        {
            return this._inputSchema != null;
        }

        /// <summary>
        /// Gets and sets the property InputStartingPositionConfiguration. 
        /// <para>
        /// Point at which the application is configured to read from the input stream.
        /// </para>
        /// </summary>
        public InputStartingPositionConfiguration InputStartingPositionConfiguration
        {
            get { return this._inputStartingPositionConfiguration; }
            set { this._inputStartingPositionConfiguration = value; }
        }

        // Check to see if InputStartingPositionConfiguration property is set
        internal bool IsSetInputStartingPositionConfiguration()
        {
            return this._inputStartingPositionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseInputDescription. 
        /// <para>
        /// If an Amazon Kinesis Firehose delivery stream is configured as a streaming source,
        /// provides the delivery stream's ARN and an IAM role that enables Amazon Kinesis Analytics
        /// to access the stream on your behalf.
        /// </para>
        /// </summary>
        public KinesisFirehoseInputDescription KinesisFirehoseInputDescription
        {
            get { return this._kinesisFirehoseInputDescription; }
            set { this._kinesisFirehoseInputDescription = value; }
        }

        // Check to see if KinesisFirehoseInputDescription property is set
        internal bool IsSetKinesisFirehoseInputDescription()
        {
            return this._kinesisFirehoseInputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamsInputDescription. 
        /// <para>
        /// If an Amazon Kinesis stream is configured as streaming source, provides Amazon Kinesis
        /// stream's Amazon Resource Name (ARN) and an IAM role that enables Amazon Kinesis Analytics
        /// to access the stream on your behalf.
        /// </para>
        /// </summary>
        public KinesisStreamsInputDescription KinesisStreamsInputDescription
        {
            get { return this._kinesisStreamsInputDescription; }
            set { this._kinesisStreamsInputDescription = value; }
        }

        // Check to see if KinesisStreamsInputDescription property is set
        internal bool IsSetKinesisStreamsInputDescription()
        {
            return this._kinesisStreamsInputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// In-application name prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

    }
}