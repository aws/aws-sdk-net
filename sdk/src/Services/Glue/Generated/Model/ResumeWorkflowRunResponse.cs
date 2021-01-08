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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ResumeWorkflowRun operation.
    /// </summary>
    public partial class ResumeWorkflowRunResponse : AmazonWebServiceResponse
    {
        private List<string> _nodeIds = new List<string>();
        private string _runId;

        /// <summary>
        /// Gets and sets the property NodeIds. 
        /// <para>
        /// A list of the node IDs for the nodes that were actually restarted.
        /// </para>
        /// </summary>
        public List<string> NodeIds
        {
            get { return this._nodeIds; }
            set { this._nodeIds = value; }
        }

        // Check to see if NodeIds property is set
        internal bool IsSetNodeIds()
        {
            return this._nodeIds != null && this._nodeIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The new ID assigned to the resumed workflow run. Each resume of a workflow run will
        /// have a new run ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

    }
}