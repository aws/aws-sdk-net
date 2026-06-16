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
    /// Container for the parameters to the CreateDaemon operation.
    /// Creates a new daemon in the specified cluster and capacity providers. A daemon deploys
    /// cross-cutting software agents such as security monitoring, telemetry, and logging
    /// independently across your Amazon ECS infrastructure.
    /// 
    ///  
    /// <para>
    /// Amazon ECS deploys exactly one daemon task on each container instance of the specified
    /// capacity providers. When a container instance registers with the cluster, Amazon ECS
    /// automatically starts daemon tasks. Amazon ECS starts a daemon task before scheduling
    /// other tasks.
    /// </para>
    ///  
    /// <para>
    /// Daemons are essential for instance health - if a daemon task stops, Amazon ECS automatically
    /// drains and replaces that container instance.
    /// </para>
    ///  <note> 
    /// <para>
    /// ECS Managed Daemons is only supported for Amazon ECS Managed Instances Capacity Providers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDaemonRequest : AmazonECSRequest
    {
        private List<string> _capacityProviderArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _clusterArn;
        private string _daemonName;
        private string _daemonTaskDefinitionArn;
        private DaemonDeploymentConfiguration _deploymentConfiguration;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private DaemonPropagateTags _propagateTags;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CapacityProviderArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the capacity providers to associate with the daemon.
        /// The daemon deploys tasks on container instances managed by these capacity providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CapacityProviderArns
        {
            get { return this._capacityProviderArns; }
            set { this._capacityProviderArns = value; }
        }

        // Check to see if CapacityProviderArns property is set
        internal bool IsSetCapacityProviderArns()
        {
            return this._capacityProviderArns != null && (this._capacityProviderArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An identifier that you provide to ensure the idempotency of the request. It must be
        /// unique and is case sensitive. Up to 36 ASCII characters in the range of 33-126 (inclusive)
        /// are allowed.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to create the daemon in.
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
        /// Gets and sets the property DaemonName. 
        /// <para>
        /// The name of the daemon. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DaemonName
        {
            get { return this._daemonName; }
            set { this._daemonName = value; }
        }

        // Check to see if DaemonName property is set
        internal bool IsSetDaemonName()
        {
            return this._daemonName != null;
        }

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon task definition to use for the daemon.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Optional deployment parameters that control how the daemon rolls out updates, including
        /// the drain percentage, alarm-based rollback, and bake time.
        /// </para>
        /// </summary>
        public DaemonDeploymentConfiguration DeploymentConfiguration
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
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to turn on Amazon ECS managed tags for the tasks in the daemon.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// your Amazon ECS resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// Determines whether the execute command functionality is turned on for the daemon.
        /// If <c>true</c>, the execute command functionality is turned on for all tasks in the
        /// daemon.
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
        /// Specifies whether to propagate the tags from the daemon to the daemon tasks. If you
        /// don't specify a value, the tags aren't propagated. You can only propagate tags to
        /// daemon tasks during task creation. To add tags to a task after task creation, use
        /// the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TagResource.html">TagResource</a>
        /// API action.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the daemon to help you categorize and organize them.
        /// Each tag consists of a key and an optional value. You define both of them.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}