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
    /// Container for the parameters to the CreateAgent operation.
    /// Activates an AWS DataSync agent that you have deployed on your host. The activation
    /// process associates your agent with your account. In the activation process, you specify
    /// information such as the AWS Region that you want to activate the agent in. You activate
    /// the agent in the AWS Region where your target locations (in Amazon S3 or Amazon EFS)
    /// reside. Your tasks are created in this AWS Region. 
    /// 
    ///  
    /// <para>
    /// You can use an agent for more than one location. If a task uses multiple agents, all
    /// of them need to have status AVAILABLE for the task to run. If you use multiple agents
    /// for a source location, the status of all the agents must be AVAILABLE for the task
    /// to run. For more information, see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/working-with-sync-agents.html#activating-sync-agent">Activating
    /// a Sync Agent</a> in the <i>AWS DataSync User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// Agents are automatically updated by AWS on a regular basis, using a mechanism that
    /// ensures minimal interruption to your tasks.
    /// </para>
    /// </summary>
    public partial class CreateAgentRequest : AmazonDataSyncRequest
    {
        private string _activationKey;
        private string _agentName;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property ActivationKey. 
        /// <para>
        /// Your agent activation key. You can get the activation key either by sending an HTTP
        /// GET request with redirects that enable you to get the agent IP address (port 80).
        /// Alternatively, you can get it from the AWS DataSync console. 
        /// </para>
        ///  
        /// <para>
        /// The redirect URL returned in the response provides you the activation key for your
        /// agent in the query string parameter <code>activationKey</code>. It might also include
        /// other activation-related parameters; however, these are merely defaults. The arguments
        /// you pass to this API call determine the actual configuration of your agent. For more
        /// information, see <a href="https://docs.aws.amazon.com/sync-service/latest/userguide/working-with-sync-agents.html#activating-sync-agent">Activating
        /// a Sync Agent</a> in the <i>AWS DataSync User Guide.</i> 
        /// </para>
        /// </summary>
        public string ActivationKey
        {
            get { return this._activationKey; }
            set { this._activationKey = value; }
        }

        // Check to see if ActivationKey property is set
        internal bool IsSetActivationKey()
        {
            return this._activationKey != null;
        }

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name you configured for your agent. This value is a text reference that is used
        /// to identify the agent in the console.
        /// </para>
        /// </summary>
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents the tag you want to associate with the agent. The
        /// value can be an empty string. This value helps you manage, filter, and search for
        /// your agents.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. 
        /// </para>
        ///  </note>
        /// </summary>
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}