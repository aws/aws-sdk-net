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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// A record created when a user submits a form card.
    /// </summary>
    public partial class Submission
    {
        private string _submissionId;
        private DateTime? _timestamp;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property SubmissionId. 
        /// <para>
        /// The unique identifier of the submission.
        /// </para>
        /// </summary>
        public string SubmissionId
        {
            get { return this._submissionId; }
            set { this._submissionId = value; }
        }

        // Check to see if SubmissionId property is set
        internal bool IsSetSubmissionId()
        {
            return this._submissionId != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time when the card is submitted.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The data submitted by the user.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}