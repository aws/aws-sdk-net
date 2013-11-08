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
    /// Container for the parameters to the ListParts operation.
    /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
    /// </summary>
    public partial class ListPartsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private int? maxParts;
        private string partNumberMarker;
        private string uploadId;


        /// <summary>
        /// The name of the bucketName receiving the multipart upload.
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
        /// The object key for which the multipart upload was initiated.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Sets the maximum number of parts to return.
        ///  
        /// </summary>
        public int MaxParts
        {
            get { return this.maxParts ?? default(int); }
            set { this.maxParts = value; }
        }

        // Check to see if MaxParts property is set
        internal bool IsSetMaxParts()
        {
            return this.maxParts.HasValue;
        }

        /// <summary>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers will be listed.
        ///  
        /// </summary>
        public string PartNumberMarker
        {
            get { return this.partNumberMarker; }
            set { this.partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this.partNumberMarker != null;
        }

        /// <summary>
        /// Upload ID identifying the multipart upload whose parts are being listed.
        ///  
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

    }
}
    
