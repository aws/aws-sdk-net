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
    /// The contact configuration for push notification registration.
    /// </summary>
    public partial class ContactConfiguration
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact within the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property IncludeRawMessage. 
        /// <para>
        /// Whether to include raw connect message in the push notification payload. Default is
        /// <c>False</c>.
        /// </para>
        /// </summary>
        public bool? IncludeRawMessage { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRawMessage property is set.
        /// </summary>
        internal bool IsSetIncludeRawMessage() => this.IncludeRawMessage.HasValue;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant in the chat conversation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only <c>CUSTOMER</c> is currently supported. Any other values other than <c>CUSTOMER</c>
        /// will result in an exception (4xx error).
        /// </para>
        ///  </note>
        /// </summary>
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;
    }
}
