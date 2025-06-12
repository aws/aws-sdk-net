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
    /// The registration details for a linked phone number.
    /// </summary>
    public partial class WabaPhoneNumberSetupFinalization
    {
        private string _dataLocalizationRegion;
        private string _id;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _twoFactorPin;

        /// <summary>
        /// Gets and sets the property DataLocalizationRegion. 
        /// <para>
        /// The two letter ISO region for the location of where Meta will store data.
        /// </para>
        ///  
        /// <para>
        ///  <b>Asia–Pacific (APAC)</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Australia <b>AU</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Indonesia <b>ID</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// India <b>IN</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Japan <b>JP</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Singapore <b>SG</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South Korea <b>KR</b> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Europe</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Germany <b>DE</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Switzerland <b>CH</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// United Kingdom <b>GB</b> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Latin America (LATAM)</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Brazil <b>BR</b> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Middle East and Africa (MEA)</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Bahrain <b>BH</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// South Africa <b>ZA</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// United Arab Emirates <b>AE</b> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>North America (NORAM)</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Canada <b>CA</b> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string DataLocalizationRegion
        {
            get { return this._dataLocalizationRegion; }
            set { this._dataLocalizationRegion = value; }
        }

        // Check to see if DataLocalizationRegion property is set
        internal bool IsSetDataLocalizationRegion()
        {
            return this._dataLocalizationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the originating phone number associated with the media. Phone
        /// number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_GetLinkedWhatsAppBusinessAccountPhoneNumber.html">GetLinkedWhatsAppBusinessAccount</a>
        /// to find a phone number's id.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key and value pair tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TwoFactorPin. 
        /// <para>
        /// The PIN to use for two-step verification. To reset your PIN follow the directions
        /// in <a href="https://developers.facebook.com/docs/whatsapp/cloud-api/reference/two-step-verification/#updating-pin">Updating
        /// PIN</a> in the <i>WhatsApp Business Platform Cloud API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=6)]
        public string TwoFactorPin
        {
            get { return this._twoFactorPin; }
            set { this._twoFactorPin = value; }
        }

        // Check to see if TwoFactorPin property is set
        internal bool IsSetTwoFactorPin()
        {
            return this._twoFactorPin != null;
        }

    }
}