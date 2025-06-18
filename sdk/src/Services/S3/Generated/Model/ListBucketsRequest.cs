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
    /// Container for the parameters to the ListBuckets operation.
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will stop returning <c>DisplayName</c>.
    /// Update your applications to use canonical IDs (unique identifier for Amazon Web Services
    /// accounts), Amazon Web Services account ID (12 digit identifier) or IAM ARNs (full
    /// resource naming) as a direct replacement of <c>DisplayName</c>. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Returns a list of all buckets owned by the authenticated sender of the request. To
    /// grant IAM permission to use this operation, you must add the <c>s3:ListAllMyBuckets</c>
    /// policy action. 
    /// </para>
    ///  
    /// <para>
    /// For information about Amazon S3 buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/creating-buckets-s3.html">Creating,
    /// configuring, and working with Amazon S3 buckets</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend using only paginated <c>ListBuckets</c> requests. Unpaginated
    /// <c>ListBuckets</c> requests are only supported for Amazon Web Services accounts set
    /// to the default general purpose bucket quota of 10,000. If you have an approved general
    /// purpose bucket quota above 10,000, you must send paginated <c>ListBuckets</c> requests
    /// to list your account’s buckets. All unpaginated <c>ListBuckets</c> requests will be
    /// rejected for Amazon Web Services accounts with a general purpose bucket quota greater
    /// than 10,000. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListBucketsRequest : AmazonWebServiceRequest
    {
        private string _bucketRegion;
        private string _continuationToken;
        private int? _maxBuckets;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// Limits the response to buckets that are located in the specified Amazon Web Services
        /// Region. The Amazon Web Services Region must be expressed according to the Amazon Web
        /// Services Region code, such as <c>us-west-2</c> for the US West (Oregon) Region. For
        /// a list of the valid values for all of the Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
        /// and Endpoints</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Requests made to a Regional endpoint that is different from the <c>bucket-region</c>
        /// parameter are not supported. For example, if you want to limit the response to your
        /// buckets in Region <c>us-west-2</c>, the request must be made to an endpoint in Region
        /// <c>us-west-2</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> indicates to Amazon S3 that the list is being continued
        /// on this bucket with a token. <c>ContinuationToken</c> is obfuscated and is not a real
        /// key. You can use this <c>ContinuationToken</c> for pagination of the list results.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 0. Maximum length of 1024.
        /// </para>
        ///  
        /// <para>
        /// Required: No.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify the <c>bucket-region</c>, <c>prefix</c>, or <c>continuation-token</c>
        /// query parameters without using <c>max-buckets</c> to set the maximum number of buckets
        /// returned in the response, Amazon S3 applies a default page size of 10,000 and provides
        /// a continuation token if there are more buckets.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property MaxBuckets. 
        /// <para>
        /// Maximum number of buckets to be returned in response. When the number is more than
        /// the count of buckets that are owned by an Amazon Web Services account, return all
        /// the buckets in response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxBuckets
        {
            get { return this._maxBuckets; }
            set { this._maxBuckets = value; }
        }

        // Check to see if MaxBuckets property is set
        internal bool IsSetMaxBuckets()
        {
            return this._maxBuckets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Limits the response to bucket names that begin with the specified bucket name prefix.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}