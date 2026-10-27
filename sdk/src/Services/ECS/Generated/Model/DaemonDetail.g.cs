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
    /// The detailed information about a daemon.
    /// </summary>
    public partial class DaemonDetail
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that the daemon is running in.
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
        /// The Unix timestamp for the time when the daemon was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentRevisions. 
        /// <para>
        /// The current daemon revision details, including the running task counts per capacity
        /// provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonRevisionDetail> CurrentRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonRevisionDetail>() : null;

        /// <summary>
        /// Checks to see if the CurrentRevisions property is set.
        /// </summary>
        internal bool IsSetCurrentRevisions() => this.CurrentRevisions != null && (this.CurrentRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the most recent daemon deployment.
        /// </para>
        /// </summary>
        public string DeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArn property is set.
        /// </summary>
        internal bool IsSetDeploymentArn() => this.DeploymentArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon.
        /// </para>
        /// </summary>
        public DaemonStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
