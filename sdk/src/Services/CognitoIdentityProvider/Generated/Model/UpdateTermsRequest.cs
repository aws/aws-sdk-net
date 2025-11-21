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
    /// Container for the parameters to the UpdateTerms operation.
    /// Modifies existing terms documents for the requested app client. When Terms and conditions
    /// and Privacy policy documents are configured, the app client displays links to them
    /// in the sign-up page of managed login for the app client.
    /// 
    ///  
    /// <para>
    /// You can provide URLs for terms documents in the languages that are supported by <a
    /// href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-localization">managed
    /// login localization</a>. Amazon Cognito directs users to the terms documents for their
    /// current language, with fallback to <c>default</c> if no document exists for the language.
    /// </para>
    ///  
    /// <para>
    /// Each request accepts one type of terms document and a map of language-to-link for
    /// that document type. You must provide both types of terms documents in at least one
    /// language before Amazon Cognito displays your terms documents. Supply each type in
    /// separate requests.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
    /// documents</a>.
    /// </para>
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
    public partial class UpdateTermsRequest : AmazonCognitoIdentityProviderRequest
    {
        private TermsEnforcementType _enforcement;
        private Dictionary<string, string> _links = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _termsId;
        private string _termsName;
        private TermsSourceType _termsSource;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Enforcement. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts only one value.
        /// </para>
        /// </summary>
        public TermsEnforcementType Enforcement
        {
            get { return this._enforcement; }
            set { this._enforcement = value; }
        }

        // Check to see if Enforcement property is set
        internal bool IsSetEnforcement()
        {
            return this._enforcement != null;
        }

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// A map of URLs to languages. For each localized language that will view the requested
        /// <c>TermsName</c>, assign a URL. A selection of <c>cognito:default</c> displays for
        /// all languages that don't have a language-specific URL.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>"cognito:default": "https://terms.example.com", "cognito:spanish":
        /// "https://terms.example.com/es"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public Dictionary<string, string> Links
        {
            get { return this._links; }
            set { this._links = value; }
        }

        // Check to see if Links property is set
        internal bool IsSetLinks()
        {
            return this._links != null && (this._links.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TermsId. 
        /// <para>
        /// The ID of the terms document that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TermsId
        {
            get { return this._termsId; }
            set { this._termsId = value; }
        }

        // Check to see if TermsId property is set
        internal bool IsSetTermsId()
        {
            return this._termsId != null;
        }

        /// <summary>
        /// Gets and sets the property TermsName. 
        /// <para>
        /// The new name that you want to apply to the requested terms documents.
        /// </para>
        /// </summary>
        public string TermsName
        {
            get { return this._termsName; }
            set { this._termsName = value; }
        }

        // Check to see if TermsName property is set
        internal bool IsSetTermsName()
        {
            return this._termsName != null;
        }

        /// <summary>
        /// Gets and sets the property TermsSource. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts only one value.
        /// </para>
        /// </summary>
        public TermsSourceType TermsSource
        {
            get { return this._termsSource; }
            set { this._termsSource = value; }
        }

        // Check to see if TermsSource property is set
        internal bool IsSetTermsSource()
        {
            return this._termsSource != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the terms that you want to update.
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