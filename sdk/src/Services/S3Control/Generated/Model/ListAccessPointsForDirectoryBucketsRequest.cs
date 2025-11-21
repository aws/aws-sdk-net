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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccessPointsForDirectoryBuckets operation.
    /// Returns a list of the access points that are owned by the Amazon Web Services account
    /// and that are associated with the specified directory bucket.
    /// 
    ///  
    /// <para>
    /// To list access points for general purpose buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccesspoints</a>.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the permission to perform the <c>s3express:ListAccessPointsForDirectoryBuckets</c>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For information about REST API errors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#RESTErrorResponses">REST
    /// error responses</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListAccessPointsForDirectoryBucketsRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _directoryBucket;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the access points.
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
        /// Gets and sets the property DirectoryBucket. 
        /// <para>
        /// The name of the directory bucket associated with the access points you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string DirectoryBucket
        {
            get { return this._directoryBucket; }
            set { this._directoryBucket = value; }
        }

        // Check to see if DirectoryBucket property is set
        internal bool IsSetDirectoryBucket()
        {
            return this._directoryBucket != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of access points that you would like returned in the <c>ListAccessPointsForDirectoryBuckets</c>
        /// response. If the directory bucket is associated with more than this number of access
        /// points, the results include the pagination token <c>NextToken</c>. Make another call
        /// using the <c>NextToken</c> to retrieve more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If <c>NextToken</c> is returned, there are more access points available than requested
        /// in the <c>maxResults</c> value. The value of <c>NextToken</c> is a unique pagination
        /// token for each page. Make the call again using the returned token to retrieve the
        /// next page. Keep all other arguments unchanged. Each pagination token expires after
        /// 24 hours. 
        /// </para>
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

    }
}