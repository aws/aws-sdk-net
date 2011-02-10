/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> A description of a job flow.</para>
    /// </summary>
    public class JobFlowDetail  
    {
        
        private string jobFlowId;
        private string name;
        private string logUri;
        private JobFlowExecutionStatusDetail executionStatusDetail;
        private JobFlowInstancesDetail instances;
        private List<StepDetail> steps = new List<StepDetail>();
        private List<BootstrapActionDetail> bootstrapActions = new List<BootstrapActionDetail>();

        /// <summary>
        /// The job flow identifier.
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

        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">The value to set for the JobFlowId property </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithJobFlowId(string jobFlowId)
        {
            this.jobFlowId = jobFlowId;
            return this;
        }
            
        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this.jobFlowId != null;      
        }

        /// <summary>
        /// The name of the job flow.
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
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithName(string name)
        {
            this.name = name;
            return this;
        }
            
        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }

        /// <summary>
        /// The location in Amazon S3 where log files for the job are stored.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this.logUri; }
            set { this.logUri = value; }
        }

        /// <summary>
        /// Sets the LogUri property
        /// </summary>
        /// <param name="logUri">The value to set for the LogUri property </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithLogUri(string logUri)
        {
            this.logUri = logUri;
            return this;
        }
            
        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this.logUri != null;         
        }

        /// <summary>
        /// Describes the execution status of the job flow.
        ///  
        /// </summary>
        public JobFlowExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this.executionStatusDetail; }
            set { this.executionStatusDetail = value; }
        }

        /// <summary>
        /// Sets the ExecutionStatusDetail property
        /// </summary>
        /// <param name="executionStatusDetail">The value to set for the ExecutionStatusDetail property </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithExecutionStatusDetail(JobFlowExecutionStatusDetail executionStatusDetail)
        {
            this.executionStatusDetail = executionStatusDetail;
            return this;
        }
            
        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this.executionStatusDetail != null;      
        }

        /// <summary>
        /// Describes the Amazon EC2 instances of the job flow.
        ///  
        /// </summary>
        public JobFlowInstancesDetail Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">The value to set for the Instances property </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithInstances(JobFlowInstancesDetail instances)
        {
            this.instances = instances;
            return this;
        }
            
        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances != null;      
        }

        /// <summary>
        /// A list of steps run by the job flow.
        ///  
        /// </summary>
        public List<StepDetail> Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }
        /// <summary>
        /// Adds elements to the Steps collection
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithSteps(params StepDetail[] steps)
        {
            foreach (StepDetail element in steps)
            {
                this.steps.Add(element);
            }

            return this;
        }
        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this.steps.Count > 0;        
        }

        /// <summary>
        /// A list of the bootstrap actions run by the job flow.
        ///  
        /// </summary>
        public List<BootstrapActionDetail> BootstrapActions
        {
            get { return this.bootstrapActions; }
            set { this.bootstrapActions = value; }
        }
        /// <summary>
        /// Adds elements to the BootstrapActions collection
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithBootstrapActions(params BootstrapActionDetail[] bootstrapActions)
        {
            foreach (BootstrapActionDetail element in bootstrapActions)
            {
                this.bootstrapActions.Add(element);
            }

            return this;
        }
        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this.bootstrapActions.Count > 0;         
        }
    }
}
