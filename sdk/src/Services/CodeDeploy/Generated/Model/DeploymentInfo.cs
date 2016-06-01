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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment.
    /// </summary>
    public partial class DeploymentInfo
    {
        private string _applicationName;
        private DateTime? _completeTime;
        private DateTime? _createTime;
        private DeploymentCreator _creator;
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private string _deploymentId;
        private DeploymentOverview _deploymentOverview;
        private string _description;
        private ErrorInformation _errorInformation;
        private bool? _ignoreApplicationStopFailures;
        private RevisionLocation _revision;
        private DateTime? _startTime;
        private DeploymentStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CompleteTime. 
        /// <para>
        /// A timestamp indicating when the deployment was complete.
        /// </para>
        /// </summary>
        public DateTime CompleteTime
        {
            get { return this._completeTime.GetValueOrDefault(); }
            set { this._completeTime = value; }
        }

        // Check to see if CompleteTime property is set
        internal bool IsSetCompleteTime()
        {
            return this._completeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// A timestamp indicating when the deployment was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Creator. 
        /// <para>
        /// The means by which the deployment was created:
        /// </para>
        ///  <ul> <li>user: A user created the deployment.</li> <li>autoscaling: Auto Scaling
        /// created the deployment.</li> </ul>
        /// </summary>
        public DeploymentCreator Creator
        {
            get { return this._creator; }
            set { this._creator = value; }
        }

        // Check to see if Creator property is set
        internal bool IsSetCreator()
        {
            return this._creator != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
        /// </para>
        /// </summary>
        public string DeploymentConfigName
        {
            get { return this._deploymentConfigName; }
            set { this._deploymentConfigName = value; }
        }

        // Check to see if DeploymentConfigName property is set
        internal bool IsSetDeploymentConfigName()
        {
            return this._deploymentConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The deployment group name.
        /// </para>
        /// </summary>
        public string DeploymentGroupName
        {
            get { return this._deploymentGroupName; }
            set { this._deploymentGroupName = value; }
        }

        // Check to see if DeploymentGroupName property is set
        internal bool IsSetDeploymentGroupName()
        {
            return this._deploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The deployment ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeploymentOverview. 
        /// <para>
        /// A summary of the deployment status of the instances in the deployment.
        /// </para>
        /// </summary>
        public DeploymentOverview DeploymentOverview
        {
            get { return this._deploymentOverview; }
            set { this._deploymentOverview = value; }
        }

        // Check to see if DeploymentOverview property is set
        internal bool IsSetDeploymentOverview()
        {
            return this._deploymentOverview != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A comment about the deployment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ErrorInformation. 
        /// <para>
        /// Information about any error associated with this deployment.
        /// </para>
        /// </summary>
        public ErrorInformation ErrorInformation
        {
            get { return this._errorInformation; }
            set { this._errorInformation = value; }
        }

        // Check to see if ErrorInformation property is set
        internal bool IsSetErrorInformation()
        {
            return this._errorInformation != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreApplicationStopFailures. 
        /// <para>
        /// If true, then if the deployment causes the ApplicationStop deployment lifecycle event
        /// to an instance to fail, the deployment to that instance will not be considered to
        /// have failed at that point and will continue on to the BeforeInstall deployment lifecycle
        /// event.
        /// </para>
        ///  
        /// <para>
        /// If false or not specified, then if the deployment causes the ApplicationStop deployment
        /// lifecycle event to an instance to fail, the deployment to that instance will stop,
        /// and the deployment to that instance will be considered to have failed.
        /// </para>
        /// </summary>
        public bool IgnoreApplicationStopFailures
        {
            get { return this._ignoreApplicationStopFailures.GetValueOrDefault(); }
            set { this._ignoreApplicationStopFailures = value; }
        }

        // Check to see if IgnoreApplicationStopFailures property is set
        internal bool IsSetIgnoreApplicationStopFailures()
        {
            return this._ignoreApplicationStopFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// Information about the location of stored application artifacts and the service from
        /// which to retrieve them.
        /// </para>
        /// </summary>
        public RevisionLocation Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp indicating when the deployment was deployed to the deployment group.
        /// </para>
        ///  
        /// <para>
        /// In some cases, the reported value of the start time may be later than the complete
        /// time. This is due to differences in the clock settings of back-end servers that participate
        /// in the deployment process.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the deployment as a whole.
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