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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the effective recommendation preferences for Amazon Aurora and RDS databases.
    /// </summary>
    public partial class RDSEffectiveRecommendationPreferences
    {
        /// <summary>
        /// Gets and sets the property CpuVendorArchitectures. 
        /// <para>
        ///  Describes the CPU vendor and architecture for DB instance recommendations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CpuVendorArchitectures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CpuVendorArchitectures property is set.
        /// </summary>
        internal bool IsSetCpuVendorArchitectures() => this.CpuVendorArchitectures != null && (this.CpuVendorArchitectures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnhancedInfrastructureMetrics. 
        /// <para>
        /// Describes the activation status of the enhanced infrastructure metrics preference.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A status of <c>Active</c> confirms that the preference is applied in the latest recommendation
        /// refresh, and a status of <c>Inactive</c> confirms that it's not yet applied to recommendations.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Enhanced
        /// infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>. 
        /// </para>
        /// </summary>
        public EnhancedInfrastructureMetrics EnhancedInfrastructureMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedInfrastructureMetrics property is set.
        /// </summary>
        internal bool IsSetEnhancedInfrastructureMetrics() => this.EnhancedInfrastructureMetrics != null;

        /// <summary>
        /// Gets and sets the property LookBackPeriod. 
        /// <para>
        ///  The number of days the utilization metrics of the DB instance are analyzed. 
        /// </para>
        /// </summary>
        public LookBackPeriodPreference LookBackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the LookBackPeriod property is set.
        /// </summary>
        internal bool IsSetLookBackPeriod() => this.LookBackPeriod != null;

        /// <summary>
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        ///  Describes the savings estimation mode preference applied for calculating savings
        /// opportunity for DB instances. 
        /// </para>
        /// </summary>
        public RDSSavingsEstimationMode SavingsEstimationMode { get; set; }

        /// <summary>
        /// Checks to see if the SavingsEstimationMode property is set.
        /// </summary>
        internal bool IsSetSavingsEstimationMode() => this.SavingsEstimationMode != null;
    }
}
