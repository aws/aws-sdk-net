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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// Container for the parameters to the TerminateJobFlows operation.
    /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
    /// down, any step not yet completed is canceled and the Amazon EC2 instances on which
    /// the cluster is running are stopped. Any log files not already saved are uploaded to
    /// Amazon S3 if a LogUri was specified when the cluster was created.
    /// 
    ///  
    /// <para>
    /// The maximum number of clusters allowed is 10. The call to <c>TerminateJobFlows</c>
    /// is asynchronous. Depending on the configuration of the cluster, it may take up to
    /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
    /// such as Amazon EC2 instances.
    /// </para>
    /// </summary>
    public partial class TerminateJobFlowsRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public TerminateJobFlowsRequest() { }

        /// <summary>
        /// Instantiates TerminateJobFlowsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowIds">A list of job flows to be shut down.</param>
        public TerminateJobFlowsRequest(List<string> jobFlowIds)
        {
            _jobFlowIds = jobFlowIds;
        }

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// A list of job flows to be shut down.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> JobFlowIds
        {
            get { return this._jobFlowIds; }
            set { this._jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this._jobFlowIds != null && (this._jobFlowIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}