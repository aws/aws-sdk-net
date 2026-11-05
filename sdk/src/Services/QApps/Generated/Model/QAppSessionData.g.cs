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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// The response collected for a Amazon Q App session. This container represents a single
    /// response to a Q App session.
    /// </summary>
    public partial class QAppSessionData
    {
        /// <summary>
        /// Gets and sets the property CardId. 
        /// <para>
        /// The card Id associated with the response submitted for a Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CardId { get; set; }

        /// <summary>
        /// Checks to see if the CardId property is set.
        /// </summary>
        internal bool IsSetCardId() => this.CardId != null;

        /// <summary>
        /// Gets and sets the property SubmissionId. 
        /// <para>
        /// The unique identifier of the submission.
        /// </para>
        /// </summary>
        public string SubmissionId { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionId property is set.
        /// </summary>
        internal bool IsSetSubmissionId() => this.SubmissionId != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time when the session data is submitted.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user who submitted the response for a Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public User User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The response submitted for a Q App session.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => !this.Value.IsNull();
    }
}
