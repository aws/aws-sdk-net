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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
    /// For a SQL-based Kinesis Data Analytics application, describes updates to a specific
    /// input configuration (identified by the <c>InputId</c> of an application).
    /// </summary>
    public partial class InputUpdate
    {
        private string _inputId;
        private InputParallelismUpdate _inputParallelismUpdate;
        private InputProcessingConfigurationUpdate _inputProcessingConfigurationUpdate;
        private InputSchemaUpdate _inputSchemaUpdate;
        private KinesisFirehoseInputUpdate _kinesisFirehoseInputUpdate;
        private KinesisStreamsInputUpdate _kinesisStreamsInputUpdate;
        private string _namePrefixUpdate;

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// The input ID of the application input to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property InputParallelismUpdate. 
        /// <para>
        /// Describes the parallelism updates (the number of in-application streams Kinesis Data
        /// Analytics creates for the specific streaming source).
        /// </para>
        /// </summary>
        public InputParallelismUpdate InputParallelismUpdate
        {
            get { return this._inputParallelismUpdate; }
            set { this._inputParallelismUpdate = value; }
        }

        // Check to see if InputParallelismUpdate property is set
        internal bool IsSetInputParallelismUpdate()
        {
            return this._inputParallelismUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property InputProcessingConfigurationUpdate. 
        /// <para>
        /// Describes updates to an <a>InputProcessingConfiguration</a>.
        /// </para>
        /// </summary>
        public InputProcessingConfigurationUpdate InputProcessingConfigurationUpdate
        {
            get { return this._inputProcessingConfigurationUpdate; }
            set { this._inputProcessingConfigurationUpdate = value; }
        }

        // Check to see if InputProcessingConfigurationUpdate property is set
        internal bool IsSetInputProcessingConfigurationUpdate()
        {
            return this._inputProcessingConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property InputSchemaUpdate. 
        /// <para>
        /// Describes the data format on the streaming source, and how record elements on the
        /// streaming source map to columns of the in-application stream that is created.
        /// </para>
        /// </summary>
        public InputSchemaUpdate InputSchemaUpdate
        {
            get { return this._inputSchemaUpdate; }
            set { this._inputSchemaUpdate = value; }
        }

        // Check to see if InputSchemaUpdate property is set
        internal bool IsSetInputSchemaUpdate()
        {
            return this._inputSchemaUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseInputUpdate. 
        /// <para>
        /// If a Kinesis Data Firehose delivery stream is the streaming source to be updated,
        /// provides an updated stream ARN.
        /// </para>
        /// </summary>
        public KinesisFirehoseInputUpdate KinesisFirehoseInputUpdate
        {
            get { return this._kinesisFirehoseInputUpdate; }
            set { this._kinesisFirehoseInputUpdate = value; }
        }

        // Check to see if KinesisFirehoseInputUpdate property is set
        internal bool IsSetKinesisFirehoseInputUpdate()
        {
            return this._kinesisFirehoseInputUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamsInputUpdate. 
        /// <para>
        /// If a Kinesis data stream is the streaming source to be updated, provides an updated
        /// stream Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public KinesisStreamsInputUpdate KinesisStreamsInputUpdate
        {
            get { return this._kinesisStreamsInputUpdate; }
            set { this._kinesisStreamsInputUpdate = value; }
        }

        // Check to see if KinesisStreamsInputUpdate property is set
        internal bool IsSetKinesisStreamsInputUpdate()
        {
            return this._kinesisStreamsInputUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property NamePrefixUpdate. 
        /// <para>
        /// The name prefix for in-application streams that Kinesis Data Analytics creates for
        /// the specific streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NamePrefixUpdate
        {
            get { return this._namePrefixUpdate; }
            set { this._namePrefixUpdate = value; }
        }

        // Check to see if NamePrefixUpdate property is set
        internal bool IsSetNamePrefixUpdate()
        {
            return this._namePrefixUpdate != null;
        }

    }
}