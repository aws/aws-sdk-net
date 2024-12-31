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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private AppType _appType;
        private SpaceCodeEditorAppSettings _codeEditorAppSettings;
        private List<CustomFileSystem> _customFileSystems = AWSConfigs.InitializeCollections ? new List<CustomFileSystem>() : null;
        private SpaceJupyterLabAppSettings _jupyterLabAppSettings;
        private JupyterServerAppSettings _jupyterServerAppSettings;
        private KernelGatewayAppSettings _kernelGatewayAppSettings;
        private SpaceStorageSettings _spaceStorageSettings;

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
        public AppType AppType
        {
            get { return this._appType; }
            set { this._appType = value; }
        }

        // Check to see if AppType property is set
        internal bool IsSetAppType()
        {
            return this._appType != null;
        }

        /// <summary>
        /// Gets and sets the property CodeEditorAppSettings. 
        /// <para>
        /// The Code Editor application settings.
        /// </para>
        /// </summary>
        public SpaceCodeEditorAppSettings CodeEditorAppSettings
        {
            get { return this._codeEditorAppSettings; }
            set { this._codeEditorAppSettings = value; }
        }

        // Check to see if CodeEditorAppSettings property is set
        internal bool IsSetCodeEditorAppSettings()
        {
            return this._codeEditorAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CustomFileSystems. 
        /// <para>
        /// A file system, created by you, that you assign to a space for an Amazon SageMaker
        /// AI Domain. Permitted users can access this file system in Amazon SageMaker AI Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<CustomFileSystem> CustomFileSystems
        {
            get { return this._customFileSystems; }
            set { this._customFileSystems = value; }
        }

        // Check to see if CustomFileSystems property is set
        internal bool IsSetCustomFileSystems()
        {
            return this._customFileSystems != null && (this._customFileSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JupyterLabAppSettings. 
        /// <para>
        /// The settings for the JupyterLab application.
        /// </para>
        /// </summary>
        public SpaceJupyterLabAppSettings JupyterLabAppSettings
        {
            get { return this._jupyterLabAppSettings; }
            set { this._jupyterLabAppSettings = value; }
        }

        // Check to see if JupyterLabAppSettings property is set
        internal bool IsSetJupyterLabAppSettings()
        {
            return this._jupyterLabAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings.
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings
        {
            get { return this._jupyterServerAppSettings; }
            set { this._jupyterServerAppSettings = value; }
        }

        // Check to see if JupyterServerAppSettings property is set
        internal bool IsSetJupyterServerAppSettings()
        {
            return this._jupyterServerAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings.
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings
        {
            get { return this._kernelGatewayAppSettings; }
            set { this._kernelGatewayAppSettings = value; }
        }

        // Check to see if KernelGatewayAppSettings property is set
        internal bool IsSetKernelGatewayAppSettings()
        {
            return this._kernelGatewayAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings. 
        /// <para>
        /// The storage settings for a space.
        /// </para>
        /// </summary>
        public SpaceStorageSettings SpaceStorageSettings
        {
            get { return this._spaceStorageSettings; }
            set { this._spaceStorageSettings = value; }
        }

        // Check to see if SpaceStorageSettings property is set
        internal bool IsSetSpaceStorageSettings()
        {
            return this._spaceStorageSettings != null;
        }

    }
}