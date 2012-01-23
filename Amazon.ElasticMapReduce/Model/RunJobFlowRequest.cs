/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the RunJobFlow operation.
    /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
    /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
    /// Amazon S3. If the JobFlowInstancesDetail <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
    /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
    /// JobFlowInstancesDetail <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
    /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
    /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
    /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
    /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to Add More than
    /// 256 Steps to a Job Flow in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend
    /// that you periodically store your results.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticMapReduce.AmazonElasticMapReduce.RunJobFlow"/>
    public class RunJobFlowRequest : AmazonWebServiceRequest
    {
        private string name;
        private string logUri;
        private string additionalInfo;
        private string amiVersion;
        private JobFlowInstancesConfig instances;
        private List<StepConfig> steps = new List<StepConfig>();
        private List<BootstrapActionConfig> bootstrapActions = new List<BootstrapActionConfig>();
        private List<string> supportedProducts = new List<string>();

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
        public RunJobFlowRequest WithName(string name)
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
        /// Specifies the location in Amazon S3 to write the log files of the job flow. If a value is not provided, logs are not created.
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
        public RunJobFlowRequest WithLogUri(string logUri)
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
        /// A JSON string for selecting additional features.
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
        public string AdditionalInfo
        {
            get { return this.additionalInfo; }
            set { this.additionalInfo = value; }
        }

        /// <summary>
        /// Sets the AdditionalInfo property
        /// </summary>
        /// <param name="additionalInfo">The value to set for the AdditionalInfo property </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithAdditionalInfo(string additionalInfo)
        {
            this.additionalInfo = additionalInfo;
            return this;
        }
            

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this.additionalInfo != null;       
        }

        /// <summary>
        /// The version of the Amazon Machine Image (AMI) to use when launching Amazon EC2 instances in the job flow. If this value is not specified,
        /// the job flow uses the 1.0 AMI version. For a list of AMI versions currently supported by Amazon ElasticMapReduce, go to <a
        /// href="http://docs.amazonwebservices.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in Elastic MapReduce</a> in the <i>Amazon Elastic MapReduce Developer's Guide.</i>
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
        public string AmiVersion
        {
            get { return this.amiVersion; }
            set { this.amiVersion = value; }
        }

        /// <summary>
        /// Sets the AmiVersion property
        /// </summary>
        /// <param name="amiVersion">The value to set for the AmiVersion property </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithAmiVersion(string amiVersion)
        {
            this.amiVersion = amiVersion;
            return this;
        }
            

        // Check to see if AmiVersion property is set
        internal bool IsSetAmiVersion()
        {
            return this.amiVersion != null;       
        }

        /// <summary>
        /// A specification of the number and type of Amazon EC2 instances on which to run the job flow.
        ///  
        /// </summary>
        public JobFlowInstancesConfig Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">The value to set for the Instances property </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithInstances(JobFlowInstancesConfig instances)
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
        /// A list of steps to be executed by the job flow.
        ///  
        /// </summary>
        public List<StepConfig> Steps
        {
            get { return this.steps; }
            set { this.steps = value; }
        }
        /// <summary>
        /// Adds elements to the Steps collection
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithSteps(params StepConfig[] steps)
        {
            foreach (StepConfig element in steps)
            {
                this.steps.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Steps collection
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithSteps(IEnumerable<StepConfig> steps)
        {
            foreach (StepConfig element in steps)
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
        /// A list of bootstrap actions that will be run before Hadoop is started on the cluster nodes.
        ///  
        /// </summary>
        public List<BootstrapActionConfig> BootstrapActions
        {
            get { return this.bootstrapActions; }
            set { this.bootstrapActions = value; }
        }
        /// <summary>
        /// Adds elements to the BootstrapActions collection
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithBootstrapActions(params BootstrapActionConfig[] bootstrapActions)
        {
            foreach (BootstrapActionConfig element in bootstrapActions)
            {
                this.bootstrapActions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the BootstrapActions collection
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithBootstrapActions(IEnumerable<BootstrapActionConfig> bootstrapActions)
        {
            foreach (BootstrapActionConfig element in bootstrapActions)
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

        /// <summary>
        /// A list of strings used by third-party software to tag the job flow. Currently the only valid value is "karmasphere-enterprise-utility",
        /// which tags the job flow for management by <a href="http://aws.amazon.com/elasticmapreduce/karmasphere/">Karmasphere.</a>
        ///  
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this.supportedProducts; }
            set { this.supportedProducts = value; }
        }
        /// <summary>
        /// Adds elements to the SupportedProducts collection
        /// </summary>
        /// <param name="supportedProducts">The values to add to the SupportedProducts collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithSupportedProducts(params string[] supportedProducts)
        {
            foreach (string element in supportedProducts)
            {
                this.supportedProducts.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SupportedProducts collection
        /// </summary>
        /// <param name="supportedProducts">The values to add to the SupportedProducts collection </param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithSupportedProducts(IEnumerable<string> supportedProducts)
        {
            foreach (string element in supportedProducts)
            {
                this.supportedProducts.Add(element);
            }

            return this;
        }

        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this.supportedProducts.Count > 0;       
        }
    }
}
    
