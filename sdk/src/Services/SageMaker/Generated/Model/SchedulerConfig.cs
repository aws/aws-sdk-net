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
    /// Cluster policy configuration. This policy is used for task prioritization and fair-share
    /// allocation. This helps prioritize critical workloads and distributes idle compute
    /// across entities.
    /// </summary>
    public partial class SchedulerConfig
    {
        private FairShare _fairShare;
        private List<PriorityClass> _priorityClasses = AWSConfigs.InitializeCollections ? new List<PriorityClass>() : null;

        /// <summary>
        /// Gets and sets the property FairShare. 
        /// <para>
        /// When enabled, entities borrow idle compute based on their assigned <c>FairShareWeight</c>.
        /// </para>
        ///  
        /// <para>
        /// When disabled, entities borrow idle compute based on a first-come first-serve basis.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>Enabled</c>.
        /// </para>
        /// </summary>
        public FairShare FairShare
        {
            get { return this._fairShare; }
            set { this._fairShare = value; }
        }

        // Check to see if FairShare property is set
        internal bool IsSetFairShare()
        {
            return this._fairShare != null;
        }

        /// <summary>
        /// Gets and sets the property PriorityClasses. 
        /// <para>
        /// List of the priority classes, <c>PriorityClass</c>, of the cluster policy. When specified,
        /// these class configurations define how tasks are queued.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<PriorityClass> PriorityClasses
        {
            get { return this._priorityClasses; }
            set { this._priorityClasses = value; }
        }

        // Check to see if PriorityClasses property is set
        internal bool IsSetPriorityClasses()
        {
            return this._priorityClasses != null && (this._priorityClasses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}