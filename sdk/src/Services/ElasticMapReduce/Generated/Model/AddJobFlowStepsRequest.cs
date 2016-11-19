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
    /// Container for the parameters to the AddJobFlowSteps operation.
    /// AddJobFlowSteps adds new steps to a running job flow. A maximum of 256 steps are allowed
    /// in each job flow.
    /// 
    ///  
    /// <para>
    /// If your job flow is long-running (such as a Hive data warehouse) or complex, you may
    /// require more than 256 steps to process your data. You can bypass the 256-step limitation
    /// in various ways, including using the SSH shell to connect to the master node and submitting
    /// queries directly to the software running on the master node, such as Hive and Hadoop.
    /// For more information on how to do this, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add
    /// More than 256 Steps to a Job Flow</a> in the <i>Amazon EMR Developer's Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A step specifies the location of a JAR file stored either on the master node of the
    /// job flow or in Amazon S3. Each step is performed by the main function of the main
    /// class of the JAR file. The main class can be specified either in the manifest of the
    /// JAR or by using the MainFunction parameter of the step.
    /// </para>
    ///  
    /// <para>
    /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
    /// the main function must exit with a zero exit code and all Hadoop jobs started while
    /// the step was running must have completed and run successfully.
    /// </para>
    ///  
    /// <para>
    /// You can only add steps to a job flow that is in one of the following states: STARTING,
    /// BOOTSTRAPPING, RUNNING, or WAITING.
    /// </para>
    /// </summary>
    public partial class AddJobFlowStepsRequest : AmazonElasticMapReduceRequest
    {
        private string _jobFlowId;
        private List<StepConfig> _steps = new List<StepConfig>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AddJobFlowStepsRequest() { }

        /// <summary>
        /// Instantiates AddJobFlowStepsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowId">A string that uniquely identifies the job flow. This identifier is returned by <a>RunJobFlow</a> and can also be obtained from <a>ListClusters</a>. </param>
        public AddJobFlowStepsRequest(string jobFlowId)
        {
            _jobFlowId = jobFlowId;
        }

        /// <summary>
        /// Instantiates AddJobFlowStepsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowId">A string that uniquely identifies the job flow. This identifier is returned by <a>RunJobFlow</a> and can also be obtained from <a>ListClusters</a>. </param>
        /// <param name="steps"> A list of <a>StepConfig</a> to be executed by the job flow. </param>
        public AddJobFlowStepsRequest(string jobFlowId, List<StepConfig> steps)
        {
            _jobFlowId = jobFlowId;
            _steps = steps;
        }

        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// A string that uniquely identifies the job flow. This identifier is returned by <a>RunJobFlow</a>
        /// and can also be obtained from <a>ListClusters</a>. 
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this._jobFlowId; }
            set { this._jobFlowId = value; }
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this._jobFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        ///  A list of <a>StepConfig</a> to be executed by the job flow. 
        /// </para>
        /// </summary>
        public List<StepConfig> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }

    }
}