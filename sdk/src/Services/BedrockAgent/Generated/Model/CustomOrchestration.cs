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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Details of custom orchestration.
    /// </summary>
    public partial class CustomOrchestration
    {
        private OrchestrationExecutor _executor;

        /// <summary>
        /// Gets and sets the property Executor. 
        /// <para>
        ///  The structure of the executor invoking the actions in custom orchestration. 
        /// </para>
        /// </summary>
        public OrchestrationExecutor Executor
        {
            get { return this._executor; }
            set { this._executor = value; }
        }

        // Check to see if Executor property is set
        internal bool IsSetExecutor()
        {
            return this._executor != null;
        }

    }
}