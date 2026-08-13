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
    /// The AI agent that participates in the contact, including its identifier.
    /// </summary>
    public partial class AiAgentInput
    {
        private string _aiAgentId;

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// The identifier of the AI agent that participates in the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string AiAgentId
        {
            get { return this._aiAgentId; }
            set { this._aiAgentId = value; }
        }

        // Check to see if AiAgentId property is set
        internal bool IsSetAiAgentId()
        {
            return this._aiAgentId != null;
        }

    }
}