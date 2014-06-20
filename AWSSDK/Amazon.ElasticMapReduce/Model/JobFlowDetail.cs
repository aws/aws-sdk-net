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
    /// A description of a job flow.
    /// </summary>
    public partial class JobFlowDetail
    {
        private string _amiVersion;
        private List<BootstrapActionDetail> _bootstrapActions = new List<BootstrapActionDetail>();
        private JobFlowExecutionStatusDetail _executionStatusDetail;
        private JobFlowInstancesDetail _instances;
        private string _jobFlowId;
        private string _jobFlowRole;
        private string _logUri;
        private string _name;
        private string _serviceRole;
        private List<StepDetail> _steps = new List<StepDetail>();
        private List<string> _supportedProducts = new List<string>();
        private bool? _visibleToAllUsers;


        /// <summary>
        /// Gets and sets the property AmiVersion. 
        /// <para>
        /// The version of the AMI used to initialize Amazon EC2 instances in the job flow. For
        /// a list of  AMI versions currently       supported by Amazon ElasticMapReduce, go to
        /// <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/EnvironmentConfig_AMIVersion.html#ami-versions-supported">AMI
        /// Versions Supported in Elastic MapReduce</a> in the       <i>Amazon Elastic MapReduce
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
        public JobFlowDetail WithAmiVersion(string amiVersion)
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
        /// A list of the bootstrap actions run by the job flow.
        /// </para>
        /// </summary>
        public List<BootstrapActionDetail> BootstrapActions
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
        public JobFlowDetail WithBootstrapActions(params BootstrapActionDetail[] bootstrapActions)
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
        public JobFlowDetail WithBootstrapActions(IEnumerable<BootstrapActionDetail> bootstrapActions)
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
        /// Gets and sets the property ExecutionStatusDetail. 
        /// <para>
        /// Describes the execution status of the job flow.
        /// </para>
        /// </summary>
        public JobFlowExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this._executionStatusDetail; }
            set { this._executionStatusDetail = value; }
        }


        /// <summary>
        /// Sets the ExecutionStatusDetail property
        /// </summary>
        /// <param name="executionStatusDetail">The value to set for the ExecutionStatusDetail property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowDetail WithExecutionStatusDetail(JobFlowExecutionStatusDetail executionStatusDetail)
        {
            this._executionStatusDetail = executionStatusDetail;
            return this;
        }

        // Check to see if ExecutionStatusDetail property is set
        internal bool IsSetExecutionStatusDetail()
        {
            return this._executionStatusDetail != null;
        }


        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// Describes the Amazon EC2 instances of the job flow.
        /// </para>
        /// </summary>
        public JobFlowInstancesDetail Instances
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
        public JobFlowDetail WithInstances(JobFlowInstancesDetail instances)
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
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// The job flow identifier.
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this._jobFlowId; }
            set { this._jobFlowId = value; }
        }


        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">The value to set for the JobFlowId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public JobFlowDetail WithJobFlowId(string jobFlowId)
        {
            this._jobFlowId = jobFlowId;
            return this;
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this._jobFlowId != null;
        }


        /// <summary>
        /// Gets and sets the property JobFlowRole. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. The EC2 instances
        /// of the job flow assume this role.
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
        public JobFlowDetail WithJobFlowRole(string jobFlowRole)
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
        /// The location in Amazon S3 where log files for the job are stored. 
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
        public JobFlowDetail WithLogUri(string logUri)
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
        public JobFlowDetail WithName(string name)
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM role that was specified when the job flow was launched. Amazon ElasticMapReduce
        /// will assume this role to work with AWS resources on your behalf.
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
        public JobFlowDetail WithServiceRole(string serviceRole)
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
        /// A list of steps run by the job flow.
        /// </para>
        /// </summary>
        public List<StepDetail> Steps
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
        public JobFlowDetail WithSteps(params StepDetail[] steps)
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
        public JobFlowDetail WithSteps(IEnumerable<StepDetail> steps)
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
        /// A list of strings set by third party software when the job flow is launched. If you
        /// are not using third party software to manage the job flow this value is empty.
        /// </para>
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
        public JobFlowDetail WithSupportedProducts(params string[] supportedProducts)
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
        public JobFlowDetail WithSupportedProducts(IEnumerable<string> supportedProducts)
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
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        /// Specifies whether the job flow is visible to all IAM users of the AWS account associated
        /// with the job flow. If this value is set to <code>true</code>, all IAM users of that
        /// AWS account can view and (if they have the proper policy permissions set) manage the
        /// job flow. If it is set to <code>false</code>, only the IAM user that created the job
        /// flow can view and manage it. This value can be changed using the <a>SetVisibleToAllUsers</a>
        /// action.
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
        public JobFlowDetail WithVisibleToAllUsers(bool visibleToAllUsers)
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