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
    /// Container for the parameters to the BatchGetWorkflows operation.
    /// Returns a list of resource metadata for a given list of workflow names. After calling
    /// the <code>ListWorkflows</code> operation, you can call this operation to access the
    /// data to which you have been granted permissions. This operation supports all IAM permissions,
    /// including permission conditions that uses tags.
    /// </summary>
    public partial class BatchGetWorkflowsRequest : AmazonGlueRequest
    {
        private bool? _includeGraph;
        private List<string> _names = new List<string>();

        /// <summary>
        /// Gets and sets the property IncludeGraph. 
        /// <para>
        /// Specifies whether to include a graph when returning the workflow resource metadata.
        /// </para>
        /// </summary>
        public bool IncludeGraph
        {
            get { return this._includeGraph.GetValueOrDefault(); }
            set { this._includeGraph = value; }
        }

        // Check to see if IncludeGraph property is set
        internal bool IsSetIncludeGraph()
        {
            return this._includeGraph.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of workflow names, which may be the names returned from the <code>ListWorkflows</code>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

    }
}