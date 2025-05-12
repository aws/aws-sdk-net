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
    /// This is the response object from the DescribeAppImageConfig operation.
    /// </summary>
    public partial class DescribeAppImageConfigResponse : AmazonWebServiceResponse
    {
        private string _appImageConfigArn;
        private string _appImageConfigName;
        private CodeEditorAppImageConfig _codeEditorAppImageConfig;
        private DateTime? _creationTime;
        private JupyterLabAppImageConfig _jupyterLabAppImageConfig;
        private KernelGatewayImageConfig _kernelGatewayImageConfig;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property AppImageConfigArn. 
        /// <para>
        /// The ARN of the AppImageConfig.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AppImageConfigArn
        {
            get { return this._appImageConfigArn; }
            set { this._appImageConfigArn = value; }
        }

        // Check to see if AppImageConfigArn property is set
        internal bool IsSetAppImageConfigArn()
        {
            return this._appImageConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
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
        /// The configuration of the Code Editor app.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the AppImageConfig was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JupyterLabAppImageConfig. 
        /// <para>
        /// The configuration of the JupyterLab app.
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
        /// The configuration of a KernelGateway app.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the AppImageConfig was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}