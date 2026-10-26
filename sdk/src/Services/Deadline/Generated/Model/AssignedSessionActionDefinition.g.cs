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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The definition of the assigned session action.
    /// </summary>
    public partial class AssignedSessionActionDefinition
    {
        /// <summary>
        /// Gets and sets the property EnvEnter. The environment a session starts on.
        /// </summary>
        public AssignedEnvironmentEnterSessionActionDefinition EnvEnter { get; set; }

        /// <summary>
        /// Checks to see if the EnvEnter property is set.
        /// </summary>
        internal bool IsSetEnvEnter() => this.EnvEnter != null;

        /// <summary>
        /// Gets and sets the property EnvExit. The environment a session exits from.
        /// </summary>
        public AssignedEnvironmentExitSessionActionDefinition EnvExit { get; set; }

        /// <summary>
        /// Checks to see if the EnvExit property is set.
        /// </summary>
        internal bool IsSetEnvExit() => this.EnvExit != null;

        /// <summary>
        /// Gets and sets the property SyncInputJobAttachments. The job attachments to sync for
        /// the assigned session action.
        /// </summary>
        public AssignedSyncInputJobAttachmentsSessionActionDefinition SyncInputJobAttachments { get; set; }

        /// <summary>
        /// Checks to see if the SyncInputJobAttachments property is set.
        /// </summary>
        internal bool IsSetSyncInputJobAttachments() => this.SyncInputJobAttachments != null;

        /// <summary>
        /// Gets and sets the property TaskRun. The task run.
        /// </summary>
        public AssignedTaskRunSessionActionDefinition TaskRun { get; set; }

        /// <summary>
        /// Checks to see if the TaskRun property is set.
        /// </summary>
        internal bool IsSetTaskRun() => this.TaskRun != null;
    }
}
