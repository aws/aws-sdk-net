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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAct operation.
    /// Updates an existing act's configuration, status, or error information.
    /// </summary>
    public partial class UpdateActRequest : AmazonNovaActRequest
    {
        private string _actId;
        private ActError _error;
        private string _sessionId;
        private ActStatus _status;
        private string _workflowDefinitionName;
        private string _workflowRunId;

        /// <summary>
        /// Gets and sets the property ActId. 
        /// <para>
        /// The unique identifier of the act to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActId
        {
            get { return this._actId; }
            set { this._actId = value; }
        }

        // Check to see if ActId property is set
        internal bool IsSetActId()
        {
            return this._actId != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information to associate with the act, if applicable.
        /// </para>
        /// </summary>
        public ActError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status to set for the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string WorkflowDefinitionName
        {
            get { return this._workflowDefinitionName; }
            set { this._workflowDefinitionName = value; }
        }

        // Check to see if WorkflowDefinitionName property is set
        internal bool IsSetWorkflowDefinitionName()
        {
            return this._workflowDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowRunId
        {
            get { return this._workflowRunId; }
            set { this._workflowRunId = value; }
        }

        // Check to see if WorkflowRunId property is set
        internal bool IsSetWorkflowRunId()
        {
            return this._workflowRunId != null;
        }

    }
}