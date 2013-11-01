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
    /// Container for the parameters to the AddJobFlowSteps operation.
    /// <para> AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed in each job flow. </para> <para>If your job
    /// flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data. You can bypass
    /// the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries directly to the
    /// software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a
    /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html" >Add More than 256 Steps to a Job Flow</a>
    /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para> A step specifies the location of a JAR file stored either on the
    /// master node of the job flow or in Amazon S3. Each step is performed by the main function of the main class of the JAR file. The main class
    /// can be specified either in the manifest of the JAR or by using the MainFunction parameter of the step. </para> <para> Elastic MapReduce
    /// executes each step in the order listed. For a step to be considered complete, the main function must exit with a zero exit code and all
    /// Hadoop jobs started while the step was running must have completed and run successfully. </para> <para> You can only add steps to a job flow
    /// that is in one of the following states: STARTING, BOOTSTRAPPING, RUNNING, or WAITING.</para>
    /// </summary>
    public partial class AddJobFlowStepsRequest : AmazonElasticMapReduceRequest
    {
        private string jobFlowId;
        private List<StepConfig> steps = new List<StepConfig>();


        /// <summary>
        /// A string that uniquely identifies the job flow. This identifier is returned by <a>RunJobFlow</a> and can also be obtained from
        /// <a>DescribeJobFlows</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this.jobFlowId; }
            set { this.jobFlowId = value; }
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this.jobFlowId != null;
        }

        /// <summary>
        /// A list of <a>StepConfig</a> to be executed by the job flow.
        ///  
        /// </summary>
        public List<StepConfig> Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this.steps.Count > 0;
        }

    }
}
    
