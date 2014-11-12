/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeScalingActivities operation.
    /// Returns the scaling activities for the specified Auto Scaling group. 
    ///       
    /// 
    ///         
    /// <para>
    ///             If the specified <code>ActivityIds</code> list is empty,            all
    /// the activities from the past six weeks are returned.            Activities are sorted
    /// by the start time.            Activities still in progress appear first on the list.
    ///        
    /// </para>
    ///         
    /// <para>
    ///             This action supports pagination. If the response includes a token,   
    ///          there are more records available. To get the additional records, repeat 
    ///           the request with the response token as the <code>NextToken</code> parameter.
    ///                    
    /// </para>
    /// </summary>
    public partial class DescribeScalingActivitiesRequest : AmazonWebServiceRequest
    {
        private List<string> _activityIds = new List<string>();
        private string _autoScalingGroupName;
        private int? _maxRecords;
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property ActivityIds. 
        /// <para>
        ///             A list containing the activity IDs of the desired scaling activities.
        ///            If this list is omitted, all activities are described.             If an
        /// <code>AutoScalingGroupName</code> is provided, the results            are limited
        /// to that group. The list of requested            activities cannot contain more than
        /// 50 items. If            unknown activities are requested, they are ignored       
        ///     with no error.        
        /// </para>
        /// </summary>
        public List<string> ActivityIds
        {
            get { return this._activityIds; }
            set { this._activityIds = value; }
        }

        /// <summary>
        /// Sets the ActivityIds property
        /// </summary>
        /// <param name="activityIds">The values to add to the ActivityIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingActivitiesRequest WithActivityIds(params string[] activityIds)
        {
            foreach (var element in activityIds)
            {
                this._activityIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ActivityIds property
        /// </summary>
        /// <param name="activityIds">The values to add to the ActivityIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingActivitiesRequest WithActivityIds(IEnumerable<string> activityIds)
        {
            foreach (var element in activityIds)
            {
                this._activityIds.Add(element);
            }
            return this;
        }
        // Check to see if ActivityIds property is set
        internal bool IsSetActivityIds()
        {
            return this._activityIds != null && this._activityIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///         The name of the <a>AutoScalingGroup</a>.        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingActivitiesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///         The maximum number of scaling activities to return.        
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingActivitiesRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///             A string that marks the start of the next batch of returned results for
        /// pagination.        
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }


        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeScalingActivitiesRequest WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}