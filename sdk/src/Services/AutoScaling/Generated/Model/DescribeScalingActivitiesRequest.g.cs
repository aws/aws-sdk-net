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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingActivities operation. Gets information
    /// about the scaling activities in the account and Region. <para> When scaling events
    /// occur, you see a record of the scaling activity in the scaling activities. For more
    /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verify
    /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
    /// User Guide</i>. </para> <para> If the scaling event succeeds, the value of the <c>StatusCode</c>
    /// element in the response is <c>Successful</c>. If an attempt to launch instances failed,
    /// the <c>StatusCode</c> value is <c>Failed</c> or <c>Cancelled</c> and the <c>StatusMessage</c>
    /// element in the response indicates the cause of the failure. For help interpreting
    /// the <c>StatusMessage</c>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
    /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. </para>
    /// </summary>
    public partial class DescribeScalingActivitiesRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property ActivityIds. 
        /// <para>
        ///  The activity IDs of the desired scaling activities. If unknown activity IDs are requested,
        /// they are ignored with no error. Only activities started within the last six weeks
        /// can be returned regardless of the activity IDs specified. If other filters are specified
        /// with the request, only results matching all filter criteria can be returned. 
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 50 IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ActivityIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActivityIds property is set.
        /// </summary>
        internal bool IsSetActivityIds() => this.ActivityIds != null && (this.ActivityIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Omitting this property performs an account-wide operation, which can result in slower
        /// or timed-out requests. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  One or more filters to limit the results based on specific criteria. The following
        /// filters are supported: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>StartTimeLowerBound</c> - The earliest scaling activities to return based on the
        /// activity start time. Scaling activities with a start time earlier than this value
        /// are not included in the results. Only activities started within the last six weeks
        /// can be returned regardless of the value specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StartTimeUpperBound</c> - The latest scaling activities to return based on the
        /// activity start time. Scaling activities with a start time later than this value are
        /// not included in the results. Only activities started within the last six weeks can
        /// be returned regardless of the value specified. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c> - The <c>StatusCode</c> value of the scaling activity. This filter
        /// can only be used in combination with the <c>AutoScalingGroupName</c> parameter. For
        /// valid <c>StatusCode</c> values, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_Activity.html">Activity</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>StartTimeLowerBound</c> and <c>StartTimeUpperBound</c> accept ISO 8601 formatted
        /// timestamps. Timestamps without a timezone offset are assumed to be UTC. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>2000-01-18T08:15:00Z</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>2000-01-18T16:15:00+08:00</c> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property IncludeDeletedGroups. 
        /// <para>
        /// Indicates whether to include scaling activity from deleted Auto Scaling groups.
        /// </para>
        /// </summary>
        public bool? IncludeDeletedGroups { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDeletedGroups property is set.
        /// </summary>
        internal bool IsSetIncludeDeletedGroups() => this.IncludeDeletedGroups.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeManagedResources. 
        /// <para>
        ///  Specifies whether to include scaling activities for managed Auto Scaling groups in
        /// the response. When set to <c>true</c> (default), the response includes scaling activities
        /// for managed Auto Scaling groups. 
        /// </para>
        /// </summary>
        public bool? IncludeManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeManagedResources property is set.
        /// </summary>
        internal bool IsSetIncludeManagedResources() => this.IncludeManagedResources.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <c>100</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        ///  
        /// <para>
        /// A response can contain fewer items than the value specified by <c>MaxRecords</c>,
        /// even when more items are available. To retrieve the additional items, use the <c>NextToken</c>
        /// value in a subsequent call rather than relying on the number of items in the response.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
