/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUserPoolClient operation.
    /// Creates the user pool client.
    /// </summary>
    public partial class CreateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _clientName;
        private List<string> _explicitAuthFlows = new List<string>();
        private bool? _generateSecret;
        private List<string> _readAttributes = new List<string>();
        private int? _refreshTokenValidity;
        private string _userPoolId;
        private List<string> _writeAttributes = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The client name for the user pool client you would like to create.
        /// </para>
        /// </summary>
        public string ClientName
        {
            get { return this._clientName; }
            set { this._clientName = value; }
        }

        // Check to see if ClientName property is set
        internal bool IsSetClientName()
        {
            return this._clientName != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitAuthFlows. 
        /// <para>
        /// The explicit authentication flows.
        /// </para>
        /// </summary>
        public List<string> ExplicitAuthFlows
        {
            get { return this._explicitAuthFlows; }
            set { this._explicitAuthFlows = value; }
        }

        // Check to see if ExplicitAuthFlows property is set
        internal bool IsSetExplicitAuthFlows()
        {
            return this._explicitAuthFlows != null && this._explicitAuthFlows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GenerateSecret. 
        /// <para>
        ///  Boolean to specify whether you want to generate a secret for the user pool client
        /// being created.
        /// </para>
        /// </summary>
        public bool GenerateSecret
        {
            get { return this._generateSecret.GetValueOrDefault(); }
            set { this._generateSecret = value; }
        }

        // Check to see if GenerateSecret property is set
        internal bool IsSetGenerateSecret()
        {
            return this._generateSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadAttributes. 
        /// <para>
        /// The read attributes.
        /// </para>
        /// </summary>
        public List<string> ReadAttributes
        {
            get { return this._readAttributes; }
            set { this._readAttributes = value; }
        }

        // Check to see if ReadAttributes property is set
        internal bool IsSetReadAttributes()
        {
            return this._readAttributes != null && this._readAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RefreshTokenValidity. 
        /// <para>
        /// Refreshes the token validity.
        /// </para>
        /// </summary>
        public int RefreshTokenValidity
        {
            get { return this._refreshTokenValidity.GetValueOrDefault(); }
            set { this._refreshTokenValidity = value; }
        }

        // Check to see if RefreshTokenValidity property is set
        internal bool IsSetRefreshTokenValidity()
        {
            return this._refreshTokenValidity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where you want to create a user pool client.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property WriteAttributes. 
        /// <para>
        /// The write attributes.
        /// </para>
        /// </summary>
        public List<string> WriteAttributes
        {
            get { return this._writeAttributes; }
            set { this._writeAttributes = value; }
        }

        // Check to see if WriteAttributes property is set
        internal bool IsSetWriteAttributes()
        {
            return this._writeAttributes != null && this._writeAttributes.Count > 0; 
        }

    }
}