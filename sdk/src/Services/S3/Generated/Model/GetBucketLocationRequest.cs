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
    /// Container for the parameters to the GetBucketLocation operation.
    /// <important> 
    /// <para>
    /// Using the <c>GetBucketLocation</c> operation is no longer a best practice. To return
    /// the Region that a bucket resides in, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_HeadBucket.html">HeadBucket</a>
    /// operation instead. For backward compatibility, Amazon S3 continues to support the
    /// <c>GetBucketLocation</c> operation.
    /// </para>
    ///  </important> 
    /// <para>
    /// Returns the Region the bucket resides in. You set the bucket's Region using the <c>LocationConstraint</c>
    /// request parameter in a <c>CreateBucket</c> request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// In a bucket's home Region, calls to the <c>GetBucketLocation</c> operation are governed
    /// by the bucket's policy. In other Regions, the bucket policy doesn't apply, which means
    /// that cross-account access won't be authorized. However, calls to the <c>HeadBucket</c>
    /// operation always return the bucket’s location through an HTTP response header, whether
    /// access to the bucket is authorized or not. Therefore, we recommend using the <c>HeadBucket</c>
    /// operation for bucket Region discovery and to avoid using the <c>GetBucketLocation</c>
    /// operation.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you use this API operation with an access point, provide the alias of the access
    /// point in place of the bucket name.
    /// </para>
    ///  
    /// <para>
    /// When you use this API operation with an Object Lambda access point, provide the alias
    /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
    /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
    /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
    /// of Error Codes</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following operations are related to <c>GetBucketLocation</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class GetBucketLocationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to get the location.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an access point, provide the alias of the access
        /// point in place of the bucket name.
        /// </para>
        ///  
        /// <para>
        /// When you use this API operation with an Object Lambda access point, provide the alias
        /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
        /// access point alias in a request is not valid, the error code <c>InvalidAccessPointAliasError</c>
        /// is returned. For more information about <c>InvalidAccessPointAliasError</c>, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a>.
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