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
    /// Describes the configuration of a license for an Amazon EC2 instance.
    /// </summary>
    public partial class LicenseConfiguration
    {
        private string _instanceType;
        private LicenseEdition _licenseEdition;
        private LicenseModel _licenseModel;
        private LicenseName _licenseName;
        private string _licenseVersion;
        private List<MetricSource> _metricsSource = AWSConfigs.InitializeCollections ? new List<MetricSource>() : null;
        private int? _numberOfCores;
        private string _operatingSystem;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type used in the license. 
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseEdition. 
        /// <para>
        ///  The edition of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public LicenseEdition LicenseEdition
        {
            get { return this._licenseEdition; }
            set { this._licenseEdition = value; }
        }

        // Check to see if LicenseEdition property is set
        internal bool IsSetLicenseEdition()
        {
            return this._licenseEdition != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        ///  The license type associated with the instance. 
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseName. 
        /// <para>
        ///  The name of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public LicenseName LicenseName
        {
            get { return this._licenseName; }
            set { this._licenseName = value; }
        }

        // Check to see if LicenseName property is set
        internal bool IsSetLicenseName()
        {
            return this._licenseName != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseVersion. 
        /// <para>
        ///  The version of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public string LicenseVersion
        {
            get { return this._licenseVersion; }
            set { this._licenseVersion = value; }
        }

        // Check to see if LicenseVersion property is set
        internal bool IsSetLicenseVersion()
        {
            return this._licenseVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsSource. 
        /// <para>
        ///  The list of metric sources required to generate recommendations for commercial software
        /// licenses. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricSource> MetricsSource
        {
            get { return this._metricsSource; }
            set { this._metricsSource = value; }
        }

        // Check to see if MetricsSource property is set
        internal bool IsSetMetricsSource()
        {
            return this._metricsSource != null && (this._metricsSource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberOfCores. 
        /// <para>
        ///  The current number of cores associated with the instance. 
        /// </para>
        /// </summary>
        public int? NumberOfCores
        {
            get { return this._numberOfCores; }
            set { this._numberOfCores = value; }
        }

        // Check to see if NumberOfCores property is set
        internal bool IsSetNumberOfCores()
        {
            return this._numberOfCores.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        ///  The operating system of the instance. 
        /// </para>
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

    }
}