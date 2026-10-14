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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that apply to users in a domain. These settings are specified
    /// when the <c>CreateUserProfile</c> API is called, and as <c>DefaultUserSettings</c>
    /// when the <c>CreateDomain</c> API is called.
    /// 
    ///  
    /// <para>
    ///  <c>SecurityGroups</c> is aggregated when specified in both calls. For all other settings
    /// in <c>UserSettings</c>, the values specified in <c>CreateUserProfile</c> take precedence
    /// over those specified in <c>CreateDomain</c>.
    /// </para>
    /// </summary>
    public partial class UserSettings
    {
        /// <summary>
        /// Gets and sets the property AutoMountHomeEFS. 
        /// <para>
        /// Indicates whether auto-mounting of an EFS volume is supported for the user profile.
        /// The <c>DefaultAsDomain</c> value is only supported for user profiles. Do not use the
        /// <c>DefaultAsDomain</c> value when setting this parameter for a domain.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies this setting only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply this setting to shared spaces.
        /// </para>
        /// </summary>
        public AutoMountHomeEFS AutoMountHomeEFS { get; set; }

        /// <summary>
        /// Checks to see if the AutoMountHomeEFS property is set.
        /// </summary>
        internal bool IsSetAutoMountHomeEFS() => this.AutoMountHomeEFS != null;

        /// <summary>
        /// Gets and sets the property CanvasAppSettings. 
        /// <para>
        /// The Canvas app settings.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that SageMaker creates for
        /// the Canvas app.
        /// </para>
        /// </summary>
        public CanvasAppSettings CanvasAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the CanvasAppSettings property is set.
        /// </summary>
        internal bool IsSetCanvasAppSettings() => this.CanvasAppSettings != null;

        /// <summary>
        /// Gets and sets the property CodeEditorAppSettings. 
        /// <para>
        /// The Code Editor application settings.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// </summary>
        public CodeEditorAppSettings CodeEditorAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodeEditorAppSettings property is set.
        /// </summary>
        internal bool IsSetCodeEditorAppSettings() => this.CodeEditorAppSettings != null;

        /// <summary>
        /// Gets and sets the property CustomFileSystemConfigs. 
        /// <para>
        /// The settings for assigning a custom file system to a user profile. Permitted users
        /// can access this file system in Amazon SageMaker AI Studio.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<CustomFileSystemConfig> CustomFileSystemConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomFileSystemConfig>() : null;

        /// <summary>
        /// Checks to see if the CustomFileSystemConfigs property is set.
        /// </summary>
        internal bool IsSetCustomFileSystemConfigs() => this.CustomFileSystemConfigs != null && (this.CustomFileSystemConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomPosixUserConfig. 
        /// <para>
        /// Details about the POSIX identity that is used for file system operations.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// </summary>
        public CustomPosixUserConfig CustomPosixUserConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomPosixUserConfig property is set.
        /// </summary>
        internal bool IsSetCustomPosixUserConfig() => this.CustomPosixUserConfig != null;

        /// <summary>
        /// Gets and sets the property DefaultLandingUri. 
        /// <para>
        /// The default experience that the user is directed to when accessing the domain. The
        /// supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>studio::</c>: Indicates that Studio is the default experience. This value can
        /// only be passed if <c>StudioWebPortal</c> is set to <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:JupyterServer:</c>: Indicates that Studio Classic is the default experience.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string DefaultLandingUri { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLandingUri property is set.
        /// </summary>
        internal bool IsSetDefaultLandingUri() => this.DefaultLandingUri != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the user.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies this setting only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply this setting to shared spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property JupyterLabAppSettings. 
        /// <para>
        /// The settings for the JupyterLab application.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// </summary>
        public JupyterLabAppSettings JupyterLabAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterLabAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterLabAppSettings() => this.JupyterLabAppSettings != null;

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings. 
        /// <para>
        /// The Jupyter server's app settings.
        /// </para>
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterServerAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterServerAppSettings() => this.JupyterServerAppSettings != null;

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings. 
        /// <para>
        /// The kernel gateway app settings.
        /// </para>
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayAppSettings property is set.
        /// </summary>
        internal bool IsSetKernelGatewayAppSettings() => this.KernelGatewayAppSettings != null;

        /// <summary>
        /// Gets and sets the property RSessionAppSettings. 
        /// <para>
        /// A collection of settings that configure the <c>RSessionGateway</c> app.
        /// </para>
        /// </summary>
        public RSessionAppSettings RSessionAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the RSessionAppSettings property is set.
        /// </summary>
        internal bool IsSetRSessionAppSettings() => this.RSessionAppSettings != null;

        /// <summary>
        /// Gets and sets the property RStudioServerProAppSettings. 
        /// <para>
        /// A collection of settings that configure user interaction with the <c>RStudioServerPro</c>
        /// app.
        /// </para>
        /// </summary>
        public RStudioServerProAppSettings RStudioServerProAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the RStudioServerProAppSettings property is set.
        /// </summary>
        internal bool IsSetRStudioServerProAppSettings() => this.RStudioServerProAppSettings != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud (VPC) that the domain uses
        /// for communication.
        /// </para>
        ///  
        /// <para>
        /// Optional when the <c>CreateDomain.AppNetworkAccessType</c> parameter is set to <c>PublicInternetOnly</c>.
        /// </para>
        ///  
        /// <para>
        /// Required when the <c>CreateDomain.AppNetworkAccessType</c> parameter is set to <c>VpcOnly</c>,
        /// unless specified as part of the <c>DefaultUserSettings</c> for the domain.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker AI adds a security group to allow NFS traffic from Amazon SageMaker
        /// AI Studio. Therefore, the number of security groups that you can specify is one less
        /// than the maximum number shown.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SharingSettings. 
        /// <para>
        /// Specifies options for sharing Amazon SageMaker AI Studio notebooks.
        /// </para>
        /// </summary>
        public SharingSettings SharingSettings { get; set; }

        /// <summary>
        /// Checks to see if the SharingSettings property is set.
        /// </summary>
        internal bool IsSetSharingSettings() => this.SharingSettings != null;

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings. 
        /// <para>
        /// The storage settings for a space.
        /// </para>
        ///  
        /// <para>
        /// SageMaker applies these settings only to private spaces that the user creates in the
        /// domain. SageMaker doesn't apply these settings to shared spaces.
        /// </para>
        /// </summary>
        public DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceStorageSettings property is set.
        /// </summary>
        internal bool IsSetSpaceStorageSettings() => this.SpaceStorageSettings != null;

        /// <summary>
        /// Gets and sets the property StudioWebPortal. 
        /// <para>
        /// Whether the user can access Studio. If this value is set to <c>DISABLED</c>, the user
        /// cannot access Studio, even if that is the default experience for the domain.
        /// </para>
        /// </summary>
        public StudioWebPortal StudioWebPortal { get; set; }

        /// <summary>
        /// Checks to see if the StudioWebPortal property is set.
        /// </summary>
        internal bool IsSetStudioWebPortal() => this.StudioWebPortal != null;

        /// <summary>
        /// Gets and sets the property StudioWebPortalSettings. 
        /// <para>
        /// Studio settings. If these settings are applied on a user level, they take priority
        /// over the settings applied on a domain level.
        /// </para>
        /// </summary>
        public StudioWebPortalSettings StudioWebPortalSettings { get; set; }

        /// <summary>
        /// Checks to see if the StudioWebPortalSettings property is set.
        /// </summary>
        internal bool IsSetStudioWebPortalSettings() => this.StudioWebPortalSettings != null;

        /// <summary>
        /// Gets and sets the property TensorBoardAppSettings. 
        /// <para>
        /// The TensorBoard app settings.
        /// </para>
        /// </summary>
        public TensorBoardAppSettings TensorBoardAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the TensorBoardAppSettings property is set.
        /// </summary>
        internal bool IsSetTensorBoardAppSettings() => this.TensorBoardAppSettings != null;
    }
}
