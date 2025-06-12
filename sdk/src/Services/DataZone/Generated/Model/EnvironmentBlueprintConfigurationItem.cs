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
    /// The configuration details of an environment blueprint.
    /// </summary>
    public partial class EnvironmentBlueprintConfigurationItem
    {
        private DateTime? _createdAt;
        private string _domainId;
        private List<string> _enabledRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _environmentBlueprintId;
        private string _environmentRolePermissionBoundary;
        private string _manageAccessRoleArn;
        private List<ProvisioningConfiguration> _provisioningConfigurations = AWSConfigs.InitializeCollections ? new List<ProvisioningConfiguration>() : null;
        private string _provisioningRoleArn;
        private Dictionary<string, Dictionary<string, string>> _regionalParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when an environment blueprint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which an environment blueprint exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledRegions. 
        /// <para>
        /// The enabled Amazon Web Services Regions specified in a blueprint configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The identifier of the environment blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentBlueprintId
        {
            get { return this._environmentBlueprintId; }
            set { this._environmentBlueprintId = value; }
        }

        // Check to see if EnvironmentBlueprintId property is set
        internal bool IsSetEnvironmentBlueprintId()
        {
            return this._environmentBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentRolePermissionBoundary. 
        /// <para>
        /// The environment role permission boundary.
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
        /// Gets and sets the property ManageAccessRoleArn. 
        /// <para>
        /// The ARN of the manage access role specified in the environment blueprint configuration.
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
        /// The ARN of the provisioning role specified in the environment blueprint configuration.
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
        /// The regional parameters of the environment blueprint.
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the environment blueprint was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}