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
    /// Container for the parameters to the UpdateAppImageConfig operation. Updates the properties
    /// of an AppImageConfig.
    /// </summary>
    public partial class UpdateAppImageConfigRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig to update.
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
        /// The Code Editor app running on the image.
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
        /// The JupyterLab app running on the image.
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
        /// The new KernelGateway app to run on the image.
        /// </para>
        /// </summary>
        public KernelGatewayImageConfig KernelGatewayImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayImageConfig property is set.
        /// </summary>
        internal bool IsSetKernelGatewayImageConfig() => this.KernelGatewayImageConfig != null;
    }
}
