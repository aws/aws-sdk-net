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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The criteria for inspecting account creation requests, used by the ACFP rule group
    /// to validate and track account creation attempts. 
    /// 
    ///  
    /// <para>
    /// This is part of the <c>AWSManagedRulesACFPRuleSet</c> configuration in <c>ManagedRuleGroupConfig</c>.
    /// </para>
    ///  
    /// <para>
    /// In these settings, you specify how your application accepts account creation attempts
    /// by providing the request payload type and the names of the fields within the request
    /// body where the username, password, email, and primary address and phone number fields
    /// are provided. 
    /// </para>
    /// </summary>
    public partial class RequestInspectionACFP
    {
        private List<AddressField> _addressFields = AWSConfigs.InitializeCollections ? new List<AddressField>() : null;
        private EmailField _emailField;
        private PasswordField _passwordField;
        private PayloadType _payloadType;
        private List<PhoneNumberField> _phoneNumberFields = AWSConfigs.InitializeCollections ? new List<PhoneNumberField>() : null;
        private UsernameField _usernameField;

        /// <summary>
        /// Gets and sets the property AddressFields. 
        /// <para>
        /// The names of the fields in the request payload that contain your customer's primary
        /// physical address. 
        /// </para>
        ///  
        /// <para>
        /// Order the address fields in the array exactly as they are ordered in the request payload.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify the address fields depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field identifiers in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "primaryaddressline1": "THE_ADDRESS1",
        /// "primaryaddressline2": "THE_ADDRESS2", "primaryaddressline3": "THE_ADDRESS3" } }</c>,
        /// the address field idenfiers are <c>/form/primaryaddressline1</c>, <c>/form/primaryaddressline2</c>,
        /// and <c>/form/primaryaddressline3</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with input elements named <c>primaryaddressline1</c>,
        /// <c>primaryaddressline2</c>, and <c>primaryaddressline3</c>, the address fields identifiers
        /// are <c>primaryaddressline1</c>, <c>primaryaddressline2</c>, and <c>primaryaddressline3</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddressField> AddressFields
        {
            get { return this._addressFields; }
            set { this._addressFields = value; }
        }

        // Check to see if AddressFields property is set
        internal bool IsSetAddressFields()
        {
            return this._addressFields != null && (this._addressFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EmailField. 
        /// <para>
        /// The name of the field in the request payload that contains your customer's email.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify this depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field name in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "email": "THE_EMAIL" } }</c>, the
        /// email field specification is <c>/form/email</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with the input element named <c>email1</c>, the email
        /// field specification is <c>email1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EmailField EmailField
        {
            get { return this._emailField; }
            set { this._emailField = value; }
        }

        // Check to see if EmailField property is set
        internal bool IsSetEmailField()
        {
            return this._emailField != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordField. 
        /// <para>
        /// The name of the field in the request payload that contains your customer's password.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify this depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field name in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "password": "THE_PASSWORD" } }</c>,
        /// the password field specification is <c>/form/password</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with the input element named <c>password1</c>, the password
        /// field specification is <c>password1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PasswordField PasswordField
        {
            get { return this._passwordField; }
            set { this._passwordField = value; }
        }

        // Check to see if PasswordField property is set
        internal bool IsSetPasswordField()
        {
            return this._passwordField != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The payload type for your account creation endpoint, either JSON or form encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PayloadType PayloadType
        {
            get { return this._payloadType; }
            set { this._payloadType = value; }
        }

        // Check to see if PayloadType property is set
        internal bool IsSetPayloadType()
        {
            return this._payloadType != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberFields. 
        /// <para>
        /// The names of the fields in the request payload that contain your customer's primary
        /// phone number. 
        /// </para>
        ///  
        /// <para>
        /// Order the phone number fields in the array exactly as they are ordered in the request
        /// payload. 
        /// </para>
        ///  
        /// <para>
        /// How you specify the phone number fields depends on the request inspection payload
        /// type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field identifiers in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "primaryphoneline1": "THE_PHONE1",
        /// "primaryphoneline2": "THE_PHONE2", "primaryphoneline3": "THE_PHONE3" } }</c>, the
        /// phone number field identifiers are <c>/form/primaryphoneline1</c>, <c>/form/primaryphoneline2</c>,
        /// and <c>/form/primaryphoneline3</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with input elements named <c>primaryphoneline1</c>,
        /// <c>primaryphoneline2</c>, and <c>primaryphoneline3</c>, the phone number field identifiers
        /// are <c>primaryphoneline1</c>, <c>primaryphoneline2</c>, and <c>primaryphoneline3</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhoneNumberField> PhoneNumberFields
        {
            get { return this._phoneNumberFields; }
            set { this._phoneNumberFields = value; }
        }

        // Check to see if PhoneNumberFields property is set
        internal bool IsSetPhoneNumberFields()
        {
            return this._phoneNumberFields != null && (this._phoneNumberFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsernameField. 
        /// <para>
        /// The name of the field in the request payload that contains your customer's username.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify this depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field name in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "username": "THE_USERNAME" } }</c>,
        /// the username field specification is <c>/form/username</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with the input element named <c>username1</c>, the username
        /// field specification is <c>username1</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UsernameField UsernameField
        {
            get { return this._usernameField; }
            set { this._usernameField = value; }
        }

        // Check to see if UsernameField property is set
        internal bool IsSetUsernameField()
        {
            return this._usernameField != null;
        }

    }
}