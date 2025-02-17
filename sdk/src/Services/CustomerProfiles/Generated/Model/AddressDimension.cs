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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Object that segments on Customer Profile's address object.
    /// </summary>
    public partial class AddressDimension
    {
        private ProfileDimension _city;
        private ProfileDimension _country;
        private ProfileDimension _county;
        private ProfileDimension _postalCode;
        private ProfileDimension _province;
        private ProfileDimension _state;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension City
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
        /// The country belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension Country
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
        /// Gets and sets the property County. 
        /// <para>
        /// The county belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension County
        {
            get { return this._county; }
            set { this._county = value; }
        }

        // Check to see if County property is set
        internal bool IsSetCounty()
        {
            return this._county != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension PostalCode
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
        /// Gets and sets the property Province. 
        /// <para>
        /// The province belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension Province
        {
            get { return this._province; }
            set { this._province = value; }
        }

        // Check to see if Province property is set
        internal bool IsSetProvince()
        {
            return this._province != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state belonging to the address.
        /// </para>
        /// </summary>
        public ProfileDimension State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}