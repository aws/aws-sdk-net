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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// This is the response object from the GetAgentTaskResponseUrl operation.
    /// </summary>
    public partial class GetAgentTaskResponseUrlResponse : AmazonWebServiceResponse
    {
        private string _agentId;
        private string _presignedLogUrl;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// UUID of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property PresignedLogUrl. 
        /// <para>
        /// Presigned URL for uploading agent task response logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PresignedLogUrl
        {
            get { return this._presignedLogUrl; }
            set { this._presignedLogUrl = value; }
        }

        // Check to see if PresignedLogUrl property is set
        internal bool IsSetPresignedLogUrl()
        {
            return this._presignedLogUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// GUID of the agent task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}