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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration of the compute allocation definition for an entity. This includes the
    /// resource sharing option and the setting to preempt low priority tasks.
    /// </summary>
    public partial class ComputeQuotaConfig
    {
        private List<ComputeQuotaResourceConfig> _computeQuotaResources = AWSConfigs.InitializeCollections ? new List<ComputeQuotaResourceConfig>() : null;
        private PreemptTeamTasks _preemptTeamTasks;
        private ResourceSharingConfig _resourceSharingConfig;

        /// <summary>
        /// Gets and sets the property ComputeQuotaResources. 
        /// <para>
        /// Allocate compute resources by instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<ComputeQuotaResourceConfig> ComputeQuotaResources
        {
            get { return this._computeQuotaResources; }
            set { this._computeQuotaResources = value; }
        }

        // Check to see if ComputeQuotaResources property is set
        internal bool IsSetComputeQuotaResources()
        {
            return this._computeQuotaResources != null && (this._computeQuotaResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreemptTeamTasks. 
        /// <para>
        /// Allows workloads from within an entity to preempt same-team workloads. When set to
        /// <c>LowerPriority</c>, the entity's lower priority tasks are preempted by their own
        /// higher priority tasks.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>LowerPriority</c>.
        /// </para>
        /// </summary>
        public PreemptTeamTasks PreemptTeamTasks
        {
            get { return this._preemptTeamTasks; }
            set { this._preemptTeamTasks = value; }
        }

        // Check to see if PreemptTeamTasks property is set
        internal bool IsSetPreemptTeamTasks()
        {
            return this._preemptTeamTasks != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSharingConfig. 
        /// <para>
        /// Resource sharing configuration. This defines how an entity can lend and borrow idle
        /// compute with other entities within the cluster.
        /// </para>
        /// </summary>
        public ResourceSharingConfig ResourceSharingConfig
        {
            get { return this._resourceSharingConfig; }
            set { this._resourceSharingConfig = value; }
        }

        // Check to see if ResourceSharingConfig property is set
        internal bool IsSetResourceSharingConfig()
        {
            return this._resourceSharingConfig != null;
        }

    }
}