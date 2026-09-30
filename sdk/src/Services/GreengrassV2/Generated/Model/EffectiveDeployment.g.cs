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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a deployment job that IoT Greengrass sends to a Greengrass
    /// core device.
    /// </summary>
    public partial class EffectiveDeployment
    {
        /// <summary>
        /// Gets and sets the property CoreDeviceExecutionStatus. 
        /// <para>
        /// The status of the deployment job on the Greengrass core device.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> – The deployment job is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUEUED</c> – The deployment job is in the job queue and waiting to run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The deployment failed. For more information, see the <c>statusDetails</c>
        /// field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> – The deployment to an IoT thing was completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMED_OUT</c> – The deployment didn't complete in the allotted time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> – The deployment was canceled by the user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> – The deployment was rejected. For more information, see the <c>statusDetails</c>
        /// field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> – The deployment to an IoT thing group was completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EffectiveDeploymentExecutionStatus CoreDeviceExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CoreDeviceExecutionStatus property is set.
        /// </summary>
        internal bool IsSetCoreDeviceExecutionStatus() => this.CoreDeviceExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the deployment was created, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentName property is set.
        /// </summary>
        internal bool IsSetDeploymentName() => this.DeploymentName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IotJobArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IoT job that applies the deployment to target devices.
        /// </para>
        /// </summary>
        public string IotJobArn { get; set; }

        /// <summary>
        /// Checks to see if the IotJobArn property is set.
        /// </summary>
        internal bool IsSetIotJobArn() => this.IotJobArn != null;

        /// <summary>
        /// Gets and sets the property IotJobId. 
        /// <para>
        /// The ID of the IoT job that applies the deployment to target devices.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string IotJobId { get; set; }

        /// <summary>
        /// Checks to see if the IotJobId property is set.
        /// </summary>
        internal bool IsSetIotJobId() => this.IotJobId != null;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time at which the deployment job was last modified, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetModifiedTimestamp() => this.ModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason code for the update, if the job was updated.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// The status details that explain why a deployment has an error. This response will
        /// be null if the deployment is in a success state.
        /// </para>
        /// </summary>
        public EffectiveDeploymentStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target IoT thing or thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;
    }
}
