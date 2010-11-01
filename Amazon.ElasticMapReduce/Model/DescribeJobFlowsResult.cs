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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para> The output for the DescribeJobFlows operation. </para>
    /// </summary>
    public class DescribeJobFlowsResult  
    {
        
        private List<JobFlowDetail> jobFlows = new List<JobFlowDetail>();

        /// <summary>
        /// A list of job flows matching the parameters supplied.
        ///  
        /// </summary>
        public List<JobFlowDetail> JobFlows
        {
            get { return this.jobFlows; }
            set { this.jobFlows = value; }
        }
        /// <summary>
        /// Adds elements to the JobFlows collection
        /// </summary>
        /// <param name="jobFlows">The values to add to the JobFlows collection </param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsResult WithJobFlows(params JobFlowDetail[] jobFlows)
        {
            foreach (JobFlowDetail element in jobFlows)
            {
                this.jobFlows.Add(element);
            }

            return this;
        }
        // Check to see if JobFlows property is set
        internal bool IsSetJobFlows()
        {
            return this.jobFlows.Count > 0;         
        }
    }
}
