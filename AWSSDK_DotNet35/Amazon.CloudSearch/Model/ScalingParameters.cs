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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The desired instance type and desired number of replicas of each index partition.</para>
    /// </summary>
    public partial class ScalingParameters
    {
        
        private PartitionInstanceType desiredInstanceType;
        private int? desiredReplicationCount;


        /// <summary>
        /// The instance type that you want to preconfigure for your domain. For example, <c>search.m1.small</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>search.m1.small, search.m1.large, search.m2.xlarge, search.m2.2xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public PartitionInstanceType DesiredInstanceType
        {
            get { return this.desiredInstanceType; }
            set { this.desiredInstanceType = value; }
        }

        // Check to see if DesiredInstanceType property is set
        internal bool IsSetDesiredInstanceType()
        {
            return this.desiredInstanceType != null;
        }

        /// <summary>
        /// The number of replicas you want to preconfigure for each index partition.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int DesiredReplicationCount
        {
            get { return this.desiredReplicationCount ?? default(int); }
            set { this.desiredReplicationCount = value; }
        }

        // Check to see if DesiredReplicationCount property is set
        internal bool IsSetDesiredReplicationCount()
        {
            return this.desiredReplicationCount.HasValue;
        }
    }
}
