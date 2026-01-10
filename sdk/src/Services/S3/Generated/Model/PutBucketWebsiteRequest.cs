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
    /// Container for the parameters to the PutBucketWebsite operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the configuration of the website that is specified in the <c>website</c> subresource.
    /// To configure a bucket as a website, you can add this subresource on the bucket with
    /// website configuration information such as the file name of the index document and
    /// any redirect rules. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
    /// Websites on Amazon S3</a>.
    /// </para>
    ///  
    /// <para>
    /// This PUT action requires the <c>S3:PutBucketWebsite</c> permission. By default, only
    /// the bucket owner can configure the website attached to a bucket; however, bucket owners
    /// can allow other users to set the website configuration by writing a bucket policy
    /// that grants them the <c>S3:PutBucketWebsite</c> permission.
    /// </para>
    ///  
    /// <para>
    /// To redirect all website requests sent to the bucket's website endpoint, you add a
    /// website configuration with the following elements. Because all requests are sent to
    /// another website, you don't need to provide index document name for the bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>WebsiteConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RedirectAllRequestsTo</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HostName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Protocol</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you want granular control over redirects, you can use the following elements to
    /// add routing rules that describe conditions for redirecting requests and information
    /// about the redirect destination. In this case, the website configuration must provide
    /// an index document for the bucket, because some requests might not be redirected. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>WebsiteConfiguration</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>IndexDocument</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Suffix</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ErrorDocument</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RoutingRules</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RoutingRule</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Condition</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HttpErrorCodeReturnedEquals</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>KeyPrefixEquals</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Redirect</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Protocol</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HostName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ReplaceKeyPrefixWith</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ReplaceKeyWith</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HttpRedirectCode</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon S3 has a limitation of 50 routing rules per website configuration. If you require
    /// more than 50 routing rules, you can use object redirect. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html">Configuring
    /// an Object Redirect</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The maximum request length is limited to 128 KB.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutBucketWebsiteRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private WebsiteConfiguration _websiteConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the data. You must use this header
        /// as a message integrity check to verify that the request body was not corrupted in
        /// transit. For more information, see <a href="http://www.ietf.org/rfc/rfc1864.txt">RFC
        /// 1864</a>.
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
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property WebsiteConfiguration. 
        /// <para>
        /// Container for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WebsiteConfiguration WebsiteConfiguration
        {
            get { return this._websiteConfiguration; }
            set { this._websiteConfiguration = value; }
        }

        // Check to see if WebsiteConfiguration property is set
        internal bool IsSetWebsiteConfiguration()
        {
            return this._websiteConfiguration != null;
        }

    }
}