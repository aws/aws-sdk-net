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
    /// Contains information summarizing device details and deployment status.
    /// </summary>
    public partial class DeviceDeploymentSummary
    {
        /// <summary>
        /// Gets and sets the property DeployedStageName. 
        /// <para>
        /// The name of the deployed stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DeployedStageName { get; set; }

        /// <summary>
        /// Checks to see if the DeployedStageName property is set.
        /// </summary>
        internal bool IsSetDeployedStageName() => this.DeployedStageName != null;

        /// <summary>
        /// Gets and sets the property DeploymentStartTime. 
        /// <para>
        /// The time when the deployment on the device started.
        /// </para>
        /// </summary>
        public DateTime? DeploymentStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStartTime property is set.
        /// </summary>
        internal bool IsSetDeploymentStartTime() => this.DeploymentStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property DeviceDeploymentStatus. 
        /// <para>
        /// The deployment status of the device.
        /// </para>
        /// </summary>
        public DeviceDeploymentStatus DeviceDeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeviceDeploymentStatus() => this.DeviceDeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property DeviceDeploymentStatusMessage. 
        /// <para>
        /// The detailed error message for the deployoment status result.
        /// </para>
        /// </summary>
        public string DeviceDeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeviceDeploymentStatusMessage() => this.DeviceDeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet to which the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanArn. 
        /// <para>
        /// The ARN of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EdgeDeploymentPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPlanArn property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPlanArn() => this.EdgeDeploymentPlanArn != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string EdgeDeploymentPlanName { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPlanName property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPlanName() => this.EdgeDeploymentPlanName != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage in the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string StageName { get; set; }

        /// <summary>
        /// Checks to see if the StageName property is set.
        /// </summary>
        internal bool IsSetStageName() => this.StageName != null;
    }
}
