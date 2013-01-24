/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The output for the DescribeScalingActivities action. </para>
    /// </summary>
    public class DescribeScalingActivitiesResult  
    {
        
        private List<Activity> activities = new List<Activity>();
        private string nextToken;

        /// <summary>
        /// A list of the requested scaling activities.
        ///  
        /// </summary>
        public List<Activity> Activities
        {
            get { return this.activities; }
            set { this.activities = value; }
        }
        /// <summary>
        /// Adds elements to the Activities collection
        /// </summary>
        /// <param name="activities">The values to add to the Activities collection </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesResult WithActivities(params Activity[] activities)
        {
            foreach (Activity element in activities)
            {
                this.activities.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Activities collection
        /// </summary>
        /// <param name="activities">The values to add to the Activities collection </param>
        /// <returns>this instance</returns>
        public DescribeScalingActivitiesResult WithActivities(IEnumerable<Activity> activities)
        {
            foreach (Activity element in activities)
            {
                this.activities.Add(element);
            }

            return this;
        }

        // Check to see if Activities property is set
        internal bool IsSetActivities()
        {
            return this.activities.Count > 0;       
        }

        /// <summary>
        /// Acts as a paging mechanism for large result sets. Set to a non-empty string if there are additional results waiting to be returned. Pass
        /// this in to subsequent calls to return additional results.
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
        public DescribeScalingActivitiesResult WithNextToken(string nextToken)
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
