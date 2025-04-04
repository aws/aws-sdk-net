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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Container for the parameters to the GetMedicalScribeStream operation.
    /// Provides details about the specified Amazon Web Services HealthScribe streaming session.
    /// To view the status of the streaming session, check the <c>StreamStatus</c> field in
    /// the response. To get the details of post-stream analytics, including its status, check
    /// the <c>PostStreamAnalyticsResult</c> field in the response.
    /// </summary>
    public partial class GetMedicalScribeStreamRequest : AmazonTranscribeStreamingRequest
    {
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the HealthScribe streaming session you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}