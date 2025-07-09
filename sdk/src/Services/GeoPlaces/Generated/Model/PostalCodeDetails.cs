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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Contains details about the postal code of the place or result.
    /// </summary>
    public partial class PostalCodeDetails
    {
        private PostalAuthority _postalAuthority;
        private string _postalCode;
        private PostalCodeType _postalCodeType;
        private UspsZip _uspsZip;
        private UspsZipPlus4 _uspsZipPlus4;

        /// <summary>
        /// Gets and sets the property PostalAuthority. 
        /// <para>
        /// The postal authority or entity. This could be a governmental authority, a regulatory
        /// authority, or a designated postal operator.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PostalAuthority PostalAuthority
        {
            get { return this._postalAuthority; }
            set { this._postalAuthority = value; }
        }

        // Check to see if PostalAuthority property is set
        internal bool IsSetPostalAuthority()
        {
            return this._postalAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code for which the result should possess. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
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
        /// Gets and sets the property PostalCodeType. 
        /// <para>
        /// The postal code type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public PostalCodeType PostalCodeType
        {
            get { return this._postalCodeType; }
            set { this._postalCodeType = value; }
        }

        // Check to see if PostalCodeType property is set
        internal bool IsSetPostalCodeType()
        {
            return this._postalCodeType != null;
        }

        /// <summary>
        /// Gets and sets the property UspsZip. 
        /// <para>
        /// The ZIP Classification Code, or in other words what type of postal code is it.
        /// </para>
        /// </summary>
        public UspsZip UspsZip
        {
            get { return this._uspsZip; }
            set { this._uspsZip = value; }
        }

        // Check to see if UspsZip property is set
        internal bool IsSetUspsZip()
        {
            return this._uspsZip != null;
        }

        /// <summary>
        /// Gets and sets the property UspsZipPlus4. 
        /// <para>
        /// The USPS ZIP+4 Record Type Code.
        /// </para>
        /// </summary>
        public UspsZipPlus4 UspsZipPlus4
        {
            get { return this._uspsZipPlus4; }
            set { this._uspsZipPlus4 = value; }
        }

        // Check to see if UspsZipPlus4 property is set
        internal bool IsSetUspsZipPlus4()
        {
            return this._uspsZipPlus4 != null;
        }

    }
}