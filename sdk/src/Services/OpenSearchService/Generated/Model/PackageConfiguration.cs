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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The configuration parameters for a package.
    /// </summary>
    public partial class PackageConfiguration
    {
        private RequirementLevel _configurationRequirement;
        private string _licenseFilepath;
        private RequirementLevel _licenseRequirement;
        private bool? _requiresRestartForConfigurationUpdate;

        /// <summary>
        /// Gets and sets the property ConfigurationRequirement. 
        /// <para>
        /// The configuration requirements for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequirementLevel ConfigurationRequirement
        {
            get { return this._configurationRequirement; }
            set { this._configurationRequirement = value; }
        }

        // Check to see if ConfigurationRequirement property is set
        internal bool IsSetConfigurationRequirement()
        {
            return this._configurationRequirement != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseFilepath. 
        /// <para>
        /// The relative file path for the license associated with the package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string LicenseFilepath
        {
            get { return this._licenseFilepath; }
            set { this._licenseFilepath = value; }
        }

        // Check to see if LicenseFilepath property is set
        internal bool IsSetLicenseFilepath()
        {
            return this._licenseFilepath != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseRequirement. 
        /// <para>
        /// The license requirements for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequirementLevel LicenseRequirement
        {
            get { return this._licenseRequirement; }
            set { this._licenseRequirement = value; }
        }

        // Check to see if LicenseRequirement property is set
        internal bool IsSetLicenseRequirement()
        {
            return this._licenseRequirement != null;
        }

        /// <summary>
        /// Gets and sets the property RequiresRestartForConfigurationUpdate. 
        /// <para>
        /// This indicates whether a B/G deployment is required for updating the configuration
        /// that the plugin is prerequisite for.
        /// </para>
        /// </summary>
        public bool? RequiresRestartForConfigurationUpdate
        {
            get { return this._requiresRestartForConfigurationUpdate; }
            set { this._requiresRestartForConfigurationUpdate = value; }
        }

        // Check to see if RequiresRestartForConfigurationUpdate property is set
        internal bool IsSetRequiresRestartForConfigurationUpdate()
        {
            return this._requiresRestartForConfigurationUpdate.HasValue; 
        }

    }
}