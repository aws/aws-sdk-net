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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateJobFlows operation.
    /// TerminateJobFlows shuts a list of job flows down. When a job flow is shut down, any
    /// step not yet completed is canceled and the EC2 instances on which the job flow is
    /// running are stopped. Any log files not already saved are uploaded to Amazon S3 if
    /// a LogUri was specified when the job flow was created.
    /// 
    ///  
    /// <para>
    /// The maximum number of JobFlows allowed is 10. The call to TerminateJobFlows is asynchronous.
    /// Depending on the configuration of the job flow, it may take up to 1-5 minutes for
    /// the job flow to completely terminate and release allocated resources, such as Amazon
    /// EC2 instances.
    /// </para>
    /// </summary>
    public partial class TerminateJobFlowsRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public TerminateJobFlowsRequest() { }

        /// <summary>
        /// Instantiates TerminateJobFlowsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowIds">A list of job flows to be shutdown.</param>
        public TerminateJobFlowsRequest(List<string> jobFlowIds)
        {
            _jobFlowIds = jobFlowIds;
        }

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// A list of job flows to be shutdown.
        /// </para>
        /// </summary>
        public List<string> JobFlowIds
        {
            get { return this._jobFlowIds; }
            set { this._jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this._jobFlowIds != null && this._jobFlowIds.Count > 0; 
        }

    }
}