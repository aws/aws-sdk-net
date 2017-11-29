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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The authorizer description.
    /// </summary>
    public partial class AuthorizerDescription
    {
        private string _authorizerArn;
        private string _authorizerFunctionArn;
        private string _authorizerName;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private AuthorizerStatus _status;
        private string _tokenKeyName;
        private Dictionary<string, string> _tokenSigningPublicKeys = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AuthorizerArn. 
        /// <para>
        /// The authorizer ARN.
        /// </para>
        /// </summary>
        public string AuthorizerArn
        {
            get { return this._authorizerArn; }
            set { this._authorizerArn = value; }
        }

        // Check to see if AuthorizerArn property is set
        internal bool IsSetAuthorizerArn()
        {
            return this._authorizerArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerFunctionArn. 
        /// <para>
        /// The authorizer's Lambda function ARN.
        /// </para>
        /// </summary>
        public string AuthorizerFunctionArn
        {
            get { return this._authorizerFunctionArn; }
            set { this._authorizerFunctionArn = value; }
        }

        // Check to see if AuthorizerFunctionArn property is set
        internal bool IsSetAuthorizerFunctionArn()
        {
            return this._authorizerFunctionArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The authorizer name.
        /// </para>
        /// </summary>
        public string AuthorizerName
        {
            get { return this._authorizerName; }
            set { this._authorizerName = value; }
        }

        // Check to see if AuthorizerName property is set
        internal bool IsSetAuthorizerName()
        {
            return this._authorizerName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UNIX timestamp of when the authorizer was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The UNIX timestamp of when the authorizer was last updated.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the authorizer.
        /// </para>
        /// </summary>
        public AuthorizerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TokenKeyName. 
        /// <para>
        /// The key used to extract the token from the HTTP headers.
        /// </para>
        /// </summary>
        public string TokenKeyName
        {
            get { return this._tokenKeyName; }
            set { this._tokenKeyName = value; }
        }

        // Check to see if TokenKeyName property is set
        internal bool IsSetTokenKeyName()
        {
            return this._tokenKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property TokenSigningPublicKeys. 
        /// <para>
        /// The public keys used to validate the token signature returned by your custom authentication
        /// service.
        /// </para>
        /// </summary>
        public Dictionary<string, string> TokenSigningPublicKeys
        {
            get { return this._tokenSigningPublicKeys; }
            set { this._tokenSigningPublicKeys = value; }
        }

        // Check to see if TokenSigningPublicKeys property is set
        internal bool IsSetTokenSigningPublicKeys()
        {
            return this._tokenSigningPublicKeys != null && this._tokenSigningPublicKeys.Count > 0; 
        }

    }
}