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
    /// Container for the parameters to the SelectObjectContent operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
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
    /// You must have the <c>s3:GetObject</c> permission for this operation. Amazon S3 Select
    /// does not support anonymous access. For more information about permissions, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
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
    /// of messages and includes a <c>Transfer-Encoding</c> header with <c>chunked</c> as
    /// its value in the response. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTSelectObjectAppendix.html">Appendix:
    /// SelectObjectContent Response</a>.
    /// </para>
    ///  </dd> <dt>GetObject Support</dt> <dd> 
    /// <para>
    /// The <c>SelectObjectContent</c> action does not support the following <c>GetObject</c>
    /// functionality. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Range</c>: Although you can specify a scan range for an Amazon S3 Select request
    /// (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_SelectObjectContent.html#AmazonS3-SelectObjectContent-request-ScanRange">SelectObjectContentRequest
    /// - ScanRange</a> in the request parameters), you cannot specify the range of bytes
    /// of an object to return. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>GLACIER</c>, <c>DEEP_ARCHIVE</c>, and <c>REDUCED_REDUNDANCY</c> storage classes,
    /// or the <c>ARCHIVE_ACCESS</c> and <c>DEEP_ARCHIVE_ACCESS</c> access tiers of the <c>INTELLIGENT_TIERING</c>
    /// storage class: You cannot query objects in the <c>GLACIER</c>, <c>DEEP_ARCHIVE</c>,
    /// or <c>REDUCED_REDUNDANCY</c> storage classes, nor objects in the <c>ARCHIVE_ACCESS</c>
    /// or <c>DEEP_ARCHIVE_ACCESS</c> access tiers of the <c>INTELLIGENT_TIERING</c> storage
    /// class. For more information about storage classes, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-class-intro.html">Using
    /// Amazon S3 storage classes</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Special Errors</dt> <dd> 
    /// <para>
    /// For a list of special errors for this operation, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#SelectObjectContentErrorCodeList">List
    /// of SELECT Object Content Error Codes</a> 
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>SelectObjectContent</c>:
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
    public partial class SelectObjectContentRequest : AmazonS3Request
    {
        private string _bucketName;
        private string _expectedBucketOwner;
        private string _expression;
        private ExpressionType _expressionType;
        private InputSerialization _inputSerialization;
        private string _key;
        private OutputSerialization _outputSerialization;
        private RequestProgress _requestProgress;
        private ScanRange _scanRange;
        private string _sseCustomerAlgorithm;
        private string _sseCustomerKey;
        private string _sseCustomerKeyMD5;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The S3 bucket.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression that is used to query the object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionType. 
        /// <para>
        /// The type of the provided expression (for example, SQL).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExpressionType ExpressionType
        {
            get { return this._expressionType; }
            set { this._expressionType = value; }
        }

        // Check to see if ExpressionType property is set
        internal bool IsSetExpressionType()
        {
            return this._expressionType != null;
        }

        /// <summary>
        /// Gets and sets the property InputSerialization. 
        /// <para>
        /// Describes the format of the data in the object that is being queried.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputSerialization InputSerialization
        {
            get { return this._inputSerialization; }
            set { this._inputSerialization = value; }
        }

        // Check to see if InputSerialization property is set
        internal bool IsSetInputSerialization()
        {
            return this._inputSerialization != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSerialization. 
        /// <para>
        /// Describes the format of the data that you want Amazon S3 to return in response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputSerialization OutputSerialization
        {
            get { return this._outputSerialization; }
            set { this._outputSerialization = value; }
        }

        // Check to see if OutputSerialization property is set
        internal bool IsSetOutputSerialization()
        {
            return this._outputSerialization != null;
        }

        /// <summary>
        /// Gets and sets the property RequestProgress. 
        /// <para>
        /// Specifies if periodic request progress information should be enabled.
        /// </para>
        /// </summary>
        public RequestProgress RequestProgress
        {
            get { return this._requestProgress; }
            set { this._requestProgress = value; }
        }

        // Check to see if RequestProgress property is set
        internal bool IsSetRequestProgress()
        {
            return this._requestProgress != null;
        }

        /// <summary>
        /// Gets and sets the property ScanRange. 
        /// <para>
        /// Specifies the byte range of the object to get the records from. A record is processed
        /// when its first byte is contained by the range. This parameter is optional, but when
        /// specified, it must not be empty. See RFC 2616, Section 14.35.1 about how to specify
        /// the start and end of the range.
        /// </para>
        ///  
        /// <para>
        ///  <c>ScanRange</c>may be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>&lt;scanrange&gt;&lt;start&gt;50&lt;/start&gt;&lt;end&gt;100&lt;/end&gt;&lt;/scanrange&gt;</c>
        /// - process only the records starting between the bytes 50 and 100 (inclusive, counting
        /// from zero)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>&lt;scanrange&gt;&lt;start&gt;50&lt;/start&gt;&lt;/scanrange&gt;</c> - process
        /// only the records starting after the byte 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>&lt;scanrange&gt;&lt;end&gt;50&lt;/end&gt;&lt;/scanrange&gt;</c> - process only
        /// the records within the last 50 bytes of the file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScanRange ScanRange
        {
            get { return this._scanRange; }
            set { this._scanRange = value; }
        }

        // Check to see if ScanRange property is set
        internal bool IsSetScanRange()
        {
            return this._scanRange != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm. 
        /// <para>
        /// The server-side encryption (SSE) algorithm used to encrypt the object. This parameter
        /// is needed only when the object was created using a checksum algorithm. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKey. 
        /// <para>
        /// The server-side encryption (SSE) customer managed key. This parameter is needed only
        /// when the object was created using a checksum algorithm. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SSECustomerKey
        {
            get { return this._sseCustomerKey; }
            set { this._sseCustomerKey = value; }
        }

        // Check to see if SSECustomerKey property is set
        internal bool IsSetSSECustomerKey()
        {
            return this._sseCustomerKey != null;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5. 
        /// <para>
        /// The MD5 server-side encryption (SSE) customer managed key. This parameter is needed
        /// only when the object was created using a checksum algorithm. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using SSE-C keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return this._sseCustomerKeyMD5 != null;
        }

    }
}