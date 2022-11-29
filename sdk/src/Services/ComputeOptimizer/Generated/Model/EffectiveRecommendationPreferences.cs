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
    /// Describes the effective recommendation preferences for a resource.
    /// </summary>
    public partial class EffectiveRecommendationPreferences
    {
        private List<string> _cpuVendorArchitectures = new List<string>();
        private EnhancedInfrastructureMetrics _enhancedInfrastructureMetrics;
        private ExternalMetricsPreference _externalMetricsPreference;
        private InferredWorkloadTypesPreference _inferredWorkloadTypes;

        /// <summary>
        /// Gets and sets the property CpuVendorArchitectures. 
        /// <para>
        /// Describes the CPU vendor and architecture for an instance or Auto Scaling group recommendations.
        /// </para>
        ///  
        /// <para>
        /// For example, when you specify <code>AWS_ARM64</code> with:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <a>GetEC2InstanceRecommendations</a> or <a>GetAutoScalingGroupRecommendations</a>
        /// request, Compute Optimizer returns recommendations that consist of Graviton2 instance
        /// types only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a>GetEC2RecommendationProjectedMetrics</a> request, Compute Optimizer returns projected
        /// utilization metrics for Graviton2 instance type recommendations only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a>ExportEC2InstanceRecommendations</a> or <a>ExportAutoScalingGroupRecommendations</a>
        /// request, Compute Optimizer exports recommendations that consist of Graviton2 instance
        /// types only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> CpuVendorArchitectures
        {
            get { return this._cpuVendorArchitectures; }
            set { this._cpuVendorArchitectures = value; }
        }

        // Check to see if CpuVendorArchitectures property is set
        internal bool IsSetCpuVendorArchitectures()
        {
            return this._cpuVendorArchitectures != null && this._cpuVendorArchitectures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// Describes the activation status of the enhanced infrastructure metrics preference.
        /// </para>
        ///  
        /// <para>
        /// A status of <code>Active</code> confirms that the preference is applied in the latest
        /// recommendation refresh, and a status of <code>Inactive</code> confirms that it's not
        /// yet applied to recommendations.
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
        /// a valid <code>source</code> value appears in the response. If the preference isn't
        /// applied to the recommendations already, then this object doesn't appear in the response.
        /// 
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
        /// Describes the activation status of the inferred workload types preference.
        /// </para>
        ///  
        /// <para>
        /// A status of <code>Active</code> confirms that the preference is applied in the latest
        /// recommendation refresh. A status of <code>Inactive</code> confirms that it's not yet
        /// applied to recommendations.
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

    }
}