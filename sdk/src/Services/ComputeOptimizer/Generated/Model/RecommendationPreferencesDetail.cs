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
    /// Describes a recommendation preference.
    /// </summary>
    public partial class RecommendationPreferencesDetail
    {
        private EnhancedInfrastructureMetrics _enhancedInfrastructureMetrics;
        private ExternalMetricsPreference _externalMetricsPreference;
        private InferredWorkloadTypesPreference _inferredWorkloadTypes;
        private LookBackPeriodPreference _lookBackPeriod;
        private List<EffectivePreferredResource> _preferredResources = AWSConfigs.InitializeCollections ? new List<EffectivePreferredResource>() : null;
        private ResourceType _resourceType;
        private SavingsEstimationMode _savingsEstimationMode;
        private Scope _scope;
        private List<UtilizationPreference> _utilizationPreferences = AWSConfigs.InitializeCollections ? new List<UtilizationPreference>() : null;

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// The status of the enhanced infrastructure metrics recommendation preference.
        /// </para>
        ///  
        /// <para>
        /// When the recommendations page is refreshed, a status of <c>Active</c> confirms that
        /// the preference is applied to the recommendations, and a status of <c>Inactive</c>
        /// confirms that the preference isn't yet applied to recommendations.
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
        ///  An object that describes the external metrics recommendation preference. 
        /// </para>
        ///  
        /// <para>
        ///  If the preference is applied in the latest recommendation refresh, an object with
        /// a valid <c>source</c> value appears in the response. If the preference isn't applied
        /// to the recommendations already, then this object doesn't appear in the response. 
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
        /// The status of the inferred workload types recommendation preference.
        /// </para>
        ///  
        /// <para>
        /// When the recommendations page is refreshed, a status of <c>Active</c> confirms that
        /// the preference is applied to the recommendations, and a status of <c>Inactive</c>
        /// confirms that the preference isn't yet applied to recommendations.
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
        /// Web Services resource are analyzed. If the preference isn’t set, this object is null.
        /// 
        /// </para>
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
        /// rightsizing recommendations. This object resolves any wildcard expressions and returns
        /// the effective list of candidate resource type values. If the preference isn’t set,
        /// this object is null. 
        /// </para>
        /// </summary>
        public List<EffectivePreferredResource> PreferredResources
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
        ///  Describes the savings estimation mode used for calculating savings opportunity. 
        /// </para>
        ///  
        /// <para>
        /// Only the account manager or delegated administrator of your organization can activate
        /// this preference.
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
        /// An object that describes the scope of the recommendation preference.
        /// </para>
        ///  
        /// <para>
        /// Recommendation preferences can be created at the organization level (for management
        /// accounts of an organization only), account level, and resource level. For more information,
        /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
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
        /// headroom, and memory utilization headroom. If the preference isn’t set, this object
        /// is null. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This preference is only available for the Amazon EC2 instance resource type.
        /// </para>
        ///  </note>
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