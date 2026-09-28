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
    /// Reference information for a suggested message.
    /// </summary>
    public partial class SuggestedMessageReference
    {
        /// <summary>
        /// Gets and sets the property AiAgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI Agent that generated the suggested message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiAgentArn { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentArn property is set.
        /// </summary>
        internal bool IsSetAiAgentArn() => this.AiAgentArn != null;

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// The identifier of the AI Agent that generated the suggested message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AiAgentId { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentId property is set.
        /// </summary>
        internal bool IsSetAiAgentId() => this.AiAgentId != null;
    }
}
