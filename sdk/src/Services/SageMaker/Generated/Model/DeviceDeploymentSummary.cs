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
    /// Contains information summarizing device details and deployment status.
    /// </summary>
    public partial class DeviceDeploymentSummary
    {
        private string _deployedStageName;
        private DateTime? _deploymentStartTime;
        private string _description;
        private string _deviceArn;
        private DeviceDeploymentStatus _deviceDeploymentStatus;
        private string _deviceDeploymentStatusMessage;
        private string _deviceFleetName;
        private string _deviceName;
        private string _edgeDeploymentPlanArn;
        private string _edgeDeploymentPlanName;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property DeployedStageName. 
        /// <para>
        /// The name of the deployed stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeployedStageName
        {
            get { return this._deployedStageName; }
            set { this._deployedStageName = value; }
        }

        // Check to see if DeployedStageName property is set
        internal bool IsSetDeployedStageName()
        {
            return this._deployedStageName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStartTime. 
        /// <para>
        /// The time when the deployment on the device started.
        /// </para>
        /// </summary>
        public DateTime? DeploymentStartTime
        {
            get { return this._deploymentStartTime; }
            set { this._deploymentStartTime = value; }
        }

        // Check to see if DeploymentStartTime property is set
        internal bool IsSetDeploymentStartTime()
        {
            return this._deploymentStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDeploymentStatus. 
        /// <para>
        /// The deployment status of the device.
        /// </para>
        /// </summary>
        public DeviceDeploymentStatus DeviceDeploymentStatus
        {
            get { return this._deviceDeploymentStatus; }
            set { this._deviceDeploymentStatus = value; }
        }

        // Check to see if DeviceDeploymentStatus property is set
        internal bool IsSetDeviceDeploymentStatus()
        {
            return this._deviceDeploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDeploymentStatusMessage. 
        /// <para>
        /// The detailed error message for the deployoment status result.
        /// </para>
        /// </summary>
        public string DeviceDeploymentStatusMessage
        {
            get { return this._deviceDeploymentStatusMessage; }
            set { this._deviceDeploymentStatusMessage = value; }
        }

        // Check to see if DeviceDeploymentStatusMessage property is set
        internal bool IsSetDeviceDeploymentStatusMessage()
        {
            return this._deviceDeploymentStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet to which the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanArn. 
        /// <para>
        /// The ARN of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EdgeDeploymentPlanArn
        {
            get { return this._edgeDeploymentPlanArn; }
            set { this._edgeDeploymentPlanArn = value; }
        }

        // Check to see if EdgeDeploymentPlanArn property is set
        internal bool IsSetEdgeDeploymentPlanArn()
        {
            return this._edgeDeploymentPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeDeploymentPlanName
        {
            get { return this._edgeDeploymentPlanName; }
            set { this._edgeDeploymentPlanName = value; }
        }

        // Check to see if EdgeDeploymentPlanName property is set
        internal bool IsSetEdgeDeploymentPlanName()
        {
            return this._edgeDeploymentPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage in the edge deployment plan.
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