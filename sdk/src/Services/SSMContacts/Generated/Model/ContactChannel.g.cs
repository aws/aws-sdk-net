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
    /// The method that Incident Manager uses to engage a contact.
    /// </summary>
    public partial class ContactChannel
    {
        /// <summary>
        /// Gets and sets the property ActivationStatus. 
        /// <para>
        /// A Boolean value describing if the contact channel has been activated or not. If the
        /// contact channel isn't activated, Incident Manager can't engage the contact through
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivationStatus ActivationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivationStatus property is set.
        /// </summary>
        internal bool IsSetActivationStatus() => this.ActivationStatus != null;

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact that contains the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactArn property is set.
        /// </summary>
        internal bool IsSetContactArn() => this.ContactArn != null;

        /// <summary>
        /// Gets and sets the property ContactChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactChannelArn property is set.
        /// </summary>
        internal bool IsSetContactChannelArn() => this.ContactChannelArn != null;

        /// <summary>
        /// Gets and sets the property DeliveryAddress. 
        /// <para>
        /// The details that Incident Manager uses when trying to engage the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContactChannelAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryAddress property is set.
        /// </summary>
        internal bool IsSetDeliveryAddress() => this.DeliveryAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public ChannelType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
