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
    /// A summary of a daemon deployment.
    /// </summary>
    public partial class DaemonDeploymentSummary
    {
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
        /// The time the daemon deployment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon.
        /// </para>
        /// </summary>
        public string DaemonArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonArn property is set.
        /// </summary>
        internal bool IsSetDaemonArn() => this.DaemonArn != null;

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
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The time the daemon deployment finished.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the daemon deployment started.
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
        /// The time the daemon deployment stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetDaemonRevisionArn. 
        /// <para>
        /// The ARN of the daemon revision being deployed.
        /// </para>
        /// </summary>
        public string TargetDaemonRevisionArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetDaemonRevisionArn property is set.
        /// </summary>
        internal bool IsSetTargetDaemonRevisionArn() => this.TargetDaemonRevisionArn != null;
    }
}
