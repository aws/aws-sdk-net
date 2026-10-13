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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for the JWT token type.
    /// </summary>
    public partial class JwtTokenTypeConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClaimRegex. 
        /// <para>
        /// The regular expression that identifies the claim.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClaimRegex { get; set; }

        /// <summary>
        /// Checks to see if the ClaimRegex property is set.
        /// </summary>
        internal bool IsSetClaimRegex() => this.ClaimRegex != null;

        /// <summary>
        /// Gets and sets the property GroupAttributeField. 
        /// <para>
        /// The group attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string GroupAttributeField { get; set; }

        /// <summary>
        /// Checks to see if the GroupAttributeField property is set.
        /// </summary>
        internal bool IsSetGroupAttributeField() => this.GroupAttributeField != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer of the token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property KeyLocation. 
        /// <para>
        /// The location of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyLocation KeyLocation { get; set; }

        /// <summary>
        /// Checks to see if the KeyLocation property is set.
        /// </summary>
        internal bool IsSetKeyLocation() => this.KeyLocation != null;

        /// <summary>
        /// Gets and sets the property SecretManagerArn. 
        /// <para>
        /// The Amazon Resource Name (arn) of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string SecretManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretManagerArn property is set.
        /// </summary>
        internal bool IsSetSecretManagerArn() => this.SecretManagerArn != null;

        /// <summary>
        /// Gets and sets the property URL. 
        /// <para>
        /// The signing key URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string URL { get; set; }

        /// <summary>
        /// Checks to see if the URL property is set.
        /// </summary>
        internal bool IsSetURL() => this.URL != null;

        /// <summary>
        /// Gets and sets the property UserNameAttributeField. 
        /// <para>
        /// The user name attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string UserNameAttributeField { get; set; }

        /// <summary>
        /// Checks to see if the UserNameAttributeField property is set.
        /// </summary>
        internal bool IsSetUserNameAttributeField() => this.UserNameAttributeField != null;
    }
}
