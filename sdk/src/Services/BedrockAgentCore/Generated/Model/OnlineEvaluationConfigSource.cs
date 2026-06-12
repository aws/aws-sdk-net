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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// A reference to an existing online evaluation configuration to use as the data source
    /// for batch evaluation.
    /// </summary>
    public partial class OnlineEvaluationConfigSource
    {
        private string _onlineEvaluationConfigArn;
        private SessionFilterConfig _sessionFilterConfig;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the online evaluation configuration to use as the
        /// session source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigArn
        {
            get { return this._onlineEvaluationConfigArn; }
            set { this._onlineEvaluationConfigArn = value; }
        }

        // Check to see if OnlineEvaluationConfigArn property is set
        internal bool IsSetOnlineEvaluationConfigArn()
        {
            return this._onlineEvaluationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionFilterConfig. 
        /// <para>
        /// Optional session filter configuration to narrow down which sessions from the online
        /// evaluation configuration to include.
        /// </para>
        /// </summary>
        public SessionFilterConfig SessionFilterConfig
        {
            get { return this._sessionFilterConfig; }
            set { this._sessionFilterConfig = value; }
        }

        // Check to see if SessionFilterConfig property is set
        internal bool IsSetSessionFilterConfig()
        {
            return this._sessionFilterConfig != null;
        }

    }
}