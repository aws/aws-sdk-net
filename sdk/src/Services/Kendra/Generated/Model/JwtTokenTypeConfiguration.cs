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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
        private string _claimRegex;
        private string _groupAttributeField;
        private string _issuer;
        private KeyLocation _keyLocation;
        private string _secretManagerArn;
        private string _url;
        private string _userNameAttributeField;

        /// <summary>
        /// Gets and sets the property ClaimRegex. 
        /// <para>
        /// The regular expression that identifies the claim.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClaimRegex
        {
            get { return this._claimRegex; }
            set { this._claimRegex = value; }
        }

        // Check to see if ClaimRegex property is set
        internal bool IsSetClaimRegex()
        {
            return this._claimRegex != null;
        }

        /// <summary>
        /// Gets and sets the property GroupAttributeField. 
        /// <para>
        /// The group attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string GroupAttributeField
        {
            get { return this._groupAttributeField; }
            set { this._groupAttributeField = value; }
        }

        // Check to see if GroupAttributeField property is set
        internal bool IsSetGroupAttributeField()
        {
            return this._groupAttributeField != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer of the token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property KeyLocation. 
        /// <para>
        /// The location of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyLocation KeyLocation
        {
            get { return this._keyLocation; }
            set { this._keyLocation = value; }
        }

        // Check to see if KeyLocation property is set
        internal bool IsSetKeyLocation()
        {
            return this._keyLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SecretManagerArn. 
        /// <para>
        /// The Amazon Resource Name (arn) of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string SecretManagerArn
        {
            get { return this._secretManagerArn; }
            set { this._secretManagerArn = value; }
        }

        // Check to see if SecretManagerArn property is set
        internal bool IsSetSecretManagerArn()
        {
            return this._secretManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property URL. 
        /// <para>
        /// The signing key URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string URL
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if URL property is set
        internal bool IsSetURL()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UserNameAttributeField. 
        /// <para>
        /// The user name attribute field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string UserNameAttributeField
        {
            get { return this._userNameAttributeField; }
            set { this._userNameAttributeField = value; }
        }

        // Check to see if UserNameAttributeField property is set
        internal bool IsSetUserNameAttributeField()
        {
            return this._userNameAttributeField != null;
        }

    }
}