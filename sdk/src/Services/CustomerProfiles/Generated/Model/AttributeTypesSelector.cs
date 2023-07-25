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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration information about the <code>AttributeTypesSelector </code>where the
    /// rule-based identity resolution uses to match profiles. You can choose how profiles
    /// are compared across attribute types and which attribute to use for matching from each
    /// type. There are three attribute types you can configure:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Email type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <code>Email</code>, <code>BusinessEmail</code>, and <code>PersonalEmail</code>
    /// 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Phone number type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <code>Phone</code>, <code>HomePhone</code>, and <code>MobilePhone</code>
    /// 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Address type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <code>Address</code>, <code>BusinessAddress</code>, <code>MaillingAddress</code>,
    /// and <code>ShippingAddress</code> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// You can either choose <code>ONE_TO_ONE</code> or <code>MANY_TO_MANY</code> as the
    /// <code>AttributeMatchingModel</code>. When choosing <code>MANY_TO_MANY</code>, the
    /// system can match attribute across the sub-types of an attribute type. For example,
    /// if the value of the <code>Email</code> field of Profile A and the value of <code>BusinessEmail</code>
    /// field of Profile B matches, the two profiles are matched on the Email type. When choosing
    /// <code>ONE_TO_ONE</code> the system can only match if the sub-types are exact matches.
    /// For example, only when the value of the <code>Email</code> field of Profile A and
    /// the value of the <code>Email</code> field of Profile B matches, the two profiles are
    /// matched on the Email type.
    /// </para>
    /// </summary>
    public partial class AttributeTypesSelector
    {
        private List<string> _address = new List<string>();
        private AttributeMatchingModel _attributeMatchingModel;
        private List<string> _emailAddress = new List<string>();
        private List<string> _phoneNumber = new List<string>();

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The <code>Address</code> type. You can choose from <code>Address</code>, <code>BusinessAddress</code>,
        /// <code>MaillingAddress</code>, and <code>ShippingAddress</code>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the Address type in the <code>MatchingRule</code>. For example, if
        /// you want to match profile based on <code>BusinessAddress.City</code> or <code>MaillingAddress.City</code>,
        /// you need to choose the <code>BusinessAddress</code> and the <code>MaillingAddress</code>
        /// to represent the Address type and specify the <code>Address.City</code> on the matching
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null && this._address.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AttributeMatchingModel. 
        /// <para>
        /// Configures the <code>AttributeMatchingModel</code>, you can either choose <code>ONE_TO_ONE</code>
        /// or <code>MANY_TO_MANY</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttributeMatchingModel AttributeMatchingModel
        {
            get { return this._attributeMatchingModel; }
            set { this._attributeMatchingModel = value; }
        }

        // Check to see if AttributeMatchingModel property is set
        internal bool IsSetAttributeMatchingModel()
        {
            return this._attributeMatchingModel != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The <code>Email</code> type. You can choose from <code>EmailAddress</code>, <code>BusinessEmailAddress</code>
        /// and <code>PersonalEmailAddress</code>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the <code>EmailAddress</code> type in the <code>MatchingRule</code>.
        /// For example, if you want to match profile based on <code>PersonalEmailAddress</code>
        /// or <code>BusinessEmailAddress</code>, you need to choose the <code>PersonalEmailAddress</code>
        /// and the <code>BusinessEmailAddress</code> to represent the <code>EmailAddress</code>
        /// type and only specify the <code>EmailAddress</code> on the matching rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null && this._emailAddress.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The <code>PhoneNumber</code> type. You can choose from <code>PhoneNumber</code>, <code>HomePhoneNumber</code>,
        /// and <code>MobilePhoneNumber</code>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the <code>PhoneNumber</code> type in the <code>MatchingRule</code>.
        /// For example, if you want to match a profile based on <code>Phone</code> or <code>HomePhone</code>,
        /// you need to choose the <code>Phone</code> and the <code>HomePhone</code> to represent
        /// the <code>PhoneNumber</code> type and only specify the <code>PhoneNumber</code> on
        /// the matching rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null && this._phoneNumber.Count > 0; 
        }

    }
}