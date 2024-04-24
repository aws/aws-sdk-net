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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
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
namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// The possible types of dialer config parameters
    /// </summary>
    public partial class DialerConfig
    {
        private AgentlessDialerConfig _agentlessDialerConfig;
        private PredictiveDialerConfig _predictiveDialerConfig;
        private ProgressiveDialerConfig _progressiveDialerConfig;

        /// <summary>
        /// Gets and sets the property AgentlessDialerConfig.
        /// </summary>
        public AgentlessDialerConfig AgentlessDialerConfig
        {
            get { return this._agentlessDialerConfig; }
            set { this._agentlessDialerConfig = value; }
        }

        // Check to see if AgentlessDialerConfig property is set
        internal bool IsSetAgentlessDialerConfig()
        {
            return this._agentlessDialerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PredictiveDialerConfig.
        /// </summary>
        public PredictiveDialerConfig PredictiveDialerConfig
        {
            get { return this._predictiveDialerConfig; }
            set { this._predictiveDialerConfig = value; }
        }

        // Check to see if PredictiveDialerConfig property is set
        internal bool IsSetPredictiveDialerConfig()
        {
            return this._predictiveDialerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressiveDialerConfig.
        /// </summary>
        public ProgressiveDialerConfig ProgressiveDialerConfig
        {
            get { return this._progressiveDialerConfig; }
            set { this._progressiveDialerConfig = value; }
        }

        // Check to see if ProgressiveDialerConfig property is set
        internal bool IsSetProgressiveDialerConfig()
        {
            return this._progressiveDialerConfig != null;
        }

    }
}