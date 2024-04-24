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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The streaming configuration, such as the Amazon SNS streaming endpoint.
    /// </summary>
    public partial class ChatStreamingConfiguration
    {
        private string _streamingEndpointArn;

        /// <summary>
        /// Gets and sets the property StreamingEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the standard Amazon SNS topic. The Amazon Resource
        /// Name (ARN) of the streaming endpoint that is used to publish real-time message streaming
        /// for chat conversations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=350)]
        public string StreamingEndpointArn
        {
            get { return this._streamingEndpointArn; }
            set { this._streamingEndpointArn = value; }
        }

        // Check to see if StreamingEndpointArn property is set
        internal bool IsSetStreamingEndpointArn()
        {
            return this._streamingEndpointArn != null;
        }

    }
}