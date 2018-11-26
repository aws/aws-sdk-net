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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Describes the detailed result of a <code>TaskExecution</code> operation. This result
    /// includes the time in milliseconds spent in each phase, the status of the task execution,
    /// and the errors encountered.
    /// </summary>
    public partial class TaskExecutionResultDetail
    {
        private string _errorCode;
        private string _errorDetail;
        private long? _prepareDuration;
        private PhaseStatus _prepareStatus;
        private long? _transferDuration;
        private PhaseStatus _transferStatus;
        private long? _verifyDuration;
        private PhaseStatus _verifyStatus;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Errors that AWS DataSync encountered during execution of the task. You can use this
        /// error code to help troubleshoot issues.
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
        /// Detailed description of an error that was encountered during the task execution. You
        /// can use this information to help troubleshoot issues. 
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
        /// The total time in milliseconds that AWS DataSync spent in the PREPARING phase. 
        /// </para>
        /// </summary>
        public long PrepareDuration
        {
            get { return this._prepareDuration.GetValueOrDefault(); }
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
        /// The status of the PREPARING phase.
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
        /// Gets and sets the property TransferDuration. 
        /// <para>
        /// The total time in milliseconds that AWS DataSync spent in the TRANSFERRING phase.
        /// </para>
        /// </summary>
        public long TransferDuration
        {
            get { return this._transferDuration.GetValueOrDefault(); }
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
        /// The status of the TRANSFERRING Phase.
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
        /// The total time in milliseconds that AWS DataSync spent in the VERIFYING phase.
        /// </para>
        /// </summary>
        public long VerifyDuration
        {
            get { return this._verifyDuration.GetValueOrDefault(); }
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
        /// The status of the VERIFYING Phase.
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