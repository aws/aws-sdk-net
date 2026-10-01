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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTask operation. Updates an existing task
    /// in the specified workspace. Only the fields provided in the request are updated; fields
    /// not included in the request are preserved unchanged.
    /// </summary>
    public partial class UpdateTaskRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property TaskConfiguration. 
        /// <para>
        /// The updated task execution configuration.
        /// </para>
        /// </summary>
        public TaskConfiguration TaskConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TaskConfiguration property is set.
        /// </summary>
        internal bool IsSetTaskConfiguration() => this.TaskConfiguration != null;

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the task to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TaskName { get; set; }

        /// <summary>
        /// Checks to see if the TaskName property is set.
        /// </summary>
        internal bool IsSetTaskName() => this.TaskName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
