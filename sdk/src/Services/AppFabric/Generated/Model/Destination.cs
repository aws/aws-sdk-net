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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Contains information about an audit log destination.
    /// </summary>
    public partial class Destination
    {
        private FirehoseStream _firehoseStream;
        private S3Bucket _s3Bucket;

        /// <summary>
        /// Gets and sets the property FirehoseStream. 
        /// <para>
        /// Contains information about an Amazon Kinesis Data Firehose delivery stream.
        /// </para>
        /// </summary>
        public FirehoseStream FirehoseStream
        {
            get { return this._firehoseStream; }
            set { this._firehoseStream = value; }
        }

        // Check to see if FirehoseStream property is set
        internal bool IsSetFirehoseStream()
        {
            return this._firehoseStream != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// Contains information about an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3Bucket S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

    }
}