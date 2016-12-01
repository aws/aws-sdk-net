/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Details about a specific Automation execution.
    /// </summary>
    public partial class AutomationExecutionMetadata
    {
        private string _automationExecutionId;
        private AutomationExecutionStatus _automationExecutionStatus;
        private string _documentName;
        private string _documentVersion;
        private string _executedBy;
        private DateTime? _executionEndTime;
        private DateTime? _executionStartTime;
        private string _logFile;
        private Dictionary<string, List<string>> _outputs = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The execution ID.
        /// </para>
        /// </summary>
        public string AutomationExecutionId
        {
            get { return this._automationExecutionId; }
            set { this._automationExecutionId = value; }
        }

        // Check to see if AutomationExecutionId property is set
        internal bool IsSetAutomationExecutionId()
        {
            return this._automationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationExecutionStatus. 
        /// <para>
        /// The status of the execution. Valid values include: Running, Succeeded, Failed, Timed
        /// out, or Cancelled.
        /// </para>
        /// </summary>
        public AutomationExecutionStatus AutomationExecutionStatus
        {
            get { return this._automationExecutionStatus; }
            set { this._automationExecutionStatus = value; }
        }

        // Check to see if AutomationExecutionStatus property is set
        internal bool IsSetAutomationExecutionStatus()
        {
            return this._automationExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Automation document used during execution.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The document version used during the execution.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutedBy. 
        /// <para>
        /// The IAM role ARN of the user who executed the Automation.
        /// </para>
        /// </summary>
        public string ExecutedBy
        {
            get { return this._executedBy; }
            set { this._executedBy = value; }
        }

        // Check to see if ExecutedBy property is set
        internal bool IsSetExecutedBy()
        {
            return this._executedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The time the execution finished. This is not populated if the execution is still in
        /// progress.
        /// </para>
        /// </summary>
        public DateTime ExecutionEndTime
        {
            get { return this._executionEndTime.GetValueOrDefault(); }
            set { this._executionEndTime = value; }
        }

        // Check to see if ExecutionEndTime property is set
        internal bool IsSetExecutionEndTime()
        {
            return this._executionEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// The time the execution started.&gt;
        /// </para>
        /// </summary>
        public DateTime ExecutionStartTime
        {
            get { return this._executionStartTime.GetValueOrDefault(); }
            set { this._executionStartTime = value; }
        }

        // Check to see if ExecutionStartTime property is set
        internal bool IsSetExecutionStartTime()
        {
            return this._executionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogFile. 
        /// <para>
        /// An Amazon S3 bucket where execution information is stored.
        /// </para>
        /// </summary>
        public string LogFile
        {
            get { return this._logFile; }
            set { this._logFile = value; }
        }

        // Check to see if LogFile property is set
        internal bool IsSetLogFile()
        {
            return this._logFile != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The list of execution outputs as defined in the Automation document.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

    }
}