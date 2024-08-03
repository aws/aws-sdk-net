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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The current status of an archive export job.
    /// </summary>
    public partial class ExportStatus
    {
        private DateTime? _completionTimestamp;
        private string _errorMessage;
        private ExportState _state;
        private DateTime? _submissionTimestamp;

        /// <summary>
        /// Gets and sets the property CompletionTimestamp. 
        /// <para>
        /// The timestamp of when the export job completed (if finished).
        /// </para>
        /// </summary>
        public DateTime? CompletionTimestamp
        {
            get { return this._completionTimestamp; }
            set { this._completionTimestamp = value; }
        }

        // Check to see if CompletionTimestamp property is set
        internal bool IsSetCompletionTimestamp()
        {
            return this._completionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message if the export job failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the export job.
        /// </para>
        /// </summary>
        public ExportState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionTimestamp. 
        /// <para>
        /// The timestamp of when the export job was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmissionTimestamp
        {
            get { return this._submissionTimestamp; }
            set { this._submissionTimestamp = value; }
        }

        // Check to see if SubmissionTimestamp property is set
        internal bool IsSetSubmissionTimestamp()
        {
            return this._submissionTimestamp.HasValue; 
        }

    }
}