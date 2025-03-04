// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the SelectObjectContent operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// This action filters the contents of an Amazon S3 object based on a simple structured
    /// query language (SQL) statement. In the request, along with the SQL expression, you
    /// must also specify a data serialization format (JSON, CSV, or Apache Parquet) of the
    /// object. Amazon S3 uses this format to parse object data into records, and returns
    /// only records that match the specified SQL expression. You must also specify the data
    /// serialization format for the response.
    /// </para>
    ///  
    /// <para>
    /// This functionality is not supported for Amazon S3 on Outposts.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon S3 Select, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/selecting-content-from-objects.html">Selecting
    /// Content from Objects</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-glacier-select-sql-reference-select.html">SELECT
    /// Command</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///   <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <code>s3:GetObject</code> permission for this operation. Amazon
    /// S3 Select does not support anonymous access. For more information about permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
    /// Permissions in a Policy</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>Object Data Formats</dt> <dd> 
    /// <para>
    /// You can use Amazon S3 Select to query objects that have the following format properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>CSV, JSON, and Parquet</i> - Objects must be in CSV, JSON, or Parquet format.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>UTF-8</i> - UTF-8 is the only encoding type Amazon S3 Select supports.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>GZIP or BZIP2</i> - CSV and JSON files can be compressed using GZIP or BZIP2.
    /// GZIP and BZIP2 are the only compression formats that Amazon S3 Select supports for
    /// CSV and JSON files. Amazon S3 Select supports columnar compression for Parquet using
    /// GZIP or Snappy. Amazon S3 Select does not support whole-object compression for Parquet
    /// objects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Server-side encryption</i> - Amazon S3 Select supports querying objects that are
    /// protected with server-side encryption.
    /// </para>
    ///  
    /// <para>
    /// For objects that are encrypted with customer-provided encryption keys (SSE-C), you
    /// must use HTTPS, and you must use the headers that are documented in the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>.
    /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
    /// Encryption (Using Customer-Provided Encryption Keys)</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For objects that are encrypted with Amazon S3 managed keys (SSE-S3) and Amazon Web
    /// Services KMS keys (SSE-KMS), server-side encryption is handled transparently, so you
    /// don't need to specify anything. For more information about server-side encryption,
    /// including SSE-S3 and SSE-KMS, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
    /// Data Using Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Working with the Response Body</dt> <dd> 
    /// <para>
    /// Given the response size is unknown, Amazon S3 Select streams the response as a series
    /// of messages and includes a <code>Transfer-Encoding</code> header with <code>chunked</code>
    /// as its value in the response. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTSelectObjectAppendix.html">Appendix:
    /// SelectObjectContent Response</a>.
    /// </para>
    ///  </dd> <dt>GetObject Support</dt> <dd> 
    /// <para>
    /// The <code>SelectObjectContent</code> action does not support the following <code>GetObject</code>
    /// functionality. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Range</code>: Although you can specify a scan range for an Amazon S3 Select
    /// request (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_SelectObjectContent.html#AmazonS3-SelectObjectContent-request-ScanRange">SelectObjectContentRequest
    /// - ScanRange</a> in the request parameters), you cannot specify the range of bytes
    /// of an object to return. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>GLACIER</code>, <code>DEEP_ARCHIVE</code>, and <code>REDUCED_REDUNDANCY</code>
    /// storage classes, or the <code>ARCHIVE_ACCESS</code> and <code>DEEP_ARCHIVE_ACCESS</code>
    /// access tiers of the <code>INTELLIGENT_TIERING</code> storage class: You cannot query
    /// objects in the <code>GLACIER</code>, <code>DEEP_ARCHIVE</code>, or <code>REDUCED_REDUNDANCY</code>
    /// storage classes, nor objects in the <code>ARCHIVE_ACCESS</code> or <code>DEEP_ARCHIVE_ACCESS</code>
    /// access tiers of the <code>INTELLIGENT_TIERING</code> storage class. For more information
    /// about storage classes, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-class-intro.html">Using
    /// Amazon S3 storage classes</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Special Errors</dt> <dd> 
    /// <para>
    /// For a list of special errors for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#SelectObjectContentErrorCodeList">List
    /// of SELECT Object Content Error Codes</a> 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <code>SelectObjectContent</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public class SelectObjectContentRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// The S3 Bucket name.
        /// </summary>
        public string BucketName { get; set; }

        private string expectedBucketOwner;

        internal bool IsSetBucket() => BucketName != null;

        /// <summary>
        /// The Object Key.
        /// </summary>
        public string Key { get; set; }

        internal bool IsSetKey() => Key != null;

        /// <summary>
        /// The SSE Algorithm used to encrypt the object.
        /// </summary>
        /// <para>
        /// The SSE algorithm used to encrypt the object. This is only needed when the object
        /// was created using a checksum algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        public ServerSideEncryptionCustomerMethod ServerSideCustomerEncryptionMethod { get; set; }

        internal bool IsSetServerSideCustomerEncryptionMethod() => ServerSideCustomerEncryptionMethod != null;

        /// <summary>
        /// The SSE Customer Key.
        /// </summary>
        /// <para>
        /// The SSE customer key. This is only needed when the object was cureated using a checksum
        /// algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey { get; set; }

        internal bool IsSetServerSideEncryptionCustomerProvidedKey() => ServerSideEncryptionCustomerProvidedKey != null;

        /// <summary>
        /// The SSE Customer Key MD5.
        /// </summary>
        /// <para>
        /// The MD5 SSE customer key. This is only needed when the object was cureated using a
        /// checksum algorithm. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }

        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5() =>
            ServerSideEncryptionCustomerProvidedKeyMD5 != null;

        /// <summary>
        /// The expression that is used to query the object.
        /// </summary>
        public string Expression { get; set; }

        internal bool IsSetExpression() => Expression != null;

        /// <summary>
        /// The type of the provided expression (e.g., SQL).
        /// </summary>
        public ExpressionType ExpressionType { get; set; }

        internal bool IsSetExpressionType() => ExpressionType != null;

        /// <summary>
        /// Specifies if periodic request progress information should be enabled.
        /// </summary>
        public bool? RequestProgress { get; set; }

        internal bool IsSetRequestProgress() => RequestProgress != null;
        
        /// <summary>
        /// Describes the format of the data in the object that is being queried.
        /// </summary>
        public InputSerialization InputSerialization { get; set; }

        internal bool IsSetInputSerialization() => InputSerialization != null;

        /// <summary>
        /// Describes the format of the data that you want Amazon S3 to return in response.
        /// </summary>
        public OutputSerialization OutputSerialization { get; set; }

        internal bool IsSetOutputSerialization() => OutputSerialization != null;

        /// <summary>
        /// The byte range of the object to get the records from.
        /// </summary>
        public ScanRange ScanRange { get; set; }

        internal bool IsSetScanRange() => ScanRange != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
        /// </para>
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