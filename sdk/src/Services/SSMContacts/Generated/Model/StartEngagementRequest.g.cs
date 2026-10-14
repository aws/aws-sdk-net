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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the StartEngagement operation. Starts an engagement
    /// to a contact or escalation plan. The engagement engages each contact specified in
    /// the incident.
    /// </summary>
    public partial class StartEngagementRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact being engaged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The secure content of the message that was sent to the contact. Use this field for
        /// engagements to <c>VOICE</c> or <c>EMAIL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property IncidentId. 
        /// <para>
        /// The ARN of the incident that the engagement is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IncidentId { get; set; }

        /// <summary>
        /// Checks to see if the IncidentId property is set.
        /// </summary>
        internal bool IsSetIncidentId() => this.IncidentId != null;

        /// <summary>
        /// Gets and sets the property PublicContent. 
        /// <para>
        /// The insecure content of the message that was sent to the contact. Use this field for
        /// engagements to <c>SMS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string PublicContent { get; set; }

        /// <summary>
        /// Checks to see if the PublicContent property is set.
        /// </summary>
        internal bool IsSetPublicContent() => this.PublicContent != null;

        /// <summary>
        /// Gets and sets the property PublicSubject. 
        /// <para>
        /// The insecure subject of the message that was sent to the contact. Use this field for
        /// engagements to <c>SMS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PublicSubject { get; set; }

        /// <summary>
        /// Checks to see if the PublicSubject property is set.
        /// </summary>
        internal bool IsSetPublicSubject() => this.PublicSubject != null;

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The user that started the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Sender { get; set; }

        /// <summary>
        /// Checks to see if the Sender property is set.
        /// </summary>
        internal bool IsSetSender() => this.Sender != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The secure subject of the message that was sent to the contact. Use this field for
        /// engagements to <c>VOICE</c> or <c>EMAIL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
