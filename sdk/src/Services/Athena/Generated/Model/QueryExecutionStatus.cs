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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// The completion date, current state, submission time, and state change reason (if applicable)
    /// for the query execution.
    /// </summary>
    public partial class QueryExecutionStatus
    {
        private AthenaError _athenaError;
        private DateTime? _completionDateTime;
        private QueryExecutionState _state;
        private string _stateChangeReason;
        private DateTime? _submissionDateTime;

        /// <summary>
        /// Gets and sets the property AthenaError. 
        /// <para>
        /// Provides information about an Athena query error.
        /// </para>
        /// </summary>
        public AthenaError AthenaError
        {
            get { return this._athenaError; }
            set { this._athenaError = value; }
        }

        // Check to see if AthenaError property is set
        internal bool IsSetAthenaError()
        {
            return this._athenaError != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDateTime. 
        /// <para>
        /// The date and time that the query completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionDateTime
        {
            get { return this._completionDateTime; }
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
        /// The state of query execution. <c>QUEUED</c> indicates that the query has been submitted
        /// to the service, and Athena will execute the query as soon as resources are available.
        /// <c>RUNNING</c> indicates that the query is in execution phase. <c>SUCCEEDED</c> indicates
        /// that the query completed without errors. <c>FAILED</c> indicates that the query experienced
        /// an error and did not complete processing. <c>CANCELLED</c> indicates that a user input
        /// interrupted query execution.
        /// </para>
        ///  <note> 
        /// <para>
        /// Athena automatically retries your queries in cases of certain transient errors. As
        /// a result, you may see the query state transition from <c>RUNNING</c> or <c>FAILED</c>
        /// to <c>QUEUED</c>. 
        /// </para>
        ///  </note>
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
        public DateTime? SubmissionDateTime
        {
            get { return this._submissionDateTime; }
            set { this._submissionDateTime = value; }
        }

        // Check to see if SubmissionDateTime property is set
        internal bool IsSetSubmissionDateTime()
        {
            return this._submissionDateTime.HasValue; 
        }

    }
}