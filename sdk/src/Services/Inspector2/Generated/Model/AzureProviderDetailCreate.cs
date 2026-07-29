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
    /// The Azure-specific configuration details for creating a connector, including the Amazon
    /// Web Services Config connector association, scan scope, and regions to scan.
    /// </summary>
    public partial class AzureProviderDetailCreate
    {
        private bool? _autoInstallVMScanner;
        private string _awsConfigConnectorArn;
        private List<string> _azureRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AzureScopeConfigurationInput _scopeConfiguration;

        /// <summary>
        /// Gets and sets the property AutoInstallVMScanner. 
        /// <para>
        /// Specifies whether to automatically install the VM scanner on connected Azure resources.
        /// Defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? AutoInstallVMScanner
        {
            get { return this._autoInstallVMScanner; }
            set { this._autoInstallVMScanner = value; }
        }

        // Check to see if AutoInstallVMScanner property is set
        internal bool IsSetAutoInstallVMScanner()
        {
            return this._autoInstallVMScanner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsConfigConnectorArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Config connector to associate with this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AwsConfigConnectorArn
        {
            get { return this._awsConfigConnectorArn; }
            set { this._awsConfigConnectorArn = value; }
        }

        // Check to see if AwsConfigConnectorArn property is set
        internal bool IsSetAwsConfigConnectorArn()
        {
            return this._awsConfigConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property AzureRegions. 
        /// <para>
        /// The Azure regions to scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> AzureRegions
        {
            get { return this._azureRegions; }
            set { this._azureRegions = value; }
        }

        // Check to see if AzureRegions property is set
        internal bool IsSetAzureRegions()
        {
            return this._azureRegions != null && (this._azureRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The scope configuration that defines which Azure resources to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AzureScopeConfigurationInput ScopeConfiguration
        {
            get { return this._scopeConfiguration; }
            set { this._scopeConfiguration = value; }
        }

        // Check to see if ScopeConfiguration property is set
        internal bool IsSetScopeConfiguration()
        {
            return this._scopeConfiguration != null;
        }

    }
}