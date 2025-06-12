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
    /// This is the response object from the GetEffectiveRecommendationPreferences operation.
    /// </summary>
    public partial class GetEffectiveRecommendationPreferencesResponse : AmazonWebServiceResponse
    {
        private EnhancedInfrastructureMetrics _enhancedInfrastructureMetrics;
        private ExternalMetricsPreference _externalMetricsPreference;
        private LookBackPeriodPreference _lookBackPeriod;
        private List<EffectivePreferredResource> _preferredResources = AWSConfigs.InitializeCollections ? new List<EffectivePreferredResource>() : null;
        private List<UtilizationPreference> _utilizationPreferences = AWSConfigs.InitializeCollections ? new List<UtilizationPreference>() : null;

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// The status of the enhanced infrastructure metrics recommendation preference. Considers
        /// all applicable preferences that you might have set at the resource, account, and organization
        /// level.
        /// </para>
        ///  
        /// <para>
        /// A status of <c>Active</c> confirms that the preference is applied in the latest recommendation
        /// refresh, and a status of <c>Inactive</c> confirms that it's not yet applied to recommendations.
        /// </para>
        ///  
        /// <para>
        /// To validate whether the preference is applied to your last generated set of recommendations,
        /// review the <c>effectiveRecommendationPreferences</c> value in the response of the
        /// <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
        /// actions.
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
        /// The provider of the external metrics recommendation preference. Considers all applicable
        /// preferences that you might have set at the account and organization level.
        /// </para>
        ///  
        /// <para>
        /// If the preference is applied in the latest recommendation refresh, an object with
        /// a valid <c>source</c> value appears in the response. If the preference isn't applied
        /// to the recommendations already, then this object doesn't appear in the response.
        /// </para>
        ///  
        /// <para>
        /// To validate whether the preference is applied to your last generated set of recommendations,
        /// review the <c>effectiveRecommendationPreferences</c> value in the response of the
        /// <a>GetEC2InstanceRecommendations</a> actions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/external-metrics-ingestion.html">Enhanced
        /// infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
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
        /// Gets and sets the property LookBackPeriod. 
        /// <para>
        ///  The number of days the utilization metrics of the Amazon Web Services resource are
        /// analyzed. 
        /// </para>
        ///  
        /// <para>
        /// To validate that the preference is applied to your last generated set of recommendations,
        /// review the <c>effectiveRecommendationPreferences</c> value in the response of the
        /// GetAutoScalingGroupRecommendations or GetEC2InstanceRecommendations actions.
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
        ///  The resource type values that are considered as candidates when generating rightsizing
        /// recommendations. This object resolves any wildcard expressions and returns the effective
        /// list of candidate resource type values. It also considers all applicable preferences
        /// that you set at the resource, account, and organization level. 
        /// </para>
        ///  
        /// <para>
        /// To validate that the preference is applied to your last generated set of recommendations,
        /// review the <c>effectiveRecommendationPreferences</c> value in the response of the
        /// GetAutoScalingGroupRecommendations or GetEC2InstanceRecommendations actions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property UtilizationPreferences. 
        /// <para>
        ///  The resource’s CPU and memory utilization preferences, such as threshold and headroom,
        /// that were used to generate rightsizing recommendations. It considers all applicable
        /// preferences that you set at the resource, account, and organization level. 
        /// </para>
        ///  
        /// <para>
        /// To validate that the preference is applied to your last generated set of recommendations,
        /// review the <c>effectiveRecommendationPreferences</c> value in the response of the
        /// GetAutoScalingGroupRecommendations or GetEC2InstanceRecommendations actions.
        /// </para>
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