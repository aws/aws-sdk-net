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
    /// Container for the parameters to the UpdateContactChannel operation.
    /// Updates a contact's contact channel.
    /// </summary>
    public partial class UpdateContactChannelRequest : AmazonSSMContactsRequest
    {
        private string _contactChannelId;
        private ContactChannelAddress _deliveryAddress;
        private string _name;

        /// <summary>
        /// Gets and sets the property ContactChannelId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact channel you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ContactChannelId
        {
            get { return this._contactChannelId; }
            set { this._contactChannelId = value; }
        }

        // Check to see if ContactChannelId property is set
        internal bool IsSetContactChannelId()
        {
            return this._contactChannelId != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryAddress. 
        /// <para>
        /// The details that Incident Manager uses when trying to engage the contact channel.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min=1, Max=255)]
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

    }
}