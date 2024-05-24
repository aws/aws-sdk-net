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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
    /// The details of a session action definition.
    /// </summary>
    public partial class SessionActionDefinitionSummary
    {
        private EnvironmentEnterSessionActionDefinitionSummary _envEnter;
        private EnvironmentExitSessionActionDefinitionSummary _envExit;
        private SyncInputJobAttachmentsSessionActionDefinitionSummary _syncInputJobAttachments;
        private TaskRunSessionActionDefinitionSummary _taskRun;

        /// <summary>
        /// Gets and sets the property EnvEnter. 
        /// <para>
        /// The environment to enter into.
        /// </para>
        /// </summary>
        public EnvironmentEnterSessionActionDefinitionSummary EnvEnter
        {
            get { return this._envEnter; }
            set { this._envEnter = value; }
        }

        // Check to see if EnvEnter property is set
        internal bool IsSetEnvEnter()
        {
            return this._envEnter != null;
        }

        /// <summary>
        /// Gets and sets the property EnvExit. 
        /// <para>
        /// The environment to exit from.
        /// </para>
        /// </summary>
        public EnvironmentExitSessionActionDefinitionSummary EnvExit
        {
            get { return this._envExit; }
            set { this._envExit = value; }
        }

        // Check to see if EnvExit property is set
        internal bool IsSetEnvExit()
        {
            return this._envExit != null;
        }

        /// <summary>
        /// Gets and sets the property SyncInputJobAttachments. 
        /// <para>
        /// The job attachments to sync with the session action definition.
        /// </para>
        /// </summary>
        public SyncInputJobAttachmentsSessionActionDefinitionSummary SyncInputJobAttachments
        {
            get { return this._syncInputJobAttachments; }
            set { this._syncInputJobAttachments = value; }
        }

        // Check to see if SyncInputJobAttachments property is set
        internal bool IsSetSyncInputJobAttachments()
        {
            return this._syncInputJobAttachments != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRun. 
        /// <para>
        /// The task run.
        /// </para>
        /// </summary>
        public TaskRunSessionActionDefinitionSummary TaskRun
        {
            get { return this._taskRun; }
            set { this._taskRun = value; }
        }

        // Check to see if TaskRun property is set
        internal bool IsSetTaskRun()
        {
            return this._taskRun != null;
        }

    }
}