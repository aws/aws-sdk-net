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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetBucketOwnershipControls operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Retrieves <c>OwnershipControls</c> for an Amazon S3 bucket. To use this operation,
    /// you must have the <c>s3:GetBucketOwnershipControls</c> permission. For more information
    /// about Amazon S3 permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html">Specifying
    /// permissions in a policy</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// A bucket doesn't have <c>OwnershipControls</c> settings in the following cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The bucket was created before the <c>BucketOwnerEnforced</c> ownership setting was
    /// introduced and you've never explicitly applied this value
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You've manually deleted the bucket ownership control value using the <c>DeleteBucketOwnershipControls</c>
    /// API operation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// By default, Amazon S3 sets <c>OwnershipControls</c> for all newly created buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about Amazon S3 Object Ownership, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Using
    /// Object Ownership</a>. 
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>GetBucketOwnershipControls</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>PutBucketOwnershipControls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBucketOwnershipControls</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketOwnershipControlsRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket whose <c>OwnershipControls</c> you want to retrieve.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

    }
}