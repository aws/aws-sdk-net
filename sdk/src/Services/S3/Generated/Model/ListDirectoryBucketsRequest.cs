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
    /// Container for the parameters to the ListDirectoryBuckets operation.
    /// Returns a list of all Amazon S3 directory buckets owned by the authenticated sender
    /// of the request. For more information about directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
    /// buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
    /// </c>. Virtual-hosted-style requests aren't supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3express:ListAllMyDirectoryBuckets</c> permission in an IAM
    /// identity-based policy instead of a bucket policy. Cross-account access to this API
    /// operation isn't supported. This operation can only be performed by the Amazon Web
    /// Services account that owns the resource. For more information about directory bucket
    /// policies and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> <note> 
    /// <para>
    ///  The <c>BucketRegion</c> response element is not part of the <c>ListDirectoryBuckets</c>
    /// Response Syntax.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListDirectoryBucketsRequest : AmazonWebServiceRequest
    {
        private string _continuationToken;
        private int? _maxDirectoryBuckets;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> indicates to Amazon S3 that the list is being continued
        /// on buckets in this account with a token. <c>ContinuationToken</c> is obfuscated and
        /// is not a real bucket name. You can use this <c>ContinuationToken</c> for the pagination
        /// of the list results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDirectoryBuckets. 
        /// <para>
        /// Maximum number of buckets to be returned in response. When the number is more than
        /// the count of buckets that are owned by an Amazon Web Services account, return all
        /// the buckets in response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaxDirectoryBuckets
        {
            get { return this._maxDirectoryBuckets; }
            set { this._maxDirectoryBuckets = value; }
        }

        // Check to see if MaxDirectoryBuckets property is set
        internal bool IsSetMaxDirectoryBuckets()
        {
            return this._maxDirectoryBuckets.HasValue; 
        }

    }
}