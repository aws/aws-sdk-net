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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A workflow is a collection of multiple dependent Glue jobs and crawlers that are run
    /// to complete a complex ETL task. A workflow manages the execution and monitoring of
    /// all its jobs and crawlers.
    /// </summary>
    public partial class Workflow
    {
        /// <summary>
        /// Gets and sets the property BlueprintDetails. 
        /// <para>
        /// This structure indicates the details of the blueprint that this particular workflow
        /// is created from.
        /// </para>
        /// </summary>
        public BlueprintDetails BlueprintDetails { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintDetails property is set.
        /// </summary>
        internal bool IsSetBlueprintDetails() => this.BlueprintDetails != null;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date and time when the workflow was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedOn property is set.
        /// </summary>
        internal bool IsSetCreatedOn() => this.CreatedOn.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultRunProperties. 
        /// <para>
        /// A collection of properties to be used as part of each execution of the workflow. The
        /// run properties are made available to each job in the workflow. A job can modify the
        /// properties for the next jobs in the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DefaultRunProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DefaultRunProperties property is set.
        /// </summary>
        internal bool IsSetDefaultRunProperties() => this.DefaultRunProperties != null && (this.DefaultRunProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Graph. 
        /// <para>
        /// The graph representing all the Glue components that belong to the workflow as nodes
        /// and directed connections between them as edges.
        /// </para>
        /// </summary>
        public WorkflowGraph Graph { get; set; }

        /// <summary>
        /// Checks to see if the Graph property is set.
        /// </summary>
        internal bool IsSetGraph() => this.Graph != null;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time when the workflow was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

        /// <summary>
        /// Gets and sets the property LastRun. 
        /// <para>
        /// The information about the last execution of the workflow.
        /// </para>
        /// </summary>
        public WorkflowRun LastRun { get; set; }

        /// <summary>
        /// Checks to see if the LastRun property is set.
        /// </summary>
        internal bool IsSetLastRun() => this.LastRun != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrentRuns. 
        /// <para>
        /// You can use this parameter to prevent unwanted multiple updates to data, to control
        /// costs, or in some cases, to prevent exceeding the maximum number of concurrent runs
        /// of any of the component jobs. If you leave this parameter blank, there is no limit
        /// to the number of concurrent workflow runs.
        /// </para>
        /// </summary>
        public int? MaxConcurrentRuns { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrentRuns property is set.
        /// </summary>
        internal bool IsSetMaxConcurrentRuns() => this.MaxConcurrentRuns.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
