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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AddCustomAttributes operation.
    /// Adds additional user attributes to the user pool schema. Custom attributes can be
    /// mutable or immutable and have a <c>custom:</c> or <c>dev:</c> prefix. For more information,
    /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-custom-attributes">Custom
    /// attributes</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AddCustomAttributesRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<SchemaAttributeType> _customAttributes = AWSConfigs.InitializeCollections ? new List<SchemaAttributeType>() : null;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// An array of custom attribute names and other properties. Sets the following characteristics:
        /// </para>
        ///  <dl> <dt>AttributeDataType</dt> <dd> 
        /// <para>
        /// The expected data type. Can be a string, a number, a date and time, or a boolean.
        /// </para>
        ///  </dd> <dt>Mutable</dt> <dd> 
        /// <para>
        /// If true, you can grant app clients write access to the attribute value. If false,
        /// the attribute value can only be set up on sign-up or administrator creation of users.
        /// </para>
        ///  </dd> <dt>Name</dt> <dd> 
        /// <para>
        /// The attribute name. For an attribute like <c>custom:myAttribute</c>, enter <c>myAttribute</c>
        /// for this field.
        /// </para>
        ///  </dd> <dt>Required</dt> <dd> 
        /// <para>
        /// When true, users who sign up or are created must set a value for the attribute.
        /// </para>
        ///  </dd> <dt>NumberAttributeConstraints</dt> <dd> 
        /// <para>
        /// The minimum and maximum length of accepted values for a <c>Number</c>-type attribute.
        /// </para>
        ///  </dd> <dt>StringAttributeConstraints</dt> <dd> 
        /// <para>
        /// The minimum and maximum length of accepted values for a <c>String</c>-type attribute.
        /// </para>
        ///  </dd> <dt>DeveloperOnlyAttribute</dt> <dd> 
        /// <para>
        /// This legacy option creates an attribute with a <c>dev:</c> prefix. You can only set
        /// the value of a developer-only attribute with administrative IAM credentials.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<SchemaAttributeType> CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null && (this._customAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to add custom attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}