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
    /// Information of the AI agent involved in the contact.
    /// </summary>
    public partial class AiAgentInfo
    {
        private bool? _aiAgentEscalated;
        private string _aiAgentVersionId;
        private AiUseCase _aiUseCase;

        /// <summary>
        /// Gets and sets the property AiAgentEscalated. 
        /// <para>
        ///  A boolean flag indicating whether the contact initially handled by this AI agent
        /// was escalated to a human agent. 
        /// </para>
        /// </summary>
        public bool? AiAgentEscalated
        {
            get { return this._aiAgentEscalated; }
            set { this._aiAgentEscalated = value; }
        }

        // Check to see if AiAgentEscalated property is set
        internal bool IsSetAiAgentEscalated()
        {
            return this._aiAgentEscalated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AiAgentVersionId. 
        /// <para>
        ///  The unique identifier that specifies both the AI agent ID and its version number
        /// that was involved in the contact 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string AiAgentVersionId
        {
            get { return this._aiAgentVersionId; }
            set { this._aiAgentVersionId = value; }
        }

        // Check to see if AiAgentVersionId property is set
        internal bool IsSetAiAgentVersionId()
        {
            return this._aiAgentVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property AiUseCase. 
        /// <para>
        ///  The use case or scenario for which the AI agent is involved in the contact 
        /// </para>
        /// </summary>
        public AiUseCase AiUseCase
        {
            get { return this._aiUseCase; }
            set { this._aiUseCase = value; }
        }

        // Check to see if AiUseCase property is set
        internal bool IsSetAiUseCase()
        {
            return this._aiUseCase != null;
        }

    }
}