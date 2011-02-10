/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The PoliciesType data type. </para>
    /// </summary>
    public class DescribePoliciesResult  
    {
        
        private List<ScalingPolicy> scalingPolicies = new List<ScalingPolicy>();
        private string nextToken;

        /// <summary>
        /// A list of scaling policies.
        ///  
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies
        {
            get { return this.scalingPolicies; }
            set { this.scalingPolicies = value; }
        }
        /// <summary>
        /// Adds elements to the ScalingPolicies collection
        /// </summary>
        /// <param name="scalingPolicies">The values to add to the ScalingPolicies collection </param>
        /// <returns>this instance</returns>
        public DescribePoliciesResult WithScalingPolicies(params ScalingPolicy[] scalingPolicies)
        {
            foreach (ScalingPolicy element in scalingPolicies)
            {
                this.scalingPolicies.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ScalingPolicies collection
        /// </summary>
        /// <param name="scalingPolicies">The values to add to the ScalingPolicies collection </param>
        /// <returns>this instance</returns>
        public DescribePoliciesResult WithScalingPolicies(IEnumerable<ScalingPolicy> scalingPolicies)
        {
            foreach (ScalingPolicy element in scalingPolicies)
            {
                this.scalingPolicies.Add(element);
            }

            return this;
        }

        // Check to see if ScalingPolicies property is set
        internal bool IsSetScalingPolicies()
        {
            return this.scalingPolicies.Count > 0;       
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
        public DescribePoliciesResult WithNextToken(string nextToken)
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
