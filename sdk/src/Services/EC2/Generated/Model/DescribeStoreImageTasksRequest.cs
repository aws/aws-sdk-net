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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStoreImageTasks operation.
    /// Describes the progress of the AMI store tasks. You can describe the store tasks for
    /// specified AMIs. If you don't specify the AMIs, you get a paginated list of store tasks
    /// from the last 31 days.
    /// 
    ///  
    /// <para>
    /// For each AMI task, the response indicates if the task is <code>InProgress</code>,
    /// <code>Completed</code>, or <code>Failed</code>. For tasks <code>InProgress</code>,
    /// the response shows the estimated progress as a percentage.
    /// </para>
    ///  
    /// <para>
    /// Tasks are listed in reverse chronological order. Currently, only tasks from the past
    /// 31 days can be viewed.
    /// </para>
    ///  
    /// <para>
    /// To use this API, you must have the required permissions. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html#ami-s3-permissions">Permissions
    /// for storing and restoring AMIs using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
    /// and restore an AMI using Amazon S3</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeStoreImageTasksRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _imageIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>task-state</code> - Returns tasks in a certain state (<code>InProgress</code>
        /// | <code>Completed</code> | <code>Failed</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>bucket</code> - Returns task information for tasks that targeted a specific
        /// bucket. For the filter value, specify the bucket name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The AMI IDs for which to show progress. Up to 20 AMI IDs can be included in a request.
        /// </para>
        /// </summary>
        public List<string> ImageIds
        {
            get { return this._imageIds; }
            set { this._imageIds = value; }
        }

        // Check to see if ImageIds property is set
        internal bool IsSetImageIds()
        {
            return this._imageIds != null && this._imageIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>NextToken</code> value. This value
        /// can be between 1 and 200. You cannot specify this parameter and the <code>ImageIDs</code>
        /// parameter in the same call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
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