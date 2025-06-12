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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ResumeWorkflowRun operation.
    /// Restarts selected nodes of a previous partially completed workflow run and resumes
    /// the workflow run. The selected nodes and all nodes that are downstream from the selected
    /// nodes are run.
    /// </summary>
    public partial class ResumeWorkflowRunRequest : AmazonGlueRequest
    {
        private string _name;
        private List<string> _nodeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _runId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow to resume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NodeIds. 
        /// <para>
        /// A list of the node IDs for the nodes you want to restart. The nodes that are to be
        /// restarted must have a run attempt in the original run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> NodeIds
        {
            get { return this._nodeIds; }
            set { this._nodeIds = value; }
        }

        // Check to see if NodeIds property is set
        internal bool IsSetNodeIds()
        {
            return this._nodeIds != null && (this._nodeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The ID of the workflow run to resume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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