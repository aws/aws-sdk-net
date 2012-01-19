/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <i>ActivityIds</i> list is
    /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
    /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
    /// available. To get the additional records, repeat the request with the response token as the NextToken parameter. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeScalingActivities"/>
    public class DescribeScalingActivitiesRequest : AmazonWebServiceRequest
    {
        private List<string> activityIds = new List<string>();
        private string autoScalingGroupName;
        private int? maxRecords;
        private string nextToken;

        /// <summary>
        /// A list containing the activity IDs of the desired scaling activities. If this list is omitted, all activities are described. If an
        /// AutoScalingGroupName is provided, the results are limited to that group. The list of requested activities cannot contain more than 50 items.
        /// If unknown activities are requested, they are ignored with no error.
        ///  
        /// </summary>
        public List<string> ActivityIds
        {
            get { return this.activityIds; }
            set { this.activityIds = value; }
        }
        /// <summary>
        /// Adds elements to the ActivityIds collection
        /// </summary>
        /// <param name="activityIds">The values to add to the ActivityIds collection </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithActivityIds(params string[] activityIds)
        {
            foreach (string element in activityIds)
            {
                this.activityIds.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ActivityIds collection
        /// </summary>
        /// <param name="activityIds">The values to add to the ActivityIds collection </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithActivityIds(IEnumerable<string> activityIds)
        {
            foreach (string element in activityIds)
            {
                this.activityIds.Add(element);
            }

            return this;
        }

        // Check to see if ActivityIds property is set
        internal bool IsSetActivityIds()
        {
            return this.activityIds.Count > 0;       
        }

        /// <summary>
        /// The name of the <a>AutoScalingGroup</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
        }
            

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;       
        }

        /// <summary>
        /// The maximum number of scaling activities to return.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 50</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results for pagination.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
    
