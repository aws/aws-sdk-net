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
    /// Container for the parameters to the CreateDaemon operation. Creates a new daemon in
    /// the specified cluster and capacity providers. A daemon deploys cross-cutting software
    /// agents such as security monitoring, telemetry, and logging independently across your
    /// Amazon ECS infrastructure. <para> Amazon ECS deploys exactly one daemon task on each
    /// container instance of the specified capacity providers. When a container instance
    /// registers with the cluster, Amazon ECS automatically starts daemon tasks. Amazon ECS
    /// starts a daemon task before scheduling other tasks. </para> <para> Daemons are essential
    /// for instance health - if a daemon task stops, Amazon ECS automatically drains and
    /// replaces that container instance. </para> <note> <para> ECS Managed Daemons is only
    /// supported for Amazon ECS Managed Instances Capacity Providers. </para> </note>
    /// </summary>
    public partial class CreateDaemonRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the capacity providers to associate with the daemon.
        /// The daemon deploys tasks on container instances managed by these capacity providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> CapacityProviderArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviderArns property is set.
        /// </summary>
        internal bool IsSetCapacityProviderArns() => this.CapacityProviderArns != null && (this.CapacityProviderArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An identifier that you provide to ensure the idempotency of the request. It must be
        /// unique and is case sensitive. Up to 36 ASCII characters in the range of 33-126 (inclusive)
        /// are allowed.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to create the daemon in.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// If the <c>critical</c> parameter of a daemon is <c>true</c>, and the daemon task fails,
        /// stops, or becomes unhealthy, Amazon ECS drains the container instance and stops the
        /// other tasks running on it. If the <c>critical</c> parameter is <c>false</c>, the daemon
        /// task failure doesn't affect the other tasks on the instance. The default value is
        /// <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// A non-critical daemon doesn't block instance registration. The container instance
        /// becomes active and continues to run your other tasks, whether the daemon task fails
        /// during scale-out or during a deployment.
        /// </para>
        ///  
        /// <para>
        /// Amazon ECS emits an EventBridge event when a daemon task fails to start, for both
        /// critical and non-critical daemons.
        /// </para>
        ///  
        /// <para>
        /// Daemon task launch failures during a deployment are still counted by the deployment
        /// circuit breaker. The circuit breaker can roll back an unstable target revision.
        /// </para>
        /// </summary>
        public bool? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property DaemonName. 
        /// <para>
        /// The name of the daemon. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DaemonName { get; set; }

        /// <summary>
        /// Checks to see if the DaemonName property is set.
        /// </summary>
        internal bool IsSetDaemonName() => this.DaemonName != null;

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon task definition to use for the daemon.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DaemonTaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonTaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetDaemonTaskDefinitionArn() => this.DaemonTaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Optional deployment parameters that control how the daemon rolls out updates, including
        /// the drain percentage, alarm-based rollback, and bake time.
        /// </para>
        /// </summary>
        public DaemonDeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to turn on Amazon ECS managed tags for the tasks in the daemon.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// your Amazon ECS resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// Determines whether the execute command functionality is turned on for the daemon.
        /// If <c>true</c>, the execute command functionality is turned on for all tasks in the
        /// daemon.
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
        /// Specifies whether to propagate the tags from the daemon to the daemon tasks. If you
        /// don't specify a value, the tags aren't propagated. You can only propagate tags to
        /// daemon tasks during task creation. To add tags to a task after task creation, use
        /// the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TagResource.html">TagResource</a>
        /// API action.
        /// </para>
        /// </summary>
        public DaemonPropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
