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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the CreateAgent operation.
    /// </summary>
    public partial class CreateAgentResponse : AmazonWebServiceResponse
    {
        private string _agentId;
        private string _agentName;
        private AgentStatus _agentStatus;
        private string _arn;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier for the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}