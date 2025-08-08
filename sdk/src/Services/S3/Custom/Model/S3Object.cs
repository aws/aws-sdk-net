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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an S3 Object. Contains all attributes that an S3 Object has.
    /// For more information about S3 Objects refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/UsingObjects.html"/>
    /// </summary>
    public partial class S3Object
    {
        private string bucketName;
        /// <summary>
        /// The name of the bucket containing this object.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // check to see if the BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }
    }
}
