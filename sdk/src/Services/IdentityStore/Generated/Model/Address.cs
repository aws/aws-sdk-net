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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// The address associated with the specified user.
    /// </summary>
    public partial class Address
    {
        private string _country;
        private string _formatted;
        private string _locality;
        private string _postalCode;
        private bool? _primary;
        private string _region;
        private string _streetAddress;
        private string _type;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property Formatted. 
        /// <para>
        /// A string containing a formatted version of the address for display.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Formatted
        {
            get { return this._formatted; }
            set { this._formatted = value; }
        }

        // Check to see if Formatted property is set
        internal bool IsSetFormatted()
        {
            return this._formatted != null;
        }

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// A string of the address locality.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property Primary. 
        /// <para>
        /// A Boolean value representing whether this is the primary address for the associated
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool Primary
        {
            get { return this._primary.GetValueOrDefault(); }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The region of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property StreetAddress. 
        /// <para>
        /// The street of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string StreetAddress
        {
            get { return this._streetAddress; }
            set { this._streetAddress = value; }
        }

        // Check to see if StreetAddress property is set
        internal bool IsSetStreetAddress()
        {
            return this._streetAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A string representing the type of address. For example, "Home."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}