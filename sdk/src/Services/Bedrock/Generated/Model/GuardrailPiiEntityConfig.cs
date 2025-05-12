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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The PII entity to configure for the guardrail.
    /// </summary>
    public partial class GuardrailPiiEntityConfig
    {
        private GuardrailSensitiveInformationAction _action;
        private GuardrailSensitiveInformationAction _inputAction;
        private bool? _inputEnabled;
        private GuardrailSensitiveInformationAction _outputAction;
        private bool? _outputEnabled;
        private GuardrailPiiEntityType _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Configure guardrail action when the PII entity is detected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailSensitiveInformationAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property InputAction. 
        /// <para>
        /// Specifies the action to take when harmful content is detected in the input. Supported
        /// values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANONYMIZE</c> – Mask the content and replace it with identifier tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GuardrailSensitiveInformationAction InputAction
        {
            get { return this._inputAction; }
            set { this._inputAction = value; }
        }

        // Check to see if InputAction property is set
        internal bool IsSetInputAction()
        {
            return this._inputAction != null;
        }

        /// <summary>
        /// Gets and sets the property InputEnabled. 
        /// <para>
        /// Specifies whether to enable guardrail evaluation on the input. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? InputEnabled
        {
            get { return this._inputEnabled; }
            set { this._inputEnabled = value; }
        }

        // Check to see if InputEnabled property is set
        internal bool IsSetInputEnabled()
        {
            return this._inputEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputAction. 
        /// <para>
        /// Specifies the action to take when harmful content is detected in the output. Supported
        /// values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c> – Block the content and replace it with blocked messaging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANONYMIZE</c> – Mask the content and replace it with identifier tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> – Take no action but return detection information in the trace response.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GuardrailSensitiveInformationAction OutputAction
        {
            get { return this._outputAction; }
            set { this._outputAction = value; }
        }

        // Check to see if OutputAction property is set
        internal bool IsSetOutputAction()
        {
            return this._outputAction != null;
        }

        /// <summary>
        /// Gets and sets the property OutputEnabled. 
        /// <para>
        /// Specifies whether to enable guardrail evaluation on the output. When disabled, you
        /// aren't charged for the evaluation. The evaluation doesn't appear in the response.
        /// </para>
        /// </summary>
        public bool? OutputEnabled
        {
            get { return this._outputEnabled; }
            set { this._outputEnabled = value; }
        }

        // Check to see if OutputEnabled property is set
        internal bool IsSetOutputEnabled()
        {
            return this._outputEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Configure guardrail type when the PII entity is detected.
        /// </para>
        ///  
        /// <para>
        /// The following PIIs are used to block or mask sensitive information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>General</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ADDRESS</b> 
        /// </para>
        ///  
        /// <para>
        /// A physical address, such as "100 Main Street, Anytown, USA" or "Suite #12, Building
        /// 123". An address can include information such as the street, building, location, city,
        /// state, country, county, zip code, precinct, and neighborhood. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AGE</b> 
        /// </para>
        ///  
        /// <para>
        /// An individual's age, including the quantity and unit of time. For example, in the
        /// phrase "I am 40 years old," Guardrails recognizes "40 years" as an age. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NAME</b> 
        /// </para>
        ///  
        /// <para>
        /// An individual's name. This entity type does not include titles, such as Dr., Mr.,
        /// Mrs., or Miss. guardrails doesn't apply this entity type to names that are part of
        /// organizations or addresses. For example, guardrails recognizes the "John Doe Organization"
        /// as an organization, and it recognizes "Jane Doe Street" as an address. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EMAIL</b> 
        /// </para>
        ///  
        /// <para>
        /// An email address, such as <i>marymajor@email.com</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PHONE</b> 
        /// </para>
        ///  
        /// <para>
        /// A phone number. This entity type also includes fax and pager numbers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>USERNAME</b> 
        /// </para>
        ///  
        /// <para>
        /// A user name that identifies an account, such as a login name, screen name, nick name,
        /// or handle. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PASSWORD</b> 
        /// </para>
        ///  
        /// <para>
        /// An alphanumeric string that is used as a password, such as "*<i>very20special#pass*</i>".
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DRIVER_ID</b> 
        /// </para>
        ///  
        /// <para>
        /// The number assigned to a driver's license, which is an official document permitting
        /// an individual to operate one or more motorized vehicles on a public road. A driver's
        /// license number consists of alphanumeric characters. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>LICENSE_PLATE</b> 
        /// </para>
        ///  
        /// <para>
        /// A license plate for a vehicle is issued by the state or country where the vehicle
        /// is registered. The format for passenger vehicles is typically five to eight digits,
        /// consisting of upper-case letters and numbers. The format varies depending on the location
        /// of the issuing state or country. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VEHICLE_IDENTIFICATION_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A Vehicle Identification Number (VIN) uniquely identifies a vehicle. VIN content and
        /// format are defined in the <i>ISO 3779</i> specification. Each country has specific
        /// codes and formats for VINs. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Finance</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CREDIT_DEBIT_CARD_CVV</b> 
        /// </para>
        ///  
        /// <para>
        /// A three-digit card verification code (CVV) that is present on VISA, MasterCard, and
        /// Discover credit and debit cards. For American Express credit or debit cards, the CVV
        /// is a four-digit numeric code. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CREDIT_DEBIT_CARD_EXPIRY</b> 
        /// </para>
        ///  
        /// <para>
        /// The expiration date for a credit or debit card. This number is usually four digits
        /// long and is often formatted as <i>month/year</i> or <i>MM/YY</i>. Guardrails recognizes
        /// expiration dates such as <i>01/21</i>, <i>01/2021</i>, and <i>Jan 2021</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CREDIT_DEBIT_CARD_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// The number for a credit or debit card. These numbers can vary from 13 to 16 digits
        /// in length. However, Amazon Comprehend also recognizes credit or debit card numbers
        /// when only the last four digits are present. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PIN</b> 
        /// </para>
        ///  
        /// <para>
        /// A four-digit personal identification number (PIN) with which you can access your bank
        /// account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERNATIONAL_BANK_ACCOUNT_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// An International Bank Account Number has specific formats in each country. For more
        /// information, see <a href="https://www.iban.com/structure">www.iban.com/structure</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SWIFT_CODE</b> 
        /// </para>
        ///  
        /// <para>
        /// A SWIFT code is a standard format of Bank Identifier Code (BIC) used to specify a
        /// particular bank or branch. Banks use these codes for money transfers such as international
        /// wire transfers.
        /// </para>
        ///  
        /// <para>
        /// SWIFT codes consist of eight or 11 characters. The 11-digit codes refer to specific
        /// branches, while eight-digit codes (or 11-digit codes ending in 'XXX') refer to the
        /// head or primary office.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>IT</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>IP_ADDRESS</b> 
        /// </para>
        ///  
        /// <para>
        /// An IPv4 address, such as <i>198.51.100.0</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAC_ADDRESS</b> 
        /// </para>
        ///  
        /// <para>
        /// A <i>media access control</i> (MAC) address is a unique identifier assigned to a network
        /// interface controller (NIC). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>URL</b> 
        /// </para>
        ///  
        /// <para>
        /// A web address, such as <i>www.example.com</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS_ACCESS_KEY</b> 
        /// </para>
        ///  
        /// <para>
        /// A unique identifier that's associated with a secret access key; you use the access
        /// key ID and secret access key to sign programmatic Amazon Web Services requests cryptographically.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AWS_SECRET_KEY</b> 
        /// </para>
        ///  
        /// <para>
        /// A unique identifier that's associated with an access key. You use the access key ID
        /// and secret access key to sign programmatic Amazon Web Services requests cryptographically.
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>USA specific</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>US_BANK_ACCOUNT_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A US bank account number, which is typically 10 to 12 digits long. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>US_BANK_ROUTING_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A US bank account routing number. These are typically nine digits long, 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>US_INDIVIDUAL_TAX_IDENTIFICATION_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A US Individual Taxpayer Identification Number (ITIN) is a nine-digit number that
        /// starts with a "9" and contain a "7" or "8" as the fourth digit. An ITIN can be formatted
        /// with a space or a dash after the third and forth digits. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>US_PASSPORT_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A US passport number. Passport numbers range from six to nine alphanumeric characters.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>US_SOCIAL_SECURITY_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A US Social Security Number (SSN) is a nine-digit number that is issued to US citizens,
        /// permanent residents, and temporary working residents. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Canada specific</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CA_HEALTH_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A Canadian Health Service Number is a 10-digit unique identifier, required for individuals
        /// to access healthcare benefits. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CA_SOCIAL_INSURANCE_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A Canadian Social Insurance Number (SIN) is a nine-digit unique identifier, required
        /// for individuals to access government programs and benefits.
        /// </para>
        ///  
        /// <para>
        /// The SIN is formatted as three groups of three digits, such as <i>123-456-789</i>.
        /// A SIN can be validated through a simple check-digit process called the <a href="https://www.wikipedia.org/wiki/Luhn_algorithm">Luhn
        /// algorithm</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>UK Specific</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UK_NATIONAL_HEALTH_SERVICE_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A UK National Health Service Number is a 10-17 digit number, such as <i>485 777 3456</i>.
        /// The current system formats the 10-digit number with spaces after the third and sixth
        /// digits. The final digit is an error-detecting checksum.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UK_NATIONAL_INSURANCE_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A UK National Insurance Number (NINO) provides individuals with access to National
        /// Insurance (social security) benefits. It is also used for some purposes in the UK
        /// tax system.
        /// </para>
        ///  
        /// <para>
        /// The number is nine digits long and starts with two letters, followed by six numbers
        /// and one letter. A NINO can be formatted with a space or a dash after the two letters
        /// and after the second, forth, and sixth digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UK_UNIQUE_TAXPAYER_REFERENCE_NUMBER</b> 
        /// </para>
        ///  
        /// <para>
        /// A UK Unique Taxpayer Reference (UTR) is a 10-digit number that identifies a taxpayer
        /// or a business. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Custom</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Regex filter</b> - You can use a regular expressions to define patterns for a
        /// guardrail to recognize and act upon such as serial number, booking ID etc..
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailPiiEntityType Type
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