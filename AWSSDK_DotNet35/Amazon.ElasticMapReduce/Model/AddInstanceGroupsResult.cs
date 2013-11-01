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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Output from an AddInstanceGroups call.</para>
    /// </summary>
    public partial class AddInstanceGroupsResult : AmazonWebServiceResponse
    {
        
        private string jobFlowId;
        private List<string> instanceGroupIds = new List<string>();


        /// <summary>
        /// The job flow ID in which the instance groups are added.
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

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this.jobFlowId != null;
        }

        /// <summary>
        /// Instance group IDs of the newly created instance groups.
        ///  
        /// </summary>
        public List<string> InstanceGroupIds
        {
            get { return this.instanceGroupIds; }
            set { this.instanceGroupIds = value; }
        }

        // Check to see if InstanceGroupIds property is set
        internal bool IsSetInstanceGroupIds()
        {
            return this.instanceGroupIds.Count > 0;
        }
    }
}
