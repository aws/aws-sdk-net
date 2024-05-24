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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Information about the Amazon Kinesis Data Streams stream to which a Amazon Rekognition
    /// Video stream processor streams the results of a video analysis. For more information,
    /// see CreateStreamProcessor in the Amazon Rekognition Developer Guide.
    /// </summary>
    public partial class StreamProcessorOutput
    {
        private KinesisDataStream _kinesisDataStream;
        private S3Destination _s3Destination;

        /// <summary>
        /// Gets and sets the property KinesisDataStream. 
        /// <para>
        /// The Amazon Kinesis Data Streams stream to which the Amazon Rekognition stream processor
        /// streams the analysis results.
        /// </para>
        /// </summary>
        public KinesisDataStream KinesisDataStream
        {
            get { return this._kinesisDataStream; }
            set { this._kinesisDataStream = value; }
        }

        // Check to see if KinesisDataStream property is set
        internal bool IsSetKinesisDataStream()
        {
            return this._kinesisDataStream != null;
        }

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        ///  The Amazon S3 bucket location to which Amazon Rekognition publishes the detailed
        /// inference results of a video analysis operation. 
        /// </para>
        /// </summary>
        public S3Destination S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

    }
}