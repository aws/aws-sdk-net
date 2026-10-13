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
    /// Container for the parameters to the GetMLTaskRuns operation. Gets a list of runs for
    /// a machine learning transform. Machine learning task runs are asynchronous tasks that
    /// Glue runs on your behalf as part of various machine learning workflows. You can get
    /// a sortable, filterable list of machine learning task runs by calling <c>GetMLTaskRuns</c>
    /// with their parent transform's <c>TransformID</c> and other optional parameters as
    /// documented in this section. <para> This operation returns a list of historic runs
    /// and must be paginated. </para>
    /// </summary>
    public partial class GetMLTaskRunsRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter criteria, in the <c>TaskRunFilterCriteria</c> structure, for the task run.
        /// </para>
        /// </summary>
        public TaskRunFilterCriteria Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token for pagination of the results. The default is empty.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sorting criteria, in the <c>TaskRunSortCriteria</c> structure, for the task run.
        /// </para>
        /// </summary>
        public TaskRunSortCriteria Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property TransformId. 
        /// <para>
        /// The unique identifier of the machine learning transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TransformId { get; set; }

        /// <summary>
        /// Checks to see if the TransformId property is set.
        /// </summary>
        internal bool IsSetTransformId() => this.TransformId != null;
    }
}
