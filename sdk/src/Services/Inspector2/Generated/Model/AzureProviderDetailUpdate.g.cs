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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The Azure-specific configuration details for updating a connector, including the scan
    /// scope and regions to scan.
    /// </summary>
    public partial class AzureProviderDetailUpdate
    {
        /// <summary>
        /// Gets and sets the property AutoInstallVMScanner. 
        /// <para>
        /// Specifies whether to automatically install the VM scanner on connected Azure resources.
        /// </para>
        /// </summary>
        public bool? AutoInstallVMScanner { get; set; }

        /// <summary>
        /// Checks to see if the AutoInstallVMScanner property is set.
        /// </summary>
        internal bool IsSetAutoInstallVMScanner() => this.AutoInstallVMScanner.HasValue;

        /// <summary>
        /// Gets and sets the property AzureRegions. 
        /// <para>
        /// The updated Azure regions to scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> AzureRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AzureRegions property is set.
        /// </summary>
        internal bool IsSetAzureRegions() => this.AzureRegions != null && (this.AzureRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The updated scope configuration that defines which Azure resources to scan.
        /// </para>
        /// </summary>
        public AzureScopeConfigurationInput ScopeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScopeConfiguration property is set.
        /// </summary>
        internal bool IsSetScopeConfiguration() => this.ScopeConfiguration != null;
    }
}
