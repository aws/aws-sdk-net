/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the ListObjects operation.
    /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
    /// subset of the objects in a bucket.</para>
    /// </summary>
    public partial class ListObjectsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string delimiter;
        private string marker;
        private int? maxKeys;
        private string prefix;
        private EncodingType encoding;


        /// <summary>
        /// The name of the bucket containing the objects whose keys are to be listed.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// A delimiter is a character you use to group keys.
        /// </summary>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this.delimiter != null;
        }

        /// <summary>
        /// Specifies the key to start with when listing objects in a bucket.
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Sets the maximum number of keys returned in the response. The response might contain fewer keys but will never contain more.
        /// </summary>
        public int MaxKeys
        {
            get { return this.maxKeys ?? default(int); }
            set { this.maxKeys = value; }
        }

        // Check to see if MaxKeys property is set
        internal bool IsSetMaxKeys()
        {
            return this.maxKeys.HasValue;
        }

        /// <summary>
        /// Limits the response to keys that begin with the specified prefix.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// Requests Amazon S3 to encode the object keys in the response and specifies
        /// the encoding method to use. An object key may contain any Unicode character;
        /// however, XML 1.0 parser cannot parse some characters, such as characters
        /// with an ASCII value from 0 to 10. For characters that are not supported in
        /// XML 1.0, you can add this parameter to request that Amazon S3 encode the
        /// keys in the response.
        /// </summary>
        public EncodingType Encoding
        {
            get { return this.encoding; }
            set { this.encoding = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetEncoding()
        {
            return this.encoding != null;
        }
    }
}
    
