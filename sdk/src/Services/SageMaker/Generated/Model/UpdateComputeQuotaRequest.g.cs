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
    /// Container for the parameters to the UpdateComputeQuota operation. Update the compute
    /// allocation definition.
    /// </summary>
    public partial class UpdateComputeQuotaRequest : AmazonSageMakerRequest
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
        /// Gets and sets the property ComputeQuotaConfig. 
        /// <para>
        /// Configuration of the compute allocation definition. This includes the resource sharing
        /// option, and the setting to preempt low priority tasks.
        /// </para>
        /// </summary>
        public ComputeQuotaConfig ComputeQuotaConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeQuotaConfig property is set.
        /// </summary>
        internal bool IsSetComputeQuotaConfig() => this.ComputeQuotaConfig != null;

        /// <summary>
        /// Gets and sets the property ComputeQuotaId. 
        /// <para>
        /// ID of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComputeQuotaId { get; set; }

        /// <summary>
        /// Checks to see if the ComputeQuotaId property is set.
        /// </summary>
        internal bool IsSetComputeQuotaId() => this.ComputeQuotaId != null;

        /// <summary>
        /// Gets and sets the property ComputeQuotaTarget. 
        /// <para>
        /// The target entity to allocate compute resources to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// Target version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion.HasValue;
    }
}
