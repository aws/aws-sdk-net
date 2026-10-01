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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Configuration information about the <c>AttributeTypesSelector </c>where the rule-based
    /// identity resolution uses to match profiles. You can choose how profiles are compared
    /// across attribute types and which attribute to use for matching from each type. There
    /// are three attribute types you can configure:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Email type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <c>Email</c>, <c>BusinessEmail</c>, and <c>PersonalEmail</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Phone number type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <c>Phone</c>, <c>HomePhone</c>, and <c>MobilePhone</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Address type
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can choose from <c>Address</c>, <c>BusinessAddress</c>, <c>MaillingAddress</c>,
    /// and <c>ShippingAddress</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// You can either choose <c>ONE_TO_ONE</c> or <c>MANY_TO_MANY</c> as the <c>AttributeMatchingModel</c>.
    /// When choosing <c>MANY_TO_MANY</c>, the system can match attribute across the sub-types
    /// of an attribute type. For example, if the value of the <c>Email</c> field of Profile
    /// A and the value of <c>BusinessEmail</c> field of Profile B matches, the two profiles
    /// are matched on the Email type. When choosing <c>ONE_TO_ONE</c> the system can only
    /// match if the sub-types are exact matches. For example, only when the value of the
    /// <c>Email</c> field of Profile A and the value of the <c>Email</c> field of Profile
    /// B matches, the two profiles are matched on the Email type.
    /// </para>
    /// </summary>
    public partial class AttributeTypesSelector
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The <c>Address</c> type. You can choose from <c>Address</c>, <c>BusinessAddress</c>,
        /// <c>MaillingAddress</c>, and <c>ShippingAddress</c>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the Address type in the <c>MatchingRule</c>. For example, if you
        /// want to match profile based on <c>BusinessAddress.City</c> or <c>MaillingAddress.City</c>,
        /// you need to choose the <c>BusinessAddress</c> and the <c>MaillingAddress</c> to represent
        /// the Address type and specify the <c>Address.City</c> on the matching rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> Address { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null && (this.Address.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeMatchingModel. 
        /// <para>
        /// Configures the <c>AttributeMatchingModel</c>, you can either choose <c>ONE_TO_ONE</c>
        /// or <c>MANY_TO_MANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttributeMatchingModel AttributeMatchingModel { get; set; }

        /// <summary>
        /// Checks to see if the AttributeMatchingModel property is set.
        /// </summary>
        internal bool IsSetAttributeMatchingModel() => this.AttributeMatchingModel != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The <c>Email</c> type. You can choose from <c>EmailAddress</c>, <c>BusinessEmailAddress</c>
        /// and <c>PersonalEmailAddress</c>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the <c>EmailAddress</c> type in the <c>MatchingRule</c>. For example,
        /// if you want to match profile based on <c>PersonalEmailAddress</c> or <c>BusinessEmailAddress</c>,
        /// you need to choose the <c>PersonalEmailAddress</c> and the <c>BusinessEmailAddress</c>
        /// to represent the <c>EmailAddress</c> type and only specify the <c>EmailAddress</c>
        /// on the matching rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> EmailAddress { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null && (this.EmailAddress.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The <c>PhoneNumber</c> type. You can choose from <c>PhoneNumber</c>, <c>HomePhoneNumber</c>,
        /// and <c>MobilePhoneNumber</c>.
        /// </para>
        ///  
        /// <para>
        /// You only can use the <c>PhoneNumber</c> type in the <c>MatchingRule</c>. For example,
        /// if you want to match a profile based on <c>Phone</c> or <c>HomePhone</c>, you need
        /// to choose the <c>Phone</c> and the <c>HomePhone</c> to represent the <c>PhoneNumber</c>
        /// type and only specify the <c>PhoneNumber</c> on the matching rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> PhoneNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null && (this.PhoneNumber.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
