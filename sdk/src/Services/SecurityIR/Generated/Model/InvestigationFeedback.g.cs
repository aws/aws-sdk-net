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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Represents user feedback for an investigation result. This structure captures the
    /// user's evaluation of the investigation's quality, usefulness, and any additional comments.
    /// </summary>
    public partial class InvestigationFeedback
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Optional user comments providing additional context about the investigation feedback.
        /// This allows users to explain their rating or provide suggestions for improvement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// ISO 8601 timestamp when the feedback was submitted. This records when the user provided
        /// their assessment of the investigation results.
        /// </para>
        /// </summary>
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Usefulness. 
        /// <para>
        /// User assessment of the investigation result's quality and helpfulness. This rating
        /// indicates how valuable the investigation findings were in addressing the case.
        /// </para>
        /// </summary>
        public UsefulnessRating Usefulness { get; set; }

        /// <summary>
        /// Checks to see if the Usefulness property is set.
        /// </summary>
        internal bool IsSetUsefulness() => this.Usefulness != null;
    }
}
