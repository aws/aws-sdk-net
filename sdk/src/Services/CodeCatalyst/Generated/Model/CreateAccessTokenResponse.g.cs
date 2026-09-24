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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessToken operation.
    /// </summary>
    public partial class CreateAccessTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessTokenId. 
        /// <para>
        /// The system-generated unique ID of the access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string AccessTokenId { get; set; }

        /// <summary>
        /// Checks to see if the AccessTokenId property is set.
        /// </summary>
        internal bool IsSetAccessTokenId() => this.AccessTokenId != null;

        /// <summary>
        /// Gets and sets the property ExpiresTime. 
        /// <para>
        /// The date and time the personal access token expires, in coordinated universal time
        /// (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>. If not specified, the default is one year from creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiresTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresTime property is set.
        /// </summary>
        internal bool IsSetExpiresTime() => this.ExpiresTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the personal access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// The secret value of the personal access token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4000)]
        public string Secret { get; set; }

        /// <summary>
        /// Checks to see if the Secret property is set.
        /// </summary>
        internal bool IsSetSecret() => this.Secret != null;
    }
}
