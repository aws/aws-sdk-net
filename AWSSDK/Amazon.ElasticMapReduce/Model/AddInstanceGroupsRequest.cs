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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the AddInstanceGroups operation.
    /// <para>AddInstanceGroups adds an instance group to a running cluster.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.AddInstanceGroups"/>
    public class AddInstanceGroupsRequest : AmazonWebServiceRequest
    {
        private List<InstanceGroupConfig> instanceGroups = new List<InstanceGroupConfig>();
        private string jobFlowId;

        /// <summary>
        /// Instance Groups to add.
        ///  
        /// </summary>
        public List<InstanceGroupConfig> InstanceGroups
        {
            get { return this.instanceGroups; }
            set { this.instanceGroups = value; }
        }
        /// <summary>
        /// Adds elements to the InstanceGroups collection
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        public AddInstanceGroupsRequest WithInstanceGroups(params InstanceGroupConfig[] instanceGroups)
        {
            foreach (InstanceGroupConfig element in instanceGroups)
            {
                this.instanceGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the InstanceGroups collection
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        public AddInstanceGroupsRequest WithInstanceGroups(IEnumerable<InstanceGroupConfig> instanceGroups)
        {
            foreach (InstanceGroupConfig element in instanceGroups)
            {
                this.instanceGroups.Add(element);
            }

            return this;
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this.instanceGroups.Count > 0;
        }

        /// <summary>
        /// Job flow in which to add the instance groups.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this.jobFlowId; }
            set { this.jobFlowId = value; }
        }

        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">The value to set for the JobFlowId property </param>
        /// <returns>this instance</returns>
        public AddInstanceGroupsRequest WithJobFlowId(string jobFlowId)
        {
            this.jobFlowId = jobFlowId;
            return this;
        }
            

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this.jobFlowId != null;
        }
    }
}
    
