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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthorizer operation.
    /// Creates an authorizer.
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonIoTRequest
    {
        private string _authorizerFunctionArn;
        private string _authorizerName;
        private bool? _signingDisabled;
        private AuthorizerStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _tokenKeyName;
        private Dictionary<string, string> _tokenSigningPublicKeys = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AuthorizerFunctionArn. 
        /// <para>
        /// The ARN of the authorizer's Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
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
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property SigningDisabled. 
        /// <para>
        /// Specifies whether AWS IoT validates the token signature in an authorization request.
        /// </para>
        /// </summary>
        public bool SigningDisabled
        {
            get { return this._signingDisabled.GetValueOrDefault(); }
            set { this._signingDisabled = value; }
        }

        // Check to see if SigningDisabled property is set
        internal bool IsSetSigningDisabled()
        {
            return this._signingDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the create authorizer request.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the custom authorizer.
        /// </para>
        ///  <note> 
        /// <para>
        /// For URI Request parameters use format: ...key1=value1&amp;key2=value2...
        /// </para>
        ///  
        /// <para>
        /// For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."
        /// </para>
        ///  
        /// <para>
        /// For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property TokenKeyName. 
        /// <para>
        /// The name of the token key used to extract the token from the HTTP headers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The public keys used to verify the digital signature returned by your custom authentication
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