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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Contains information about the schema attribute.
    /// </summary>
    public partial class SchemaAttributeType
    {
        private AttributeDataType _attributeDataType;
        private bool? _developerOnlyAttribute;
        private bool? _mutable;
        private string _name;
        private NumberAttributeConstraintsType _numberAttributeConstraints;
        private bool? _required;
        private StringAttributeConstraintsType _stringAttributeConstraints;

        /// <summary>
        /// Gets and sets the property AttributeDataType. 
        /// <para>
        /// The attribute data type.
        /// </para>
        /// </summary>
        public AttributeDataType AttributeDataType
        {
            get { return this._attributeDataType; }
            set { this._attributeDataType = value; }
        }

        // Check to see if AttributeDataType property is set
        internal bool IsSetAttributeDataType()
        {
            return this._attributeDataType != null;
        }

        /// <summary>
        /// Gets and sets the property DeveloperOnlyAttribute. <note> 
        /// <para>
        /// We recommend that you use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UserPoolClientType.html#CognitoUserPools-Type-UserPoolClientType-WriteAttributes">WriteAttributes</a>
        /// in the user pool client to control how attributes can be mutated for new use cases
        /// instead of using <code>DeveloperOnlyAttribute</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specifies whether the attribute type is developer only. This attribute can only be
        /// modified by an administrator. Users will not be able to modify this attribute using
        /// their access token. For example, <code>DeveloperOnlyAttribute</code> can be modified
        /// using AdminUpdateUserAttributes but cannot be updated using UpdateUserAttributes.
        /// </para>
        /// </summary>
        public bool DeveloperOnlyAttribute
        {
            get { return this._developerOnlyAttribute.GetValueOrDefault(); }
            set { this._developerOnlyAttribute = value; }
        }

        // Check to see if DeveloperOnlyAttribute property is set
        internal bool IsSetDeveloperOnlyAttribute()
        {
            return this._developerOnlyAttribute.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mutable. 
        /// <para>
        /// Specifies whether the value of the attribute can be changed.
        /// </para>
        ///  
        /// <para>
        /// For any user pool attribute that's mapped to an identity provider attribute, you must
        /// set this parameter to <code>true</code>. Amazon Cognito updates mapped attributes
        /// when users sign in to your application through an identity provider. If an attribute
        /// is immutable, Amazon Cognito throws an error when it attempts to update the attribute.
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-specifying-attribute-mapping.html">Specifying
        /// Identity Provider Attribute Mappings for Your User Pool</a>.
        /// </para>
        /// </summary>
        public bool Mutable
        {
            get { return this._mutable.GetValueOrDefault(); }
            set { this._mutable = value; }
        }

        // Check to see if Mutable property is set
        internal bool IsSetMutable()
        {
            return this._mutable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A schema attribute of the name type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberAttributeConstraints. 
        /// <para>
        /// Specifies the constraints for an attribute of the number type.
        /// </para>
        /// </summary>
        public NumberAttributeConstraintsType NumberAttributeConstraints
        {
            get { return this._numberAttributeConstraints; }
            set { this._numberAttributeConstraints = value; }
        }

        // Check to see if NumberAttributeConstraints property is set
        internal bool IsSetNumberAttributeConstraints()
        {
            return this._numberAttributeConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether a user pool attribute is required. If the attribute is required
        /// and the user does not provide a value, registration or sign-in will fail.
        /// </para>
        /// </summary>
        public bool Required
        {
            get { return this._required.GetValueOrDefault(); }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringAttributeConstraints. 
        /// <para>
        /// Specifies the constraints for an attribute of the string type.
        /// </para>
        /// </summary>
        public StringAttributeConstraintsType StringAttributeConstraints
        {
            get { return this._stringAttributeConstraints; }
            set { this._stringAttributeConstraints = value; }
        }

        // Check to see if StringAttributeConstraints property is set
        internal bool IsSetStringAttributeConstraints()
        {
            return this._stringAttributeConstraints != null;
        }

    }
}