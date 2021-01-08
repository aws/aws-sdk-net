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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the ListRegionalBuckets operation.
    /// Returns a list of all Outposts buckets in an Outpost that are owned by the authenticated
    /// sender of the request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and <code>x-amz-outpost-id</code> in your request,
    /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListRegionalBuckets.html#API_control_ListRegionalBuckets_Examples">Examples</a>
    /// section.
    /// </para>
    /// </summary>
    public partial class ListRegionalBucketsRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private int? _maxResults;
        private string _nextToken;
        private string _outpostId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID of the Outposts bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the AWS Outposts.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is required by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

    }
}