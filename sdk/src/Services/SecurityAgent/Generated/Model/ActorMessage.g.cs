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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A message received at an actor's server-generated email MFA address.
    /// </summary>
    public partial class ActorMessage
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The plain-text body of the message, containing the MFA code or verification link.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ReceivedAt. 
        /// <para>
        /// The time the message was received.
        /// </para>
        /// </summary>
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedAt property is set.
        /// </summary>
        internal bool IsSetReceivedAt() => this.ReceivedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Sender. 
        /// <para>
        /// The address the message was sent from.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Sender { get; set; }

        /// <summary>
        /// Checks to see if the Sender property is set.
        /// </summary>
        internal bool IsSetSender() => this.Sender != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject line of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
