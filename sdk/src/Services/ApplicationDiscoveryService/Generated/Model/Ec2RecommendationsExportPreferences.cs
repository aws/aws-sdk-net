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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private UsageMetricBasis _cpuPerformanceMetricBasis;
        private bool? _enabled;
        private List<string> _excludedInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _preferredRegion;
        private UsageMetricBasis _ramPerformanceMetricBasis;
        private ReservedInstanceOptions _reservedInstanceOptions;
        private Tenancy _tenancy;

        /// <summary>
        /// Gets and sets the property CpuPerformanceMetricBasis. 
        /// <para>
        ///  The recommended EC2 instance type that matches the CPU usage metric of server performance
        /// data. 
        /// </para>
        /// </summary>
        public UsageMetricBasis CpuPerformanceMetricBasis
        {
            get { return this._cpuPerformanceMetricBasis; }
            set { this._cpuPerformanceMetricBasis = value; }
        }

        // Check to see if CpuPerformanceMetricBasis property is set
        internal bool IsSetCpuPerformanceMetricBasis()
        {
            return this._cpuPerformanceMetricBasis != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  If set to true, the export <a href="https://docs.aws.amazon.com/application-discovery/latest/APIReference/API_StartExportTask.html#API_StartExportTask_RequestSyntax">preferences</a>
        /// is set to <c>Ec2RecommendationsExportPreferences</c>. 
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludedInstanceTypes. 
        /// <para>
        ///  An array of instance types to exclude from recommendations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedInstanceTypes
        {
            get { return this._excludedInstanceTypes; }
            set { this._excludedInstanceTypes = value; }
        }

        // Check to see if ExcludedInstanceTypes property is set
        internal bool IsSetExcludedInstanceTypes()
        {
            return this._excludedInstanceTypes != null && (this._excludedInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreferredRegion. 
        /// <para>
        ///  The target Amazon Web Services Region for the recommendations. You can use any of
        /// the Region codes available for the chosen service, as listed in <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Amazon
        /// Web Services service endpoints</a> in the <i>Amazon Web Services General Reference</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string PreferredRegion
        {
            get { return this._preferredRegion; }
            set { this._preferredRegion = value; }
        }

        // Check to see if PreferredRegion property is set
        internal bool IsSetPreferredRegion()
        {
            return this._preferredRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RamPerformanceMetricBasis. 
        /// <para>
        ///  The recommended EC2 instance type that matches the Memory usage metric of server
        /// performance data. 
        /// </para>
        /// </summary>
        public UsageMetricBasis RamPerformanceMetricBasis
        {
            get { return this._ramPerformanceMetricBasis; }
            set { this._ramPerformanceMetricBasis = value; }
        }

        // Check to see if RamPerformanceMetricBasis property is set
        internal bool IsSetRamPerformanceMetricBasis()
        {
            return this._ramPerformanceMetricBasis != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstanceOptions. 
        /// <para>
        ///  The contract type for a reserved instance. If blank, we assume an On-Demand instance
        /// is preferred. 
        /// </para>
        /// </summary>
        public ReservedInstanceOptions ReservedInstanceOptions
        {
            get { return this._reservedInstanceOptions; }
            set { this._reservedInstanceOptions = value; }
        }

        // Check to see if ReservedInstanceOptions property is set
        internal bool IsSetReservedInstanceOptions()
        {
            return this._reservedInstanceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        ///  The target tenancy to use for your recommended EC2 instances. 
        /// </para>
        /// </summary>
        public Tenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}