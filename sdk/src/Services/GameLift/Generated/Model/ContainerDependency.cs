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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A container's dependency on another container in the same container group. The dependency
    /// impacts how the dependent container is able to start or shut down based the status
    /// of the other container.
    /// 
    ///  
    /// <para>
    /// For example, <i>ContainerA</i> is configured with the following dependency: a <c>START</c>
    /// dependency on <i>ContainerB</i>. This means that <i>ContainerA</i> can't start until
    /// <i>ContainerB</i> has started. It also means that <i>ContainerA</i> must shut down
    /// before <i>ContainerB</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinition.html">GameServerContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html">GameServerContainerDefinitionInput</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html">SupportContainerDefinitionInput</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerDependency
    {
        private ContainerDependencyCondition _condition;
        private string _containerName;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition that the dependency container must reach before the dependent container
        /// can start. Valid conditions include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// START - The dependency container must have started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETE - The dependency container has run to completion (exits). Use this condition
        /// with nonessential containers, such as those that run a script and then exit. The dependency
        /// container can't be an essential container. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUCCESS - The dependency container has run to completion and exited with a zero status.
        /// The dependency container can't be an essential container. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HEALTHY - The dependency container has passed its Docker health check. Use this condition
        /// with dependency containers that have health checks configured. This condition is confirmed
        /// at container group startup only.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerDependencyCondition Condition
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
        /// A descriptive label for the container definition that this container depends on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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