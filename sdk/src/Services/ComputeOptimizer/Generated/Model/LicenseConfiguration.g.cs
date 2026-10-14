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
    /// Describes the configuration of a license for an Amazon EC2 instance.
    /// </summary>
    public partial class LicenseConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type used in the license. 
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LicenseEdition. 
        /// <para>
        ///  The edition of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public LicenseEdition LicenseEdition { get; set; }

        /// <summary>
        /// Checks to see if the LicenseEdition property is set.
        /// </summary>
        internal bool IsSetLicenseEdition() => this.LicenseEdition != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        ///  The license type associated with the instance. 
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property LicenseName. 
        /// <para>
        ///  The name of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public LicenseName LicenseName { get; set; }

        /// <summary>
        /// Checks to see if the LicenseName property is set.
        /// </summary>
        internal bool IsSetLicenseName() => this.LicenseName != null;

        /// <summary>
        /// Gets and sets the property LicenseVersion. 
        /// <para>
        ///  The version of the license for the application that runs on the instance. 
        /// </para>
        /// </summary>
        public string LicenseVersion { get; set; }

        /// <summary>
        /// Checks to see if the LicenseVersion property is set.
        /// </summary>
        internal bool IsSetLicenseVersion() => this.LicenseVersion != null;

        /// <summary>
        /// Gets and sets the property MetricsSource. 
        /// <para>
        ///  The list of metric sources required to generate recommendations for commercial software
        /// licenses. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricSource> MetricsSource { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricSource>() : null;

        /// <summary>
        /// Checks to see if the MetricsSource property is set.
        /// </summary>
        internal bool IsSetMetricsSource() => this.MetricsSource != null && (this.MetricsSource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfCores. 
        /// <para>
        ///  The current number of cores associated with the instance. 
        /// </para>
        /// </summary>
        public int? NumberOfCores { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfCores property is set.
        /// </summary>
        internal bool IsSetNumberOfCores() => this.NumberOfCores.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        ///  The operating system of the instance. 
        /// </para>
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;
    }
}
