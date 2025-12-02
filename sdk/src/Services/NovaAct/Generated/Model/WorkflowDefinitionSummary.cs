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
    /// Summary information about a workflow definition, used in list operations.
    /// </summary>
    public partial class WorkflowDefinitionSummary
    {
        private DateTime? _createdAt;
        private WorkflowDefinitionStatus _status;
        private string _workflowDefinitionArn;
        private string _workflowDefinitionName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the workflow definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowDefinitionStatus Status
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
        /// Gets and sets the property WorkflowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowDefinitionArn
        {
            get { return this._workflowDefinitionArn; }
            set { this._workflowDefinitionArn = value; }
        }

        // Check to see if WorkflowDefinitionArn property is set
        internal bool IsSetWorkflowDefinitionArn()
        {
            return this._workflowDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition.
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

    }
}