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
    /// The <code>AutoScalingGroupsType</code> data type.
    /// </summary>
    public partial class DescribeAutoScalingGroupsResult
    {
        private List<AutoScalingGroup> _autoScalingGroups = new List<AutoScalingGroup>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        ///             A list of Auto Scaling groups.        
        /// </para>
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroups property
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingGroupsResult WithAutoScalingGroups(params AutoScalingGroup[] autoScalingGroups)
        {
            foreach (var element in autoScalingGroups)
            {
                this._autoScalingGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AutoScalingGroups property
        /// </summary>
        /// <param name="autoScalingGroups">The values to add to the AutoScalingGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingGroupsResult WithAutoScalingGroups(IEnumerable<AutoScalingGroup> autoScalingGroups)
        {
            foreach (var element in autoScalingGroups)
            {
                this._autoScalingGroups.Add(element);
            }
            return this;
        }
        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && this._autoScalingGroups.Count > 0; 
        }


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
        public DescribeAutoScalingGroupsResult WithNextToken(string nextToken)
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