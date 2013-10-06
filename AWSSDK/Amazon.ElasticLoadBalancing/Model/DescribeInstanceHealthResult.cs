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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The output for the DescribeInstanceHealth action. </para>
    /// </summary>
    public class DescribeInstanceHealthResult  
    {
        
        private List<InstanceState> instanceStates = new List<InstanceState>();

        /// <summary>
        /// A list containing health information for the specified instances.
        ///  
        /// </summary>
        public List<InstanceState> InstanceStates
        {
            get { return this.instanceStates; }
            set { this.instanceStates = value; }
        }
        /// <summary>
        /// Adds elements to the InstanceStates collection
        /// </summary>
        /// <param name="instanceStates">The values to add to the InstanceStates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceHealthResult WithInstanceStates(params InstanceState[] instanceStates)
        {
            foreach (InstanceState element in instanceStates)
            {
                this.instanceStates.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the InstanceStates collection
        /// </summary>
        /// <param name="instanceStates">The values to add to the InstanceStates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceHealthResult WithInstanceStates(IEnumerable<InstanceState> instanceStates)
        {
            foreach (InstanceState element in instanceStates)
            {
                this.instanceStates.Add(element);
            }

            return this;
        }

        // Check to see if InstanceStates property is set
        internal bool IsSetInstanceStates()
        {
            return this.instanceStates.Count > 0;       
        }
    }
}
