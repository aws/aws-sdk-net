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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that apply to users of Amazon SageMaker Studio. These settings
    /// are specified when the <code>CreateUserProfile</code> API is called, and as <code>DefaultUserSettings</code>
    /// when the <code>CreateDomain</code> API is called.
    /// 
    ///  
    /// <para>
    ///  <code>SecurityGroups</code> is aggregated when specified in both calls. For all other
    /// settings in <code>UserSettings</code>, the values specified in <code>CreateUserProfile</code>
    /// take precedence over those specified in <code>CreateDomain</code>.
    /// </para>
    /// </summary>
    public partial class UserSettings
    {
        private CanvasAppSettings _canvasAppSettings;
        private string _executionRole;
        private JupyterServerAppSettings _jupyterServerAppSettings;
        private KernelGatewayAppSettings _kernelGatewayAppSettings;
        private RSessionAppSettings _rSessionAppSettings;
        private RStudioServerProAppSettings _rStudioServerProAppSettings;
        private List<string> _securityGroups = new List<string>();
        private SharingSettings _sharingSettings;
        private TensorBoardAppSettings _tensorBoardAppSettings;

        /// <summary>
        /// Gets and sets the property CanvasAppSettings. 
        /// <para>
        /// The Canvas app settings.
        /// </para>
        /// </summary>
        public CanvasAppSettings CanvasAppSettings
        {
            get { return this._canvasAppSettings; }
            set { this._canvasAppSettings = value; }
        }

        // Check to see if CanvasAppSettings property is set
        internal bool IsSetCanvasAppSettings()
        {
            return this._canvasAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings. 
        /// <para>
        /// The Jupyter server's app settings.
        /// </para>
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
        /// <para>
        /// The kernel gateway app settings.
        /// </para>
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
        /// Gets and sets the property RSessionAppSettings. 
        /// <para>
        /// A collection of settings that configure the <code>RSessionGateway</code> app.
        /// </para>
        /// </summary>
        public RSessionAppSettings RSessionAppSettings
        {
            get { return this._rSessionAppSettings; }
            set { this._rSessionAppSettings = value; }
        }

        // Check to see if RSessionAppSettings property is set
        internal bool IsSetRSessionAppSettings()
        {
            return this._rSessionAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RStudioServerProAppSettings. 
        /// <para>
        /// A collection of settings that configure user interaction with the <code>RStudioServerPro</code>
        /// app.
        /// </para>
        /// </summary>
        public RStudioServerProAppSettings RStudioServerProAppSettings
        {
            get { return this._rStudioServerProAppSettings; }
            set { this._rStudioServerProAppSettings = value; }
        }

        // Check to see if RStudioServerProAppSettings property is set
        internal bool IsSetRStudioServerProAppSettings()
        {
            return this._rStudioServerProAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud (VPC) that Studio uses for
        /// communication.
        /// </para>
        ///  
        /// <para>
        /// Optional when the <code>CreateDomain.AppNetworkAccessType</code> parameter is set
        /// to <code>PublicInternetOnly</code>.
        /// </para>
        ///  
        /// <para>
        /// Required when the <code>CreateDomain.AppNetworkAccessType</code> parameter is set
        /// to <code>VpcOnly</code>, unless specified as part of the <code>DefaultUserSettings</code>
        /// for the domain.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker adds a security group to allow NFS traffic from SageMaker Studio.
        /// Therefore, the number of security groups that you can specify is one less than the
        /// maximum number shown.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SharingSettings. 
        /// <para>
        /// Specifies options for sharing SageMaker Studio notebooks.
        /// </para>
        /// </summary>
        public SharingSettings SharingSettings
        {
            get { return this._sharingSettings; }
            set { this._sharingSettings = value; }
        }

        // Check to see if SharingSettings property is set
        internal bool IsSetSharingSettings()
        {
            return this._sharingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property TensorBoardAppSettings. 
        /// <para>
        /// The TensorBoard app settings.
        /// </para>
        /// </summary>
        public TensorBoardAppSettings TensorBoardAppSettings
        {
            get { return this._tensorBoardAppSettings; }
            set { this._tensorBoardAppSettings = value; }
        }

        // Check to see if TensorBoardAppSettings property is set
        internal bool IsSetTensorBoardAppSettings()
        {
            return this._tensorBoardAppSettings != null;
        }

    }
}