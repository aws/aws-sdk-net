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
    /// Container for the parameters to the ListDirectoryBuckets operation.
    /// Returns a list of all Amazon S3 directory buckets owned by the authenticated sender
    /// of the request. For more information about directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
    /// buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <code>https://s3express-control.<i>region_code</i>.amazonaws.com/<i>bucket-name</i>
    /// </code>. Virtual-hosted-style requests aren't supported. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <code>s3express:ListAllMyDirectoryBuckets</code> permission in an
    /// IAM identity-based policy instead of a bucket policy. Cross-account access to this
    /// API operation isn't supported. This operation can only be performed by the Amazon
    /// Web Services account that owns the resource. For more information about directory
    /// bucket policies and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <code>s3express-control.<i>region</i>.amazonaws.com</code>.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class ListDirectoryBucketsRequest : AmazonWebServiceRequest
    {
        private string _continuationToken;
        private int? _maxDirectoryBuckets;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <code>ContinuationToken</code> indicates to Amazon S3 that the list is being continued
        /// on this bucket with a token. <code>ContinuationToken</code> is obfuscated and is not
        /// a real key. You can use this <code>ContinuationToken</code> for pagination of the
        /// list results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
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
        [AWSProperty(Min = 0, Max = 1000)]
        public int MaxDirectoryBuckets
        {
            get { return this._maxDirectoryBuckets.GetValueOrDefault(); }
            set { this._maxDirectoryBuckets = value; }
        }

        // Check to see if MaxDirectoryBuckets property is set
        internal bool IsSetMaxDirectoryBuckets()
        {
            return this._maxDirectoryBuckets.HasValue;
        }

    }
}