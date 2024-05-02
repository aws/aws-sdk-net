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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _comment;
        private MessageUsefulnessReason _reason;
        private DateTime? _submittedAt;
        private MessageUsefulness _usefulness;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment given by an end user on the usefulness of an AI-generated chat message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for a usefulness rating.
        /// </para>
        /// </summary>
        public MessageUsefulnessReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The timestamp for when the feedback was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmittedAt
        {
            get { return this._submittedAt; }
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
        /// The usefulness value assigned by an end user to a message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageUsefulness Usefulness
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