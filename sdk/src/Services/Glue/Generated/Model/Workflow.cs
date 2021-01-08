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
    /// A workflow represents a flow in which AWS Glue components should be executed to complete
    /// a logical task.
    /// </summary>
    public partial class Workflow
    {
        private DateTime? _createdOn;
        private Dictionary<string, string> _defaultRunProperties = new Dictionary<string, string>();
        private string _description;
        private WorkflowGraph _graph;
        private DateTime? _lastModifiedOn;
        private WorkflowRun _lastRun;
        private int? _maxConcurrentRuns;
        private string _name;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date and time when the workflow was created.
        /// </para>
        /// </summary>
        public DateTime CreatedOn
        {
            get { return this._createdOn.GetValueOrDefault(); }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultRunProperties. 
        /// <para>
        /// A collection of properties to be used as part of each execution of the workflow.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DefaultRunProperties
        {
            get { return this._defaultRunProperties; }
            set { this._defaultRunProperties = value; }
        }

        // Check to see if DefaultRunProperties property is set
        internal bool IsSetDefaultRunProperties()
        {
            return this._defaultRunProperties != null && this._defaultRunProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The graph representing all the AWS Glue components that belong to the workflow as
        /// nodes and directed connections between them as edges.
        /// </para>
        /// </summary>
        public WorkflowGraph Graph
        {
            get { return this._graph; }
            set { this._graph = value; }
        }

        // Check to see if Graph property is set
        internal bool IsSetGraph()
        {
            return this._graph != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time when the workflow was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRun. 
        /// <para>
        /// The information about the last execution of the workflow.
        /// </para>
        /// </summary>
        public WorkflowRun LastRun
        {
            get { return this._lastRun; }
            set { this._lastRun = value; }
        }

        // Check to see if LastRun property is set
        internal bool IsSetLastRun()
        {
            return this._lastRun != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentRuns. 
        /// <para>
        /// You can use this parameter to prevent unwanted multiple updates to data, to control
        /// costs, or in some cases, to prevent exceeding the maximum number of concurrent runs
        /// of any of the component jobs. If you leave this parameter blank, there is no limit
        /// to the number of concurrent workflow runs.
        /// </para>
        /// </summary>
        public int MaxConcurrentRuns
        {
            get { return this._maxConcurrentRuns.GetValueOrDefault(); }
            set { this._maxConcurrentRuns = value; }
        }

        // Check to see if MaxConcurrentRuns property is set
        internal bool IsSetMaxConcurrentRuns()
        {
            return this._maxConcurrentRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow representing the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

    }
}