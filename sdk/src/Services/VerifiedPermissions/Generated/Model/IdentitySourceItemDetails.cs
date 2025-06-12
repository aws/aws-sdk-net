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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
    /// A structure that contains configuration of the identity source.
    /// 
    ///  
    /// <para>
    /// This data type was a response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListIdentitySources.html">ListIdentitySources</a>
    /// operation. Replaced by <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ConfigurationItem.html">ConfigurationItem</a>.
    /// </para>
    /// </summary>
    [Obsolete("This shape has been replaced by ConfigurationItem")]
    public partial class IdentitySourceItemDetails
    {
        private List<string> _clientIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _discoveryUrl;
        private OpenIdIssuer _openIdIssuer;
        private string _userPoolArn;

        /// <summary>
        /// Gets and sets the property ClientIds. 
        /// <para>
        /// The application client IDs associated with the specified Amazon Cognito user pool
        /// that are enabled for this identity source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration.cognitoUserPoolConfiguration.clientIds")]
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ClientIds
        {
            get { return this._clientIds; }
            set { this._clientIds = value; }
        }

        // Check to see if ClientIds property is set
        internal bool IsSetClientIds()
        {
            return this._clientIds != null && (this._clientIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryUrl. 
        /// <para>
        /// The well-known URL that points to this user pool's OIDC discovery endpoint. This is
        /// a URL string in the following format. This URL replaces the placeholders for both
        /// the Amazon Web Services Region and the user pool identifier with those appropriate
        /// for this user pool.
        /// </para>
        ///  
        /// <para>
        ///  <c>https://cognito-idp.<i>&lt;region&gt;</i>.amazonaws.com/<i>&lt;user-pool-id&gt;</i>/.well-known/openid-configuration</c>
        /// 
        /// </para>
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration.cognitoUserPoolConfiguration.issuer")]
        [AWSProperty(Min=1, Max=2048)]
        public string DiscoveryUrl
        {
            get { return this._discoveryUrl; }
            set { this._discoveryUrl = value; }
        }

        // Check to see if DiscoveryUrl property is set
        internal bool IsSetDiscoveryUrl()
        {
            return this._discoveryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIdIssuer. 
        /// <para>
        /// A string that identifies the type of OIDC service represented by this identity source.
        /// 
        /// </para>
        ///  
        /// <para>
        /// At this time, the only valid value is <c>cognito</c>.
        /// </para>
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration")]
        public OpenIdIssuer OpenIdIssuer
        {
            get { return this._openIdIssuer; }
            set { this._openIdIssuer = value; }
        }

        // Check to see if OpenIdIssuer property is set
        internal bool IsSetOpenIdIssuer()
        {
            return this._openIdIssuer != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The Amazon Cognito user pool whose identities are accessible to this Verified Permissions
        /// policy store.
        /// </para>
        /// </summary>
        [Obsolete("This attribute has been replaced by configuration.cognitoUserPoolConfiguration.userPoolArn")]
        [AWSProperty(Min=1, Max=255)]
        public string UserPoolArn
        {
            get { return this._userPoolArn; }
            set { this._userPoolArn = value; }
        }

        // Check to see if UserPoolArn property is set
        internal bool IsSetUserPoolArn()
        {
            return this._userPoolArn != null;
        }

    }
}