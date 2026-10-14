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
    /// The query execution timeline, statistics on input and output rows and bytes, and the
    /// different query stages that form the query execution plan.
    /// </summary>
    public partial class QueryRuntimeStatistics
    {
        /// <summary>
        /// Gets and sets the property OutputStage. 
        /// <para>
        /// Stage statistics such as input and output rows and bytes, execution time, and stage
        /// state. This information also includes substages and the query stage plan.
        /// </para>
        /// </summary>
        public QueryStage OutputStage { get; set; }

        /// <summary>
        /// Checks to see if the OutputStage property is set.
        /// </summary>
        internal bool IsSetOutputStage() => this.OutputStage != null;

        /// <summary>
        /// Gets and sets the property Rows.
        /// </summary>
        public QueryRuntimeStatisticsRows Rows { get; set; }

        /// <summary>
        /// Checks to see if the Rows property is set.
        /// </summary>
        internal bool IsSetRows() => this.Rows != null;

        /// <summary>
        /// Gets and sets the property Timeline.
        /// </summary>
        public QueryRuntimeStatisticsTimeline Timeline { get; set; }

        /// <summary>
        /// Checks to see if the Timeline property is set.
        /// </summary>
        internal bool IsSetTimeline() => this.Timeline != null;
    }
}
