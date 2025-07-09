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
    /// Container for the parameters to the CreateCodeSecurityScanConfiguration operation.
    /// Creates a scan configuration for code security scanning.
    /// </summary>
    public partial class CreateCodeSecurityScanConfigurationRequest : AmazonInspector2Request
    {
        private CodeSecurityScanConfiguration _configuration;
        private ConfigurationLevel _level;
        private string _name;
        private ScopeSettings _scopeSettings;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration settings for the code security scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeSecurityScanConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The security level for the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeSettings. 
        /// <para>
        /// The scope settings that define which repositories will be scanned. Include this parameter
        /// to create a default scan configuration. Otherwise Amazon Inspector creates a general
        /// scan configuration. 
        /// </para>
        ///  
        /// <para>
        /// A default scan configuration automatically applies to all existing and future projects
        /// imported into Amazon Inspector. Use the <c>BatchAssociateCodeSecurityScanConfiguration</c>
        /// operation to associate a general scan configuration with projects.
        /// </para>
        /// </summary>
        public ScopeSettings ScopeSettings
        {
            get { return this._scopeSettings; }
            set { this._scopeSettings = value; }
        }

        // Check to see if ScopeSettings property is set
        internal bool IsSetScopeSettings()
        {
            return this._scopeSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}