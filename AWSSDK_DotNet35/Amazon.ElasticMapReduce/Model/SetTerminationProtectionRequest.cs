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
    /// Container for the parameters to the SetTerminationProtection operation.
    /// <para> SetTerminationProtection locks a job flow so the Amazon EC2 instances in the cluster cannot be terminated by user intervention, an
    /// API call, or in the event of a job-flow error. The cluster still terminates upon successful completion of the job flow. Calling
    /// SetTerminationProtection on a job flow is analogous to calling the Amazon EC2 DisableAPITermination API on all of the EC2 instances in a
    /// cluster.</para> <para> SetTerminationProtection is used to prevent accidental termination of a job flow and to ensure that in the event of
    /// an error, the instances will persist so you can recover any data stored in their ephemeral instance storage.</para> <para> To terminate a
    /// job flow that has been locked by setting SetTerminationProtection to <c>true</c> ,
    /// you must first unlock the job flow by a subsequent call to SetTerminationProtection in which you set the value to <c>false</c> .
    /// </para> <para> For more information, go to <a
    /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/UsingEMR_TerminationProtection.html" >Protecting a Job Flow from
    /// Termination</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i> </para>
    /// </summary>
    public partial class SetTerminationProtectionRequest : AmazonElasticMapReduceRequest
    {
        private List<string> jobFlowIds = new List<string>();
        private bool? terminationProtected;


        /// <summary>
        /// A list of strings that uniquely identify the job flows to protect. This identifier is returned by <a>RunJobFlow</a> and can also be obtained
        /// from <a>DescribeJobFlows</a> .
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
        /// A Boolean that indicates whether to protect the job flow and prevent the Amazon EC2 instances in the cluster from shutting down due to API
        /// calls, user intervention, or job-flow error.
        ///  
        /// </summary>
        public bool TerminationProtected
        {
            get { return this.terminationProtected ?? default(bool); }
            set { this.terminationProtected = value; }
        }

        // Check to see if TerminationProtected property is set
        internal bool IsSetTerminationProtected()
        {
            return this.terminationProtected.HasValue;
        }

    }
}
    
