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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// ContactDetail includes the following elements.
    /// </summary>
    public partial class ContactDetail
    {
        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// First line of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine1 property is set.
        /// </summary>
        internal bool IsSetAddressLine1() => this.AddressLine1 != null;

        /// <summary>
        /// Gets and sets the property AddressLine2. 
        /// <para>
        /// Second line of contact's address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine2 property is set.
        /// </summary>
        internal bool IsSetAddressLine2() => this.AddressLine2 != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property ContactType. 
        /// <para>
        /// Indicates whether the contact is a person, company, association, or public organization.
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a value other than <c>PERSON</c>, you must also specify a value for
        /// <c>OrganizationName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For some TLDs, the privacy protection available depends on the value that you specify
        /// for <c>Contact Type</c>. For the privacy protection settings for your TLD, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For .es domains, the value of <c>ContactType</c> must be <c>PERSON</c> for all three
        /// contacts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContactType ContactType { get; set; }

        /// <summary>
        /// Checks to see if the ContactType property is set.
        /// </summary>
        internal bool IsSetContactType() => this.ContactType != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// Code for the country of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Email address of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property ExtraParams. 
        /// <para>
        /// A list of name-value pairs for parameters required by certain top-level domains.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExtraParam> ExtraParams { get; set; } = AWSConfigs.InitializeCollections ? new List<ExtraParam>() : null;

        /// <summary>
        /// Checks to see if the ExtraParams property is set.
        /// </summary>
        internal bool IsSetExtraParams() => this.ExtraParams != null && (this.ExtraParams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Fax. 
        /// <para>
        /// Fax number of the contact.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Phone number must be specified in the format "+[country dialing code].[number
        /// including any area code]". For example, a US phone number might appear as <c>"+1.1234567890"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 30)]
        public string Fax { get; set; }

        /// <summary>
        /// Checks to see if the Fax property is set.
        /// </summary>
        internal bool IsSetFax() => this.Fax != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// First name of contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// Last name of contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// Name of the organization for contact types other than <c>PERSON</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationName property is set.
        /// </summary>
        internal bool IsSetOrganizationName() => this.OrganizationName != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the contact.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Phone number must be specified in the format "+[country dialing code].[number
        /// including any area code>]". For example, a US phone number might appear as <c>"+1.1234567890"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 30)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state or province of the contact's city.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// The zip or postal code of the contact's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Checks to see if the ZipCode property is set.
        /// </summary>
        internal bool IsSetZipCode() => this.ZipCode != null;
    }
}
