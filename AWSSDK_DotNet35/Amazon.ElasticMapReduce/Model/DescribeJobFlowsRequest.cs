/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeJobFlows operation.
    /// <para> DescribeJobFlows returns a list of job flows that match all of the supplied parameters. The parameters can include a list of job flow
    /// IDs, job flow states, and restrictions on job flow creation date and time.</para> <para> Regardless of supplied parameters, only job flows
    /// created within the last two months are returned.</para> <para> If no parameters are supplied, then job flows matching either of the
    /// following criteria are returned:</para>
    /// <ul>
    /// <li>Job flows created and completed in the last two weeks</li>
    /// <li> Job flows created within the last two months that are in one of the following states: <c>RUNNING</c> ,
    /// <c>WAITING</c> ,
    /// <c>SHUTTING_DOWN</c> ,
    /// 
    /// <c>STARTING</c> </li>
    /// 
    /// </ul>
    /// <para> Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. </para>
    /// </summary>
    public partial class DescribeJobFlowsRequest : AmazonElasticMapReduceRequest
    {
        private DateTime? createdAfter;
        private DateTime? createdBefore;
        private List<string> jobFlowIds = new List<string>();
        private List<string> jobFlowStates = new List<string>();


        /// <summary>
        /// Return only job flows created after this date and time.
        ///  
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this.createdAfter ?? default(DateTime); }
            set { this.createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this.createdAfter.HasValue;
        }

        /// <summary>
        /// Return only job flows created before this date and time.
        ///  
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this.createdBefore ?? default(DateTime); }
            set { this.createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this.createdBefore.HasValue;
        }

        /// <summary>
        /// Return only job flows whose job flow ID is contained in this list.
        ///  
        /// </summary>
        public List<string> JobFlowIds
        {
            get { return this.jobFlowIds; }
            set { this.jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this.jobFlowIds.Count > 0;
        }

        /// <summary>
        /// Return only job flows whose state is contained in this list.
        ///  
        /// </summary>
        public List<string> JobFlowStates
        {
            get { return this.jobFlowStates; }
            set { this.jobFlowStates = value; }
        }

        // Check to see if JobFlowStates property is set
        internal bool IsSetJobFlowStates()
        {
            return this.jobFlowStates.Count > 0;
        }

    }
}
    
