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
    /// Information about a daemon revision. A daemon revision is a snapshot of the daemon's
    /// configuration at the time a deployment was initiated.
    /// </summary>
    public partial class DaemonRevision
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
        /// Gets and sets the property ContainerImages. 
        /// <para>
        /// The container images used by the daemon revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonContainerImage> ContainerImages { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonContainerImage>() : null;

        /// <summary>
        /// Checks to see if the ContainerImages property is set.
        /// </summary>
        internal bool IsSetContainerImages() => this.ContainerImages != null && (this.ContainerImages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon revision was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// If the <c>critical</c> parameter of this daemon revision is <c>true</c>, and the daemon
        /// task fails, stops, or becomes unhealthy, Amazon ECS drains the container instance
        /// and stops the other tasks running on it. If the parameter is <c>false</c>, the daemon
        /// task failure doesn't affect the other tasks on the instance, and doesn't block instance
        /// registration. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon for this revision.
        /// </para>
        /// </summary>
        public string DaemonArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonArn property is set.
        /// </summary>
        internal bool IsSetDaemonArn() => this.DaemonArn != null;

        /// <summary>
        /// Gets and sets the property DaemonRevisionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon revision.
        /// </para>
        /// </summary>
        public string DaemonRevisionArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonRevisionArn property is set.
        /// </summary>
        internal bool IsSetDaemonRevisionArn() => this.DaemonRevisionArn != null;

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon task definition used by this revision.
        /// </para>
        /// </summary>
        public string DaemonTaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonTaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetDaemonTaskDefinitionArn() => this.DaemonTaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether Amazon ECS managed tags are turned on for the daemon tasks.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags { get; set; }

        /// <summary>
        /// Checks to see if the EnableECSManagedTags property is set.
        /// </summary>
        internal bool IsSetEnableECSManagedTags() => this.EnableECSManagedTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Specifies whether the execute command functionality is turned on for the daemon tasks.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether tags are propagated from the daemon to the daemon tasks.
        /// </para>
        /// </summary>
        public DaemonPropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;
    }
}
