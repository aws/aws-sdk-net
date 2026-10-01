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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// End user feedback on an AI-generated web experience chat message usefulness.
    /// </summary>
    public partial class MessageUsefulnessFeedback
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment given by an end user on the usefulness of an AI-generated chat message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for a usefulness rating.
        /// </para>
        /// </summary>
        public MessageUsefulnessReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The timestamp for when the feedback was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Usefulness. 
        /// <para>
        /// The usefulness value assigned by an end user to a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageUsefulness Usefulness { get; set; }

        /// <summary>
        /// Checks to see if the Usefulness property is set.
        /// </summary>
        internal bool IsSetUsefulness() => this.Usefulness != null;
    }
}
