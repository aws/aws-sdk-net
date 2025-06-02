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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutCORSConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the <code>cors</code> configuration for your bucket. If the configuration exists,
    /// Amazon S3 replaces it.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must be allowed to perform the <code>s3:PutBucketCORS</code>
    /// action. By default, the bucket owner has this permission and can grant it to others.
    /// </para>
    ///  
    /// <para>
    /// You set this configuration on a bucket so that the bucket can service cross-origin
    /// requests. For example, you might want to enable a request whose origin is <code>http://www.example.com</code>
    /// to access your Amazon S3 bucket at <code>amzn-s3-demo-bucket</code> by using the
    /// browser's <code>XMLHttpRequest</code> capability.
    /// </para>
    ///  
    /// <para>
    /// To enable cross-origin resource sharing (CORS) on a bucket, you add the <code>cors</code>
    /// subresource to the bucket. The <code>cors</code> subresource is an XML document in
    /// which you configure rules that identify origins and the HTTP methods that can be executed
    /// on your bucket. The document is limited to 64 KB in size. 
    /// </para>
    ///  
    /// <para>
    /// When Amazon S3 receives a cross-origin request (or a pre-flight OPTIONS request) against
    /// a bucket, it evaluates the <code>cors</code> configuration on the bucket and uses
    /// the first <code>CORSRule</code> rule that matches the incoming browser request to
    /// enable a cross-origin request. For a rule to match, the following conditions must
    /// be met:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The request's <code>Origin</code> header must match <code>AllowedOrigin</code> elements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The request method (for example, GET, PUT, HEAD, and so on) or the <code>Access-Control-Request-Method</code>
    /// header in case of a pre-flight <code>OPTIONS</code> request must be one of the <code>AllowedMethod</code>
    /// elements. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Every header specified in the <code>Access-Control-Request-Headers</code> request
    /// header of a pre-flight request must match an <code>AllowedHeader</code> element. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about CORS, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
    /// Cross-Origin Resource Sharing</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketCors</code>:
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
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private CORSConfiguration configuration;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket to have the CORS configuration applied.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <code>x-amz-checksum</code>
        /// or <code>x-amz-trailer</code> header sent. Otherwise, Amazon S3 fails the request
        /// with the HTTP status code <code>400 Bad Request</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <code>ChecksumAlgorithm</code>
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
        /// The CORS configuration to apply.
        /// </summary>
        public CORSConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }

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
    
