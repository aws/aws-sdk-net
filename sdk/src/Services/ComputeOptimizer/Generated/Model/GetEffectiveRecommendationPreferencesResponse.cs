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
    /// This is the response object from the GetEffectiveRecommendationPreferences operation.
    /// </summary>
    public partial class GetEffectiveRecommendationPreferencesResponse : AmazonWebServiceResponse
    {
        private EnhancedInfrastructureMetrics _enhancedInfrastructureMetrics;
        private ExternalMetricsPreference _externalMetricsPreference;

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// The status of the enhanced infrastructure metrics recommendation preference. Considers
        /// all applicable preferences that you might have set at the resource, account, and organization
        /// level.
        /// </para>
        ///  
        /// <para>
        /// A status of <code>Active</code> confirms that the preference is applied in the latest
        /// recommendation refresh, and a status of <code>Inactive</code> confirms that it's not
        /// yet applied to recommendations.
        /// </para>
        ///  
        /// <para>
        /// To validate whether the preference is applied to your last generated set of recommendations,
        /// review the <code>effectiveRecommendationPreferences</code> value in the response of
        /// the <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
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
        /// a valid <code>source</code> value appears in the response. If the preference isn't
        /// applied to the recommendations already, then this object doesn't appear in the response.
        /// </para>
        ///  
        /// <para>
        /// To validate whether the preference is applied to your last generated set of recommendations,
        /// review the <code>effectiveRecommendationPreferences</code> value in the response of
        /// the <a>GetEC2InstanceRecommendations</a> actions.
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

    }
}