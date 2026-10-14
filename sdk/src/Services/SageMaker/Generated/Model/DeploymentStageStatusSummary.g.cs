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
    /// Contains information summarizing the deployment stage results.
    /// </summary>
    public partial class DeploymentStageStatusSummary
    {
        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// Configuration of the deployment details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdgeDeploymentConfig DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// General status of the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdgeDeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property DeviceSelectionConfig. 
        /// <para>
        /// Configuration of the devices in the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeviceSelectionConfig DeviceSelectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeviceSelectionConfig property is set.
        /// </summary>
        internal bool IsSetDeviceSelectionConfig() => this.DeviceSelectionConfig != null;

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage.
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
