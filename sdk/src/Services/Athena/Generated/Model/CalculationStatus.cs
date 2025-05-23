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
    /// Contains information about the status of a notebook calculation.
    /// </summary>
    public partial class CalculationStatus
    {
        private DateTime? _completionDateTime;
        private CalculationExecutionState _state;
        private string _stateChangeReason;
        private DateTime? _submissionDateTime;

        /// <summary>
        /// Gets and sets the property CompletionDateTime. 
        /// <para>
        /// The date and time the calculation completed processing.
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
        /// The state of the calculation execution. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATING</c> - The calculation is in the process of being created.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED</c> - The calculation has been created and is ready to run.
        /// </para>
        ///  
        /// <para>
        ///  <c>QUEUED</c> - The calculation has been queued for processing.
        /// </para>
        ///  
        /// <para>
        ///  <c>RUNNING</c> - The calculation is running.
        /// </para>
        ///  
        /// <para>
        ///  <c>CANCELING</c> - A request to cancel the calculation has been received and the
        /// system is working to stop it.
        /// </para>
        ///  
        /// <para>
        ///  <c>CANCELED</c> - The calculation is no longer running as the result of a cancel
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <c>COMPLETED</c> - The calculation has completed without error.
        /// </para>
        ///  
        /// <para>
        ///  <c>FAILED</c> - The calculation failed and is no longer running.
        /// </para>
        /// </summary>
        public CalculationExecutionState State
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
        /// The reason for the calculation state change (for example, the calculation was canceled
        /// because the session was terminated).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The date and time the calculation was submitted for processing.
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