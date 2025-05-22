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
    /// Container for the parameters to the UpdateComputeQuota operation.
    /// Update the compute allocation definition.
    /// </summary>
    public partial class UpdateComputeQuotaRequest : AmazonSageMakerRequest
    {
        private ActivationState _activationState;
        private ComputeQuotaConfig _computeQuotaConfig;
        private string _computeQuotaId;
        private ComputeQuotaTarget _computeQuotaTarget;
        private string _description;
        private int? _targetVersion;

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
        public ActivationState ActivationState
        {
            get { return this._activationState; }
            set { this._activationState = value; }
        }

        // Check to see if ActivationState property is set
        internal bool IsSetActivationState()
        {
            return this._activationState != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaConfig. 
        /// <para>
        /// Configuration of the compute allocation definition. This includes the resource sharing
        /// option, and the setting to preempt low priority tasks.
        /// </para>
        /// </summary>
        public ComputeQuotaConfig ComputeQuotaConfig
        {
            get { return this._computeQuotaConfig; }
            set { this._computeQuotaConfig = value; }
        }

        // Check to see if ComputeQuotaConfig property is set
        internal bool IsSetComputeQuotaConfig()
        {
            return this._computeQuotaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaId. 
        /// <para>
        /// ID of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeQuotaId
        {
            get { return this._computeQuotaId; }
            set { this._computeQuotaId = value; }
        }

        // Check to see if ComputeQuotaId property is set
        internal bool IsSetComputeQuotaId()
        {
            return this._computeQuotaId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaTarget. 
        /// <para>
        /// The target entity to allocate compute resources to.
        /// </para>
        /// </summary>
        public ComputeQuotaTarget ComputeQuotaTarget
        {
            get { return this._computeQuotaTarget; }
            set { this._computeQuotaTarget = value; }
        }

        // Check to see if ComputeQuotaTarget property is set
        internal bool IsSetComputeQuotaTarget()
        {
            return this._computeQuotaTarget != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// Target version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion.HasValue; 
        }

    }
}