/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCanary operation.
    /// Updates the configuration of a canary that has already been created.
    /// 
    ///  
    /// <para>
    /// You can't use this operation to update the tags of an existing canary. To change the
    /// tags of an existing canary, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// </para>
    /// </summary>
    public partial class UpdateCanaryRequest : AmazonSyntheticsRequest
    {
        private ArtifactConfigInput _artifactConfig;
        private string _artifactS3Location;
        private CanaryCodeInput _code;
        private string _executionRoleArn;
        private int? _failureRetentionPeriodInDays;
        private string _name;
        private ProvisionedResourceCleanupSetting _provisionedResourceCleanup;
        private CanaryRunConfigInput _runConfig;
        private string _runtimeVersion;
        private CanaryScheduleInput _schedule;
        private int? _successRetentionPeriodInDays;
        private VisualReferenceInput _visualReference;
        private VpcConfigInput _vpcConfig;

        /// <summary>
        /// Gets and sets the property ArtifactConfig. 
        /// <para>
        /// A structure that contains the configuration for canary artifacts, including the encryption-at-rest
        /// settings for artifacts that the canary uploads to Amazon S3.
        /// </para>
        /// </summary>
        public ArtifactConfigInput ArtifactConfig
        {
            get { return this._artifactConfig; }
            set { this._artifactConfig = value; }
        }

        // Check to see if ArtifactConfig property is set
        internal bool IsSetArtifactConfig()
        {
            return this._artifactConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactS3Location. 
        /// <para>
        /// The location in Amazon S3 where Synthetics stores artifacts from the test runs of
        /// this canary. Artifacts include the log file, screenshots, and HAR files. The name
        /// of the S3 bucket can't include a period (.).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ArtifactS3Location
        {
            get { return this._artifactS3Location; }
            set { this._artifactS3Location = value; }
        }

        // Check to see if ArtifactS3Location property is set
        internal bool IsSetArtifactS3Location()
        {
            return this._artifactS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A structure that includes the entry point from which the canary should start running
        /// your script. If the script is stored in an S3 bucket, the bucket name, key, and version
        /// are also included. 
        /// </para>
        /// </summary>
        public CanaryCodeInput Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role to be used to run the canary. This role must already exist,
        /// and must include <c>lambda.amazonaws.com</c> as a principal in the trust policy. The
        /// role must also have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3:PutObject</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:GetBucketLocation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3:ListAllMyBuckets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cloudwatch:PutMetricData</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:CreateLogGroup</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:CreateLogStream</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:CreateLogStream</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureRetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain data about failed runs of this canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int FailureRetentionPeriodInDays
        {
            get { return this._failureRetentionPeriodInDays.GetValueOrDefault(); }
            set { this._failureRetentionPeriodInDays = value; }
        }

        // Check to see if FailureRetentionPeriodInDays property is set
        internal bool IsSetFailureRetentionPeriodInDays()
        {
            return this._failureRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary that you want to update. To find the names of your canaries,
        /// use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot change the name of a canary that has already been created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedResourceCleanup. 
        /// <para>
        /// Specifies whether to also delete the Lambda functions and layers used by this canary
        /// when the canary is deleted.
        /// </para>
        ///  
        /// <para>
        /// If the value of this parameter is <c>OFF</c>, then the value of the <c>DeleteLambda</c>
        /// parameter of the <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DeleteCanary.html">DeleteCanary</a>
        /// operation determines whether the Lambda functions and layers will be deleted.
        /// </para>
        /// </summary>
        public ProvisionedResourceCleanupSetting ProvisionedResourceCleanup
        {
            get { return this._provisionedResourceCleanup; }
            set { this._provisionedResourceCleanup = value; }
        }

        // Check to see if ProvisionedResourceCleanup property is set
        internal bool IsSetProvisionedResourceCleanup()
        {
            return this._provisionedResourceCleanup != null;
        }

        /// <summary>
        /// Gets and sets the property RunConfig. 
        /// <para>
        /// A structure that contains the timeout value that is used for each individual run of
        /// the canary.
        /// </para>
        ///  <important> 
        /// <para>
        /// The environment variables keys and values are not encrypted. Do not store sensitive
        /// information in this field.
        /// </para>
        ///  </important>
        /// </summary>
        public CanaryRunConfigInput RunConfig
        {
            get { return this._runConfig; }
            set { this._runConfig = value; }
        }

        // Check to see if RunConfig property is set
        internal bool IsSetRunConfig()
        {
            return this._runConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeVersion. 
        /// <para>
        /// Specifies the runtime version to use for the canary. For a list of valid runtime versions
        /// and for more information about runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RuntimeVersion
        {
            get { return this._runtimeVersion; }
            set { this._runtimeVersion = value; }
        }

        // Check to see if RuntimeVersion property is set
        internal bool IsSetRuntimeVersion()
        {
            return this._runtimeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A structure that contains information about how often the canary is to run, and when
        /// these runs are to stop.
        /// </para>
        /// </summary>
        public CanaryScheduleInput Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessRetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain data about successful runs of this canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int SuccessRetentionPeriodInDays
        {
            get { return this._successRetentionPeriodInDays.GetValueOrDefault(); }
            set { this._successRetentionPeriodInDays = value; }
        }

        // Check to see if SuccessRetentionPeriodInDays property is set
        internal bool IsSetSuccessRetentionPeriodInDays()
        {
            return this._successRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VisualReference. 
        /// <para>
        /// Defines the screenshots to use as the baseline for comparisons during visual monitoring
        /// comparisons during future runs of this canary. If you omit this parameter, no changes
        /// are made to any baseline screenshots that the canary might be using already.
        /// </para>
        ///  
        /// <para>
        /// Visual monitoring is supported only on canaries running the <b>syn-puppeteer-node-3.2</b>
        /// runtime or later. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Library_SyntheticsLogger_VisualTesting.html">
        /// Visual monitoring</a> and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Blueprints_VisualTesting.html">
        /// Visual monitoring blueprint</a> 
        /// </para>
        /// </summary>
        public VisualReferenceInput VisualReference
        {
            get { return this._visualReference; }
            set { this._visualReference = value; }
        }

        // Check to see if VisualReference property is set
        internal bool IsSetVisualReference()
        {
            return this._visualReference != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If this canary is to test an endpoint in a VPC, this structure contains information
        /// about the subnet and security groups of the VPC endpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_VPC.html">
        /// Running a Canary in a VPC</a>.
        /// </para>
        /// </summary>
        public VpcConfigInput VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}