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
    /// A Recovery Plan Execution Step resource.
    /// </summary>
    public partial class RecoveryPlanExecutionStep
    {
        private int? _attempt;
        private RecoveryPlanExecutionStepConfiguration _configuration;
        private string _createdAt;
        private ErrorDetail _errorDetail;
        private string _recoveryPlanExecutionStepArn;
        private RecoveryPlanExecutionStepStatus _status;
        private int? _stepIndex;
        private string _stepName;
        private string _updatedAt;

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of times this step has been attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Attempt
        {
            get { return this._attempt; }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryPlanExecutionStepConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the execution step was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// Error details if the step failed.
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
        /// Gets and sets the property RecoveryPlanExecutionStepArn. 
        /// <para>
        /// The ARN of the execution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RecoveryPlanExecutionStepArn
        {
            get { return this._recoveryPlanExecutionStepArn; }
            set { this._recoveryPlanExecutionStepArn = value; }
        }

        // Check to see if RecoveryPlanExecutionStepArn property is set
        internal bool IsSetRecoveryPlanExecutionStepArn()
        {
            return this._recoveryPlanExecutionStepArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the execution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryPlanExecutionStepStatus Status
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
        /// Gets and sets the property StepIndex.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public int? StepIndex
        {
            get { return this._stepIndex; }
            set { this._stepIndex = value; }
        }

        // Check to see if StepIndex property is set
        internal bool IsSetStepIndex()
        {
            return this._stepIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the execution step was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=32)]
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt != null;
        }

    }
}