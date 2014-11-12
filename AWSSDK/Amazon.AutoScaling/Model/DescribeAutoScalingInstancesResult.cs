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
    /// The <code>AutoScalingInstancesType</code> data type.
    /// </summary>
    public partial class DescribeAutoScalingInstancesResult
    {
        private List<AutoScalingInstanceDetails> _autoScalingInstances = new List<AutoScalingInstanceDetails>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property AutoScalingInstances. 
        /// <para>
        ///             A list of Auto Scaling instances.        
        /// </para>
        /// </summary>
        public List<AutoScalingInstanceDetails> AutoScalingInstances
        {
            get { return this._autoScalingInstances; }
            set { this._autoScalingInstances = value; }
        }

        /// <summary>
        /// Sets the AutoScalingInstances property
        /// </summary>
        /// <param name="autoScalingInstances">The values to add to the AutoScalingInstances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesResult WithAutoScalingInstances(params AutoScalingInstanceDetails[] autoScalingInstances)
        {
            foreach (var element in autoScalingInstances)
            {
                this._autoScalingInstances.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AutoScalingInstances property
        /// </summary>
        /// <param name="autoScalingInstances">The values to add to the AutoScalingInstances collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingInstancesResult WithAutoScalingInstances(IEnumerable<AutoScalingInstanceDetails> autoScalingInstances)
        {
            foreach (var element in autoScalingInstances)
            {
                this._autoScalingInstances.Add(element);
            }
            return this;
        }
        // Check to see if AutoScalingInstances property is set
        internal bool IsSetAutoScalingInstances()
        {
            return this._autoScalingInstances != null && this._autoScalingInstances.Count > 0; 
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
        public DescribeAutoScalingInstancesResult WithNextToken(string nextToken)
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