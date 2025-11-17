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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
    /// Container for the parameters to the CreateImportedImage operation.
    /// Creates a custom WorkSpaces Applications image by importing an EC2 AMI. This allows
    /// you to use your own customized AMI to create WorkSpaces Applications images that support
    /// additional instance types beyond the standard stream.* instances.
    /// </summary>
    public partial class CreateImportedImageRequest : AmazonAppStreamRequest
    {
        private AgentSoftwareVersion _agentSoftwareVersion;
        private List<ApplicationConfig> _appCatalogConfig = AWSConfigs.InitializeCollections ? new List<ApplicationConfig>() : null;
        private string _description;
        private string _displayName;
        private bool? _dryRun;
        private string _iamRoleArn;
        private string _name;
        private RuntimeValidationConfig _runtimeValidationConfig;
        private string _sourceAmiId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AgentSoftwareVersion. 
        /// <para>
        /// The version of the WorkSpaces Applications agent to use for the imported image. Choose
        /// CURRENT_LATEST to use the agent version available at the time of import, or ALWAYS_LATEST
        /// to automatically update to the latest agent version when new versions are released.
        /// </para>
        /// </summary>
        public AgentSoftwareVersion AgentSoftwareVersion
        {
            get { return this._agentSoftwareVersion; }
            set { this._agentSoftwareVersion = value; }
        }

        // Check to see if AgentSoftwareVersion property is set
        internal bool IsSetAgentSoftwareVersion()
        {
            return this._agentSoftwareVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AppCatalogConfig. 
        /// <para>
        /// Configuration for the application catalog of the imported image. This allows you to
        /// specify applications available for streaming, including their paths, icons, and launch
        /// parameters. This field contains sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<ApplicationConfig> AppCatalogConfig
        {
            get { return this._appCatalogConfig; }
            set { this._appCatalogConfig = value; }
        }

        // Check to see if AppCatalogConfig property is set
        internal bool IsSetAppCatalogConfig()
        {
            return this._appCatalogConfig != null && (this._appCatalogConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the imported image. The description must match approved
        /// regex patterns and can be up to 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// An optional display name for the imported image. The display name must match approved
        /// regex patterns and can be up to 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// When set to true, performs validation checks without actually creating the imported
        /// image. Use this to verify your configuration before executing the actual import operation.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that allows WorkSpaces Applications to access your AMI. The
        /// role must have permissions to modify image attributes and describe images, with a
        /// trust relationship allowing appstream.amazonaws.com to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the imported image. The name must be between 1 and 100 characters
        /// and can contain letters, numbers, underscores, periods, and hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RuntimeValidationConfig. 
        /// <para>
        /// Configuration for runtime validation of the imported image. When specified, WorkSpaces
        /// Applications provisions an instance to test streaming functionality, which helps ensure
        /// the image is suitable for use.
        /// </para>
        /// </summary>
        public RuntimeValidationConfig RuntimeValidationConfig
        {
            get { return this._runtimeValidationConfig; }
            set { this._runtimeValidationConfig = value; }
        }

        // Check to see if RuntimeValidationConfig property is set
        internal bool IsSetRuntimeValidationConfig()
        {
            return this._runtimeValidationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAmiId. 
        /// <para>
        /// The ID of the EC2 AMI to import. The AMI must meet specific requirements including
        /// Windows Server 2022 Full Base, UEFI boot mode, TPM 2.0 support, and proper drivers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceAmiId
        {
            get { return this._sourceAmiId; }
            set { this._sourceAmiId = value; }
        }

        // Check to see if SourceAmiId property is set
        internal bool IsSetSourceAmiId()
        {
            return this._sourceAmiId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the imported image. Tags help you organize and manage your WorkSpaces
        /// Applications resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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