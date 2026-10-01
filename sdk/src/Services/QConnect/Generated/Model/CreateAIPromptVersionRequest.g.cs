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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAIPromptVersion operation. Creates an Amazon
    /// Q in Connect AI Prompt version.
    /// </summary>
    public partial class CreateAIPromptVersionRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AiPromptId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect AI prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiPromptId { get; set; }

        /// <summary>
        /// Checks to see if the AiPromptId property is set.
        /// </summary>
        internal bool IsSetAiPromptId() => this.AiPromptId != null;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant. Can be either the ID or the ARN.
        /// URLs cannot contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="http://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>..
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ModifiedTime. 
        /// <para>
        /// The time the AI Prompt was last modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTime property is set.
        /// </summary>
        internal bool IsSetModifiedTime() => this.ModifiedTime.HasValue;
    }
}
