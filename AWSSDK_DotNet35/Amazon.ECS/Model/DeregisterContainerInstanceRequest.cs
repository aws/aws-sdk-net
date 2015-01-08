/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterContainerInstance operation.
    /// Deregisters an Amazon ECS container instance from the specified cluster. This instance
    /// will no longer be available to run tasks.
    /// </summary>
    public partial class DeregisterContainerInstanceRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _containerInstance;
        private bool? _force;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the container
        /// instance you want to deregister. If you do not specify a cluster, the default cluster
        /// is assumed.
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
        /// The container instance UUID or full Amazon Resource Name (ARN) of the container instance
        /// you want to deregister. The ARN contains the <code>arn:aws:ecs</code> namespace, followed
        /// by the region of the container instance, the AWS account ID of the container instance
        /// owner, the <code>container-instance</code> namespace, and then the container instance
        /// UUID. For example, arn:aws:ecs:<i>region</i>:<i>aws_account_id</i>:container-instance/<i>container_instance_UUID</i>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Force the deregistration of the container instance. You can use the <code>force</code>
        /// parameter if you have several tasks running on a container instance and you don't
        /// want to run <code>StopTask</code> for each task before deregistering the container
        /// instance.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

    }
}