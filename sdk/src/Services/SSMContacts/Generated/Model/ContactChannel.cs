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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// The method that Incident Manager uses to engage a contact.
    /// </summary>
    public partial class ContactChannel
    {
        private ActivationStatus _activationStatus;
        private string _contactArn;
        private string _contactChannelArn;
        private ContactChannelAddress _deliveryAddress;
        private string _name;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property ActivationStatus. 
        /// <para>
        /// A Boolean value describing if the contact channel has been activated or not. If the
        /// contact channel isn't activated, Incident Manager can't engage the contact through
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActivationStatus ActivationStatus
        {
            get { return this._activationStatus; }
            set { this._activationStatus = value; }
        }

        // Check to see if ActivationStatus property is set
        internal bool IsSetActivationStatus()
        {
            return this._activationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact that contains the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property ContactChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ContactChannelArn
        {
            get { return this._contactChannelArn; }
            set { this._contactChannelArn = value; }
        }

        // Check to see if ContactChannelArn property is set
        internal bool IsSetContactChannelArn()
        {
            return this._contactChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryAddress. 
        /// <para>
        /// The details that Incident Manager uses when trying to engage the contact channel.
        /// </para>
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
        /// The type of the contact channel. Incident Manager supports three contact methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SMS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VOICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL
        /// </para>
        ///  </li> </ul>
        /// </summary>
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