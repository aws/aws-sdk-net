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
    /// This is the response object from the GetContactChannel operation.
    /// </summary>
    public partial class GetContactChannelResponse : AmazonWebServiceResponse
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
        /// A Boolean value indicating if the contact channel has been activated or not.
        /// </para>
        /// </summary>
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
        /// The ARN of the contact that the channel belongs to.
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
        /// The ARN of the contact channel.
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
        /// The name of the contact channel
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
        /// The type of contact channel. The type is <code>SMS</code>, <code>VOICE</code>, or
        /// <code>EMAIL</code>.
        /// </para>
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