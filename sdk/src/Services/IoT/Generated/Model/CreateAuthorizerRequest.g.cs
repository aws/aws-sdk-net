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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthorizer operation. Creates an authorizer.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuthorizer</a>
    /// action. </para>
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizerFunctionArn. 
        /// <para>
        /// The ARN of the authorizer's Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string AuthorizerFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerFunctionArn property is set.
        /// </summary>
        internal bool IsSetAuthorizerFunctionArn() => this.AuthorizerFunctionArn != null;

        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The authorizer name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AuthorizerName { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerName property is set.
        /// </summary>
        internal bool IsSetAuthorizerName() => this.AuthorizerName != null;

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
        public bool? EnableCachingForHttp { get; set; }

        /// <summary>
        /// Checks to see if the EnableCachingForHttp property is set.
        /// </summary>
        internal bool IsSetEnableCachingForHttp() => this.EnableCachingForHttp.HasValue;

        /// <summary>
        /// Gets and sets the property SigningDisabled. 
        /// <para>
        /// Specifies whether IoT validates the token signature in an authorization request.
        /// </para>
        /// </summary>
        public bool? SigningDisabled { get; set; }

        /// <summary>
        /// Checks to see if the SigningDisabled property is set.
        /// </summary>
        internal bool IsSetSigningDisabled() => this.SigningDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the create authorizer request.
        /// </para>
        /// </summary>
        public AuthorizerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenKeyName. 
        /// <para>
        /// The name of the token key used to extract the token from the HTTP headers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TokenKeyName { get; set; }

        /// <summary>
        /// Checks to see if the TokenKeyName property is set.
        /// </summary>
        internal bool IsSetTokenKeyName() => this.TokenKeyName != null;

        /// <summary>
        /// Gets and sets the property TokenSigningPublicKeys. 
        /// <para>
        /// The public keys used to verify the digital signature returned by your custom authentication
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TokenSigningPublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TokenSigningPublicKeys property is set.
        /// </summary>
        internal bool IsSetTokenSigningPublicKeys() => this.TokenSigningPublicKeys != null && (this.TokenSigningPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
