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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains the scan configuration settings applied to a specific project in a code repository.
    /// </summary>
    public partial class ProjectCodeSecurityScanConfiguration
    {
        private List<ProjectContinuousIntegrationScanConfiguration> _continuousIntegrationScanConfigurations = AWSConfigs.InitializeCollections ? new List<ProjectContinuousIntegrationScanConfiguration>() : null;
        private List<ProjectPeriodicScanConfiguration> _periodicScanConfigurations = AWSConfigs.InitializeCollections ? new List<ProjectPeriodicScanConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ContinuousIntegrationScanConfigurations. 
        /// <para>
        /// The continuous integration scan configurations applied to the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectContinuousIntegrationScanConfiguration> ContinuousIntegrationScanConfigurations
        {
            get { return this._continuousIntegrationScanConfigurations; }
            set { this._continuousIntegrationScanConfigurations = value; }
        }

        // Check to see if ContinuousIntegrationScanConfigurations property is set
        internal bool IsSetContinuousIntegrationScanConfigurations()
        {
            return this._continuousIntegrationScanConfigurations != null && (this._continuousIntegrationScanConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PeriodicScanConfigurations. 
        /// <para>
        /// The periodic scan configurations applied to the project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectPeriodicScanConfiguration> PeriodicScanConfigurations
        {
            get { return this._periodicScanConfigurations; }
            set { this._periodicScanConfigurations = value; }
        }

        // Check to see if PeriodicScanConfigurations property is set
        internal bool IsSetPeriodicScanConfigurations()
        {
            return this._periodicScanConfigurations != null && (this._periodicScanConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}