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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Provides detailed information about the result of your DataSync task execution.
    /// </summary>
    public partial class TaskExecutionResultDetail
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error that DataSync encountered during your task execution. You can use this information
        /// to help <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">troubleshoot
        /// issues</a>.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDetail. 
        /// <para>
        /// The detailed description of an error that DataSync encountered during your task execution.
        /// You can use this information to help <a href="https://docs.aws.amazon.com/datasync/latest/userguide/troubleshooting-datasync-locations-tasks.html">troubleshoot
        /// issues</a>. 
        /// </para>
        /// </summary>
        public string ErrorDetail { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetail property is set.
        /// </summary>
        internal bool IsSetErrorDetail() => this.ErrorDetail != null;

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
        [AWSProperty(Min = 0)]
        public long? PrepareDuration { get; set; }

        /// <summary>
        /// Checks to see if the PrepareDuration property is set.
        /// </summary>
        internal bool IsSetPrepareDuration() => this.PrepareDuration.HasValue;

        /// <summary>
        /// Gets and sets the property PrepareStatus. 
        /// <para>
        /// The status of the <c>PREPARING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus PrepareStatus { get; set; }

        /// <summary>
        /// Checks to see if the PrepareStatus property is set.
        /// </summary>
        internal bool IsSetPrepareStatus() => this.PrepareStatus != null;

        /// <summary>
        /// Gets and sets the property TotalDuration. 
        /// <para>
        /// The time in milliseconds that your task execution ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalDuration { get; set; }

        /// <summary>
        /// Checks to see if the TotalDuration property is set.
        /// </summary>
        internal bool IsSetTotalDuration() => this.TotalDuration.HasValue;

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
        [AWSProperty(Min = 0)]
        public long? TransferDuration { get; set; }

        /// <summary>
        /// Checks to see if the TransferDuration property is set.
        /// </summary>
        internal bool IsSetTransferDuration() => this.TransferDuration.HasValue;

        /// <summary>
        /// Gets and sets the property TransferStatus. 
        /// <para>
        /// The status of the <c>TRANSFERRING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus TransferStatus { get; set; }

        /// <summary>
        /// Checks to see if the TransferStatus property is set.
        /// </summary>
        internal bool IsSetTransferStatus() => this.TransferStatus != null;

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
        [AWSProperty(Min = 0)]
        public long? VerifyDuration { get; set; }

        /// <summary>
        /// Checks to see if the VerifyDuration property is set.
        /// </summary>
        internal bool IsSetVerifyDuration() => this.VerifyDuration.HasValue;

        /// <summary>
        /// Gets and sets the property VerifyStatus. 
        /// <para>
        /// The status of the <c>VERIFYING</c> step for your task execution. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/run-task.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        /// </summary>
        public PhaseStatus VerifyStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerifyStatus property is set.
        /// </summary>
        internal bool IsSetVerifyStatus() => this.VerifyStatus != null;
    }
}
