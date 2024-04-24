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
    /// The dependencies defined for container startup and shutdown. A container can contain
    /// multiple dependencies. When a dependency is defined for container startup, for container
    /// shutdown it is reversed.
    /// 
    ///  
    /// <para>
    /// Your Amazon ECS container instances require at least version 1.26.0 of the container
    /// agent to use container dependencies. However, we recommend using the latest container
    /// agent version. For information about checking your agent version and updating to the
    /// latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
    /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
    /// at least version 1.26.0-1 of the <c>ecs-init</c> package. If your container instances
    /// are launched from version <c>20190301</c> or later, then they contain the required
    /// versions of the container agent and <c>ecs-init</c>. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
    /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// For tasks that use the Fargate launch type, the task or service requires the following
    /// platforms:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Linux platform version <c>1.3.0</c> or later.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Windows platform version <c>1.0.0</c> or later.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about how to create a container dependency, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/example_task_definitions.html#example_task_definition-containerdependency">Container
    /// dependency</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ContainerDependency
    {
        private ContainerCondition _condition;
        private string _containerName;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The dependency condition of the container. The following are the available conditions
        /// and their behavior:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>START</c> - This condition emulates the behavior of links and volumes today. It
        /// validates that a dependent container is started before permitting other containers
        /// to start.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> - This condition validates that a dependent container runs to completion
        /// (exits) before permitting other containers to start. This can be useful for nonessential
        /// containers that run a script and then exit. This condition can't be set on an essential
        /// container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> - This condition is the same as <c>COMPLETE</c>, but it also requires
        /// that the container exits with a <c>zero</c> status. This condition can't be set on
        /// an essential container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HEALTHY</c> - This condition validates that the dependent container passes its
        /// Docker health check before permitting other containers to start. This requires that
        /// the dependent container has health checks configured. This condition is confirmed
        /// only at task startup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of a container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

    }
}