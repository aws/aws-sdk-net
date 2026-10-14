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
    /// Container for the parameters to the CreateAppImageConfig operation. Creates a configuration
    /// for running a SageMaker AI image as a KernelGateway app. The configuration specifies
    /// the Amazon Elastic File System storage volume on the image, and a list of the kernels
    /// in the image.
    /// </summary>
    public partial class CreateAppImageConfigRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig. Must be unique to your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string AppImageConfigName { get; set; }

        /// <summary>
        /// Checks to see if the AppImageConfigName property is set.
        /// </summary>
        internal bool IsSetAppImageConfigName() => this.AppImageConfigName != null;

        /// <summary>
        /// Gets and sets the property CodeEditorAppImageConfig. 
        /// <para>
        /// The <c>CodeEditorAppImageConfig</c>. You can only specify one image kernel in the
        /// AppImageConfig API. This kernel is shown to users before the image starts. After the
        /// image runs, all kernels are visible in Code Editor.
        /// </para>
        /// </summary>
        public CodeEditorAppImageConfig CodeEditorAppImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the CodeEditorAppImageConfig property is set.
        /// </summary>
        internal bool IsSetCodeEditorAppImageConfig() => this.CodeEditorAppImageConfig != null;

        /// <summary>
        /// Gets and sets the property JupyterLabAppImageConfig. 
        /// <para>
        /// The <c>JupyterLabAppImageConfig</c>. You can only specify one image kernel in the
        /// <c>AppImageConfig</c> API. This kernel is shown to users before the image starts.
        /// After the image runs, all kernels are visible in JupyterLab.
        /// </para>
        /// </summary>
        public JupyterLabAppImageConfig JupyterLabAppImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the JupyterLabAppImageConfig property is set.
        /// </summary>
        internal bool IsSetJupyterLabAppImageConfig() => this.JupyterLabAppImageConfig != null;

        /// <summary>
        /// Gets and sets the property KernelGatewayImageConfig. 
        /// <para>
        /// The KernelGatewayImageConfig. You can only specify one image kernel in the AppImageConfig
        /// API. This kernel will be shown to users before the image starts. Once the image runs,
        /// all kernels are visible in JupyterLab.
        /// </para>
        /// </summary>
        public KernelGatewayImageConfig KernelGatewayImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayImageConfig property is set.
        /// </summary>
        internal bool IsSetKernelGatewayImageConfig() => this.KernelGatewayImageConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the AppImageConfig.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
