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
    /// Container for the parameters to the CreateAppImageConfig operation.
    /// Creates a configuration for running a SageMaker AI image as a KernelGateway app. The
    /// configuration specifies the Amazon Elastic File System storage volume on the image,
    /// and a list of the kernels in the image.
    /// </summary>
    public partial class CreateAppImageConfigRequest : AmazonSageMakerRequest
    {
        private string _appImageConfigName;
        private CodeEditorAppImageConfig _codeEditorAppImageConfig;
        private JupyterLabAppImageConfig _jupyterLabAppImageConfig;
        private KernelGatewayImageConfig _kernelGatewayImageConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig. Must be unique to your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string AppImageConfigName
        {
            get { return this._appImageConfigName; }
            set { this._appImageConfigName = value; }
        }

        // Check to see if AppImageConfigName property is set
        internal bool IsSetAppImageConfigName()
        {
            return this._appImageConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property CodeEditorAppImageConfig. 
        /// <para>
        /// The <c>CodeEditorAppImageConfig</c>. You can only specify one image kernel in the
        /// AppImageConfig API. This kernel is shown to users before the image starts. After the
        /// image runs, all kernels are visible in Code Editor.
        /// </para>
        /// </summary>
        public CodeEditorAppImageConfig CodeEditorAppImageConfig
        {
            get { return this._codeEditorAppImageConfig; }
            set { this._codeEditorAppImageConfig = value; }
        }

        // Check to see if CodeEditorAppImageConfig property is set
        internal bool IsSetCodeEditorAppImageConfig()
        {
            return this._codeEditorAppImageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterLabAppImageConfig. 
        /// <para>
        /// The <c>JupyterLabAppImageConfig</c>. You can only specify one image kernel in the
        /// <c>AppImageConfig</c> API. This kernel is shown to users before the image starts.
        /// After the image runs, all kernels are visible in JupyterLab.
        /// </para>
        /// </summary>
        public JupyterLabAppImageConfig JupyterLabAppImageConfig
        {
            get { return this._jupyterLabAppImageConfig; }
            set { this._jupyterLabAppImageConfig = value; }
        }

        // Check to see if JupyterLabAppImageConfig property is set
        internal bool IsSetJupyterLabAppImageConfig()
        {
            return this._jupyterLabAppImageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KernelGatewayImageConfig. 
        /// <para>
        /// The KernelGatewayImageConfig. You can only specify one image kernel in the AppImageConfig
        /// API. This kernel will be shown to users before the image starts. Once the image runs,
        /// all kernels are visible in JupyterLab.
        /// </para>
        /// </summary>
        public KernelGatewayImageConfig KernelGatewayImageConfig
        {
            get { return this._kernelGatewayImageConfig; }
            set { this._kernelGatewayImageConfig = value; }
        }

        // Check to see if KernelGatewayImageConfig property is set
        internal bool IsSetKernelGatewayImageConfig()
        {
            return this._kernelGatewayImageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the AppImageConfig.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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