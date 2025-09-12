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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Metadata used in generating the CSR
    /// </summary>
    public partial class CertificateSubjectType
    {
        private string _city;
        private string _commonName;
        private string _country;
        private string _emailAddress;
        private string _organization;
        private string _organizationUnit;
        private string _stateOrProvince;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// City to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CommonName. 
        /// <para>
        /// Common Name to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// Country to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
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
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// Email to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// Organization to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationUnit. 
        /// <para>
        /// Organization Unit to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OrganizationUnit
        {
            get { return this._organizationUnit; }
            set { this._organizationUnit = value; }
        }

        // Check to see if OrganizationUnit property is set
        internal bool IsSetOrganizationUnit()
        {
            return this._organizationUnit != null;
        }

        /// <summary>
        /// Gets and sets the property StateOrProvince. 
        /// <para>
        /// State Or Province to be used in the certificate signing request
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string StateOrProvince
        {
            get { return this._stateOrProvince; }
            set { this._stateOrProvince = value; }
        }

        // Check to see if StateOrProvince property is set
        internal bool IsSetStateOrProvince()
        {
            return this._stateOrProvince != null;
        }

    }
}