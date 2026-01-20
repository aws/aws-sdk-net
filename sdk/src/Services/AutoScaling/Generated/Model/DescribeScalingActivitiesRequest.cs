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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Container for the parameters to the DescribeScalingActivities operation.
    /// Gets information about the scaling activities in the account and Region.
    /// 
    ///  
    /// <para>
    /// When scaling events occur, you see a record of the scaling activity in the scaling
    /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verify
    /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the scaling event succeeds, the value of the <c>StatusCode</c> element in the response
    /// is <c>Successful</c>. If an attempt to launch instances failed, the <c>StatusCode</c>
    /// value is <c>Failed</c> or <c>Cancelled</c> and the <c>StatusMessage</c> element in
    /// the response indicates the cause of the failure. For help interpreting the <c>StatusMessage</c>,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
    /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DescribeScalingActivitiesRequest : AmazonAutoScalingRequest
    {
        private List<string> _activityIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _autoScalingGroupName;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includeDeletedGroups;
        private int? _maxRecords;
        private string _nextToken;

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
        /// </summary>
        public List<string> ActivityIds
        {
            get { return this._activityIds; }
            set { this._activityIds = value; }
        }

        // Check to see if ActivityIds property is set
        internal bool IsSetActivityIds()
        {
            return this._activityIds != null && (this._activityIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

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
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeletedGroups. 
        /// <para>
        /// Indicates whether to include scaling activity from deleted Auto Scaling groups.
        /// </para>
        /// </summary>
        public bool IncludeDeletedGroups
        {
            get { return this._includeDeletedGroups.GetValueOrDefault(); }
            set { this._includeDeletedGroups = value; }
        }

        // Check to see if IncludeDeletedGroups property is set
        internal bool IsSetIncludeDeletedGroups()
        {
            return this._includeDeletedGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <c>100</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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