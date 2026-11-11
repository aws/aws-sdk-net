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
    /// Contact summary of a contact in contact tree associated with unique identifier.
    /// </summary>
    public partial class AssociatedContactSummary
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// How the contact reached your contact center.
        /// </para>
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact
        /// </para>
        /// </summary>
        public string ContactArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactArn property is set.
        /// </summary>
        internal bool IsSetContactArn() => this.ContactArn != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The date and time that the customer endpoint disconnected from the current contact,
        /// in UTC time. In transfer scenarios, the DisconnectTimestamp of the previous contact
        /// indicates the date and time when that contact ended.
        /// </para>
        /// </summary>
        public DateTime? DisconnectTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectTimestamp property is set.
        /// </summary>
        internal bool IsSetDisconnectTimestamp() => this.DisconnectTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// If this contact is related to other contacts, this is the ID of the initial contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InitialContactId { get; set; }

        /// <summary>
        /// Checks to see if the InitialContactId property is set.
        /// </summary>
        internal bool IsSetInitialContactId() => this.InitialContactId != null;

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod { get; set; }

        /// <summary>
        /// Checks to see if the InitiationMethod property is set.
        /// </summary>
        internal bool IsSetInitiationMethod() => this.InitiationMethod != null;

        /// <summary>
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        /// The date and time this contact was initiated, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? InitiationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the InitiationTimestamp property is set.
        /// </summary>
        internal bool IsSetInitiationTimestamp() => this.InitiationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// If this contact is not the first contact, this is the ID of the previous contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PreviousContactId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousContactId property is set.
        /// </summary>
        internal bool IsSetPreviousContactId() => this.PreviousContactId != null;

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId that is related to this contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;
    }
}
