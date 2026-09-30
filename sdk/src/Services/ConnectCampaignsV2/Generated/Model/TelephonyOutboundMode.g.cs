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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Telephony Outbound Mode
    /// </summary>
    public partial class TelephonyOutboundMode
    {
        /// <summary>
        /// Gets and sets the property Agentless.
        /// </summary>
        public AgentlessConfig Agentless { get; set; }

        /// <summary>
        /// Checks to see if the Agentless property is set.
        /// </summary>
        internal bool IsSetAgentless() => this.Agentless != null;

        /// <summary>
        /// Gets and sets the property Predictive.
        /// </summary>
        public PredictiveConfig Predictive { get; set; }

        /// <summary>
        /// Checks to see if the Predictive property is set.
        /// </summary>
        internal bool IsSetPredictive() => this.Predictive != null;

        /// <summary>
        /// Gets and sets the property Preview.
        /// </summary>
        public PreviewConfig Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview != null;

        /// <summary>
        /// Gets and sets the property Progressive.
        /// </summary>
        public ProgressiveConfig Progressive { get; set; }

        /// <summary>
        /// Checks to see if the Progressive property is set.
        /// </summary>
        internal bool IsSetProgressive() => this.Progressive != null;
    }
}
