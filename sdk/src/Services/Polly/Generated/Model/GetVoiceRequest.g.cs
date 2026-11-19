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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Container for the parameters to the GetVoice operation. Returns the status and properties
    /// of a custom voice. Use this operation after <c>CreateVoice</c> to check whether the
    /// status of the voice is <c>active</c> or <c>failed</c>. Unlike <c>DescribeVoices</c>,
    /// <c>GetVoice</c> also returns <c>Arn</c>, <c>VoiceCreationData</c>, <c>CustomerManagedEncryption</c>,
    /// and <c>StatusReason</c>. If no custom voice with the specified ID exists in your account
    /// and Region, the request fails with <c>ResourceNotFoundException</c>. <para> This operation
    /// requires permissions to perform the <c>polly:GetVoice</c> action. </para>
    /// </summary>
    public partial class GetVoiceRequest : AmazonPollyRequest
    {
        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The ID of the custom voice that <c>CreateVoice</c> returned, for example, <c>vc-9a8fa85dd3</c>.
        /// You can't specify the ARN of the voice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
