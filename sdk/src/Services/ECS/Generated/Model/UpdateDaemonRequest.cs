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
    /// Container for the parameters to the UpdateDaemon operation.
    /// Updates the specified daemon. When you update a daemon, a new deployment is triggered
    /// that progressively rolls out the changes to the container instances associated with
    /// the daemon's capacity providers. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/daemon-deployments.html">Daemon
    /// deployments</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// Amazon ECS drains existing container instances and provisions new instances with the
    /// updated daemon. Amazon ECS automatically launches replacement tasks for your services.
    /// </para>
    ///  <important> 
    /// <para>
    /// Updating a daemon triggers a rolling deployment that drains and replaces container
    /// instances. Plan updates during maintenance windows to minimize impact on running services.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// ECS Managed Daemons is only supported for Amazon ECS Managed Instances Capacity Providers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateDaemonRequest : AmazonECSRequest
    {
        private List<string> _capacityProviderArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _daemonArn;
        private string _daemonTaskDefinitionArn;
        private DaemonDeploymentConfiguration _deploymentConfiguration;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private DaemonPropagateTags _propagateTags;

        /// <summary>
        /// Gets and sets the property CapacityProviderArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the capacity providers to associate with the daemon.
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
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon task definition to use for the updated
        /// daemon.
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
        /// If <c>true</c>, the execute command functionality is turned on for all tasks in the
        /// daemon. If <c>false</c>, the execute command functionality is turned off.
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
        /// daemon tasks during task creation.
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