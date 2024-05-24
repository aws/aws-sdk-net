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
    /// Describes a SQL-based Kinesis Data Analytics application's output configuration,
    /// in which you identify an in-application stream and a destination where you want the
    /// in-application stream data to be written. The destination can be a Kinesis data stream
    /// or a Kinesis Data Firehose delivery stream.
    /// </summary>
    public partial class Output
    {
        private DestinationSchema _destinationSchema;
        private KinesisFirehoseOutput _kinesisFirehoseOutput;
        private KinesisStreamsOutput _kinesisStreamsOutput;
        private LambdaOutput _lambdaOutput;
        private string _name;

        /// <summary>
        /// Gets and sets the property DestinationSchema. 
        /// <para>
        /// Describes the data format when records are written to the destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KinesisFirehoseOutput. 
        /// <para>
        /// Identifies a Kinesis Data Firehose delivery stream as the destination.
        /// </para>
        /// </summary>
        public KinesisFirehoseOutput KinesisFirehoseOutput
        {
            get { return this._kinesisFirehoseOutput; }
            set { this._kinesisFirehoseOutput = value; }
        }

        // Check to see if KinesisFirehoseOutput property is set
        internal bool IsSetKinesisFirehoseOutput()
        {
            return this._kinesisFirehoseOutput != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamsOutput. 
        /// <para>
        /// Identifies a Kinesis data stream as the destination.
        /// </para>
        /// </summary>
        public KinesisStreamsOutput KinesisStreamsOutput
        {
            get { return this._kinesisStreamsOutput; }
            set { this._kinesisStreamsOutput = value; }
        }

        // Check to see if KinesisStreamsOutput property is set
        internal bool IsSetKinesisStreamsOutput()
        {
            return this._kinesisStreamsOutput != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaOutput. 
        /// <para>
        /// Identifies an Amazon Lambda function as the destination.
        /// </para>
        /// </summary>
        public LambdaOutput LambdaOutput
        {
            get { return this._lambdaOutput; }
            set { this._lambdaOutput = value; }
        }

        // Check to see if LambdaOutput property is set
        internal bool IsSetLambdaOutput()
        {
            return this._lambdaOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the in-application stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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

    }
}