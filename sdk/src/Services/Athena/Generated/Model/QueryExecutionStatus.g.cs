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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// The completion date, current state, submission time, and state change reason (if applicable)
    /// for the query execution.
    /// </summary>
    public partial class QueryExecutionStatus
    {
        /// <summary>
        /// Gets and sets the property AthenaError. 
        /// <para>
        /// Provides information about an Athena query error.
        /// </para>
        /// </summary>
        public AthenaError AthenaError { get; set; }

        /// <summary>
        /// Checks to see if the AthenaError property is set.
        /// </summary>
        internal bool IsSetAthenaError() => this.AthenaError != null;

        /// <summary>
        /// Gets and sets the property CompletionDateTime. 
        /// <para>
        /// The date and time that the query completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDateTime property is set.
        /// </summary>
        internal bool IsSetCompletionDateTime() => this.CompletionDateTime.HasValue;

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
        /// For queries that experience certain transient errors, the state transitions from <c>RUNNING</c>
        /// back to <c>QUEUED</c>. The <c>FAILED</c> state is always terminal with no automatic
        /// retry. 
        /// </para>
        ///  </note>
        /// </summary>
        public QueryExecutionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// Further detail about the status of the query.
        /// </para>
        /// </summary>
        public string StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;

        /// <summary>
        /// Gets and sets the property SubmissionDateTime. 
        /// <para>
        /// The date and time that the query was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmissionDateTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionDateTime property is set.
        /// </summary>
        internal bool IsSetSubmissionDateTime() => this.SubmissionDateTime.HasValue;
    }
}
