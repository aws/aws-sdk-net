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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJobFlows operation. This API is no longer
    /// supported and will eventually be removed. We recommend you use <a>ListClusters</a>,
    /// <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
    /// instead. <para> DescribeJobFlows returns a list of job flows that match all of the
    /// supplied parameters. The parameters can include a list of job flow IDs, job flow states,
    /// and restrictions on job flow creation date and time. </para> <para> Regardless of
    /// supplied parameters, only job flows created within the last two months are returned.
    /// </para> <para> If no parameters are supplied, then job flows matching either of the
    /// following criteria are returned: </para> <ul> <li> <para> Job flows created and completed
    /// in the last two weeks </para> </li> <li> <para> Job flows created within the last
    /// two months that are in one of the following states: <c>RUNNING</c>, <c>WAITING</c>,
    /// <c>SHUTTING_DOWN</c>, <c>STARTING</c> </para> </li> </ul> <para> Amazon EMR can return
    /// a maximum of 512 job flow descriptions. </para>
    /// </summary>
    public partial class DescribeJobFlowsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeJobFlowsRequest() { }

        /// <summary>
        /// Instantiates DescribeJobFlowsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowIds">Return only job flows whose job flow ID is contained in this list.</param>
        public DescribeJobFlowsRequest(List<string> jobFlowIds)
        {
            this.JobFlowIds = jobFlowIds;
        }

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Return only job flows created after this date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Return only job flows created before this date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// Return only job flows whose job flow ID is contained in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobFlowIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JobFlowIds property is set.
        /// </summary>
        internal bool IsSetJobFlowIds() => this.JobFlowIds != null && (this.JobFlowIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobFlowStates. 
        /// <para>
        /// Return only job flows whose state is contained in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobFlowStates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the JobFlowStates property is set.
        /// </summary>
        internal bool IsSetJobFlowStates() => this.JobFlowStates != null && (this.JobFlowStates.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
