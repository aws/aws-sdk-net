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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Represents user feedback for an investigation result. This structure captures the
    /// user's evaluation of the investigation's quality, usefulness, and any additional comments.
    /// </summary>
    public partial class InvestigationFeedback
    {
        private string _comment;
        private DateTime? _submittedAt;
        private UsefulnessRating _usefulness;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Optional user comments providing additional context about the investigation feedback.
        /// This allows users to explain their rating or provide suggestions for improvement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// ISO 8601 timestamp when the feedback was submitted. This records when the user provided
        /// their assessment of the investigation results.
        /// </para>
        /// </summary>
        public DateTime SubmittedAt
        {
            get { return this._submittedAt.GetValueOrDefault(); }
            set { this._submittedAt = value; }
        }

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this._submittedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Usefulness. 
        /// <para>
        /// User assessment of the investigation result's quality and helpfulness. This rating
        /// indicates how valuable the investigation findings were in addressing the case.
        /// </para>
        /// </summary>
        public UsefulnessRating Usefulness
        {
            get { return this._usefulness; }
            set { this._usefulness = value; }
        }

        // Check to see if Usefulness property is set
        internal bool IsSetUsefulness()
        {
            return this._usefulness != null;
        }

    }
}