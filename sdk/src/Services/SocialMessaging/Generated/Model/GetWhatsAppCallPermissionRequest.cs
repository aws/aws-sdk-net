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
    /// Container for the parameters to the GetWhatsAppCallPermission operation.
    /// Retrieves the current calling permission for a WhatsApp end user, along with the calling
    /// actions the business is allowed to take with that user. Provide the destination phone
    /// number or the business-scoped user ID to identify the end user.
    /// </summary>
    public partial class GetWhatsAppCallPermissionRequest : AmazonSocialMessagingRequest
    {
        private string _destinationPhoneNumber;
        private string _endUserBsuid;
        private string _originationPhoneNumberId;

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. 
        /// <para>
        /// The end user's phone number, in E.164 format, for which to retrieve the calling permission.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=20)]
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property EndUserBsuid. 
        /// <para>
        /// The business-scoped user identifier (BSUID) of the end user for which to retrieve
        /// the calling permission.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string EndUserBsuid
        {
            get { return this._endUserBsuid; }
            set { this._endUserBsuid = value; }
        }

        // Check to see if EndUserBsuid property is set
        internal bool IsSetEndUserBsuid()
        {
            return this._endUserBsuid != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the business phone number for which to retrieve the calling
        /// permission. The phone number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
        public string OriginationPhoneNumberId
        {
            get { return this._originationPhoneNumberId; }
            set { this._originationPhoneNumberId = value; }
        }

        // Check to see if OriginationPhoneNumberId property is set
        internal bool IsSetOriginationPhoneNumberId()
        {
            return this._originationPhoneNumberId != null;
        }

    }
}