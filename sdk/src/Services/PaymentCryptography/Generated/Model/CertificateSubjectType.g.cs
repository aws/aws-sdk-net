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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The metadata used to create the certificate signing request.
    /// </summary>
    public partial class CertificateSubjectType
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The name you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CommonName { get; set; }

        /// <summary>
        /// Checks to see if the CommonName property is set.
        /// </summary>
        internal bool IsSetCommonName() => this.CommonName != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The organization you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property OrganizationUnit. 
        /// <para>
        /// The organization unit you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationUnit property is set.
        /// </summary>
        internal bool IsSetOrganizationUnit() => this.OrganizationUnit != null;

        /// <summary>
        /// Gets and sets the property StateOrProvince. 
        /// <para>
        /// The state or province you provide to create the certificate signing request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Checks to see if the StateOrProvince property is set.
        /// </summary>
        internal bool IsSetStateOrProvince() => this.StateOrProvince != null;
    }
}
