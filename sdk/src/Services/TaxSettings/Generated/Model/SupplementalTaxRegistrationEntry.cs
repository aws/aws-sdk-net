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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The supplemental TRN information to provide when adding or updating a supplemental
    /// TRN.
    /// </summary>
    public partial class SupplementalTaxRegistrationEntry
    {
        private Address _address;
        private string _legalName;
        private string _registrationId;
        private SupplementalTaxRegistrationType _registrationType;

        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        [AWSProperty(Required=true)]
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        ///  The legal name associated with your TRN registration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string LegalName
        {
            get { return this._legalName; }
            set { this._legalName = value; }
        }

        // Check to see if LegalName property is set
        internal bool IsSetLegalName()
        {
            return this._legalName != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        ///  The supplemental TRN unique identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        ///  Type of supplemental TRN. Currently, this can only be VAT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupplementalTaxRegistrationType RegistrationType
        {
            get { return this._registrationType; }
            set { this._registrationType = value; }
        }

        // Check to see if RegistrationType property is set
        internal bool IsSetRegistrationType()
        {
            return this._registrationType != null;
        }

    }
}