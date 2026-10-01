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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkMigrationDefinition operation.
    /// </summary>
    public partial class GetNetworkMigrationDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CidrMappings. 
        /// <para>
        /// A list of CIDR mappings that map original source CIDR ranges to updated target CIDR
        /// ranges. CIDR mappings apply only when <c>vpcProvisioningStrategy</c> is set to <c>USE_EXISTING</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CidrMapping> CidrMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<CidrMapping>() : null;

        /// <summary>
        /// Checks to see if the CidrMappings property is set.
        /// </summary>
        internal bool IsSetCidrMappings() => this.CidrMappings != null && (this.CidrMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the network migration definition was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// Scope tags for the network migration definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 40)]
        public Dictionary<string, string> ScopeTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ScopeTags property is set.
        /// </summary>
        internal bool IsSetScopeTags() => this.ScopeTags != null && (this.ScopeTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceConfigurations. 
        /// <para>
        /// A list of source configurations for the network migration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<SourceConfiguration> SourceConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SourceConfigurations property is set.
        /// </summary>
        internal bool IsSetSourceConfigurations() => this.SourceConfigurations != null && (this.SourceConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the network migration definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDeployment. 
        /// <para>
        /// The target deployment configuration for the migrated network.
        /// </para>
        /// </summary>
        public TargetDeployment TargetDeployment { get; set; }

        /// <summary>
        /// Checks to see if the TargetDeployment property is set.
        /// </summary>
        internal bool IsSetTargetDeployment() => this.TargetDeployment != null;

        /// <summary>
        /// Gets and sets the property TargetNetwork. 
        /// <para>
        /// The target network configuration including topology and CIDR ranges.
        /// </para>
        /// </summary>
        public TargetNetwork TargetNetwork { get; set; }

        /// <summary>
        /// Checks to see if the TargetNetwork property is set.
        /// </summary>
        internal bool IsSetTargetNetwork() => this.TargetNetwork != null;

        /// <summary>
        /// Gets and sets the property TargetS3Configuration. 
        /// <para>
        /// The S3 configuration for storing the target network artifacts.
        /// </para>
        /// </summary>
        public TargetS3Configuration TargetS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the TargetS3Configuration property is set.
        /// </summary>
        internal bool IsSetTargetS3Configuration() => this.TargetS3Configuration != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the network migration definition was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VpcProvisioningStrategy. 
        /// <para>
        /// Indicates whether the migration creates new target VPCs or uses existing ones. <c>CREATE_NEW</c>
        /// provisions new target VPCs; <c>USE_EXISTING</c> migrates into existing VPCs in the
        /// target account.
        /// </para>
        /// </summary>
        public VpcProvisioningStrategy VpcProvisioningStrategy { get; set; }

        /// <summary>
        /// Checks to see if the VpcProvisioningStrategy property is set.
        /// </summary>
        internal bool IsSetVpcProvisioningStrategy() => this.VpcProvisioningStrategy != null;
    }
}
