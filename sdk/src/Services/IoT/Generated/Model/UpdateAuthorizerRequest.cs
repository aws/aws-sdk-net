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
    /// Container for the parameters to the UpdateAuthorizer operation.
    /// Updates an authorizer.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateAuthorizer</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateAuthorizerRequest : AmazonIoTRequest
    {
        private string _authorizerFunctionArn;
        private string _authorizerName;
        private bool? _enableCachingForHttp;
        private AuthorizerStatus _status;
        private string _tokenKeyName;
        private Dictionary<string, string> _tokenSigningPublicKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizerFunctionArn. 
        /// <para>
        /// The ARN of the authorizer's Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// When <c>true</c>, the result from the authorizer’s Lambda function is cached for the
        /// time specified in <c>refreshAfterInSeconds</c>. The cached result is used while the
        /// device reuses the same HTTP connection.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the update authorizer request.
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
        /// The public keys used to verify the token signature.
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