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
    /// Container for the parameters to the UpdateLinkedWhatsAppBusinessAccountPhoneNumber operation.
    /// Updates the calling settings for a linked WhatsApp business phone number, such as
    /// whether calling is enabled and the hours during which the business accepts calls.
    /// </summary>
    public partial class UpdateLinkedWhatsAppBusinessAccountPhoneNumberRequest : AmazonSocialMessagingRequest
    {
        private WhatsAppCallSettings _callSettings;
        private string _id;

        /// <summary>
        /// Gets and sets the property CallSettings. 
        /// <para>
        /// The calling settings to apply to the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WhatsAppCallSettings CallSettings
        {
            get { return this._callSettings; }
            set { this._callSettings = value; }
        }

        // Check to see if CallSettings property is set
        internal bool IsSetCallSettings()
        {
            return this._callSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the phone number to update. The phone number identifiers
        /// are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
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