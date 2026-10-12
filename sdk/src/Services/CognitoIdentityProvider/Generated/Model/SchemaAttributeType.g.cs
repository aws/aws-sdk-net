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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A list of the user attributes and their properties in your user pool. The attribute
    /// schema contains standard attributes, custom attributes with a <c>custom:</c> prefix,
    /// and developer attributes with a <c>dev:</c> prefix. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html">User
    /// pool attributes</a>.
    /// 
    ///  
    /// <para>
    /// Developer-only <c>dev:</c> attributes are a legacy feature of user pools, and are
    /// read-only to all app clients. You can create and update developer-only attributes
    /// only with IAM-authenticated API operations. Use app client read/write permissions
    /// instead.
    /// </para>
    /// </summary>
    public partial class SchemaAttributeType
    {
        /// <summary>
        /// Gets and sets the property AttributeDataType. 
        /// <para>
        /// The data format of the values for your attribute. When you choose an <c>AttributeDataType</c>,
        /// Amazon Cognito validates the input against the data type. A custom attribute value
        /// in your user's ID token is always a string, for example <c>"custom:isMember" : "true"</c>
        /// or <c>"custom:YearsAsMember" : "12"</c>. 
        /// </para>
        /// </summary>
        public AttributeDataType AttributeDataType { get; set; }

        /// <summary>
        /// Checks to see if the AttributeDataType property is set.
        /// </summary>
        internal bool IsSetAttributeDataType() => this.AttributeDataType != null;

        /// <summary>
        /// Gets and sets the property DeveloperOnlyAttribute. <note> 
        /// <para>
        /// You should use <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UserPoolClientType.html#CognitoUserPools-Type-UserPoolClientType-WriteAttributes">WriteAttributes</a>
        /// in the user pool client to control how attributes can be mutated for new use cases
        /// instead of using <c>DeveloperOnlyAttribute</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specifies whether the attribute type is developer only. This attribute can only be
        /// modified by an administrator. Users won't be able to modify this attribute using their
        /// access token. For example, <c>DeveloperOnlyAttribute</c> can be modified using AdminUpdateUserAttributes
        /// but can't be updated using UpdateUserAttributes.
        /// </para>
        /// </summary>
        public bool? DeveloperOnlyAttribute { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperOnlyAttribute property is set.
        /// </summary>
        internal bool IsSetDeveloperOnlyAttribute() => this.DeveloperOnlyAttribute.HasValue;

        /// <summary>
        /// Gets and sets the property Mutable. 
        /// <para>
        /// Specifies whether the value of the attribute can be changed.
        /// </para>
        ///  
        /// <para>
        /// Any user pool attribute whose value you map from an IdP attribute must be mutable,
        /// with a parameter value of <c>true</c>. Amazon Cognito updates mapped attributes when
        /// users sign in to your application through an IdP. If an attribute is immutable, Amazon
        /// Cognito throws an error when it attempts to update the attribute. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-specifying-attribute-mapping.html">Specifying
        /// Identity Provider Attribute Mappings for Your User Pool</a>.
        /// </para>
        /// </summary>
        public bool? Mutable { get; set; }

        /// <summary>
        /// Checks to see if the Mutable property is set.
        /// </summary>
        internal bool IsSetMutable() => this.Mutable.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your user pool attribute. When you create or update a user pool, adding
        /// a schema attribute creates a custom or developer-only attribute. When you add an attribute
        /// with a <c>Name</c> value of <c>MyAttribute</c>, Amazon Cognito creates the custom
        /// attribute <c>custom:MyAttribute</c>. When <c>DeveloperOnlyAttribute</c> is <c>true</c>,
        /// Amazon Cognito creates your attribute as <c>dev:MyAttribute</c>. In an operation that
        /// describes a user pool, Amazon Cognito returns this value as <c>value</c> for standard
        /// attributes, <c>custom:value</c> for custom attributes, and <c>dev:value</c> for developer-only
        /// attributes..
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberAttributeConstraints. 
        /// <para>
        /// Specifies the constraints for an attribute of the number type.
        /// </para>
        /// </summary>
        public NumberAttributeConstraintsType NumberAttributeConstraints { get; set; }

        /// <summary>
        /// Checks to see if the NumberAttributeConstraints property is set.
        /// </summary>
        internal bool IsSetNumberAttributeConstraints() => this.NumberAttributeConstraints != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether a user pool attribute is required. If the attribute is required
        /// and the user doesn't provide a value, registration or sign-in will fail.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property StringAttributeConstraints. 
        /// <para>
        /// Specifies the constraints for an attribute of the string type.
        /// </para>
        /// </summary>
        public StringAttributeConstraintsType StringAttributeConstraints { get; set; }

        /// <summary>
        /// Checks to see if the StringAttributeConstraints property is set.
        /// </summary>
        internal bool IsSetStringAttributeConstraints() => this.StringAttributeConstraints != null;
    }
}
