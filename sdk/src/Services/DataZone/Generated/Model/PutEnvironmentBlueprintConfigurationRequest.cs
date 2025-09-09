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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the PutEnvironmentBlueprintConfiguration operation.
    /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
    /// </summary>
    public partial class PutEnvironmentBlueprintConfigurationRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private List<string> _enabledRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _environmentBlueprintIdentifier;
        private string _environmentRolePermissionBoundary;
        private Dictionary<string, string> _globalParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _manageAccessRoleArn;
        private List<ProvisioningConfiguration> _provisioningConfigurations = AWSConfigs.InitializeCollections ? new List<ProvisioningConfiguration>() : null;
        private string _provisioningRoleArn;
        private Dictionary<string, Dictionary<string, string>> _regionalParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledRegions. 
        /// <para>
        /// Specifies the enabled Amazon Web Services Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<string> EnabledRegions
        {
            get { return this._enabledRegions; }
            set { this._enabledRegions = value; }
        }

        // Check to see if EnabledRegions property is set
        internal bool IsSetEnabledRegions()
        {
            return this._enabledRegions != null && (this._enabledRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintIdentifier. 
        /// <para>
        /// The identifier of the environment blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentBlueprintIdentifier
        {
            get { return this._environmentBlueprintIdentifier; }
            set { this._environmentBlueprintIdentifier = value; }
        }

        // Check to see if EnvironmentBlueprintIdentifier property is set
        internal bool IsSetEnvironmentBlueprintIdentifier()
        {
            return this._environmentBlueprintIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentRolePermissionBoundary. 
        /// <para>
        /// The environment role permissions boundary.
        /// </para>
        /// </summary>
        public string EnvironmentRolePermissionBoundary
        {
            get { return this._environmentRolePermissionBoundary; }
            set { this._environmentRolePermissionBoundary = value; }
        }

        // Check to see if EnvironmentRolePermissionBoundary property is set
        internal bool IsSetEnvironmentRolePermissionBoundary()
        {
            return this._environmentRolePermissionBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalParameters. 
        /// <para>
        /// Region-agnostic environment blueprint parameters. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> GlobalParameters
        {
            get { return this._globalParameters; }
            set { this._globalParameters = value; }
        }

        // Check to see if GlobalParameters property is set
        internal bool IsSetGlobalParameters()
        {
            return this._globalParameters != null && (this._globalParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManageAccessRoleArn. 
        /// <para>
        /// The ARN of the manage access role.
        /// </para>
        /// </summary>
        public string ManageAccessRoleArn
        {
            get { return this._manageAccessRoleArn; }
            set { this._manageAccessRoleArn = value; }
        }

        // Check to see if ManageAccessRoleArn property is set
        internal bool IsSetManageAccessRoleArn()
        {
            return this._manageAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningConfigurations. 
        /// <para>
        /// The provisioning configuration of a blueprint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningConfiguration> ProvisioningConfigurations
        {
            get { return this._provisioningConfigurations; }
            set { this._provisioningConfigurations = value; }
        }

        // Check to see if ProvisioningConfigurations property is set
        internal bool IsSetProvisioningConfigurations()
        {
            return this._provisioningConfigurations != null && (this._provisioningConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The ARN of the provisioning role.
        /// </para>
        /// </summary>
        public string ProvisioningRoleArn
        {
            get { return this._provisioningRoleArn; }
            set { this._provisioningRoleArn = value; }
        }

        // Check to see if ProvisioningRoleArn property is set
        internal bool IsSetProvisioningRoleArn()
        {
            return this._provisioningRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalParameters. 
        /// <para>
        /// The regional parameters in the environment blueprint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> RegionalParameters
        {
            get { return this._regionalParameters; }
            set { this._regionalParameters = value; }
        }

        // Check to see if RegionalParameters property is set
        internal bool IsSetRegionalParameters()
        {
            return this._regionalParameters != null && (this._regionalParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}