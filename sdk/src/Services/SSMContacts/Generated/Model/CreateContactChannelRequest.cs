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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
    /// Container for the parameters to the CreateContactChannel operation.
    /// A contact channel is the method that Incident Manager uses to engage your contact.
    /// </summary>
    public partial class CreateContactChannelRequest : AmazonSSMContactsRequest
    {
        private string _contactId;
        private bool? _deferActivation;
        private ContactChannelAddress _deliveryAddress;
        private string _idempotencyToken;
        private string _name;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact you are adding the contact channel to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property DeferActivation. 
        /// <para>
        /// If you want to activate the channel at a later time, you can choose to defer activation.
        /// Incident Manager can't engage your contact channel until it has been activated.
        /// </para>
        /// </summary>
        public bool? DeferActivation
        {
            get { return this._deferActivation; }
            set { this._deferActivation = value; }
        }

        // Check to see if DeferActivation property is set
        internal bool IsSetDeferActivation()
        {
            return this._deferActivation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryAddress. 
        /// <para>
        /// The details that Incident Manager uses when trying to engage the contact channel.
        /// The format is dependent on the type of the contact channel. The following are the
        /// expected formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SMS - '+' followed by the country code and phone number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VOICE - '+' followed by the country code and phone number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL - any standard email format
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactChannelAddress DeliveryAddress
        {
            get { return this._deliveryAddress; }
            set { this._deliveryAddress = value; }
        }

        // Check to see if DeliveryAddress property is set
        internal bool IsSetDeliveryAddress()
        {
            return this._deliveryAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Incident Manager supports three types of contact channels:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SMS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VOICE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}