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
    /// A generic address associated with the customer that is not mailing, shipping, or billing.
    /// </summary>
    public partial class Address
    {
        private string _address1;
        private string _address2;
        private string _address3;
        private string _address4;
        private string _city;
        private string _country;
        private string _county;
        private string _postalCode;
        private string _province;
        private string _state;

        /// <summary>
        /// Gets and sets the property Address1. 
        /// <para>
        /// The first line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Address1
        {
            get { return this._address1; }
            set { this._address1 = value; }
        }

        // Check to see if Address1 property is set
        internal bool IsSetAddress1()
        {
            return this._address1 != null;
        }

        /// <summary>
        /// Gets and sets the property Address2. 
        /// <para>
        /// The second line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Address2
        {
            get { return this._address2; }
            set { this._address2 = value; }
        }

        // Check to see if Address2 property is set
        internal bool IsSetAddress2()
        {
            return this._address2 != null;
        }

        /// <summary>
        /// Gets and sets the property Address3. 
        /// <para>
        /// The third line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Address3
        {
            get { return this._address3; }
            set { this._address3 = value; }
        }

        // Check to see if Address3 property is set
        internal bool IsSetAddress3()
        {
            return this._address3 != null;
        }

        /// <summary>
        /// Gets and sets the property Address4. 
        /// <para>
        /// The fourth line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Address4
        {
            get { return this._address4; }
            set { this._address4 = value; }
        }

        // Check to see if Address4 property is set
        internal bool IsSetAddress4()
        {
            return this._address4 != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The country in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property County. 
        /// <para>
        /// The county in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string County
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
        /// The postal code of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Province. 
        /// <para>
        /// The province in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Province
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
        /// The state in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

    }
}