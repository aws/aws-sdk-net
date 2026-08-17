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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A Recovery Plan execution.
    /// </summary>
    public partial class RecoveryPlanExecution
    {
        private string _completedAt;
        private ErrorDetail _errorDetail;
        private RecoveryPlanExecutionMode _mode;
        private string _recoveryPlanArn;
        private string _recoveryPlanExecutionArn;
        private string _startedAt;
        private RecoveryPlanExecutionStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the execution completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Error details if the execution failed.
        /// </para>
        /// </summary>
        public ErrorDetail ErrorDetail
        {
            get { return this._errorDetail; }
            set { this._errorDetail = value; }
        }

        // Check to see if ErrorDetail property is set
        internal bool IsSetErrorDetail()
        {
            return this._errorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The execution mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryPlanExecutionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPlanArn. 
        /// <para>
        /// The ARN of the Recovery Plan being executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanArn
        {
            get { return this._recoveryPlanArn; }
            set { this._recoveryPlanArn = value; }
        }

        // Check to see if RecoveryPlanArn property is set
        internal bool IsSetRecoveryPlanArn()
        {
            return this._recoveryPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPlanExecutionArn. 
        /// <para>
        /// The ARN of the Recovery Plan execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanExecutionArn
        {
            get { return this._recoveryPlanExecutionArn; }
            set { this._recoveryPlanExecutionArn = value; }
        }

        // Check to see if RecoveryPlanExecutionArn property is set
        internal bool IsSetRecoveryPlanExecutionArn()
        {
            return this._recoveryPlanExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The execution status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryPlanExecutionStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the Recovery Plan execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}