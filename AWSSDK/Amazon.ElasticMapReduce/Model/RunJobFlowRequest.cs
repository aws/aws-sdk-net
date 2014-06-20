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
    /// RunJobFlow creates and starts running a new job flow. The job flow will run the steps
    ///         specified. Once the job flow completes, the cluster is stopped and the HDFS
    /// partition is         lost. To prevent loss of data, configure the last step of the
    /// job flow to store results in         Amazon S3. If the <a>JobFlowInstancesConfig</a>
    /// <code>KeepJobFlowAliveWhenNoSteps</code> parameter is         set to <code>TRUE</code>,
    /// the job flow will transition to the WAITING state rather than         shutting down
    /// once the steps have completed. 
    /// 
    ///             
    /// <para>
    /// For additional protection, you can set the          <a>JobFlowInstancesConfig</a>
    /// <code>TerminationProtected</code> parameter to <code>TRUE</code> to lock the     
    ///     job flow and prevent it from being          terminated by API call, user intervention,
    /// or in the event of a job flow error.
    /// </para>
    ///       
    /// <para>
    /// A maximum of 256 steps are allowed in each job flow.
    /// </para>
    ///             
    /// <para>
    /// If your job flow is long-running (such as a Hive data warehouse) or complex, you may
    /// require more than 256 steps to process your data. You can bypass the 256-step limitation
    /// in various ways, including using the SSH shell to connect to the master node and submitting
    /// queries directly to the software running on the master node, such as Hive and Hadoop.
    /// For more information on how to do this, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/AddMoreThan256Steps.html">Add
    /// More than 256 Steps to a Job Flow</a> in the <i>Amazon Elastic MapReduce Developer's
    /// Guide</i>.
    /// </para>
    ///       
    /// <para>
    /// For long running job flows, we recommend that you periodically store your results.
    /// </para>
    /// </summary>
    public partial class RunJobFlowRequest : AmazonWebServiceRequest
    {
        private string _additionalInfo;
        private string _amiVersion;
        private List<BootstrapActionConfig> _bootstrapActions = new List<BootstrapActionConfig>();
        private JobFlowInstancesConfig _instances;
        private string _jobFlowRole;
        private string _logUri;
        private string _name;
        private List<SupportedProductConfig> _newSupportedProducts = new List<SupportedProductConfig>();
        private string _serviceRole;
        private List<StepConfig> _steps = new List<StepConfig>();
        private List<string> _supportedProducts = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private bool? _visibleToAllUsers;


        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// A JSON string for selecting additional features.
        /// </para>
        /// </summary>
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }


        /// <summary>
        /// Sets the AdditionalInfo property
        /// </summary>
        /// <param name="additionalInfo">The value to set for the AdditionalInfo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithAdditionalInfo(string additionalInfo)
        {
            this._additionalInfo = additionalInfo;
            return this;
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }


        /// <summary>
        /// Gets and sets the property AmiVersion. 
        /// <para>
        /// The version of the Amazon Machine Image (AMI) to use when launching Amazon EC2 instances
        /// in the job flow. The following values are valid: 
        /// </para>
        ///          <ul>            <li>"latest" (uses the latest AMI)</li>            <li>The
        /// version number of the AMI to use, for example, "2.0"</li>         </ul>          
        ///        
        /// <para>
        /// If the AMI supports multiple versions of Hadoop (for example, AMI 1.0 supports both
        /// Hadoop 0.18 and 0.20) you can use the             <a>JobFlowInstancesConfig</a> <code>HadoopVersion</code>
        /// parameter             to modify the version of Hadoop from the defaults shown above.
        /// </para>
        ///          
        /// <para>
        /// For details about the AMI versions currently          supported by Amazon Elastic
        /// MapReduce, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in Elastic MapReduce</a> in the          <i>Amazon Elastic MapReduce
        /// Developer's Guide.</i>         
        /// </para>
        /// </summary>
        public string AmiVersion
        {
            get { return this._amiVersion; }
            set { this._amiVersion = value; }
        }


        /// <summary>
        /// Sets the AmiVersion property
        /// </summary>
        /// <param name="amiVersion">The value to set for the AmiVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithAmiVersion(string amiVersion)
        {
            this._amiVersion = amiVersion;
            return this;
        }

        // Check to see if AmiVersion property is set
        internal bool IsSetAmiVersion()
        {
            return this._amiVersion != null;
        }


        /// <summary>
        /// Gets and sets the property BootstrapActions. 
        /// <para>
        ///  A list of bootstrap actions that will be run before Hadoop is started on the cluster
        ///         nodes. 
        /// </para>
        /// </summary>
        public List<BootstrapActionConfig> BootstrapActions
        {
            get { return this._bootstrapActions; }
            set { this._bootstrapActions = value; }
        }

        /// <summary>
        /// Sets the BootstrapActions property
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithBootstrapActions(params BootstrapActionConfig[] bootstrapActions)
        {
            foreach (var element in bootstrapActions)
            {
                this._bootstrapActions.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the BootstrapActions property
        /// </summary>
        /// <param name="bootstrapActions">The values to add to the BootstrapActions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithBootstrapActions(IEnumerable<BootstrapActionConfig> bootstrapActions)
        {
            foreach (var element in bootstrapActions)
            {
                this._bootstrapActions.Add(element);
            }
            return this;
        }
        // Check to see if BootstrapActions property is set
        internal bool IsSetBootstrapActions()
        {
            return this._bootstrapActions != null && this._bootstrapActions.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        ///  A specification of the number and type of Amazon EC2 instances on which to run the
        /// job         flow. 
        /// </para>
        /// </summary>
        public JobFlowInstancesConfig Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }


        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">The value to set for the Instances property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithInstances(JobFlowInstancesConfig instances)
        {
            this._instances = instances;
            return this;
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null;
        }


        /// <summary>
        /// Gets and sets the property JobFlowRole. 
        /// <para>
        /// An IAM role for the job flow. The EC2 instances of the job flow assume this role.
        /// The default role is <code>EMRJobflowDefault</code>. In order to use the default role,
        /// you must have already created it using the CLI.
        /// </para>
        /// </summary>
        public string JobFlowRole
        {
            get { return this._jobFlowRole; }
            set { this._jobFlowRole = value; }
        }


        /// <summary>
        /// Sets the JobFlowRole property
        /// </summary>
        /// <param name="jobFlowRole">The value to set for the JobFlowRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithJobFlowRole(string jobFlowRole)
        {
            this._jobFlowRole = jobFlowRole;
            return this;
        }

        // Check to see if JobFlowRole property is set
        internal bool IsSetJobFlowRole()
        {
            return this._jobFlowRole != null;
        }


        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The location in Amazon S3 to write the log files of the job flow. If a value is  
        ///       not provided, logs are not created.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }


        /// <summary>
        /// Sets the LogUri property
        /// </summary>
        /// <param name="logUri">The value to set for the LogUri property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithLogUri(string logUri)
        {
            this._logUri = logUri;
            return this;
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job flow.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property NewSupportedProducts. 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow that
        /// accepts a user argument list. EMR accepts and forwards the argument list to the corresponding
        /// installation         script as bootstrap action arguments. For more information, see
        /// <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-mapr.html">Launch
        /// a Job Flow on the MapR Distribution for Hadoop</a>. Currently supported values are:
        /// </para>
        ///       <ul>         <li>"mapr-m3" - launch the job flow using MapR M3 Edition.</li>
        ///         <li>"mapr-m5" - launch the job flow using MapR M5 Edition.</li>         <li>"mapr"
        /// with the user arguments specifying "--edition,m3" or "--edition,m5" - launch the job
        /// flow using MapR M3 or M5 Edition respectively.</li>      </ul>
        /// </summary>
        public List<SupportedProductConfig> NewSupportedProducts
        {
            get { return this._newSupportedProducts; }
            set { this._newSupportedProducts = value; }
        }

        /// <summary>
        /// Sets the NewSupportedProducts property
        /// </summary>
        /// <param name="newSupportedProducts">The values to add to the NewSupportedProducts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithNewSupportedProducts(params SupportedProductConfig[] newSupportedProducts)
        {
            foreach (var element in newSupportedProducts)
            {
                this._newSupportedProducts.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the NewSupportedProducts property
        /// </summary>
        /// <param name="newSupportedProducts">The values to add to the NewSupportedProducts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithNewSupportedProducts(IEnumerable<SupportedProductConfig> newSupportedProducts)
        {
            foreach (var element in newSupportedProducts)
            {
                this._newSupportedProducts.Add(element);
            }
            return this;
        }
        // Check to see if NewSupportedProducts property is set
        internal bool IsSetNewSupportedProducts()
        {
            return this._newSupportedProducts != null && this._newSupportedProducts.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// IAM role that Amazon ElasticMapReduce will assume to work with AWS resources on your
        /// behalf. You may set this parameter to the name of an existing IAM role.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }


        /// <summary>
        /// Sets the ServiceRole property
        /// </summary>
        /// <param name="serviceRole">The value to set for the ServiceRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithServiceRole(string serviceRole)
        {
            this._serviceRole = serviceRole;
            return this;
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }


        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// A list of steps to be executed by the job flow.
        /// </para>
        /// </summary>
        public List<StepConfig> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithSteps(params StepConfig[] steps)
        {
            foreach (var element in steps)
            {
                this._steps.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithSteps(IEnumerable<StepConfig> steps)
        {
            foreach (var element in steps)
            {
                this._steps.Add(element);
            }
            return this;
        }
        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SupportedProducts. 
        /// <para>
        /// A list of strings that indicates third-party software to use with the job flow. For
        /// more information, go to <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-supported-products.html">Use
        /// Third Party Applications with Amazon EMR</a>. Currently supported values are:
        /// </para>
        ///          <ul>                        <li>"mapr-m3" - launch the job flow using MapR
        /// M3 Edition.</li>            <li>"mapr-m5" - launch the job flow using MapR M5 Edition.</li>
        ///         </ul>
        /// </summary>
        public List<string> SupportedProducts
        {
            get { return this._supportedProducts; }
            set { this._supportedProducts = value; }
        }

        /// <summary>
        /// Sets the SupportedProducts property
        /// </summary>
        /// <param name="supportedProducts">The values to add to the SupportedProducts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithSupportedProducts(params string[] supportedProducts)
        {
            foreach (var element in supportedProducts)
            {
                this._supportedProducts.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SupportedProducts property
        /// </summary>
        /// <param name="supportedProducts">The values to add to the SupportedProducts collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithSupportedProducts(IEnumerable<string> supportedProducts)
        {
            foreach (var element in supportedProducts)
            {
                this._supportedProducts.Add(element);
            }
            return this;
        }
        // Check to see if SupportedProducts property is set
        internal bool IsSetSupportedProducts()
        {
            return this._supportedProducts != null && this._supportedProducts.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with a cluster and propagate to Amazon EC2 instances.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithTags(params Tag[] tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }
        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Whether the job flow is visible to all IAM users of the AWS account associated with
        /// the job flow. If this value is set to <code>true</code>, all IAM users of that AWS
        /// account can view and (if they have the proper policy permissions set) manage the job
        /// flow. If it is set to <code>false</code>, only the IAM user that created the job flow
        /// can view and manage it.
        /// </para>
        /// </summary>
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }


        /// <summary>
        /// Sets the VisibleToAllUsers property
        /// </summary>
        /// <param name="visibleToAllUsers">The value to set for the VisibleToAllUsers property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunJobFlowRequest WithVisibleToAllUsers(bool visibleToAllUsers)
        {
            this._visibleToAllUsers = visibleToAllUsers;
            return this;
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}