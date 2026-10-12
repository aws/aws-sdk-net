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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The configuration for an identity source that represents a connection to an Amazon
    /// Cognito user pool used as an identity provider for Verified Permissions.
    /// 
    ///  
    /// <para>
    /// This data type is used as a field that is part of an <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ConfigurationDetail.html">ConfigurationDetail</a>
    /// structure that is part of the response to <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_GetIdentitySource.html">GetIdentitySource</a>.
    /// </para>
    ///  
    /// <para>
    /// Example:<c>"CognitoUserPoolConfiguration":{"UserPoolArn":"arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5","ClientIds":
    /// ["a1b2c3d4e5f6g7h8i9j0kalbmc"],"groupConfiguration": {"groupEntityType": "MyCorp::Group"}}</c>
    /// 
    /// </para>
    /// </summary>
    public partial class CognitoUserPoolConfigurationDetail
    {
        /// <summary>
        /// Gets and sets the property ClientIds. 
        /// <para>
        /// The unique application client IDs that are associated with the specified Amazon Cognito
        /// user pool.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"clientIds": ["&amp;ExampleCogClientId;"]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public List<string> ClientIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientIds property is set.
        /// </summary>
        internal bool IsSetClientIds() => this.ClientIds != null && (this.ClientIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The type of entity that a policy store maps to groups from an Amazon Cognito user
        /// pool identity source.
        /// </para>
        /// </summary>
        public CognitoGroupConfigurationDetail GroupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GroupConfiguration property is set.
        /// </summary>
        internal bool IsSetGroupConfiguration() => this.GroupConfiguration != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OpenID Connect (OIDC) <c>issuer</c> ID of the Amazon Cognito user pool that contains
        /// the identities to be authorized.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"issuer": "https://cognito-idp.us-east-1.amazonaws.com/us-east-1_1a2b3c4d5"</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the Amazon Cognito user pool that contains the identities
        /// to be authorized.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"userPoolArn": "arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5"</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string UserPoolArn { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolArn property is set.
        /// </summary>
        internal bool IsSetUserPoolArn() => this.UserPoolArn != null;
    }
}
