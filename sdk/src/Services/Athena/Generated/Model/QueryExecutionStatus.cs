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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The completion date, current state, submission time, and state change reason (if applicable)
    /// for the query execution.
    /// </summary>
    public partial class QueryExecutionStatus
    {
        private DateTime? _completionDateTime;
        private QueryExecutionState _state;
        private string _stateChangeReason;
        private DateTime? _submissionDateTime;

        /// <summary>
        /// Gets and sets the property CompletionDateTime. 
        /// <para>
        /// The date and time that the query completed.
        /// </para>
        /// </summary>
        public DateTime CompletionDateTime
        {
            get { return this._completionDateTime.GetValueOrDefault(); }
            set { this._completionDateTime = value; }
        }

        // Check to see if CompletionDateTime property is set
        internal bool IsSetCompletionDateTime()
        {
            return this._completionDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of query execution. <code>QUEUED</code> state is listed but is not used
        /// by Athena and is reserved for future use. <code>RUNNING</code> indicates that the
        /// query has been submitted to the service, and Athena will execute the query as soon
        /// as resources are available. <code>SUCCEEDED</code> indicates that the query completed
        /// without error. <code>FAILED</code> indicates that the query experienced an error and
        /// did not complete processing.<code>CANCELLED</code> indicates that user input interrupted
        /// query execution. 
        /// </para>
        /// </summary>
        public QueryExecutionState State
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
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// Further detail about the status of the query.
        /// </para>
        /// </summary>
        public string StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionDateTime. 
        /// <para>
        /// The date and time that the query was submitted.
        /// </para>
        /// </summary>
        public DateTime SubmissionDateTime
        {
            get { return this._submissionDateTime.GetValueOrDefault(); }
            set { this._submissionDateTime = value; }
        }

        // Check to see if SubmissionDateTime property is set
        internal bool IsSetSubmissionDateTime()
        {
            return this._submissionDateTime.HasValue; 
        }

    }
}