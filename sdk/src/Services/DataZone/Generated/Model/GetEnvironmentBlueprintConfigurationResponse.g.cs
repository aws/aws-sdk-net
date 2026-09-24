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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetEnvironmentBlueprintConfiguration operation.
    /// </summary>
    public partial class GetEnvironmentBlueprintConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowUserProvidedConfigurations. 
        /// <para>
        /// Specifies whether user-provided resource configurations are allowed for the environment
        /// blueprint.
        /// </para>
        /// </summary>
        public bool? AllowUserProvidedConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the AllowUserProvidedConfigurations property is set.
        /// </summary>
        internal bool IsSetAllowUserProvidedConfigurations() => this.AllowUserProvidedConfigurations.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when this blueprint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain where this blueprint exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnabledRegions. 
        /// <para>
        /// The Amazon Web Services regions in which this blueprint is enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<string> EnabledRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledRegions property is set.
        /// </summary>
        internal bool IsSetEnabledRegions() => this.EnabledRegions != null && (this.EnabledRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The ID of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentBlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentBlueprintId property is set.
        /// </summary>
        internal bool IsSetEnvironmentBlueprintId() => this.EnvironmentBlueprintId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentRolePermissionBoundary. 
        /// <para>
        /// The environment role permissions boundary.
        /// </para>
        /// </summary>
        public string EnvironmentRolePermissionBoundary { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentRolePermissionBoundary property is set.
        /// </summary>
        internal bool IsSetEnvironmentRolePermissionBoundary() => this.EnvironmentRolePermissionBoundary != null;

        /// <summary>
        /// Gets and sets the property ManageAccessRoleArn. 
        /// <para>
        /// The ARN of the manage access role with which this blueprint is created.
        /// </para>
        /// </summary>
        public string ManageAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ManageAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetManageAccessRoleArn() => this.ManageAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property ProvisioningConfigurations. 
        /// <para>
        /// The provisioning configuration of a blueprint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningConfiguration> ProvisioningConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningConfigurations property is set.
        /// </summary>
        internal bool IsSetProvisioningConfigurations() => this.ProvisioningConfigurations != null && (this.ProvisioningConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The ARN of the provisioning role with which this blueprint is created.
        /// </para>
        /// </summary>
        public string ProvisioningRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningRoleArn property is set.
        /// </summary>
        internal bool IsSetProvisioningRoleArn() => this.ProvisioningRoleArn != null;

        /// <summary>
        /// Gets and sets the property RegionalParameters. 
        /// <para>
        /// The regional parameters of the blueprint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> RegionalParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the RegionalParameters property is set.
        /// </summary>
        internal bool IsSetRegionalParameters() => this.RegionalParameters != null && (this.RegionalParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceConfigurations. 
        /// <para>
        /// The resource configurations of the environment blueprint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ResourceConfiguration> ResourceConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ResourceConfigurations property is set.
        /// </summary>
        internal bool IsSetResourceConfigurations() => this.ResourceConfigurations != null && (this.ResourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when this blueprint was upated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
