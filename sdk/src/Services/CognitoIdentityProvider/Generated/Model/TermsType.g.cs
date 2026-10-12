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
    /// The details of a set of terms documents. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
    /// documents</a>.
    /// </summary>
    public partial class TermsType
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that the terms documents are assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Enforcement. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TermsEnforcementType Enforcement { get; set; }

        /// <summary>
        /// Checks to see if the Enforcement property is set.
        /// </summary>
        internal bool IsSetEnforcement() => this.Enforcement != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 13)]
        public Dictionary<string, string> Links { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Links property is set.
        /// </summary>
        internal bool IsSetLinks() => this.Links != null && (this.Links.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TermsId. 
        /// <para>
        /// The ID of the terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TermsId { get; set; }

        /// <summary>
        /// Checks to see if the TermsId property is set.
        /// </summary>
        internal bool IsSetTermsId() => this.TermsId != null;

        /// <summary>
        /// Gets and sets the property TermsName. 
        /// <para>
        /// The type and friendly name of the terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TermsName { get; set; }

        /// <summary>
        /// Checks to see if the TermsName property is set.
        /// </summary>
        internal bool IsSetTermsName() => this.TermsName != null;

        /// <summary>
        /// Gets and sets the property TermsSource. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TermsSourceType TermsSource { get; set; }

        /// <summary>
        /// Checks to see if the TermsSource property is set.
        /// </summary>
        internal bool IsSetTermsSource() => this.TermsSource != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
