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
    /// Information about a daemon deployment. A daemon deployment orchestrates the progressive
    /// rollout of daemon task updates across container instances.
    /// </summary>
    public partial class DaemonDeployment
    {
        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms that determine when a daemon deployment fails.
        /// </para>
        /// </summary>
        public DaemonDeploymentAlarms Alarms { get; set; }

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null;

        /// <summary>
        /// Gets and sets the property CircuitBreaker. 
        /// <para>
        /// The circuit breaker configuration that determines when a daemon deployment has failed.
        /// </para>
        /// </summary>
        public DaemonCircuitBreaker CircuitBreaker { get; set; }

        /// <summary>
        /// Checks to see if the CircuitBreaker property is set.
        /// </summary>
        internal bool IsSetCircuitBreaker() => this.CircuitBreaker != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that hosts the daemon.
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
        /// The time the daemon deployment was created. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DaemonDeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon deployment.
        /// </para>
        /// </summary>
        public string DaemonDeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonDeploymentArn property is set.
        /// </summary>
        internal bool IsSetDaemonDeploymentArn() => this.DaemonDeploymentArn != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The deployment configuration used for this daemon deployment.
        /// </para>
        /// </summary>
        public DaemonDeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the daemon deployment finished. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// The rollback options for the daemon deployment.
        /// </para>
        /// </summary>
        public DaemonRollback Rollback { get; set; }

        /// <summary>
        /// Checks to see if the Rollback property is set.
        /// </summary>
        internal bool IsSetRollback() => this.Rollback != null;

        /// <summary>
        /// Gets and sets the property SourceDaemonRevisions. 
        /// <para>
        /// The currently deployed daemon revisions that are being replaced.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonDeploymentRevisionDetail> SourceDaemonRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonDeploymentRevisionDetail>() : null;

        /// <summary>
        /// Checks to see if the SourceDaemonRevisions property is set.
        /// </summary>
        internal bool IsSetSourceDaemonRevisions() => this.SourceDaemonRevisions != null && (this.SourceDaemonRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the daemon deployment started. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
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
        /// The status of the daemon deployment.
        /// </para>
        /// </summary>
        public DaemonDeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Information about why the daemon deployment is in the current status.
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
        /// The time the daemon deployment stopped. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetDaemonRevision. 
        /// <para>
        /// The daemon revision being deployed.
        /// </para>
        /// </summary>
        public DaemonDeploymentRevisionDetail TargetDaemonRevision { get; set; }

        /// <summary>
        /// Checks to see if the TargetDaemonRevision property is set.
        /// </summary>
        internal bool IsSetTargetDaemonRevision() => this.TargetDaemonRevision != null;
    }
}
