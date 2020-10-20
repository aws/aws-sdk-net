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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a GraphQL API.
    /// </summary>
    public partial class GraphqlApi
    {
        private List<AdditionalAuthenticationProvider> _additionalAuthenticationProviders = new List<AdditionalAuthenticationProvider>();
        private string _apiId;
        private string _arn;
        private AuthenticationType _authenticationType;
        private LogConfig _logConfig;
        private string _name;
        private OpenIDConnectConfig _openidConnectConfig;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private Dictionary<string, string> _uris = new Dictionary<string, string>();
        private UserPoolConfig _userPoolConfig;
        private string _wafWebAclArn;
        private bool? _xrayEnabled;

        /// <summary>
        /// Gets and sets the property AdditionalAuthenticationProviders. 
        /// <para>
        /// A list of additional authentication providers for the <code>GraphqlApi</code> API.
        /// </para>
        /// </summary>
        public List<AdditionalAuthenticationProvider> AdditionalAuthenticationProviders
        {
            get { return this._additionalAuthenticationProviders; }
            set { this._additionalAuthenticationProviders = value; }
        }

        // Check to see if AdditionalAuthenticationProviders property is set
        internal bool IsSetAdditionalAuthenticationProviders()
        {
            return this._additionalAuthenticationProviders != null && this._additionalAuthenticationProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type.
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The Amazon CloudWatch Logs configuration.
        /// </para>
        /// </summary>
        public LogConfig LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The API name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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
        /// Gets and sets the property OpenIDConnectConfig. 
        /// <para>
        /// The OpenID Connect configuration.
        /// </para>
        /// </summary>
        public OpenIDConnectConfig OpenIDConnectConfig
        {
            get { return this._openidConnectConfig; }
            set { this._openidConnectConfig = value; }
        }

        // Check to see if OpenIDConnectConfig property is set
        internal bool IsSetOpenIDConnectConfig()
        {
            return this._openidConnectConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Uris. 
        /// <para>
        /// The URIs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Uris
        {
            get { return this._uris; }
            set { this._uris = value; }
        }

        // Check to see if Uris property is set
        internal bool IsSetUris()
        {
            return this._uris != null && this._uris.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolConfig. 
        /// <para>
        /// The Amazon Cognito user pool configuration.
        /// </para>
        /// </summary>
        public UserPoolConfig UserPoolConfig
        {
            get { return this._userPoolConfig; }
            set { this._userPoolConfig = value; }
        }

        // Check to see if UserPoolConfig property is set
        internal bool IsSetUserPoolConfig()
        {
            return this._userPoolConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WafWebAclArn. 
        /// <para>
        /// The ARN of the AWS Web Application Firewall (WAF) ACL associated with this <code>GraphqlApi</code>,
        /// if one exists.
        /// </para>
        /// </summary>
        public string WafWebAclArn
        {
            get { return this._wafWebAclArn; }
            set { this._wafWebAclArn = value; }
        }

        // Check to see if WafWebAclArn property is set
        internal bool IsSetWafWebAclArn()
        {
            return this._wafWebAclArn != null;
        }

        /// <summary>
        /// Gets and sets the property XrayEnabled. 
        /// <para>
        /// A flag representing whether X-Ray tracing is enabled for this <code>GraphqlApi</code>.
        /// </para>
        /// </summary>
        public bool XrayEnabled
        {
            get { return this._xrayEnabled.GetValueOrDefault(); }
            set { this._xrayEnabled = value; }
        }

        // Check to see if XrayEnabled property is set
        internal bool IsSetXrayEnabled()
        {
            return this._xrayEnabled.HasValue; 
        }

    }
}