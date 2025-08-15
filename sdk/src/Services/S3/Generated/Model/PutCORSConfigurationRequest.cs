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
    /// Container for the parameters to the PutCORSConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the <c>cors</c> configuration for your bucket. If the configuration exists, Amazon
    /// S3 replaces it.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must be allowed to perform the <c>s3:PutBucketCORS</c>
    /// action. By default, the bucket owner has this permission and can grant it to others.
    /// </para>
    ///  
    /// <para>
    /// You set this configuration on a bucket so that the bucket can service cross-origin
    /// requests. For example, you might want to enable a request whose origin is <c>http://www.example.com</c>
    /// to access your Amazon S3 bucket at <c>my.example.bucket.com</c> by using the browser's
    /// <c>XMLHttpRequest</c> capability.
    /// </para>
    ///  
    /// <para>
    /// To enable cross-origin resource sharing (CORS) on a bucket, you add the <c>cors</c>
    /// subresource to the bucket. The <c>cors</c> subresource is an XML document in which
    /// you configure rules that identify origins and the HTTP methods that can be executed
    /// on your bucket. The document is limited to 64 KB in size. 
    /// </para>
    ///  
    /// <para>
    /// When Amazon S3 receives a cross-origin request (or a pre-flight OPTIONS request) against
    /// a bucket, it evaluates the <c>cors</c> configuration on the bucket and uses the first
    /// <c>CORSRule</c> rule that matches the incoming browser request to enable a cross-origin
    /// request. For a rule to match, the following conditions must be met:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The request's <c>Origin</c> header must match <c>AllowedOrigin</c> elements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The request method (for example, GET, PUT, HEAD, and so on) or the <c>Access-Control-Request-Method</c>
    /// header in case of a pre-flight <c>OPTIONS</c> request must be one of the <c>AllowedMethod</c>
    /// elements. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Every header specified in the <c>Access-Control-Request-Headers</c> request header
    /// of a pre-flight request must match an <c>AllowedHeader</c> element. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about CORS, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
    /// Cross-Origin Resource Sharing</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <c>PutBucketCors</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketCors.html">GetBucketCors</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketCors.html">DeleteBucketCors</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTOPTIONSobject.html">RESTOPTIONSobject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutCORSConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private CORSConfiguration _configuration;
        private string _contentMD5;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Specifies the bucket impacted by the <c>cors</c>configuration.
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the request when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Describes the cross-origin access configuration for objects in an Amazon S3 bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CORSConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the data. This header must be used
        /// as a message integrity check to verify that the request body was not corrupted in
        /// transit. For more information, go to <a href="http://www.ietf.org/rfc/rfc1864.txt">RFC
        /// 1864.</a> 
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
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