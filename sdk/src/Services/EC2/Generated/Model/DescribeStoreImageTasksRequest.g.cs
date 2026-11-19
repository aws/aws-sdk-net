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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStoreImageTasks operation. Describes the
    /// progress of the AMI store tasks. You can describe the store tasks for specified AMIs.
    /// If you don't specify the AMIs, you get a paginated list of store tasks from the last
    /// 31 days. <para> For each AMI task, the response indicates if the task is <c>InProgress</c>,
    /// <c>Completed</c>, or <c>Failed</c>. For tasks <c>InProgress</c>, the response shows
    /// the estimated progress as a percentage. </para> <para> Tasks are listed in reverse
    /// chronological order. Currently, only tasks from the past 31 days can be viewed. </para>
    /// <para> To use this API, you must have the required permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-ami-store-restore.html#ami-s3-permissions">Permissions
    /// for storing and restoring AMIs using S3</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-store-restore.html">Store
    /// and restore an AMI using S3</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class DescribeStoreImageTasksRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>task-state</c> - Returns tasks in a certain state (<c>InProgress</c> | <c>Completed</c>
        /// | <c>Failed</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bucket</c> - Returns task information for tasks that targeted a specific bucket.
        /// For the filter value, specify the bucket name.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// When you specify the <c>ImageIds</c> parameter, any filters that you specify are ignored.
        /// To use the filters, you must remove the <c>ImageIds</c> parameter.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageIds. 
        /// <para>
        /// The AMI IDs for which to show progress. Up to 20 AMI IDs can be included in a request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageIds property is set.
        /// </summary>
        internal bool IsSetImageIds() => this.ImageIds != null && (this.ImageIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter and the <c>ImageIds</c> parameter in the same call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
