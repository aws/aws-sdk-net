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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The DataSync agents that can connect to your Network File System (NFS) file server.
    /// </summary>
    public partial class OnPremConfig
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the DataSync agents that can connect to your NFS
        /// file server.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one agent. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html#multiple-agents">Using
        /// multiple DataSync agents</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}