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
    /// <c>INACTIVE</c> to <c>DELETE_IN_PROGRESS</c>. Existing tasks and services that reference
    /// a <c>DELETE_IN_PROGRESS</c> task definition revision continue to run without disruption.
    /// Existing services that reference a <c>DELETE_IN_PROGRESS</c> task definition revision
    /// can still scale up or down by modifying the service's desired count.
    /// </para>
    ///  
    /// <para>
    /// You can't use a <c>DELETE_IN_PROGRESS</c> task definition revision to run new tasks
    /// or create new services. You also can't update an existing service to reference a <c>DELETE_IN_PROGRESS</c>
    /// task definition revision.
    /// </para>
    ///  
    /// <para>
    ///  A task definition revision will stay in <c>DELETE_IN_PROGRESS</c> status until all
    /// the associated tasks and services have been terminated.
    /// </para>
    ///  
    /// <para>
    /// When you delete all <c>INACTIVE</c> task definition revisions, the task definition
    /// name is not displayed in the console and not returned in the API. If a task definition
    /// revisions are in the <c>DELETE_IN_PROGRESS</c> state, the task definition name is
    /// displayed in the console and returned in the API. The task definition name is retained
    /// by Amazon ECS and the revision is incremented the next time you create a task definition
    /// with that name.
    /// </para>
    /// </summary>
    public partial class DeleteTaskDefinitionsRequest : AmazonECSRequest
    {
        private List<string> _taskDefinitions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property TaskDefinitions. 
        /// <para>
        /// The <c>family</c> and <c>revision</c> (<c>family:revision</c>) or full Amazon Resource
        /// Name (ARN) of the task definition to delete. You must specify a <c>revision</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 task definitions as a comma separated list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._taskDefinitions != null && (this._taskDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}