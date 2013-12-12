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
    /// Container for the parameters to the RunJobFlow operation.
    /// <para> RunJobFlow creates and starts running a new job flow. The job flow will run the steps specified. Once the job flow completes, the
    /// cluster is stopped and the HDFS partition is lost. To prevent loss of data, configure the last step of the job flow to store results in
    /// Amazon S3. If the JobFlowInstancesConfig <c>KeepJobFlowAliveWhenNoSteps</c> parameter is set to <c>TRUE</c> , the job flow will transition
    /// to the WAITING state rather than shutting down once the steps have completed. </para> <para>For additional protection, you can set the
    /// JobFlowInstancesConfig <c>TerminationProtected</c> parameter to <c>TRUE</c> to lock the job flow and prevent it from being terminated by API
    /// call, user intervention, or in the event of a job flow error.</para> <para>A maximum of 256 steps are allowed in each job flow.</para>
    /// <para>If your job flow is long-running (such as a Hive data warehouse) or complex, you may require more than 256 steps to process your data.
    /// You can bypass the 256-step limitation in various ways, including using the SSH shell to connect to the master node and submitting queries
    /// directly to the software running on the master node, such as Hive and Hadoop. For more information on how to do this, go to <a
    /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html" >Add More than 256 Steps to a Job Flow</a>
    /// in the <i>Amazon Elastic MapReduce Developer's Guide</i> .</para> <para>For long running job flows, we recommend that you periodically store
    /// your results.</para>
    /// </summary>
    public partial class RunJobFlowRequest : AmazonElasticMapReduceRequest
    {
        private string name;
        private string logUri;
        private string additionalInfo;
        private string amiVersion;
        private JobFlowInstancesConfig instances;
        private List<StepConfig> steps = new List<StepConfig>();
        private List<BootstrapActionConfig> bootstrapActions = new List<BootstrapActionConfig>();
        private List<string> supportedProducts = new List<string>();
        private List<SupportedProductConfig> newSupportedProducts = new List<SupportedProductConfig>();
        private bool? visibleToAllUsers;
        private string jobFlowRole;
        private List<Tag> tags = new List<Tag>();


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

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The location in Amazon S3 to write the log files of the job flow. If a value is not provided, logs are not created.
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

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this.additionalInfo != null;
        }

        /// <summary>
        /// The version of the Amazon Machine Image (AMI) to use when launching Amazon EC2 instances in the job flow. The following values are valid:
        /// <ul> <li>"latest" (uses the latest AMI)</li> <li>The version number of the AMI to use, for example, "2.0"</li> </ul> If the AMI supports
        /// multiple versions of Hadoop (for example, AMI 1.0 supports both Hadoop 0.18 and 0.20) you can use the <a>JobFlowInstancesConfig</a>
        /// <c>HadoopVersion</c> parameter to modify the version of Hadoop from the defaults shown above. For details about the AMI versions currently
        /// supported by Amazon Elastic MapReduce, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
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

        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this.bootstrapActions.Count > 0;
        }

        /// <summary>
        /// A list of strings that indicates third-party software to use with the job flow. For more information, go to <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-supported-products.html">Use Third Party Applications with
        /// Amazon EMR</a>. Currently supported values are: <ul> <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li> <li>"mapr-m5" - launch
        /// the job flow using MapR M5 Edition.</li> </ul>
        ///  
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this.supportedProducts; }
            set { this.supportedProducts = value; }
        }

        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this.supportedProducts.Count > 0;
        }

        /// <summary>
        /// A list of strings that indicates third-party software to use with the job flow that accepts a user argument list. EMR accepts and forwards
        /// the argument list to the corresponding installation script as bootstrap action arguments. For more information, see <a
        /// href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html">Launch a Job Flow on the MapR Distribution for
        /// Hadoop</a>. Currently supported values are: <ul> <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li> <li>"mapr-m5" - launch the
        /// job flow using MapR M5 Edition.</li> <li>"mapr" with the user arguments specifying "--edition,m3" or "--edition,m5" - launch the job flow
        /// using MapR M3 or M5 Edition respectively.</li> </ul>
        ///  
        /// </summary>
        public List<SupportedProductConfig> NewSupportedProducts
        {
            get { return this.newSupportedProducts; }
            set { this.newSupportedProducts = value; }
        }

        // Check to see if NewSupportedProducts property is set
        internal bool IsSetNewSupportedProducts()
        {
            return this.newSupportedProducts.Count > 0;
        }

        /// <summary>
        /// Whether the job flow is visible to all IAM users of the AWS account associated with the job flow. If this value is set to <c>true</c>, all
        /// IAM users of that AWS account can view and (if they have the proper policy permissions set) manage the job flow. If it is set to
        /// <c>false</c>, only the IAM user that created the job flow can view and manage it.
        ///  
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this.visibleToAllUsers ?? default(bool); }
            set { this.visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this.visibleToAllUsers.HasValue;
        }

        /// <summary>
        /// An IAM role for the job flow. The EC2 instances of the job flow assume this role. The default role is <c>EMRJobflowDefault</c>. In order to
        /// use the default role, you must have already created it using the CLI.
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
        public string JobFlowRole
        {
            get { return this.jobFlowRole; }
            set { this.jobFlowRole = value; }
        }

        // Check to see if JobFlowRole property is set
        internal bool IsSetJobFlowRole()
        {
            return this.jobFlowRole != null;
        }

        /// <summary>
        /// A list of tags to associate with a cluster and propagate to Amazon EC2 instances.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
