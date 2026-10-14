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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Stage statistics such as input and output rows and bytes, execution time and stage
    /// state. This information also includes substages and the query stage plan.
    /// </summary>
    public partial class QueryStage
    {
        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// Time taken to execute this stage.
        /// </para>
        /// </summary>
        public long? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property InputBytes. 
        /// <para>
        /// The number of bytes input into the stage for execution.
        /// </para>
        /// </summary>
        public long? InputBytes { get; set; }

        /// <summary>
        /// Checks to see if the InputBytes property is set.
        /// </summary>
        internal bool IsSetInputBytes() => this.InputBytes.HasValue;

        /// <summary>
        /// Gets and sets the property InputRows. 
        /// <para>
        /// The number of rows input into the stage for execution.
        /// </para>
        /// </summary>
        public long? InputRows { get; set; }

        /// <summary>
        /// Checks to see if the InputRows property is set.
        /// </summary>
        internal bool IsSetInputRows() => this.InputRows.HasValue;

        /// <summary>
        /// Gets and sets the property OutputBytes. 
        /// <para>
        /// The number of bytes output from the stage after execution.
        /// </para>
        /// </summary>
        public long? OutputBytes { get; set; }

        /// <summary>
        /// Checks to see if the OutputBytes property is set.
        /// </summary>
        internal bool IsSetOutputBytes() => this.OutputBytes.HasValue;

        /// <summary>
        /// Gets and sets the property OutputRows. 
        /// <para>
        /// The number of rows output from the stage after execution.
        /// </para>
        /// </summary>
        public long? OutputRows { get; set; }

        /// <summary>
        /// Checks to see if the OutputRows property is set.
        /// </summary>
        internal bool IsSetOutputRows() => this.OutputRows.HasValue;

        /// <summary>
        /// Gets and sets the property QueryStagePlan. 
        /// <para>
        /// Stage plan information such as name, identifier, sub plans, and source stages.
        /// </para>
        /// </summary>
        public QueryStagePlanNode QueryStagePlan { get; set; }

        /// <summary>
        /// Checks to see if the QueryStagePlan property is set.
        /// </summary>
        internal bool IsSetQueryStagePlan() => this.QueryStagePlan != null;

        /// <summary>
        /// Gets and sets the property StageId. 
        /// <para>
        /// The identifier for a stage.
        /// </para>
        /// </summary>
        public long? StageId { get; set; }

        /// <summary>
        /// Checks to see if the StageId property is set.
        /// </summary>
        internal bool IsSetStageId() => this.StageId.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the stage after query execution.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubStages. 
        /// <para>
        /// List of sub query stages that form this stage execution plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueryStage> SubStages { get; set; } = AWSConfigs.InitializeCollections ? new List<QueryStage>() : null;

        /// <summary>
        /// Checks to see if the SubStages property is set.
        /// </summary>
        internal bool IsSetSubStages() => this.SubStages != null && (this.SubStages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
