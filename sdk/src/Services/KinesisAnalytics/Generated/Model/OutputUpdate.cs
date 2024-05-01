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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes updates to the output configuration identified by the <c>OutputId</c>.
    /// </summary>
    public partial class OutputUpdate
    {
        private DestinationSchema _destinationSchemaUpdate;
        private KinesisFirehoseOutputUpdate _kinesisFirehoseOutputUpdate;
        private KinesisStreamsOutputUpdate _kinesisStreamsOutputUpdate;
        private LambdaOutputUpdate _lambdaOutputUpdate;
        private string _nameUpdate;
        private string _outputId;

        /// <summary>
        /// Gets and sets the property DestinationSchemaUpdate. 
        /// <para>
        /// Describes the data format when records are written to the destination. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Configuring
        /// Application Output</a>.
        /// </para>
        /// </summary>
        public DestinationSchema DestinationSchemaUpdate
        {
            get { return this._destinationSchemaUpdate; }
            set { this._destinationSchemaUpdate = value; }
        }

        // Check to see if DestinationSchemaUpdate property is set
        internal bool IsSetDestinationSchemaUpdate()
        {
            return this._destinationSchemaUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisFirehoseOutputUpdate. 
        /// <para>
        /// Describes an Amazon Kinesis Firehose delivery stream as the destination for the output.
        /// </para>
        /// </summary>
        public KinesisFirehoseOutputUpdate KinesisFirehoseOutputUpdate
        {
            get { return this._kinesisFirehoseOutputUpdate; }
            set { this._kinesisFirehoseOutputUpdate = value; }
        }

        // Check to see if KinesisFirehoseOutputUpdate property is set
        internal bool IsSetKinesisFirehoseOutputUpdate()
        {
            return this._kinesisFirehoseOutputUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamsOutputUpdate. 
        /// <para>
        /// Describes an Amazon Kinesis stream as the destination for the output.
        /// </para>
        /// </summary>
        public KinesisStreamsOutputUpdate KinesisStreamsOutputUpdate
        {
            get { return this._kinesisStreamsOutputUpdate; }
            set { this._kinesisStreamsOutputUpdate = value; }
        }

        // Check to see if KinesisStreamsOutputUpdate property is set
        internal bool IsSetKinesisStreamsOutputUpdate()
        {
            return this._kinesisStreamsOutputUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaOutputUpdate. 
        /// <para>
        /// Describes an AWS Lambda function as the destination for the output.
        /// </para>
        /// </summary>
        public LambdaOutputUpdate LambdaOutputUpdate
        {
            get { return this._lambdaOutputUpdate; }
            set { this._lambdaOutputUpdate = value; }
        }

        // Check to see if LambdaOutputUpdate property is set
        internal bool IsSetLambdaOutputUpdate()
        {
            return this._lambdaOutputUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property NameUpdate. 
        /// <para>
        /// If you want to specify a different in-application stream for this output configuration,
        /// use this field to specify the new in-application stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NameUpdate
        {
            get { return this._nameUpdate; }
            set { this._nameUpdate = value; }
        }

        // Check to see if NameUpdate property is set
        internal bool IsSetNameUpdate()
        {
            return this._nameUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property OutputId. 
        /// <para>
        /// Identifies the specific output configuration that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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