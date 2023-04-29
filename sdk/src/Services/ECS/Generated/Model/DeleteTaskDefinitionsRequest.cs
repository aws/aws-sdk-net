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
    /// Container for the parameters to the DeleteTaskDefinitions operation.
    /// Deletes one or more task definitions.
    /// 
    ///  
    /// <para>
    /// You must deregister a task definition revision before you delete it. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DeregisterTaskDefinition.html">DeregisterTaskDefinition</a>.
    /// </para>
    ///  
    /// <para>
    /// When you delete a task definition revision, it is immediately transitions from the
    /// <code>INACTIVE</code> to <code>DELETE_IN_PROGRESS</code>. Existing tasks and services
    /// that reference a <code>DELETE_IN_PROGRESS</code> task definition revision continue
    /// to run without disruption. Existing services that reference a <code>DELETE_IN_PROGRESS</code>
    /// task definition revision can still scale up or down by modifying the service's desired
    /// count.
    /// </para>
    ///  
    /// <para>
    /// You can't use a <code>DELETE_IN_PROGRESS</code> task definition revision to run new
    /// tasks or create new services. You also can't update an existing service to reference
    /// a <code>DELETE_IN_PROGRESS</code> task definition revision.
    /// </para>
    ///  
    /// <para>
    ///  A task definition revision will stay in <code>DELETE_IN_PROGRESS</code> status until
    /// all the associated tasks and services have been terminated.
    /// </para>
    /// </summary>
    public partial class DeleteTaskDefinitionsRequest : AmazonECSRequest
    {
        private List<string> _taskDefinitions = new List<string>();

        /// <summary>
        /// Gets and sets the property TaskDefinitions. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full Amazon Resource Name (ARN) of the task definition to delete. You must specify
        /// a <code>revision</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 task definitions as a comma separated list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TaskDefinitions
        {
            get { return this._taskDefinitions; }
            set { this._taskDefinitions = value; }
        }

        // Check to see if TaskDefinitions property is set
        internal bool IsSetTaskDefinitions()
        {
            return this._taskDefinitions != null && this._taskDefinitions.Count > 0; 
        }

    }
}