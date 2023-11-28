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
    /// Container for the parameters to the PutBucketWebsite operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the configuration of the website that is specified in the <code>website</code>
    /// subresource. To configure a bucket as a website, you can add this subresource on the
    /// bucket with website configuration information such as the file name of the index document
    /// and any redirect rules. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
    /// Websites on Amazon S3</a>.
    /// </para>
    ///  
    /// <para>
    /// This PUT action requires the <code>S3:PutBucketWebsite</code> permission. By default,
    /// only the bucket owner can configure the website attached to a bucket; however, bucket
    /// owners can allow other users to set the website configuration by writing a bucket
    /// policy that grants them the <code>S3:PutBucketWebsite</code> permission.
    /// </para>
    ///  
    /// <para>
    /// To redirect all website requests sent to the bucket's website endpoint, you add a
    /// website configuration with the following elements. Because all requests are sent to
    /// another website, you don't need to provide index document name for the bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>WebsiteConfiguration</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedirectAllRequestsTo</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HostName</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Protocol</code> 
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
    ///  <code>WebsiteConfiguration</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>IndexDocument</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suffix</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ErrorDocument</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RoutingRules</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RoutingRule</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Condition</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HttpErrorCodeReturnedEquals</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyPrefixEquals</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Redirect</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Protocol</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HostName</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ReplaceKeyPrefixWith</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ReplaceKeyWith</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HttpRedirectCode</code> 
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
    /// </summary>
    public partial class PutBucketWebsiteRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private WebsiteConfiguration websiteConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket to apply the configuration to.
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
        /// The website configuration to apply. The configuration defines the index
        /// document suffix and custom error page.
        /// </summary>
        public WebsiteConfiguration WebsiteConfiguration
        {
            get { return this.websiteConfiguration; }
            set { this.websiteConfiguration = value; }
        }

        // Check to see if WebsiteConfiguration property is set
        internal bool IsSetWebsiteConfiguration()
        {
            return this.websiteConfiguration != null;
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
    
