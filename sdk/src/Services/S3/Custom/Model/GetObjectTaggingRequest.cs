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

using Amazon.Runtime;
using System;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetObjectTaggingRequest operation.
    /// </summary>
    public partial class GetObjectTaggingRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private string versionId;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>The bucket name containing the object for which to get the tagging information. </para>
        /// <para>When using this API with an access point, you must direct requests to the access point hostname. 
        /// The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this operation with an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. 
        /// For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</para> 
        /// <para>When using this API with Amazon S3 on Outposts, you must direct requests to the S3 on Outposts hostname. 
        /// The S3 on Outposts hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com. 
        /// When using this operation using S3 on Outposts through the AWS SDKs, you provide the Outposts bucket ARN in place of the bucket name. 
        /// For more information about S3 on Outposts ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3onOutposts.html">Using S3 on Outposts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Check to see if Bucket property is set
        /// </summary>
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this.bucketName);
        }

        /// <summary>
        /// Gets and sets the Key property. This is the user defined key that identifies the object in the bucket.
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
            return !string.IsNullOrEmpty(this.key);
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

        /// <summary>
        /// The account id of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
    }
}
    
