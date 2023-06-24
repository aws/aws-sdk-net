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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A validated address.
    /// </summary>
    public partial class Address
    {
        private string _city;
        private string _country;
        private string _postalCode;
        private string _postalCodePlus4;
        private string _postDirectional;
        private string _preDirectional;
        private string _state;
        private string _streetName;
        private string _streetNumber;
        private string _streetSuffix;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCodePlus4. 
        /// <para>
        /// The zip + 4 or postal code + 4 of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PostalCodePlus4
        {
            get { return this._postalCodePlus4; }
            set { this._postalCodePlus4 = value; }
        }

        // Check to see if PostalCodePlus4 property is set
        internal bool IsSetPostalCodePlus4()
        {
            return this._postalCodePlus4 != null;
        }

        /// <summary>
        /// Gets and sets the property PostDirectional. 
        /// <para>
        /// An address suffix location, such as the <code>S. Unit A</code> in <code>Central Park
        /// S. Unit A</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PostDirectional
        {
            get { return this._postDirectional; }
            set { this._postDirectional = value; }
        }

        // Check to see if PostDirectional property is set
        internal bool IsSetPostDirectional()
        {
            return this._postDirectional != null;
        }

        /// <summary>
        /// Gets and sets the property PreDirectional. 
        /// <para>
        /// An address prefix location, such as the <code>N</code> in <code>N. Third St.</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PreDirectional
        {
            get { return this._preDirectional; }
            set { this._preDirectional = value; }
        }

        // Check to see if PreDirectional property is set
        internal bool IsSetPreDirectional()
        {
            return this._preDirectional != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StreetName. 
        /// <para>
        /// The address street, such as <code>8th Avenue</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StreetName
        {
            get { return this._streetName; }
            set { this._streetName = value; }
        }

        // Check to see if StreetName property is set
        internal bool IsSetStreetName()
        {
            return this._streetName != null;
        }

        /// <summary>
        /// Gets and sets the property StreetNumber. 
        /// <para>
        /// The numeric portion of an address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StreetNumber
        {
            get { return this._streetNumber; }
            set { this._streetNumber = value; }
        }

        // Check to see if StreetNumber property is set
        internal bool IsSetStreetNumber()
        {
            return this._streetNumber != null;
        }

        /// <summary>
        /// Gets and sets the property StreetSuffix. 
        /// <para>
        /// The address suffix, such as the <code>N</code> in <code>8th Avenue N</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StreetSuffix
        {
            get { return this._streetSuffix; }
            set { this._streetSuffix = value; }
        }

        // Check to see if StreetSuffix property is set
        internal bool IsSetStreetSuffix()
        {
            return this._streetSuffix != null;
        }

    }
}