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
    /// The Amazon S3 bucket location to which Amazon Rekognition publishes the detailed
    /// inference results of a video analysis operation. These results include the name of
    /// the stream processor resource, the session ID of the stream processing session, and
    /// labeled timestamps and bounding boxes for detected labels.
    /// </summary>
    public partial class S3Destination
    {
        private string _bucket;
        private string _keyPrefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        ///  The name of the Amazon S3 bucket you want to associate with the streaming video project.
        /// You must be the owner of the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        ///  The prefix value of the location within the bucket that you want the information
        /// to be published to. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-prefixes.html">Using
        /// prefixes</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

    }
}