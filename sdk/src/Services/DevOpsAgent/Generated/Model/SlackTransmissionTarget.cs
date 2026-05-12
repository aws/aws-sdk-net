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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Defines Slack channels for different types of agent notifications.
    /// </summary>
    public partial class SlackTransmissionTarget
    {
        private SlackChannel _opsOncallTarget;
        private SlackChannel _opssreTarget;

        /// <summary>
        /// Gets and sets the property OpsOncallTarget. 
        /// <para>
        /// Destination for On-call Agent (Ops1)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlackChannel OpsOncallTarget
        {
            get { return this._opsOncallTarget; }
            set { this._opsOncallTarget = value; }
        }

        // Check to see if OpsOncallTarget property is set
        internal bool IsSetOpsOncallTarget()
        {
            return this._opsOncallTarget != null;
        }

        /// <summary>
        /// Gets and sets the property OpsSRETarget. 
        /// <para>
        /// Destination for SRE Agent (Ops1.5)
        /// </para>
        /// </summary>
        public SlackChannel OpsSRETarget
        {
            get { return this._opssreTarget; }
            set { this._opssreTarget = value; }
        }

        // Check to see if OpsSRETarget property is set
        internal bool IsSetOpsSRETarget()
        {
            return this._opssreTarget != null;
        }

    }
}