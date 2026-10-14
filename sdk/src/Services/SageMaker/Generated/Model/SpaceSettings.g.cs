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
    /// A collection of space settings.
    /// </summary>
    public partial class SpaceSettings
    {
        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        /// The type of app created within the space.
        /// </para>
        ///  
        /// <para>
        /// If using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UpdateSpace.html">
        /// UpdateSpace</a> API, you can't change the app type of your space by specifying a different
        /// value for this field.
        /// </para>
        /// </summary>
        public AppType AppType { get; set; }

        /// <summary>
        /// Checks to see if the AppType property is set.
        /// </summary>
        internal bool IsSetAppType() => this.AppType != null;

        /// <summary>
        /// Gets and sets the property CodeEditorAppSettings. 
        /// <para>
        /// The Code Editor application settings.
        /// </para>
        /// </summary>
        public SpaceCodeEditorAppSettings CodeEditorAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the CodeEditorAppSettings property is set.
        /// </summary>
        internal bool IsSetCodeEditorAppSettings() => this.CodeEditorAppSettings != null;

        /// <summary>
        /// Gets and sets the property CustomFileSystems. 
        /// <para>
        /// A file system, created by you, that you assign to a space for an Amazon SageMaker
        /// AI Domain. Permitted users can access this file system in Amazon SageMaker AI Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<CustomFileSystem> CustomFileSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomFileSystem>() : null;

        /// <summary>
        /// Checks to see if the CustomFileSystems property is set.
        /// </summary>
        internal bool IsSetCustomFileSystems() => this.CustomFileSystems != null && (this.CustomFileSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JupyterLabAppSettings. 
        /// <para>
        /// The settings for the JupyterLab application.
        /// </para>
        /// </summary>
        public SpaceJupyterLabAppSettings JupyterLabAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterLabAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterLabAppSettings() => this.JupyterLabAppSettings != null;

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings.
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the JupyterServerAppSettings property is set.
        /// </summary>
        internal bool IsSetJupyterServerAppSettings() => this.JupyterServerAppSettings != null;

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings.
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayAppSettings property is set.
        /// </summary>
        internal bool IsSetKernelGatewayAppSettings() => this.KernelGatewayAppSettings != null;

        /// <summary>
        /// Gets and sets the property RemoteAccess. 
        /// <para>
        /// A setting that enables or disables remote access for a SageMaker space. When enabled,
        /// this allows you to connect to the remote space from your local IDE.
        /// </para>
        /// </summary>
        public FeatureStatus RemoteAccess { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccess property is set.
        /// </summary>
        internal bool IsSetRemoteAccess() => this.RemoteAccess != null;

        /// <summary>
        /// Gets and sets the property SpaceManagedResources. 
        /// <para>
        /// If you enable this option, SageMaker AI creates the following resources on your behalf
        /// when you create the space:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user profile that possesses the space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The app that the space contains.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FeatureStatus SpaceManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the SpaceManagedResources property is set.
        /// </summary>
        internal bool IsSetSpaceManagedResources() => this.SpaceManagedResources != null;

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings. 
        /// <para>
        /// The storage settings for a space.
        /// </para>
        /// </summary>
        public SpaceStorageSettings SpaceStorageSettings { get; set; }

        /// <summary>
        /// Checks to see if the SpaceStorageSettings property is set.
        /// </summary>
        internal bool IsSetSpaceStorageSettings() => this.SpaceStorageSettings != null;
    }
}
