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
        private string _additionalDeploymentStatusInfo;
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private BlueGreenDeploymentConfiguration _blueGreenDeploymentConfiguration;
        private DateTime? _completeTime;
        private DateTime? _createTime;
        private DeploymentCreator _creator;
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private string _deploymentId;
        private DeploymentOverview _deploymentOverview;
        private DeploymentStyle _deploymentStyle;
        private string _description;
        private ErrorInformation _errorInformation;
        private bool? _ignoreApplicationStopFailures;
        private bool? _instanceTerminationWaitTimeStarted;
        private LoadBalancerInfo _loadBalancerInfo;
        private RevisionLocation _revision;
        private RollbackInfo _rollbackInfo;
        private DateTime? _startTime;
        private DeploymentStatus _status;
        private TargetInstances _targetInstances;
        private bool? _updateOutdatedInstancesOnly;

        /// <summary>
        /// Gets and sets the property AdditionalDeploymentStatusInfo. 
        /// <para>
        /// Provides information about the results of a deployment, such as whether instances
        /// in the original environment in a blue/green deployment were not terminated.
        /// </para>
        /// </summary>
        public string AdditionalDeploymentStatusInfo
        {
            get { return this._additionalDeploymentStatusInfo; }
            set { this._additionalDeploymentStatusInfo = value; }
        }

        // Check to see if AdditionalDeploymentStatusInfo property is set
        internal bool IsSetAdditionalDeploymentStatusInfo()
        {
            return this._additionalDeploymentStatusInfo != null;
        }

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
        /// Gets and sets the property AutoRollbackConfiguration. 
        /// <para>
        /// Information about the automatic rollback configuration associated with the deployment.
        /// </para>
        /// </summary>
        public AutoRollbackConfiguration AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentConfiguration. 
        /// <para>
        /// Information about blue/green deployment options for this deployment.
        /// </para>
        /// </summary>
        public BlueGreenDeploymentConfiguration BlueGreenDeploymentConfiguration
        {
            get { return this._blueGreenDeploymentConfiguration; }
            set { this._blueGreenDeploymentConfiguration = value; }
        }

        // Check to see if BlueGreenDeploymentConfiguration property is set
        internal bool IsSetBlueGreenDeploymentConfiguration()
        {
            return this._blueGreenDeploymentConfiguration != null;
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
        ///  <ul> <li> 
        /// <para>
        /// user: A user created the deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// autoscaling: Auto Scaling created the deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// codeDeployRollback: A rollback process created the deployment.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property DeploymentStyle. 
        /// <para>
        /// Information about the type of deployment, either standard or blue/green, you want
        /// to run and whether to route deployment traffic behind a load balancer.
        /// </para>
        /// </summary>
        public DeploymentStyle DeploymentStyle
        {
            get { return this._deploymentStyle; }
            set { this._deploymentStyle = value; }
        }

        // Check to see if DeploymentStyle property is set
        internal bool IsSetDeploymentStyle()
        {
            return this._deploymentStyle != null;
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
        /// Gets and sets the property InstanceTerminationWaitTimeStarted. 
        /// <para>
        /// Indicates whether the wait period set for the termination of instances in the original
        /// environment has started. Status is 'false' if the KEEP_ALIVE option is specified;
        /// otherwise, 'true' as soon as the termination wait period starts.
        /// </para>
        /// </summary>
        public bool InstanceTerminationWaitTimeStarted
        {
            get { return this._instanceTerminationWaitTimeStarted.GetValueOrDefault(); }
            set { this._instanceTerminationWaitTimeStarted = value; }
        }

        // Check to see if InstanceTerminationWaitTimeStarted property is set
        internal bool IsSetInstanceTerminationWaitTimeStarted()
        {
            return this._instanceTerminationWaitTimeStarted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerInfo. 
        /// <para>
        /// Information about the load balancer used in this blue/green deployment.
        /// </para>
        /// </summary>
        public LoadBalancerInfo LoadBalancerInfo
        {
            get { return this._loadBalancerInfo; }
            set { this._loadBalancerInfo = value; }
        }

        // Check to see if LoadBalancerInfo property is set
        internal bool IsSetLoadBalancerInfo()
        {
            return this._loadBalancerInfo != null;
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
        /// Gets and sets the property RollbackInfo. 
        /// <para>
        /// Information about a deployment rollback.
        /// </para>
        /// </summary>
        public RollbackInfo RollbackInfo
        {
            get { return this._rollbackInfo; }
            set { this._rollbackInfo = value; }
        }

        // Check to see if RollbackInfo property is set
        internal bool IsSetRollbackInfo()
        {
            return this._rollbackInfo != null;
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

        /// <summary>
        /// Gets and sets the property TargetInstances. 
        /// <para>
        /// Information about the instances that belong to the replacement environment in a blue/green
        /// deployment.
        /// </para>
        /// </summary>
        public TargetInstances TargetInstances
        {
            get { return this._targetInstances; }
            set { this._targetInstances = value; }
        }

        // Check to see if TargetInstances property is set
        internal bool IsSetTargetInstances()
        {
            return this._targetInstances != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateOutdatedInstancesOnly. 
        /// <para>
        /// Indicates whether only instances that are not running the latest application revision
        /// are to be deployed to.
        /// </para>
        /// </summary>
        public bool UpdateOutdatedInstancesOnly
        {
            get { return this._updateOutdatedInstancesOnly.GetValueOrDefault(); }
            set { this._updateOutdatedInstancesOnly = value; }
        }

        // Check to see if UpdateOutdatedInstancesOnly property is set
        internal bool IsSetUpdateOutdatedInstancesOnly()
        {
            return this._updateOutdatedInstancesOnly.HasValue; 
        }

    }
}