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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a deployment job that IoT Greengrass sends to a Greengrass
    /// core device.
    /// </summary>
    public partial class EffectiveDeployment
    {
        private EffectiveDeploymentExecutionStatus _coreDeviceExecutionStatus;
        private DateTime? _creationTimestamp;
        private string _deploymentId;
        private string _deploymentName;
        private string _description;
        private string _iotJobArn;
        private string _iotJobId;
        private DateTime? _modifiedTimestamp;
        private string _reason;
        private EffectiveDeploymentStatusDetails _statusDetails;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property CoreDeviceExecutionStatus. 
        /// <para>
        /// The status of the deployment job on the Greengrass core device.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> – The deployment job is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUEUED</code> – The deployment job is in the job queue and waiting to run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> – The deployment failed. For more information, see the <code>statusDetails</code>
        /// field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code> – The deployment to an IoT thing was completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMED_OUT</code> – The deployment didn't complete in the allotted time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELED</code> – The deployment was canceled by the user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REJECTED</code> – The deployment was rejected. For more information, see the
        /// <code>statusDetails</code> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code> – The deployment to an IoT thing group was completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EffectiveDeploymentExecutionStatus CoreDeviceExecutionStatus
        {
            get { return this._coreDeviceExecutionStatus; }
            set { this._coreDeviceExecutionStatus = value; }
        }

        // Check to see if CoreDeviceExecutionStatus property is set
        internal bool IsSetCoreDeviceExecutionStatus()
        {
            return this._coreDeviceExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the deployment was created, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }

        // Check to see if DeploymentName property is set
        internal bool IsSetDeploymentName()
        {
            return this._deploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
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
        /// Gets and sets the property IotJobArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IoT job that applies the deployment to target devices.
        /// </para>
        /// </summary>
        public string IotJobArn
        {
            get { return this._iotJobArn; }
            set { this._iotJobArn = value; }
        }

        // Check to see if IotJobArn property is set
        internal bool IsSetIotJobArn()
        {
            return this._iotJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property IotJobId. 
        /// <para>
        /// The ID of the IoT job that applies the deployment to target devices.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string IotJobId
        {
            get { return this._iotJobId; }
            set { this._iotJobId = value; }
        }

        // Check to see if IotJobId property is set
        internal bool IsSetIotJobId()
        {
            return this._iotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time at which the deployment job was last modified, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ModifiedTimestamp
        {
            get { return this._modifiedTimestamp.GetValueOrDefault(); }
            set { this._modifiedTimestamp = value; }
        }

        // Check to see if ModifiedTimestamp property is set
        internal bool IsSetModifiedTimestamp()
        {
            return this._modifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason code for the update, if the job was updated.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// The status details that explain why a deployment has an error. This response will
        /// be null if the deployment is in a success state.
        /// </para>
        /// </summary>
        public EffectiveDeploymentStatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target IoT thing or thing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}