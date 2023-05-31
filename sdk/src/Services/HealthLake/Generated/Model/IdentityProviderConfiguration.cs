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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The identity provider configuration that you gave when the Data Store was created.
    /// </summary>
    public partial class IdentityProviderConfiguration
    {
        private AuthorizationStrategy _authorizationStrategy;
        private bool? _fineGrainedAuthorizationEnabled;
        private string _idpLambdaArn;
        private string _metadata;

        /// <summary>
        /// Gets and sets the property AuthorizationStrategy. 
        /// <para>
        /// The authorization strategy that you selected when you created the Data Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizationStrategy AuthorizationStrategy
        {
            get { return this._authorizationStrategy; }
            set { this._authorizationStrategy = value; }
        }

        // Check to see if AuthorizationStrategy property is set
        internal bool IsSetAuthorizationStrategy()
        {
            return this._authorizationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property FineGrainedAuthorizationEnabled. 
        /// <para>
        /// If you enabled fine-grained authorization when you created the Data Store.
        /// </para>
        /// </summary>
        public bool FineGrainedAuthorizationEnabled
        {
            get { return this._fineGrainedAuthorizationEnabled.GetValueOrDefault(); }
            set { this._fineGrainedAuthorizationEnabled = value; }
        }

        // Check to see if FineGrainedAuthorizationEnabled property is set
        internal bool IsSetFineGrainedAuthorizationEnabled()
        {
            return this._fineGrainedAuthorizationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdpLambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that you want to use to decode
        /// the access token created by the authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=49, Max=256)]
        public string IdpLambdaArn
        {
            get { return this._idpLambdaArn; }
            set { this._idpLambdaArn = value; }
        }

        // Check to see if IdpLambdaArn property is set
        internal bool IsSetIdpLambdaArn()
        {
            return this._idpLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The JSON metadata elements that you want to use in your identity provider configuration.
        /// Required elements are listed based on the launch specification of the SMART application.
        /// For more information on all possible elements, see <a href="https://build.fhir.org/ig/HL7/smart-app-launch/conformance.html#metadata">Metadata</a>
        /// in SMART's App Launch specification.
        /// </para>
        ///  
        /// <para>
        ///  <code>authorization_endpoint</code>: The URL to the OAuth2 authorization endpoint.
        /// </para>
        ///  
        /// <para>
        ///  <code>grant_types_supported</code>: An array of grant types that are supported at
        /// the token endpoint. You must provide at least one grant type option. Valid options
        /// are <code>authorization_code</code> and <code>client_credentials</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>token_endpoint</code>: The URL to the OAuth2 token endpoint.
        /// </para>
        ///  
        /// <para>
        ///  <code>capabilities</code>: An array of strings of the SMART capabilities that the
        /// authorization server supports.
        /// </para>
        ///  
        /// <para>
        ///  <code>code_challenge_methods_supported</code>: An array of strings of supported PKCE
        /// code challenge methods. You must include the <code>S256</code> method in the array
        /// of PKCE code challenge methods.
        /// </para>
        /// </summary>
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

    }
}