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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the contact evaluations where the key is the FormId, which is a
    /// unique identifier for the form.
    /// </summary>
    public partial class ContactEvaluation
    {
        private DateTime? _deleteTimestamp;
        private DateTime? _endTimestamp;
        private string _evaluationArn;
        private string _exportLocation;
        private string _formId;
        private DateTime? _startTimestamp;
        private Status _status;

        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time when the evaluation was deleted, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp
        {
            get { return this._deleteTimestamp; }
            set { this._deleteTimestamp = value; }
        }

        // Check to see if DeleteTimestamp property is set
        internal bool IsSetDeleteTimestamp()
        {
            return this._deleteTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the evaluation was submitted, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name for the evaluation form. It is always present.
        /// </para>
        /// </summary>
        public string EvaluationArn
        {
            get { return this._evaluationArn; }
            set { this._evaluationArn = value; }
        }

        // Check to see if EvaluationArn property is set
        internal bool IsSetEvaluationArn()
        {
            return this._evaluationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportLocation. 
        /// <para>
        /// The path where evaluation was exported.
        /// </para>
        /// </summary>
        public string ExportLocation
        {
            get { return this._exportLocation; }
            set { this._exportLocation = value; }
        }

        // Check to see if ExportLocation property is set
        internal bool IsSetExportLocation()
        {
            return this._exportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property FormId. 
        /// <para>
        /// The <c>FormId</c> of the contact evaluation.
        /// </para>
        /// </summary>
        public string FormId
        {
            get { return this._formId; }
            set { this._formId = value; }
        }

        // Check to see if FormId property is set
        internal bool IsSetFormId()
        {
            return this._formId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the evaluation was started, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation.
        /// </para>
        /// </summary>
        public Status Status
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