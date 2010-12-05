/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> TerminateJobFlows shuts a list of job flows down. When a job
    /// flow is shut down, any step not yet completed is canceled and the EC2
    /// instances on which the job flow is running are stopped. Any log files
    /// not already saved are uploaded to Amazon S3 if a LogUri was specified
    /// when the job flow was created. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.TerminateJobFlows"/>
    public class TerminateJobFlowsRequest : AmazonWebServiceRequest
    {
        private List<string> jobFlowIds = new List<string>();

        /// <summary>
        /// A list of job flows to be shutdown.
        ///  
        /// </summary>
        public List<string> JobFlowIds
        {
            get { return this.jobFlowIds; }
            set { this.jobFlowIds = value; }
        }
        /// <summary>
        /// Adds elements to the JobFlowIds collection
        /// </summary>
        /// <param name="jobFlowIds">The values to add to the JobFlowIds collection </param>
        /// <returns>this instance</returns>
        public TerminateJobFlowsRequest WithJobFlowIds(params string[] jobFlowIds)
        {
            foreach (string element in jobFlowIds)
            {
                this.jobFlowIds.Add(element);
            }

            return this;
        }
        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this.jobFlowIds.Count > 0;       
        }
    }
}
    
