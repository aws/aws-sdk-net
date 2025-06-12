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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The metadata for an origination identity associated with a pool.
    /// </summary>
    public partial class OriginationIdentityMetadata
    {
        private string _isoCountryCode;
        private List<string> _numberCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _originationIdentity;
        private string _originationIdentityArn;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string IsoCountryCode
        {
            get { return this._isoCountryCode; }
            set { this._isoCountryCode = value; }
        }

        // Check to see if IsoCountryCode property is set
        internal bool IsSetIsoCountryCode()
        {
            return this._isoCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// Describes if the origination identity can be used for text messages, voice calls or
        /// both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> NumberCapabilities
        {
            get { return this._numberCapabilities; }
            set { this._numberCapabilities = value; }
        }

        // Check to see if NumberCapabilities property is set
        internal bool IsSetNumberCapabilities()
        {
            return this._numberCapabilities != null && (this._numberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The unique identifier of the origination identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the origination identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginationIdentityArn
        {
            get { return this._originationIdentityArn; }
            set { this._originationIdentityArn = value; }
        }

        // Check to see if OriginationIdentityArn property is set
        internal bool IsSetOriginationIdentityArn()
        {
            return this._originationIdentityArn != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

    }
}