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
    /// Information about a daemon revision. A daemon revision is a snapshot of the daemon's
    /// configuration at the time a deployment was initiated.
    /// </summary>
    public partial class DaemonRevision
    {
        private string _clusterArn;
        private List<DaemonContainerImage> _containerImages = AWSConfigs.InitializeCollections ? new List<DaemonContainerImage>() : null;
        private DateTime? _createdAt;
        private string _daemonArn;
        private string _daemonRevisionArn;
        private string _daemonTaskDefinitionArn;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private DaemonPropagateTags _propagateTags;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that hosts the daemon.
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
        /// Gets and sets the property ContainerImages. 
        /// <para>
        /// The container images used by the daemon revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonContainerImage> ContainerImages
        {
            get { return this._containerImages; }
            set { this._containerImages = value; }
        }

        // Check to see if ContainerImages property is set
        internal bool IsSetContainerImages()
        {
            return this._containerImages != null && (this._containerImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon revision was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon for this revision.
        /// </para>
        /// </summary>
        public string DaemonArn
        {
            get { return this._daemonArn; }
            set { this._daemonArn = value; }
        }

        // Check to see if DaemonArn property is set
        internal bool IsSetDaemonArn()
        {
            return this._daemonArn != null;
        }

        /// <summary>
        /// Gets and sets the property DaemonRevisionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon revision.
        /// </para>
        /// </summary>
        public string DaemonRevisionArn
        {
            get { return this._daemonRevisionArn; }
            set { this._daemonRevisionArn = value; }
        }

        // Check to see if DaemonRevisionArn property is set
        internal bool IsSetDaemonRevisionArn()
        {
            return this._daemonRevisionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon task definition used by this revision.
        /// </para>
        /// </summary>
        public string DaemonTaskDefinitionArn
        {
            get { return this._daemonTaskDefinitionArn; }
            set { this._daemonTaskDefinitionArn = value; }
        }

        // Check to see if DaemonTaskDefinitionArn property is set
        internal bool IsSetDaemonTaskDefinitionArn()
        {
            return this._daemonTaskDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether Amazon ECS managed tags are turned on for the daemon tasks.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags
        {
            get { return this._enableecsManagedTags; }
            set { this._enableecsManagedTags = value; }
        }

        // Check to see if EnableECSManagedTags property is set
        internal bool IsSetEnableECSManagedTags()
        {
            return this._enableecsManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Specifies whether the execute command functionality is turned on for the daemon tasks.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand
        {
            get { return this._enableExecuteCommand; }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether tags are propagated from the daemon to the daemon tasks.
        /// </para>
        /// </summary>
        public DaemonPropagateTags PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

    }
}