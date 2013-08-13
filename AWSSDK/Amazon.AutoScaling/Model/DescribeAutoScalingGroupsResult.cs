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
    /// <para> The <c>AutoScalingGroupsType</c> data type. </para>
    /// </summary>
    public class DescribeAutoScalingGroupsResult  
    {
        
        private List<AutoScalingGroup> autoScalingGroups = new List<AutoScalingGroup>();
        private string nextToken;

        /// <summary>
        /// A list of Auto Scaling groups.
        ///  
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this.autoScalingGroups; }
            set { this.autoScalingGroups = value; }
        }
        /// <summary>
        /// Adds elements to the AutoScalingGroups collection
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingGroupsResult WithAutoScalingGroups(params AutoScalingGroup[] autoScalingGroups)
        {
            foreach (AutoScalingGroup element in autoScalingGroups)
            {
                this.autoScalingGroups.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AutoScalingGroups collection
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingGroupsResult WithAutoScalingGroups(IEnumerable<AutoScalingGroup> autoScalingGroups)
        {
            foreach (AutoScalingGroup element in autoScalingGroups)
            {
                this.autoScalingGroups.Add(element);
            }

            return this;
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this.autoScalingGroups.Count > 0;       
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingGroupsResult WithNextToken(string nextToken)
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
