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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImportedImage operation. Creates a custom
    /// WorkSpaces Applications image by importing an EC2 AMI. This allows you to use your
    /// own customized AMI to create WorkSpaces Applications images that support additional
    /// instance types beyond the standard stream.* instances.
    /// </summary>
    public partial class CreateImportedImageRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSoftwareVersion. 
        /// <para>
        /// The version of the WorkSpaces Applications agent to use for the imported image. Choose
        /// CURRENT_LATEST to use the agent version available at the time of import, or ALWAYS_LATEST
        /// to automatically update to the latest agent version when new versions are released.
        /// </para>
        /// </summary>
        public AgentSoftwareVersion AgentSoftwareVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentSoftwareVersion property is set.
        /// </summary>
        internal bool IsSetAgentSoftwareVersion() => this.AgentSoftwareVersion != null;

        /// <summary>
        /// Gets and sets the property AppCatalogConfig. 
        /// <para>
        /// Configuration for the application catalog of the imported image. This allows you to
        /// specify applications available for streaming, including their paths, icons, and launch
        /// parameters. This field contains sensitive data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ApplicationConfig> AppCatalogConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationConfig>() : null;

        /// <summary>
        /// Checks to see if the AppCatalogConfig property is set.
        /// </summary>
        internal bool IsSetAppCatalogConfig() => this.AppCatalogConfig != null && (this.AppCatalogConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the imported image. The description must match approved
        /// regex patterns and can be up to 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// An optional display name for the imported image. The display name must match approved
        /// regex patterns and can be up to 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// When set to true, performs validation checks without actually creating the imported
        /// image. Use this to verify your configuration before executing the actual import operation.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that allows WorkSpaces Applications to access your AMI. The
        /// role must have permissions to modify image attributes and describe images, with a
        /// trust relationship allowing appstream.amazonaws.com to assume the role.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the imported image. The name must be between 1 and 100 characters
        /// and can contain letters, numbers, underscores, periods, and hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RuntimeValidationConfig. 
        /// <para>
        /// Configuration for runtime validation of the imported image. When specified, WorkSpaces
        /// Applications provisions an instance to test streaming functionality, which helps ensure
        /// the image is suitable for use.
        /// </para>
        /// </summary>
        public RuntimeValidationConfig RuntimeValidationConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeValidationConfig property is set.
        /// </summary>
        internal bool IsSetRuntimeValidationConfig() => this.RuntimeValidationConfig != null;

        /// <summary>
        /// Gets and sets the property SourceAmiId. 
        /// <para>
        /// The ID of the EC2 AMI to import.
        /// </para>
        /// </summary>
        public string SourceAmiId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAmiId property is set.
        /// </summary>
        internal bool IsSetSourceAmiId() => this.SourceAmiId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the imported image. Tags help you organize and manage your WorkSpaces
        /// Applications resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceImageId. 
        /// <para>
        /// The ID of the Workspaces Image to import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 67)]
        public string WorkspaceImageId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceImageId property is set.
        /// </summary>
        internal bool IsSetWorkspaceImageId() => this.WorkspaceImageId != null;
    }
}
