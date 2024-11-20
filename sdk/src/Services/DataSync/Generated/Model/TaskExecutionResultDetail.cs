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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Provides detailed information about the result of your DataSync task execution.
    /// </summary>
    public partial class TaskExecutionResultDetail
    {
        private string _errorCode;
        private string _errorDetail;
        private long? _prepareDuration;
        private PhaseStatus _prepareStatus;
        private long? _totalDuration;
        private long? _transferDuration;
        private PhaseStatus _transferStatus;
        private long? _verifyDuration;
        private PhaseStatus _verifyStatus;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error that DataSync encountered during your task execution. You can use this information
        /// to help <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">troubleshoot
        /// issues</a>.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// The detailed description of an error that DataSync encountered during your task execution.
        /// You can use this information to help <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">troubleshoot
        /// issues</a>. 
        /// </para>
        /// </summary>
        public string ErrorDetail
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
        /// Gets and sets the property PrepareDuration. 
        /// <para>
        /// The time in milliseconds that your task execution was in the <c>PREPARING</c> step.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  
        /// <para>
        /// For Enhanced mode tasks, the value is always <c>0</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/datasync/latest/userguide/how-datasync-transfer-works.html#how-datasync-prepares">How
        /// DataSync prepares your data transfer</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? PrepareDuration
        {
            get { return this._prepareDuration; }
            set { this._prepareDuration = value; }
        }

        // Check to see if PrepareDuration property is set
        internal bool IsSetPrepareDuration()
        {
            return this._prepareDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrepareStatus. 
        /// <para>
        /// The status of the <c>PREPARING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus PrepareStatus
        {
            get { return this._prepareStatus; }
            set { this._prepareStatus = value; }
        }

        // Check to see if PrepareStatus property is set
        internal bool IsSetPrepareStatus()
        {
            return this._prepareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TotalDuration. 
        /// <para>
        /// The time in milliseconds that your task execution ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalDuration
        {
            get { return this._totalDuration; }
            set { this._totalDuration = value; }
        }

        // Check to see if TotalDuration property is set
        internal bool IsSetTotalDuration()
        {
            return this._totalDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferDuration. 
        /// <para>
        /// The time in milliseconds that your task execution was in the <c>TRANSFERRING</c> step.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  
        /// <para>
        /// For Enhanced mode tasks, the value is always <c>0</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/datasync/latest/userguide/how-datasync-transfer-works.html#how-datasync-transfers">How
        /// DataSync transfers your data</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TransferDuration
        {
            get { return this._transferDuration; }
            set { this._transferDuration = value; }
        }

        // Check to see if TransferDuration property is set
        internal bool IsSetTransferDuration()
        {
            return this._transferDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferStatus. 
        /// <para>
        /// The status of the <c>TRANSFERRING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus TransferStatus
        {
            get { return this._transferStatus; }
            set { this._transferStatus = value; }
        }

        // Check to see if TransferStatus property is set
        internal bool IsSetTransferStatus()
        {
            return this._transferStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VerifyDuration. 
        /// <para>
        /// The time in milliseconds that your task execution was in the <c>VERIFYING</c> step.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  
        /// <para>
        /// For Enhanced mode tasks, the value is always <c>0</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/datasync/latest/userguide/how-datasync-transfer-works.html#how-verifying-works">How
        /// DataSync verifies your data's integrity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? VerifyDuration
        {
            get { return this._verifyDuration; }
            set { this._verifyDuration = value; }
        }

        // Check to see if VerifyDuration property is set
        internal bool IsSetVerifyDuration()
        {
            return this._verifyDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VerifyStatus. 
        /// <para>
        /// The status of the <c>VERIFYING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus VerifyStatus
        {
            get { return this._verifyStatus; }
            set { this._verifyStatus = value; }
        }

        // Check to see if VerifyStatus property is set
        internal bool IsSetVerifyStatus()
        {
            return this._verifyStatus != null;
        }

    }
}