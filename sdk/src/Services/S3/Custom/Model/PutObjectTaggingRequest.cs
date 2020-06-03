/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObjectTagging operation.
    /// </summary>
    public partial class PutObjectTaggingRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private Tagging tagging = new Tagging();
        private string versionId;

        private string md5Digest;

        /// <summary>
        /// <para>The bucket name containing the object.</para>
        /// <para>When using this API with an access point, you must direct requests to the access point hostname. 
        /// The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this operation using an access point through the AWS SDKs, you provide the access point 
        /// ARN in place of the bucket name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> 
        /// in the <i>Amazon Simple Storage Service Developer Guide</i>.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Check to see if Bucket property is set 
        /// </summary>
        internal bool IsSetBucket()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets Key property. This key is used to identify the object in S3.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Check to see if Key property is set
        /// </summary>
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters
        /// </summary>
        public Tagging Tagging
        {
            get { return this.tagging; }
            set { this.tagging = value; }
        }

        /// <summary>
        /// Checks if Tagging property is set.
        /// </summary>
        internal bool IsSetTagging()
        {
            return this.tagging != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this.versionId);
        }
    }
}
    
