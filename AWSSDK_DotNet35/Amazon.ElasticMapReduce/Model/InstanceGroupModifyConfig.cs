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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Modify an instance group size.</para>
    /// </summary>
    public class InstanceGroupModifyConfig
    {
        
        private string instanceGroupId;
        private int? instanceCount;
        private List<string> eC2InstanceIdsToTerminate = new List<string>();


        /// <summary>
        /// Unique ID of the instance group to expand or shrink.
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
        public string InstanceGroupId
        {
            get { return this.instanceGroupId; }
            set { this.instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this.instanceGroupId != null;
        }

        /// <summary>
        /// Target size for the instance group.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }

        /// <summary>
        /// The EC2 InstanceIds to terminate. For advanced users only. Once you terminate the instances, the instance group will not return to its
        /// original requested size.
        ///  
        /// </summary>
        public List<string> EC2InstanceIdsToTerminate
        {
            get { return this.eC2InstanceIdsToTerminate; }
            set { this.eC2InstanceIdsToTerminate = value; }
        }

        // Check to see if EC2InstanceIdsToTerminate property is set
        internal bool IsSetEC2InstanceIdsToTerminate()
        {
            return this.eC2InstanceIdsToTerminate.Count > 0;
        }
    }
}
