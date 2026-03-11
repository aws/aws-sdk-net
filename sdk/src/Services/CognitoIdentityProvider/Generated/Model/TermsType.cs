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
    /// The details of a set of terms documents. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
    /// documents</a>.
    /// </summary>
    public partial class TermsType
    {
        private string _clientId;
        private DateTime? _creationDate;
        private TermsEnforcementType _enforcement;
        private DateTime? _lastModifiedDate;
        private Dictionary<string, string> _links = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _termsId;
        private string _termsName;
        private TermsSourceType _termsSource;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that the terms documents are assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enforcement. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
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
        [AWSProperty(Required=true, Min=1, Max=12)]
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
        /// The ID of the terms documents.
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
        /// The type and friendly name of the terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the user pool that contains the terms documents.
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