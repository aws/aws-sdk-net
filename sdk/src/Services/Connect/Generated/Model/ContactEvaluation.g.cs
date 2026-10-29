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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the contact evaluations where the key is the FormId, which is a
    /// unique identifier for the form.
    /// </summary>
    public partial class ContactEvaluation
    {
        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time when the evaluation was deleted, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTimestamp property is set.
        /// </summary>
        internal bool IsSetDeleteTimestamp() => this.DeleteTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// The date and time when the evaluation was submitted, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndTimestamp property is set.
        /// </summary>
        internal bool IsSetEndTimestamp() => this.EndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name for the evaluation form. It is always present.
        /// </para>
        /// </summary>
        public string EvaluationArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationArn property is set.
        /// </summary>
        internal bool IsSetEvaluationArn() => this.EvaluationArn != null;

        /// <summary>
        /// Gets and sets the property ExportLocation. 
        /// <para>
        /// The path where evaluation was exported.
        /// </para>
        /// </summary>
        public string ExportLocation { get; set; }

        /// <summary>
        /// Checks to see if the ExportLocation property is set.
        /// </summary>
        internal bool IsSetExportLocation() => this.ExportLocation != null;

        /// <summary>
        /// Gets and sets the property FormId. 
        /// <para>
        /// The <c>FormId</c> of the contact evaluation.
        /// </para>
        /// </summary>
        public string FormId { get; set; }

        /// <summary>
        /// Checks to see if the FormId property is set.
        /// </summary>
        internal bool IsSetFormId() => this.FormId != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time when the evaluation was started, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
