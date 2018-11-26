/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAgent operation.
    /// Deletes an agent. To specify which agent to delete, use the Amazon Resource Name (ARN)
    /// of the agent in your request. The operation disassociates the agent from your AWS
    /// account. However, it doesn't delete the agent virtual machine (VM) from your on-premises
    /// environment.
    /// 
    ///  <note> 
    /// <para>
    /// After you delete an agent, you can't reactivate it and you longer pay software charges
    /// for it.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteAgentRequest : AmazonDataSyncRequest
    {
        private string _agentArn;

        /// <summary>
        /// Gets and sets the property AgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent to delete. Use the <code>ListAgents</code>
        /// operation to return a list of agents for your account and AWS Region.
        /// </para>
        /// </summary>
        public string AgentArn
        {
            get { return this._agentArn; }
            set { this._agentArn = value; }
        }

        // Check to see if AgentArn property is set
        internal bool IsSetAgentArn()
        {
            return this._agentArn != null;
        }

    }
}