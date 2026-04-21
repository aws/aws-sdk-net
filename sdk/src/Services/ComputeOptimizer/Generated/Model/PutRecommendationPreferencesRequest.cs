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

#pragma warning disable CS0612,CS0618,CS1570
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
        private LookBackPeriodPreference _lookBackPeriod;
        private List<PreferredResource> _preferredResources = AWSConfigs.InitializeCollections ? new List<PreferredResource>() : null;
        private ResourceType _resourceType;
        private SavingsEstimationMode _savingsEstimationMode;
        private Scope _scope;
        private List<UtilizationPreference> _utilizationPreferences = AWSConfigs.InitializeCollections ? new List<UtilizationPreference>() : null;

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// The status of the enhanced infrastructure metrics recommendation preference to create
        /// or update.
        /// </para>
        ///  
        /// <para>
        /// Specify the <c>Active</c> status to activate the preference, or specify <c>Inactive</c>
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
        /// Specify a valid provider in the <c>source</c> field to activate the preference. To
        /// delete this preference, see the <a>DeleteRecommendationPreferences</a> action.
        /// </para>
        ///  
        /// <para>
        /// This preference can only be set for the <c>Ec2Instance</c> resource type.
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
        /// Specify the <c>Inactive</c> status to deactivate the feature, or specify <c>Active</c>
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
        /// Gets and sets the property LookBackPeriod. 
        /// <para>
        ///  The preference to control the number of days the utilization metrics of the Amazon
        /// Web Services resource are analyzed. When this preference isn't specified, we use the
        /// default value <c>DAYS_14</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can only set this preference for the Amazon EC2 instance and Auto Scaling group
        /// resource types. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Amazon EC2 instance lookback preferences can be set at the organization, account,
        /// and resource levels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto Scaling group lookback preferences can only be set at the resource level.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public LookBackPeriodPreference LookBackPeriod
        {
            get { return this._lookBackPeriod; }
            set { this._lookBackPeriod = value; }
        }

        // Check to see if LookBackPeriod property is set
        internal bool IsSetLookBackPeriod()
        {
            return this._lookBackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredResources. 
        /// <para>
        ///  The preference to control which resource type values are considered when generating
        /// rightsizing recommendations. You can specify this preference as a combination of include
        /// and exclude lists. You must specify either an <c>includeList</c> or <c>excludeList</c>.
        /// If the preference is an empty set of resource type values, an error occurs. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only set this preference for the Amazon EC2 instance and Auto Scaling group
        /// resource types.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PreferredResource> PreferredResources
        {
            get { return this._preferredResources; }
            set { this._preferredResources = value; }
        }

        // Check to see if PreferredResources property is set
        internal bool IsSetPreferredResources()
        {
            return this._preferredResources != null && (this._preferredResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The target resource type of the recommendation preference to create.
        /// </para>
        ///  
        /// <para>
        /// The <c>Ec2Instance</c> option encompasses standalone instances and instances that
        /// are part of Auto Scaling groups. The <c>AutoScalingGroup</c> option encompasses only
        /// instances that are part of an Auto Scaling group.
        /// </para>
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
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        ///  The status of the savings estimation mode preference to create or update. 
        /// </para>
        ///  
        /// <para>
        /// Specify the <c>AfterDiscounts</c> status to activate the preference, or specify <c>BeforeDiscounts</c>
        /// to deactivate the preference.
        /// </para>
        ///  
        /// <para>
        /// Only the account manager or delegated administrator of your organization can activate
        /// this preference.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/savings-estimation-mode.html">
        /// Savings estimation mode</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        public SavingsEstimationMode SavingsEstimationMode
        {
            get { return this._savingsEstimationMode; }
            set { this._savingsEstimationMode = value; }
        }

        // Check to see if SavingsEstimationMode property is set
        internal bool IsSetSavingsEstimationMode()
        {
            return this._savingsEstimationMode != null;
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
        /// only at the resource level by specifying a scope name of <c>ResourceArn</c> and a
        /// scope value of the Auto Scaling group Amazon Resource Name (ARN). This will configure
        /// the preference for all instances that are part of the specified Auto Scaling group.
        /// You also cannot create recommendation preferences at the resource level for instances
        /// that are part of an Auto Scaling group. You can create recommendation preferences
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

        /// <summary>
        /// Gets and sets the property UtilizationPreferences. 
        /// <para>
        ///  The preference to control the resource’s CPU utilization threshold, CPU utilization
        /// headroom, and memory utilization headroom. When this preference isn't specified, we
        /// use the following default values. 
        /// </para>
        ///  
        /// <para>
        /// CPU utilization:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>P99_5</c> for threshold
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERCENT_20</c> for headroom
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Memory utilization:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PERCENT_20</c> for headroom
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// You can only set CPU and memory utilization preferences for the Amazon EC2 instance
        /// resource type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The threshold setting isn’t available for memory utilization.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UtilizationPreference> UtilizationPreferences
        {
            get { return this._utilizationPreferences; }
            set { this._utilizationPreferences = value; }
        }

        // Check to see if UtilizationPreferences property is set
        internal bool IsSetUtilizationPreferences()
        {
            return this._utilizationPreferences != null && (this._utilizationPreferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}