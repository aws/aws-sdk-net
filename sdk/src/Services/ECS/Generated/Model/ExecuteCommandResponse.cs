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
    /// This is the response object from the ExecuteCommand operation.
    /// </summary>
    public partial class ExecuteCommandResponse : AmazonWebServiceResponse
    {
        private string _clusterArn;
        private string _containerArn;
        private string _containerName;
        private bool? _interactive;
        private Session _session;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
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
        /// Gets and sets the property ContainerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container.
        /// </para>
        /// </summary>
        public string ContainerArn
        {
            get { return this._containerArn; }
            set { this._containerArn = value; }
        }

        // Check to see if ContainerArn property is set
        internal bool IsSetContainerArn()
        {
            return this._containerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container.
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

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// Determines whether the execute command session is running in interactive mode. Amazon
        /// ECS only supports initiating interactive sessions, so you must specify <c>true</c>
        /// for this value.
        /// </para>
        /// </summary>
        public bool? Interactive
        {
            get { return this._interactive; }
            set { this._interactive = value; }
        }

        // Check to see if Interactive property is set
        internal bool IsSetInteractive()
        {
            return this._interactive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The details of the SSM session that was created for this instance of execute-command.
        /// </para>
        /// </summary>
        public Session Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

    }
}