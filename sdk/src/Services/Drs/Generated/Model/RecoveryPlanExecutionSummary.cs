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
    /// Summary information about a Recovery Plan execution.
    /// </summary>
    public partial class RecoveryPlanExecutionSummary
    {
        private ErrorDetail _errorDetail;
        private RecoveryPlanExecutionMode _mode;
        private string _recoveryPlanArn;
        private string _recoveryPlanExecutionArn;
        private string _startedAt;
        private RecoveryPlanExecutionStatus _status;

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
        /// The ARN of the Recovery Plan.
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

    }
}