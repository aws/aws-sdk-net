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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the StartBrowserSession operation.
    /// </summary>
    public partial class StartBrowserSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BrowserIdentifier. 
        /// <para>
        /// The identifier of the browser.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrowserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BrowserIdentifier property is set.
        /// </summary>
        internal bool IsSetBrowserIdentifier() => this.BrowserIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the browser session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the created browser session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Streams. 
        /// <para>
        /// The streams associated with this browser session. These include the automation stream
        /// and live view stream.
        /// </para>
        /// </summary>
        public BrowserSessionStream Streams { get; set; }

        /// <summary>
        /// Checks to see if the Streams property is set.
        /// </summary>
        internal bool IsSetStreams() => this.Streams != null;
    }
}
