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
    /// The <code>PoliciesType</code> data type.
    /// </summary>
    public partial class DescribePoliciesResult
    {
        private string _nextToken;
        private List<ScalingPolicy> _scalingPolicies = new List<ScalingPolicy>();


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///             A string that marks the start of the next batch of returned results. 
        ///                    
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
        public DescribePoliciesResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }


        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        ///             A list of scaling policies.        
        /// </para>
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies
        {
            get { return this._scalingPolicies; }
            set { this._scalingPolicies = value; }
        }

        /// <summary>
        /// Sets the ScalingPolicies property
        /// </summary>
        /// <param name="scalingPolicies">The values to add to the ScalingPolicies collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesResult WithScalingPolicies(params ScalingPolicy[] scalingPolicies)
        {
            foreach (var element in scalingPolicies)
            {
                this._scalingPolicies.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ScalingPolicies property
        /// </summary>
        /// <param name="scalingPolicies">The values to add to the ScalingPolicies collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesResult WithScalingPolicies(IEnumerable<ScalingPolicy> scalingPolicies)
        {
            foreach (var element in scalingPolicies)
            {
                this._scalingPolicies.Add(element);
            }
            return this;
        }
        // Check to see if ScalingPolicies property is set
        internal bool IsSetScalingPolicies()
        {
            return this._scalingPolicies != null && this._scalingPolicies.Count > 0; 
        }

    }
}