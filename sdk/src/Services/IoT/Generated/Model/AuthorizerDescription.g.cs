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
    /// The authorizer description.
    /// </summary>
    public partial class AuthorizerDescription
    {
        /// <summary>
        /// Gets and sets the property AuthorizerArn. 
        /// <para>
        /// The authorizer ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AuthorizerArn { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerArn property is set.
        /// </summary>
        internal bool IsSetAuthorizerArn() => this.AuthorizerArn != null;

        /// <summary>
        /// Gets and sets the property AuthorizerFunctionArn. 
        /// <para>
        /// The authorizer's Lambda function ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
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
        [AWSProperty(Min = 1, Max = 128)]
        public string AuthorizerName { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerName property is set.
        /// </summary>
        internal bool IsSetAuthorizerName() => this.AuthorizerName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UNIX timestamp of when the authorizer was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property EnableCachingForHttp. 
        /// <para>
        /// When <c>true</c>, the result from the authorizer’s Lambda function is cached for the
        /// time specified in <c>refreshAfterInSeconds</c>. The cached result is used while the
        /// device reuses the same HTTP connection.
        /// </para>
        /// </summary>
        public bool? EnableCachingForHttp { get; set; }

        /// <summary>
        /// Checks to see if the EnableCachingForHttp property is set.
        /// </summary>
        internal bool IsSetEnableCachingForHttp() => this.EnableCachingForHttp.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The UNIX timestamp of when the authorizer was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

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
        /// The status of the authorizer.
        /// </para>
        /// </summary>
        public AuthorizerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TokenKeyName. 
        /// <para>
        /// The key used to extract the token from the HTTP headers.
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
        /// The public keys used to validate the token signature returned by your custom authentication
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
