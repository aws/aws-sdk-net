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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlacementGroup operation.
    /// <para>Creates a placement group that you launch cluster instances into. You must give the group a name that's unique within the scope of
    /// your account.</para> <para>For more information about placement groups and cluster instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreatePlacementGroupRequest : AmazonEC2Request
    {
        private string groupName;
        private PlacementStrategy strategy;


        /// <summary>
        /// A name for the placement group. Constraints: Up to 255 ASCII characters
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }

        /// <summary>
        /// The placement strategy.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>cluster</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public PlacementStrategy Strategy
        {
            get { return this.strategy; }
            set { this.strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this.strategy != null;
        }

    }
}
    
