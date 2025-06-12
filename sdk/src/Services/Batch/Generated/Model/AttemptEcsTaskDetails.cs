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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the details of a task.
    /// </summary>
    public partial class AttemptEcsTaskDetails
    {
        private string _containerInstanceArn;
        private List<AttemptTaskContainerDetails> _containers = AWSConfigs.InitializeCollections ? new List<AttemptTaskContainerDetails>() : null;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container instance that hosts the task.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn
        {
            get { return this._containerInstanceArn; }
            set { this._containerInstanceArn = value; }
        }

        // Check to see if ContainerInstanceArn property is set
        internal bool IsSetContainerInstanceArn()
        {
            return this._containerInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// A list of containers that are included in the <c>taskProperties</c> list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttemptTaskContainerDetails> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the Amazon ECS task.
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