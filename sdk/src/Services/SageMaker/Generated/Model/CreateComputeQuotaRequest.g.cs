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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateComputeQuota operation. Create compute allocation
    /// definition. This defines how compute is allocated, shared, and borrowed for specified
    /// entities. Specifically, how to lend and borrow idle compute and assign a fair-share
    /// weight to the specified entities.
    /// </summary>
    public partial class CreateComputeQuotaRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationState. 
        /// <para>
        /// The state of the compute allocation being described. Use to enable or disable compute
        /// allocation.
        /// </para>
        ///  
        /// <para>
        /// Default is <c>Enabled</c>.
        /// </para>
        /// </summary>
        public ActivationState ActivationState { get; set; }

        /// <summary>
        /// Checks to see if the ActivationState property is set.
        /// </summary>
        internal bool IsSetActivationState() => this.ActivationState != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ComputeQuotaConfig. 
        /// <para>
        /// Configuration of the compute allocation definition. This includes the resource sharing
        /// option, and the setting to preempt low priority tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeQuotaConfig ComputeQuotaConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeQuotaConfig property is set.
        /// </summary>
        internal bool IsSetComputeQuotaConfig() => this.ComputeQuotaConfig != null;

        /// <summary>
        /// Gets and sets the property ComputeQuotaTarget. 
        /// <para>
        /// The target entity to allocate compute resources to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeQuotaTarget ComputeQuotaTarget { get; set; }

        /// <summary>
        /// Checks to see if the ComputeQuotaTarget property is set.
        /// </summary>
        internal bool IsSetComputeQuotaTarget() => this.ComputeQuotaTarget != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the compute allocation definition. The name must be unique within the
        /// SageMaker AI HyperPod cluster specified by <c>ClusterArn</c>. You can use the same
        /// name in other clusters within a Region or across Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags of the compute allocation definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
