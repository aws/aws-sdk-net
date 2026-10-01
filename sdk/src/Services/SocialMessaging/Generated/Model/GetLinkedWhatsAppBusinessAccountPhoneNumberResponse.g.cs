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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// This is the response object from the GetLinkedWhatsAppBusinessAccountPhoneNumber operation.
    /// </summary>
    public partial class GetLinkedWhatsAppBusinessAccountPhoneNumberResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CallSettings. 
        /// <para>
        /// The calling settings configured for the phone number. This value is absent when calling
        /// is not configured.
        /// </para>
        /// </summary>
        public WhatsAppCallSettings CallSettings { get; set; }

        /// <summary>
        /// Checks to see if the CallSettings property is set.
        /// </summary>
        internal bool IsSetCallSettings() => this.CallSettings != null;

        /// <summary>
        /// Gets and sets the property LinkedWhatsAppBusinessAccountId. 
        /// <para>
        /// The WABA identifier linked to the phone number, formatted as <c>waba-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 115)]
        public string LinkedWhatsAppBusinessAccountId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedWhatsAppBusinessAccountId property is set.
        /// </summary>
        internal bool IsSetLinkedWhatsAppBusinessAccountId() => this.LinkedWhatsAppBusinessAccountId != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber.
        /// </summary>
        public WhatsAppPhoneNumberDetail PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;
    }
}
