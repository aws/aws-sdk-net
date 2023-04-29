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
    /// Container for the parameters to the DeregisterTaskDefinition operation.
    /// Deregisters the specified task definition by family and revision. Upon deregistration,
    /// the task definition is marked as <code>INACTIVE</code>. Existing tasks and services
    /// that reference an <code>INACTIVE</code> task definition continue to run without disruption.
    /// Existing services that reference an <code>INACTIVE</code> task definition can still
    /// scale up or down by modifying the service's desired count. If you want to delete a
    /// task definition revision, you must first deregister the task definition revision.
    /// 
    ///  
    /// <para>
    /// You can't use an <code>INACTIVE</code> task definition to run new tasks or create
    /// new services, and you can't update an existing service to reference an <code>INACTIVE</code>
    /// task definition. However, there may be up to a 10-minute window following deregistration
    /// where these restrictions have not yet taken effect.
    /// </para>
    ///  <note> 
    /// <para>
    /// At this time, <code>INACTIVE</code> task definitions remain discoverable in your account
    /// indefinitely. However, this behavior is subject to change in the future. We don't
    /// recommend that you rely on <code>INACTIVE</code> task definitions persisting beyond
    /// the lifecycle of any associated tasks and services.
    /// </para>
    ///  </note> 
    /// <para>
    /// You must deregister a task definition revision before you delete it. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DeleteTaskDefinitions.html">DeleteTaskDefinitions</a>.
    /// </para>
    /// </summary>
    public partial class DeregisterTaskDefinitionRequest : AmazonECSRequest
    {
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full Amazon Resource Name (ARN) of the task definition to deregister. You must specify
        /// a <code>revision</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}