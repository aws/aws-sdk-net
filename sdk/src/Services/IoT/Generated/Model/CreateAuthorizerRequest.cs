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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthorizer operation.
    /// Creates an authorizer.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuthorizer</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonIoTRequest
    {
        private string _authorizerFunctionArn;
        private string _authorizerName;
        private bool? _enableCachingForHttp;
        private bool? _signingDisabled;
        private AuthorizerStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tokenKeyName;
        private Dictionary<string, string> _tokenSigningPublicKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property EnableCachingForHttp. 
        /// <para>
        /// When <c>true</c>, the result from the authorizer’s Lambda function is cached for clients
        /// that use persistent HTTP connections. The results are cached for the time specified
        /// by the Lambda function in <c>refreshAfterInSeconds</c>. This value does not affect
        /// authorization of clients that use MQTT connections.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableCachingForHttp
        {
            get { return this._enableCachingForHttp; }
            set { this._enableCachingForHttp = value; }
        }

        // Check to see if EnableCachingForHttp property is set
        internal bool IsSetEnableCachingForHttp()
        {
            return this._enableCachingForHttp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningDisabled. 
        /// <para>
        /// Specifies whether IoT validates the token signature in an authorization request.
        /// </para>
        /// </summary>
        public bool? SigningDisabled
        {
            get { return this._signingDisabled; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TokenSigningPublicKeys
        {
            get { return this._tokenSigningPublicKeys; }
            set { this._tokenSigningPublicKeys = value; }
        }

        // Check to see if TokenSigningPublicKeys property is set
        internal bool IsSetTokenSigningPublicKeys()
        {
            return this._tokenSigningPublicKeys != null && (this._tokenSigningPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}