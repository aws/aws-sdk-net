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
    /// The configuration for running a SageMaker AI image as a KernelGateway app.
    /// </summary>
    public partial class AppImageConfigDetails
    {
        /// <summary>
        /// Gets and sets the property AppImageConfigArn. 
        /// <para>
        /// The ARN of the AppImageConfig.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AppImageConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the AppImageConfigArn property is set.
        /// </summary>
        internal bool IsSetAppImageConfigArn() => this.AppImageConfigArn != null;

        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig. Must be unique to your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string AppImageConfigName { get; set; }

        /// <summary>
        /// Checks to see if the AppImageConfigName property is set.
        /// </summary>
        internal bool IsSetAppImageConfigName() => this.AppImageConfigName != null;

        /// <summary>
        /// Gets and sets the property CodeEditorAppImageConfig. 
        /// <para>
        /// The configuration for the file system and the runtime, such as the environment variables
        /// and entry point.
        /// </para>
        /// </summary>
        public CodeEditorAppImageConfig CodeEditorAppImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the CodeEditorAppImageConfig property is set.
        /// </summary>
        internal bool IsSetCodeEditorAppImageConfig() => this.CodeEditorAppImageConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the AppImageConfig was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property JupyterLabAppImageConfig. 
        /// <para>
        /// The configuration for the file system and the runtime, such as the environment variables
        /// and entry point.
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
        /// The configuration for the file system and kernels in the SageMaker AI image.
        /// </para>
        /// </summary>
        public KernelGatewayImageConfig KernelGatewayImageConfig { get; set; }

        /// <summary>
        /// Checks to see if the KernelGatewayImageConfig property is set.
        /// </summary>
        internal bool IsSetKernelGatewayImageConfig() => this.KernelGatewayImageConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the AppImageConfig was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;
    }
}
