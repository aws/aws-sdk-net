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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Indicates that the exported data must include EC2 instance type matches for on-premises
    /// servers that are discovered through Amazon Web Services Application Discovery Service.
    /// </summary>
    public partial class Ec2RecommendationsExportPreferences
    {
        /// <summary>
        /// Gets and sets the property CpuPerformanceMetricBasis. 
        /// <para>
        ///  The recommended EC2 instance type that matches the CPU usage metric of server performance
        /// data. 
        /// </para>
        /// </summary>
        public UsageMetricBasis CpuPerformanceMetricBasis { get; set; }

        /// <summary>
        /// Checks to see if the CpuPerformanceMetricBasis property is set.
        /// </summary>
        internal bool IsSetCpuPerformanceMetricBasis() => this.CpuPerformanceMetricBasis != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  If set to true, the export <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_StartExportTask.html#API_StartExportTask_RequestSyntax">preferences</a>
        /// is set to <c>Ec2RecommendationsExportPreferences</c>. 
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        ///  An array of instance types to exclude from recommendations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedInstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedInstanceTypes property is set.
        /// </summary>
        internal bool IsSetExcludedInstanceTypes() => this.ExcludedInstanceTypes != null && (this.ExcludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreferredRegion. 
        /// <para>
        ///  The target Amazon Web Services Region for the recommendations. You can use any of
        /// the Region codes available for the chosen service, as listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Amazon
        /// Web Services service endpoints</a> in the <i>Amazon Web Services General Reference</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string PreferredRegion { get; set; }

        /// <summary>
        /// Checks to see if the PreferredRegion property is set.
        /// </summary>
        internal bool IsSetPreferredRegion() => this.PreferredRegion != null;

        /// <summary>
        /// Gets and sets the property RamPerformanceMetricBasis. 
        /// <para>
        ///  The recommended EC2 instance type that matches the Memory usage metric of server
        /// performance data. 
        /// </para>
        /// </summary>
        public UsageMetricBasis RamPerformanceMetricBasis { get; set; }

        /// <summary>
        /// Checks to see if the RamPerformanceMetricBasis property is set.
        /// </summary>
        internal bool IsSetRamPerformanceMetricBasis() => this.RamPerformanceMetricBasis != null;

        /// <summary>
        /// Gets and sets the property ReservedInstanceOptions. 
        /// <para>
        ///  The contract type for a reserved instance. If blank, we assume an On-Demand instance
        /// is preferred. 
        /// </para>
        /// </summary>
        public ReservedInstanceOptions ReservedInstanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstanceOptions property is set.
        /// </summary>
        internal bool IsSetReservedInstanceOptions() => this.ReservedInstanceOptions != null;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        ///  The target tenancy to use for your recommended EC2 instances. 
        /// </para>
        /// </summary>
        public Tenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;
    }
}
