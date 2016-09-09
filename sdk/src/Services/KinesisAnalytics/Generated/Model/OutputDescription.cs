/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the application output configuration, which includes the in-application
    /// stream name and the destination where the stream data is written. The destination
    /// can be an Amazon Kinesis stream or an Amazon Kinesis Firehose delivery stream.
    /// </summary>
    public partial class OutputDescription
    {
        private DestinationSchema _destinationSchema;
        private KinesisFirehoseOutputDescription _kinesisFirehoseOutputDescription;
        private KinesisStreamsOutputDescription _kinesisStreamsOutputDescription;
        private string _name;
        private string _outputId;

        /// <summary>
        /// Gets and sets the property DestinationSchema. 
        /// <para>
        /// Data format used for writing data to the destination.
        /// </para>
        /// </summary>
        public DestinationSchema DestinationSchema
        {
            get { return this._destinationSchema; }
            set { this._destinationSchema = value; }
        }

        // Check to see if DestinationSchema property is set
        internal bool IsSetDestinationSchema()
        {
            return this._destinationSchema != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseOutputDescription. 
        /// <para>
        /// Describes the Amazon Kinesis Firehose delivery stream configured as the destination
        /// where output is written.
        /// </para>
        /// </summary>
        public KinesisFirehoseOutputDescription KinesisFirehoseOutputDescription
        {
            get { return this._kinesisFirehoseOutputDescription; }
            set { this._kinesisFirehoseOutputDescription = value; }
        }

        // Check to see if KinesisFirehoseOutputDescription property is set
        internal bool IsSetKinesisFirehoseOutputDescription()
        {
            return this._kinesisFirehoseOutputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamsOutputDescription. 
        /// <para>
        /// Describes Amazon Kinesis stream configured as the destination where output is written.
        /// </para>
        /// </summary>
        public KinesisStreamsOutputDescription KinesisStreamsOutputDescription
        {
            get { return this._kinesisStreamsOutputDescription; }
            set { this._kinesisStreamsOutputDescription = value; }
        }

        // Check to see if KinesisStreamsOutputDescription property is set
        internal bool IsSetKinesisStreamsOutputDescription()
        {
            return this._kinesisStreamsOutputDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the in-application stream configured as output.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OutputId. 
        /// <para>
        /// A unique identifier for the output configuration.
        /// </para>
        /// </summary>
        public string OutputId
        {
            get { return this._outputId; }
            set { this._outputId = value; }
        }

        // Check to see if OutputId property is set
        internal bool IsSetOutputId()
        {
            return this._outputId != null;
        }

    }
}