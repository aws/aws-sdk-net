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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The current status of an archive search job.
    /// </summary>
    public partial class SearchStatus
    {
        /// <summary>
        /// Gets and sets the property CompletionTimestamp. 
        /// <para>
        /// The timestamp of when the search completed (if finished).
        /// </para>
        /// </summary>
        public DateTime? CompletionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletionTimestamp() => this.CompletionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message if the search failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the search job.
        /// </para>
        /// </summary>
        public SearchState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubmissionTimestamp. 
        /// <para>
        /// The timestamp of when the search was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmissionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionTimestamp property is set.
        /// </summary>
        internal bool IsSetSubmissionTimestamp() => this.SubmissionTimestamp.HasValue;
    }
}
