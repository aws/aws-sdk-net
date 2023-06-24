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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// A suggested address.
    /// </summary>
    public partial class CandidateAddress
    {
        private string _city;
        private string _country;
        private string _postalCode;
        private string _postalCodePlus4;
        private string _state;
        private string _streetInfo;
        private string _streetNumber;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of a candidate address.
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
        /// The country of a candidate address.
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
        /// The postal code of a candidate address.
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
        /// The Zip + 4 or postal code + 4 of a candidate address.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of a candidate address.
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
        /// Gets and sets the property StreetInfo. 
        /// <para>
        /// The street information of a candidate address
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StreetInfo
        {
            get { return this._streetInfo; }
            set { this._streetInfo = value; }
        }

        // Check to see if StreetInfo property is set
        internal bool IsSetStreetInfo()
        {
            return this._streetInfo != null;
        }

        /// <summary>
        /// Gets and sets the property StreetNumber. 
        /// <para>
        /// The numeric portion of a candidate address.
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

    }
}