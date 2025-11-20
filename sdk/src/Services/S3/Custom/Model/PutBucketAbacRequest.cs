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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketAbac operation.
    /// Sets the attribute-based access control (ABAC) property of the general purpose bucket.
    /// When you enable ABAC, you can use tags for bucket access control. Additionally, when
    /// ABAC is enabled, you must use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_TagResource.html">TagResource</a>,
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UntagResource.html">UntagResource</a>,
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListTagsForResource.html">ListTagsForResource</a>
    /// actions to manage bucket tags, and you can nolonger use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketTagging.html">PutBucketTagging</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
    /// actions to tag the bucket. You must also have the correct permissions for these actions.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/buckets-tagging-enable-abac.html">Enabling
    /// ABAC in general purpose buckets</a>.
    /// </summary>
    public partial class PutBucketAbacRequest : AmazonWebServiceRequest
    {
        private AbacStatus _abacStatus;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property AbacStatus. 
        /// <para>
        /// The ABAC status of the general purpose bucket. When ABAC is enabled for the general
        /// purpose bucket, you can use tags to manage access to the general purpose buckets as
        /// well as for cost tracking purposes. When ABAC is disabled for the general purpose
        /// buckets, you can only use tags for cost tracking purposes. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/buckets-tagging.html">Using
        /// tags with S3 general purpose buckets</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AbacStatus AbacStatus
        {
            get { return this._abacStatus; }
            set { this._abacStatus = value; }
        }

        // Check to see if AbacStatus property is set
        internal bool IsSetAbacStatus()
        {
            return this._abacStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the general purpose bucket.
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
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The MD5 hash of the <c>PutBucketAbac</c> request body. 
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
        /// The Amazon Web Services account ID of the general purpose bucket's owner. 
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