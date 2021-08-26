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
    /// Describes preferences for recommendations.
    /// </summary>
    public partial class RecommendationPreferences
    {
        private List<string> _cpuVendorArchitectures = new List<string>();

        /// <summary>
        /// Gets and sets the property CpuVendorArchitectures. 
        /// <para>
        /// Specifies the CPU vendor and architecture for Amazon EC2 instance and Auto Scaling
        /// group recommendations.
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

    }
}