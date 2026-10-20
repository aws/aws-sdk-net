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
        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms that determine when a service deployment fails.
        /// </para>
        /// </summary>
        public ServiceDeploymentAlarms Alarms { get; set; }

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the cluster that hosts the service.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the service deployment was created. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentCircuitBreaker. 
        /// <para>
        /// The circuit breaker configuration that determines a service deployment failed.
        /// </para>
        /// </summary>
        public ServiceDeploymentCircuitBreaker DeploymentCircuitBreaker { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentCircuitBreaker property is set.
        /// </summary>
        internal bool IsSetDeploymentCircuitBreaker() => this.DeploymentCircuitBreaker != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration.
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the service deployment finished. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleHookDetails. 
        /// <para>
        /// The details of the lifecycle hooks for the current service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentLifecycleHookDetail> LifecycleHookDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentLifecycleHookDetail>() : null;

        /// <summary>
        /// Checks to see if the LifecycleHookDetails property is set.
        /// </summary>
        internal bool IsSetLifecycleHookDetails() => this.LifecycleHookDetails != null && (this.LifecycleHookDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The current lifecycle stage of the deployment. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RECONCILE_SERVICE
        /// </para>
        ///  
        /// <para>
        /// The reconciliation stage that only happens when you start a new service deployment
        /// with more than 1 service revision in an ACTIVE state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRE_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has not started. The blue service revision is handling
        /// 100% of the production traffic. There is no test traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The stage when the green service revision scales up to 100% and launches new tasks.
        /// The green service revision is not serving any traffic at this point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has started. The blue service revision is handling 100%
        /// of the production traffic. There is no test traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The blue and green service revisions are running. The blue service revision handles
        /// 100% of the production traffic. The green service revision is migrating from 0% to
        /// 100% of test traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The test traffic shift is complete. The green service revision handles 100% of the
        /// test traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRE_PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// Occurs before production traffic shift. For linear and canary deployments, this stage
        /// is invoked before every traffic shift step.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// Production traffic is shifting to the green service revision. The green service revision
        /// is migrating from 0% to 100% of production traffic. For linear and canary deployments,
        /// this stage is invoked at every traffic shift step.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The production traffic shift is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BAKE_TIME
        /// </para>
        ///  
        /// <para>
        /// The stage when both blue and green service revisions are running simultaneously after
        /// the production traffic has shifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLEAN_UP
        /// </para>
        ///  
        /// <para>
        /// The stage when the blue service revision has completely scaled down to 0 running tasks.
        /// The green service revision is now the production service revision after this stage.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ServiceDeploymentLifecycleStage LifecycleStage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStage property is set.
        /// </summary>
        internal bool IsSetLifecycleStage() => this.LifecycleStage != null;

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// The rollback options the service deployment uses when the deployment fails.
        /// </para>
        /// </summary>
        public Rollback Rollback { get; set; }

        /// <summary>
        /// Checks to see if the Rollback property is set.
        /// </summary>
        internal bool IsSetRollback() => this.Rollback != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service for this service deployment.
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceDeploymentArn. 
        /// <para>
        /// The ARN of the service deployment.
        /// </para>
        /// </summary>
        public string ServiceDeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDeploymentArn property is set.
        /// </summary>
        internal bool IsSetServiceDeploymentArn() => this.ServiceDeploymentArn != null;

        /// <summary>
        /// Gets and sets the property SourceServiceRevisions. 
        /// <para>
        /// The currently deployed workload configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceRevisionSummary> SourceServiceRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceRevisionSummary>() : null;

        /// <summary>
        /// Checks to see if the SourceServiceRevisions property is set.
        /// </summary>
        internal bool IsSetSourceServiceRevisions() => this.SourceServiceRevisions != null && (this.SourceServiceRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the service deployment statred. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The service deployment state.
        /// </para>
        /// </summary>
        public ServiceDeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the service deployment is in the current status. For example,
        /// the circuit breaker detected a failure.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

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
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetServiceRevision. 
        /// <para>
        /// The workload configuration being deployed.
        /// </para>
        /// </summary>
        public ServiceRevisionSummary TargetServiceRevision { get; set; }

        /// <summary>
        /// Checks to see if the TargetServiceRevision property is set.
        /// </summary>
        internal bool IsSetTargetServiceRevision() => this.TargetServiceRevision != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time that the service deployment was last updated. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
