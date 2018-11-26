/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeDeploymentJob operation.
    /// </summary>
    public partial class DescribeDeploymentJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<DeploymentApplicationConfig> _deploymentApplicationConfigs = new List<DeploymentApplicationConfig>();
        private DeploymentConfig _deploymentConfig;
        private DeploymentJobErrorCode _failureCode;
        private string _failureReason;
        private string _fleet;
        private List<RobotDeployment> _robotDeploymentSummary = new List<RobotDeployment>();
        private DeploymentStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment job.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the deployment job was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentApplicationConfigs. 
        /// <para>
        /// The deployment application configuration.
        /// </para>
        /// </summary>
        public List<DeploymentApplicationConfig> DeploymentApplicationConfigs
        {
            get { return this._deploymentApplicationConfigs; }
            set { this._deploymentApplicationConfigs = value; }
        }

        // Check to see if DeploymentApplicationConfigs property is set
        internal bool IsSetDeploymentApplicationConfigs()
        {
            return this._deploymentApplicationConfigs != null && this._deploymentApplicationConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig
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
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The deployment job failure code.
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
        /// A short description of the reason why the deployment job failed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Fleet. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
        /// </para>
        /// </summary>
        public string Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

        /// <summary>
        /// Gets and sets the property RobotDeploymentSummary. 
        /// <para>
        /// A list of robot deployment summaries.
        /// </para>
        /// </summary>
        public List<RobotDeployment> RobotDeploymentSummary
        {
            get { return this._robotDeploymentSummary; }
            set { this._robotDeploymentSummary = value; }
        }

        // Check to see if RobotDeploymentSummary property is set
        internal bool IsSetRobotDeploymentSummary()
        {
            return this._robotDeploymentSummary != null && this._robotDeploymentSummary.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment job.
        /// </para>
        /// </summary>
        public DeploymentStatus Status
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