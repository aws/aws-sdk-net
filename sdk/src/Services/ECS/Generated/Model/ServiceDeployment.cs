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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Information about the service deployment.
    /// 
    ///  
    /// <para>
    /// Service deployments provide a comprehensive view of your deployments. For information
    /// about service deployments, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-deployment.html">View
    /// service history using Amazon ECS service deployments</a> in the <i> <i>Amazon Elastic
    /// Container Service Developer Guide</i> </i>.
    /// </para>
    /// </summary>
    public partial class ServiceDeployment
    {
        private ServiceDeploymentAlarms _alarms;
        private string _clusterArn;
        private DateTime? _createdAt;
        private ServiceDeploymentCircuitBreaker _deploymentCircuitBreaker;
        private DeploymentConfiguration _deploymentConfiguration;
        private DateTime? _finishedAt;
        private Rollback _rollback;
        private string _serviceArn;
        private string _serviceDeploymentArn;
        private List<ServiceRevisionSummary> _sourceServiceRevisions = AWSConfigs.InitializeCollections ? new List<ServiceRevisionSummary>() : null;
        private DateTime? _startedAt;
        private ServiceDeploymentStatus _status;
        private string _statusReason;
        private DateTime? _stoppedAt;
        private ServiceRevisionSummary _targetServiceRevision;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms that determine when a service deployment fails.
        /// </para>
        /// </summary>
        public ServiceDeploymentAlarms Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the cluster that hosts the service.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the service deployment was created. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// Gets and sets the property DeploymentCircuitBreaker. 
        /// <para>
        /// The circuit breaker configuration that determines a service deployment failed.
        /// </para>
        /// </summary>
        public ServiceDeploymentCircuitBreaker DeploymentCircuitBreaker
        {
            get { return this._deploymentCircuitBreaker; }
            set { this._deploymentCircuitBreaker = value; }
        }

        // Check to see if DeploymentCircuitBreaker property is set
        internal bool IsSetDeploymentCircuitBreaker()
        {
            return this._deploymentCircuitBreaker != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration.
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the service deployment finished. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime FinishedAt
        {
            get { return this._finishedAt.GetValueOrDefault(); }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// The rollback options the service deployment uses when the deployment fails.
        /// </para>
        /// </summary>
        public Rollback Rollback
        {
            get { return this._rollback; }
            set { this._rollback = value; }
        }

        // Check to see if Rollback property is set
        internal bool IsSetRollback()
        {
            return this._rollback != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service for this service deployment.
        /// </para>
        /// </summary>
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceDeploymentArn. 
        /// <para>
        /// The ARN of the service deployment.
        /// </para>
        /// </summary>
        public string ServiceDeploymentArn
        {
            get { return this._serviceDeploymentArn; }
            set { this._serviceDeploymentArn = value; }
        }

        // Check to see if ServiceDeploymentArn property is set
        internal bool IsSetServiceDeploymentArn()
        {
            return this._serviceDeploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServiceRevisions. 
        /// <para>
        /// The currently deployed workload configuration.
        /// </para>
        /// </summary>
        public List<ServiceRevisionSummary> SourceServiceRevisions
        {
            get { return this._sourceServiceRevisions; }
            set { this._sourceServiceRevisions = value; }
        }

        // Check to see if SourceServiceRevisions property is set
        internal bool IsSetSourceServiceRevisions()
        {
            return this._sourceServiceRevisions != null && (this._sourceServiceRevisions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the service deployment statred. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The service deployment state.
        /// </para>
        /// </summary>
        public ServiceDeploymentStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the service deployment is in the current status. For example,
        /// the circuit breaker detected a failure.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The time the service deployment stopped. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        ///  
        /// <para>
        /// The service deployment stops when any of the following actions happen:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A user manually stops the deployment
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rollback option is not in use for the failure detection mechanism (the circuit
        /// breaker or alarm-based) and the service fails.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetServiceRevision. 
        /// <para>
        /// The workload configuration being deployed.
        /// </para>
        /// </summary>
        public ServiceRevisionSummary TargetServiceRevision
        {
            get { return this._targetServiceRevision; }
            set { this._targetServiceRevision = value; }
        }

        // Check to see if TargetServiceRevision property is set
        internal bool IsSetTargetServiceRevision()
        {
            return this._targetServiceRevision != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time that the service deployment was last updated. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}