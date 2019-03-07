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
    /// The dependencies defined for container startup. A container can contain multiple dependencies.
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
        ///  <code>START</code> - This condition emulates the behavior of links and volumes today.
        /// It validates that a dependent container is started before permitting other containers
        /// to start.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETE</code> - This condition validates that a dependent container runs
        /// to completion (exits) before permitting other containers to start. This can be useful
        /// for non-essential containers that run a script and then subsequently exit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code> - This condition is the same as <code>COMPLETE</code>, but it
        /// will also require that the container exits with a <code>zero</code> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HEALTHY</code> - This condition validates that the dependent container passes
        /// its Docker health check before permitting other containers to start. This requires
        /// that the dependent container has health checks configured. This condition will only
        /// be confirmed at task startup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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