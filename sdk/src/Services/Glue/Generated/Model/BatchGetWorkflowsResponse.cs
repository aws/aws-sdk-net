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
    /// This is the response object from the BatchGetWorkflows operation.
    /// </summary>
    public partial class BatchGetWorkflowsResponse : AmazonWebServiceResponse
    {
        private List<string> _missingWorkflows = new List<string>();
        private List<Workflow> _workflows = new List<Workflow>();

        /// <summary>
        /// Gets and sets the property MissingWorkflows. 
        /// <para>
        /// A list of names of workflows not found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> MissingWorkflows
        {
            get { return this._missingWorkflows; }
            set { this._missingWorkflows = value; }
        }

        // Check to see if MissingWorkflows property is set
        internal bool IsSetMissingWorkflows()
        {
            return this._missingWorkflows != null && this._missingWorkflows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Workflows. 
        /// <para>
        /// A list of workflow resource metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<Workflow> Workflows
        {
            get { return this._workflows; }
            set { this._workflows = value; }
        }

        // Check to see if Workflows property is set
        internal bool IsSetWorkflows()
        {
            return this._workflows != null && this._workflows.Count > 0; 
        }

    }
}