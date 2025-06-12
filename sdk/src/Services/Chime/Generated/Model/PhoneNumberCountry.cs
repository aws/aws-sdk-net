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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// The phone number country.
    /// </summary>
    public partial class PhoneNumberCountry
    {
        private string _countryCode;
        private List<string> _supportedPhoneNumberTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The phone number country code. Format: ISO 3166-1 alpha-2.
        /// </para>
        /// </summary>
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPhoneNumberTypes. 
        /// <para>
        /// The supported phone number types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedPhoneNumberTypes
        {
            get { return this._supportedPhoneNumberTypes; }
            set { this._supportedPhoneNumberTypes = value; }
        }

        // Check to see if SupportedPhoneNumberTypes property is set
        internal bool IsSetSupportedPhoneNumberTypes()
        {
            return this._supportedPhoneNumberTypes != null && (this._supportedPhoneNumberTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}