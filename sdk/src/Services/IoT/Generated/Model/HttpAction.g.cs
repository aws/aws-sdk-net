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
    /// Send data to an HTTPS endpoint.
    /// </summary>
    public partial class HttpAction
    {
        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// The authentication method to use when sending data to an HTTPS endpoint.
        /// </para>
        /// </summary>
        public HttpAuthorization Auth { get; set; }

        /// <summary>
        /// Checks to see if the Auth property is set.
        /// </summary>
        internal bool IsSetAuth() => this.Auth != null;

        /// <summary>
        /// Gets and sets the property BatchConfig. 
        /// <para>
        /// The configuration settings for batching. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/http_batching.html">
        /// Batching HTTP action messages</a>.
        /// </para>
        /// </summary>
        public BatchConfig BatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the BatchConfig property is set.
        /// </summary>
        internal bool IsSetBatchConfig() => this.BatchConfig != null;

        /// <summary>
        /// Gets and sets the property ConfirmationUrl. 
        /// <para>
        /// The URL to which IoT sends a confirmation message. The value of the confirmation URL
        /// must be a prefix of the endpoint URL. If you do not specify a confirmation URL IoT
        /// uses the endpoint URL as the confirmation URL. If you use substitution templates in
        /// the confirmationUrl, you must create and enable topic rule destinations that match
        /// each possible value of the substitution template before traffic is allowed to your
        /// endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string ConfirmationUrl { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationUrl property is set.
        /// </summary>
        internal bool IsSetConfirmationUrl() => this.ConfirmationUrl != null;

        /// <summary>
        /// Gets and sets the property EnableBatching. 
        /// <para>
        /// Whether to process the HTTP action messages into a single request. Value can be true
        /// or false.
        /// </para>
        /// </summary>
        public bool? EnableBatching { get; set; }

        /// <summary>
        /// Checks to see if the EnableBatching property is set.
        /// </summary>
        internal bool IsSetEnableBatching() => this.EnableBatching.HasValue;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The HTTP headers to send with the message data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<HttpActionHeader> Headers { get; set; } = AWSConfigs.InitializeCollections ? new List<HttpActionHeader>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The endpoint URL. If substitution templates are used in the URL, you must also specify
        /// a <c>confirmationUrl</c>. If this is a new destination, a new <c>TopicRuleDestination</c>
        /// is created if possible.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2000)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
