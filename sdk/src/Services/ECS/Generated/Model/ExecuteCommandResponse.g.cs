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
    /// This is the response object from the ExecuteCommand operation.
    /// </summary>
    public partial class ExecuteCommandResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ContainerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container.
        /// </para>
        /// </summary>
        public string ContainerArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerArn property is set.
        /// </summary>
        internal bool IsSetContainerArn() => this.ContainerArn != null;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// Determines whether the execute command session is running in interactive mode. Amazon
        /// ECS only supports initiating interactive sessions, so you must specify <c>true</c>
        /// for this value.
        /// </para>
        /// </summary>
        public bool? Interactive { get; set; }

        /// <summary>
        /// Checks to see if the Interactive property is set.
        /// </summary>
        internal bool IsSetInteractive() => this.Interactive.HasValue;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The details of the SSM session that was created for this instance of execute-command.
        /// </para>
        /// </summary>
        public Session Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;
    }
}
