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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a robot deployment.
    /// </summary>
    public partial class RobotDeployment
    {
        private string _arn;
        private DateTime? _deploymentFinishTime;
        private DateTime? _deploymentStartTime;
        private DeploymentJobErrorCode _failureCode;
        private string _failureReason;
        private ProgressDetail _progressDetail;
        private RobotStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The robot deployment Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentFinishTime. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the deployment finished.
        /// </para>
        /// </summary>
        public DateTime? DeploymentFinishTime
        {
            get { return this._deploymentFinishTime; }
            set { this._deploymentFinishTime = value; }
        }

        // Check to see if DeploymentFinishTime property is set
        internal bool IsSetDeploymentFinishTime()
        {
            return this._deploymentFinishTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStartTime. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the deployment was started.
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The robot deployment failure code.
        /// </para>
        /// </summary>
        public DeploymentJobErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A short description of the reason why the robot deployment failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressDetail. 
        /// <para>
        /// Information about how the deployment is progressing.
        /// </para>
        /// </summary>
        public ProgressDetail ProgressDetail
        {
            get { return this._progressDetail; }
            set { this._progressDetail = value; }
        }

        // Check to see if ProgressDetail property is set
        internal bool IsSetProgressDetail()
        {
            return this._progressDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the robot deployment.
        /// </para>
        /// </summary>
        public RobotStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}