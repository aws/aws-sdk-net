/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The node group update configuration. An Amazon EKS managed node group updates by replacing
    /// nodes with new nodes of newer AMI versions in parallel. You choose the <i>maximum
    /// unavailable</i> and the <i>update strategy</i>.
    /// </summary>
    public partial class NodegroupUpdateConfig
    {
        private int? _maxUnavailable;
        private int? _maxUnavailablePercentage;
        private NodegroupUpdateStrategies _updateStrategy;

        /// <summary>
        /// Gets and sets the property MaxUnavailable. 
        /// <para>
        /// The maximum number of nodes unavailable at once during a version update. Nodes are
        /// updated in parallel. This value or <c>maxUnavailablePercentage</c> is required to
        /// have a value.The maximum number is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxUnavailable
        {
            get { return this._maxUnavailable; }
            set { this._maxUnavailable = value; }
        }

        // Check to see if MaxUnavailable property is set
        internal bool IsSetMaxUnavailable()
        {
            return this._maxUnavailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUnavailablePercentage. 
        /// <para>
        /// The maximum percentage of nodes unavailable during a version update. This percentage
        /// of nodes are updated in parallel, up to 100 nodes at once. This value or <c>maxUnavailable</c>
        /// is required to have a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxUnavailablePercentage
        {
            get { return this._maxUnavailablePercentage; }
            set { this._maxUnavailablePercentage = value; }
        }

        // Check to see if MaxUnavailablePercentage property is set
        internal bool IsSetMaxUnavailablePercentage()
        {
            return this._maxUnavailablePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateStrategy. 
        /// <para>
        /// The configuration for the behavior to follow during a node group version update of
        /// this managed node group. You choose between two possible strategies for replacing
        /// nodes during an <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_UpdateNodegroupVersion.html">
        /// <c>UpdateNodegroupVersion</c> </a> action.
        /// </para>
        ///  
        /// <para>
        /// An Amazon EKS managed node group updates by replacing nodes with new nodes of newer
        /// AMI versions in parallel. The <i>update strategy</i> changes the managed node update
        /// behavior of the managed node group for each quantity. The <i>default</i> strategy
        /// has guardrails to protect you from misconfiguration and launches the new instances
        /// first, before terminating the old instances. The <i>minimal</i> strategy removes the
        /// guardrails and terminates the old instances before launching the new instances. This
        /// minimal strategy is useful in scenarios where you are constrained to resources or
        /// costs (for example, with hardware accelerators such as GPUs).
        /// </para>
        /// </summary>
        public NodegroupUpdateStrategies UpdateStrategy
        {
            get { return this._updateStrategy; }
            set { this._updateStrategy = value; }
        }

        // Check to see if UpdateStrategy property is set
        internal bool IsSetUpdateStrategy()
        {
            return this._updateStrategy != null;
        }

    }
}