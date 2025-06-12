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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the PutWhatsAppBusinessAccountEventDestinations operation.
    /// Add an event destination to log event data from WhatsApp for a WhatsApp Business Account
    /// (WABA). A WABA can only have one event destination at a time. All resources associated
    /// with the WABA use the same event destination.
    /// </summary>
    public partial class PutWhatsAppBusinessAccountEventDestinationsRequest : AmazonSocialMessagingRequest
    {
        private List<WhatsAppBusinessAccountEventDestination> _eventDestinations = AWSConfigs.InitializeCollections ? new List<WhatsAppBusinessAccountEventDestination>() : null;
        private string _id;

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// An array of <c>WhatsAppBusinessAccountEventDestination</c> event destinations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<WhatsAppBusinessAccountEventDestination> EventDestinations
        {
            get { return this._eventDestinations; }
            set { this._eventDestinations = value; }
        }

        // Check to see if EventDestinations property is set
        internal bool IsSetEventDestinations()
        {
            return this._eventDestinations != null && (this._eventDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of your WhatsApp Business Account. WABA identifiers are formatted
        /// as <c>waba-01234567890123456789012345678901</c>. Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_ListLinkedWhatsAppBusinessAccounts.html">ListLinkedWhatsAppBusinessAccounts</a>
        /// to list all WABAs and their details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}