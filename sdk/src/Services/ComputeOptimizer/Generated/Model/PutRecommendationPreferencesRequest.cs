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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the PutRecommendationPreferences operation.
    /// Creates a new recommendation preference or updates an existing recommendation preference,
    /// such as enhanced infrastructure metrics.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
    /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutRecommendationPreferencesRequest : AmazonComputeOptimizerRequest
    {
        private EnhancedInfrastructureMetrics _enhancedInfrastructureMetrics;
        private ExternalMetricsPreference _externalMetricsPreference;
        private InferredWorkloadTypesPreference _inferredWorkloadTypes;
        private ResourceType _resourceType;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// The status of the enhanced infrastructure metrics recommendation preference to create
        /// or update.
        /// </para>
        ///  
        /// <para>
        /// Specify the <code>Active</code> status to activate the preference, or specify <code>Inactive</code>
        /// to deactivate the preference.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Enhanced
        /// infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public EnhancedInfrastructureMetrics EnhancedInfrastructureMetrics
        {
            get { return this._enhancedInfrastructureMetrics; }
            set { this._enhancedInfrastructureMetrics = value; }
        }

        // Check to see if EnhancedInfrastructureMetrics property is set
        internal bool IsSetEnhancedInfrastructureMetrics()
        {
            return this._enhancedInfrastructureMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalMetricsPreference. 
        /// <para>
        /// The provider of the external metrics recommendation preference to create or update.
        /// </para>
        ///  
        /// <para>
        /// Specify a valid provider in the <code>source</code> field to activate the preference.
        /// To delete this preference, see the <a>DeleteRecommendationPreferences</a> action.
        /// </para>
        ///  
        /// <para>
        /// This preference can only be set for the <code>Ec2Instance</code> resource type.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/external-metrics-ingestion.html">External
        /// metrics ingestion</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public ExternalMetricsPreference ExternalMetricsPreference
        {
            get { return this._externalMetricsPreference; }
            set { this._externalMetricsPreference = value; }
        }

        // Check to see if ExternalMetricsPreference property is set
        internal bool IsSetExternalMetricsPreference()
        {
            return this._externalMetricsPreference != null;
        }

        /// <summary>
        /// Gets and sets the property InferredWorkloadTypes. 
        /// <para>
        /// The status of the inferred workload types recommendation preference to create or update.
        /// </para>
        ///  <note> 
        /// <para>
        /// The inferred workload type feature is active by default. To deactivate it, create
        /// a recommendation preference.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify the <code>Inactive</code> status to deactivate the feature, or specify <code>Active</code>
        /// to activate it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/inferred-workload-types.html">Inferred
        /// workload types</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public InferredWorkloadTypesPreference InferredWorkloadTypes
        {
            get { return this._inferredWorkloadTypes; }
            set { this._inferredWorkloadTypes = value; }
        }

        // Check to see if InferredWorkloadTypes property is set
        internal bool IsSetInferredWorkloadTypes()
        {
            return this._inferredWorkloadTypes != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The target resource type of the recommendation preference to create.
        /// </para>
        ///  
        /// <para>
        /// The <code>Ec2Instance</code> option encompasses standalone instances and instances
        /// that are part of Auto Scaling groups. The <code>AutoScalingGroup</code> option encompasses
        /// only instances that are part of an Auto Scaling group.
        /// </para>
        ///  <note> 
        /// <para>
        /// The valid values for this parameter are <code>Ec2Instance</code> and <code>AutoScalingGroup</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An object that describes the scope of the recommendation preference to create.
        /// </para>
        ///  
        /// <para>
        /// You can create recommendation preferences at the organization level (for management
        /// accounts of an organization only), account level, and resource level. For more information,
        /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot create recommendation preferences for Auto Scaling groups at the organization
        /// and account levels. You can create recommendation preferences for Auto Scaling groups
        /// only at the resource level by specifying a scope name of <code>ResourceArn</code>
        /// and a scope value of the Auto Scaling group Amazon Resource Name (ARN). This will
        /// configure the preference for all instances that are part of the specified Auto Scaling
        /// group. You also cannot create recommendation preferences at the resource level for
        /// instances that are part of an Auto Scaling group. You can create recommendation preferences
        /// at the resource level only for standalone instances.
        /// </para>
        ///  </note>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}