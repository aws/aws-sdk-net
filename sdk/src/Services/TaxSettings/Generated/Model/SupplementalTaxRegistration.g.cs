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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Supplemental TRN details.
    /// </summary>
    public partial class SupplementalTaxRegistration
    {
        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        [AWSProperty(Required = true)]
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AuthorityId. 
        /// <para>
        ///  Unique authority ID for the supplemental TRN. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string AuthorityId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorityId property is set.
        /// </summary>
        internal bool IsSetAuthorityId() => this.AuthorityId != null;

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        ///  The legal name associated with your TRN registration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string LegalName { get; set; }

        /// <summary>
        /// Checks to see if the LegalName property is set.
        /// </summary>
        internal bool IsSetLegalName() => this.LegalName != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        ///  The supplemental TRN unique identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        ///  Type of supplemental TRN. Currently, this can only be VAT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupplementalTaxRegistrationType RegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationType property is set.
        /// </summary>
        internal bool IsSetRegistrationType() => this.RegistrationType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of your TRN. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaxRegistrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
