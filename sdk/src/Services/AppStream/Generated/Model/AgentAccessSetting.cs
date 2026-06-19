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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// A permission setting for an agent action. Each setting specifies an agent action and
    /// whether it is enabled or disabled.
    /// </summary>
    public partial class AgentAccessSetting
    {
        private AgentAction _agentAction;
        private Permission _permission;

        /// <summary>
        /// Gets and sets the property AgentAction. 
        /// <para>
        /// The agent action to configure. Valid values are COMPUTER_VISION, COMPUTER_INPUT, and
        /// FORWARD_MCP_TOOLS. If you enable COMPUTER_INPUT, you must also enable COMPUTER_VISION.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentAction AgentAction
        {
            get { return this._agentAction; }
            set { this._agentAction = value; }
        }

        // Check to see if AgentAction property is set
        internal bool IsSetAgentAction()
        {
            return this._agentAction != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// Whether the agent action is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Permission Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

    }
}