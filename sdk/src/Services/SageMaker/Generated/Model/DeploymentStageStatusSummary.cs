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
    /// Contains information summarizing the deployment stage results.
    /// </summary>
    public partial class DeploymentStageStatusSummary
    {
        private EdgeDeploymentConfig _deploymentConfig;
        private EdgeDeploymentStatus _deploymentStatus;
        private DeviceSelectionConfig _deviceSelectionConfig;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// Configuration of the deployment details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgeDeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// General status of the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgeDeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSelectionConfig. 
        /// <para>
        /// Configuration of the devices in the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceSelectionConfig DeviceSelectionConfig
        {
            get { return this._deviceSelectionConfig; }
            set { this._deviceSelectionConfig = value; }
        }

        // Check to see if DeviceSelectionConfig property is set
        internal bool IsSetDeviceSelectionConfig()
        {
            return this._deviceSelectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}