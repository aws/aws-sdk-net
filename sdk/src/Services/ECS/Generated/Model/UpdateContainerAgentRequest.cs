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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContainerAgent operation.
    /// Updates the Amazon ECS container agent on a specified container instance. Updating
    /// the Amazon ECS container agent doesn't interrupt running tasks or services on the
    /// container instance. The process for updating the agent differs depending on whether
    /// your container instance was launched with the Amazon ECS-optimized AMI or another
    /// operating system.
    /// 
    ///  <note> 
    /// <para>
    /// The <code>UpdateContainerAgent</code> API isn't supported for container instances
    /// using the Amazon ECS-optimized Amazon Linux 2 (arm64) AMI. To update the container
    /// agent, you can update the <code>ecs-init</code> package. This updates the agent. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/agent-update-ecs-ami.html">Updating
    /// the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Agent updates with the <code>UpdateContainerAgent</code> API operation do not apply
    /// to Windows container instances. We recommend that you launch new container instances
    /// to update the agent version in your Windows clusters.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <code>UpdateContainerAgent</code> API requires an Amazon ECS-optimized AMI or
    /// Amazon Linux AMI with the <code>ecs-init</code> service installed and running. For
    /// help updating the Amazon ECS container agent on other operating systems, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html#manually_update_agent">Manually
    /// updating the Amazon ECS container agent</a> in the <i>Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateContainerAgentRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _containerInstance;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that your container
        /// instance is running on. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerInstance. 
        /// <para>
        /// The container instance ID or full ARN entries for the container instance where you
        /// would like to update the Amazon ECS container agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerInstance
        {
            get { return this._containerInstance; }
            set { this._containerInstance = value; }
        }

        // Check to see if ContainerInstance property is set
        internal bool IsSetContainerInstance()
        {
            return this._containerInstance != null;
        }

    }
}