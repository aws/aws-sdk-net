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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private Channel _channel;
        private string _contactArn;
        private string _contactId;
        private DateTime? _disconnectTimestamp;
        private string _initialContactId;
        private ContactInitiationMethod _initiationMethod;
        private DateTime? _initiationTimestamp;
        private string _previousContactId;
        private string _relatedContactId;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// How the contact reached your contact center.
        /// </para>
        /// </summary>
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact
        /// </para>
        /// </summary>
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The date and time that the customer endpoint disconnected from the current contact,
        /// in UTC time. In transfer scenarios, the DisconnectTimestamp of the previous contact
        /// indicates the date and time when that contact ended.
        /// </para>
        /// </summary>
        public DateTime? DisconnectTimestamp
        {
            get { return this._disconnectTimestamp; }
            set { this._disconnectTimestamp = value; }
        }

        // Check to see if DisconnectTimestamp property is set
        internal bool IsSetDisconnectTimestamp()
        {
            return this._disconnectTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// If this contact is related to other contacts, this is the ID of the initial contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod
        {
            get { return this._initiationMethod; }
            set { this._initiationMethod = value; }
        }

        // Check to see if InitiationMethod property is set
        internal bool IsSetInitiationMethod()
        {
            return this._initiationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        /// The date and time this contact was initiated, in UTC time.
        /// </para>
        /// </summary>
        public DateTime? InitiationTimestamp
        {
            get { return this._initiationTimestamp; }
            set { this._initiationTimestamp = value; }
        }

        // Check to see if InitiationTimestamp property is set
        internal bool IsSetInitiationTimestamp()
        {
            return this._initiationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// If this contact is not the first contact, this is the ID of the previous contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PreviousContactId
        {
            get { return this._previousContactId; }
            set { this._previousContactId = value; }
        }

        // Check to see if PreviousContactId property is set
        internal bool IsSetPreviousContactId()
        {
            return this._previousContactId != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId that is related to this contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RelatedContactId
        {
            get { return this._relatedContactId; }
            set { this._relatedContactId = value; }
        }

        // Check to see if RelatedContactId property is set
        internal bool IsSetRelatedContactId()
        {
            return this._relatedContactId != null;
        }

    }
}