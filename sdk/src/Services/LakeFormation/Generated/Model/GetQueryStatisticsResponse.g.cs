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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the GetQueryStatistics operation.
    /// </summary>
    public partial class GetQueryStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExecutionStatistics. 
        /// <para>
        /// An <c>ExecutionStatistics</c> structure containing execution statistics.
        /// </para>
        /// </summary>
        public ExecutionStatistics ExecutionStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatistics property is set.
        /// </summary>
        internal bool IsSetExecutionStatistics() => this.ExecutionStatistics != null;

        /// <summary>
        /// Gets and sets the property PlanningStatistics. 
        /// <para>
        /// A <c>PlanningStatistics</c> structure containing query planning statistics.
        /// </para>
        /// </summary>
        public PlanningStatistics PlanningStatistics { get; set; }

        /// <summary>
        /// Checks to see if the PlanningStatistics property is set.
        /// </summary>
        internal bool IsSetPlanningStatistics() => this.PlanningStatistics != null;

        /// <summary>
        /// Gets and sets the property QuerySubmissionTime. 
        /// <para>
        /// The time that the query was submitted.
        /// </para>
        /// </summary>
        public DateTime? QuerySubmissionTime { get; set; }

        /// <summary>
        /// Checks to see if the QuerySubmissionTime property is set.
        /// </summary>
        internal bool IsSetQuerySubmissionTime() => this.QuerySubmissionTime.HasValue;
    }
}
