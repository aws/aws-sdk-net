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
    /// Container for the parameters to the CreateCanary operation.
    /// Creates a canary. Canaries are scripts that monitor your endpoints and APIs from the
    /// outside-in. Canaries help you check the availability and latency of your web services
    /// and troubleshoot anomalies by investigating load time data, screenshots of the UI,
    /// logs, and metrics. You can set up a canary to run continuously or just once. 
    /// 
    ///  
    /// <para>
    /// Do not use <c>CreateCanary</c> to modify an existing canary. Use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_UpdateCanary.html">UpdateCanary</a>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// To create canaries, you must have the <c>CloudWatchSyntheticsFullAccess</c> policy.
    /// If you are creating a new IAM role for the canary, you also need the <c>iam:CreateRole</c>,
    /// <c>iam:CreatePolicy</c> and <c>iam:AttachRolePolicy</c> permissions. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Roles">Necessary
    /// Roles and Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// Do not include secrets or proprietary information in your canary names. The canary
    /// name makes up part of the Amazon Resource Name (ARN) for the canary, and the ARN is
    /// included in outbound calls over the internet. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
    /// Considerations for Synthetics Canaries</a>.
    /// </para>
    /// </summary>
    public partial class CreateCanaryRequest : AmazonSyntheticsRequest
    {
        private ArtifactConfigInput _artifactConfig;
        private string _artifactS3Location;
        private List<BrowserConfig> _browserConfigs = AWSConfigs.InitializeCollections ? new List<BrowserConfig>() : null;
        private CanaryCodeInput _code;
        private string _executionRoleArn;
        private int? _failureRetentionPeriodInDays;
        private string _name;
        private ProvisionedResourceCleanupSetting _provisionedResourceCleanup;
        private List<string> _resourcesToReplicateTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CanaryRunConfigInput _runConfig;
        private string _runtimeVersion;
        private CanaryScheduleInput _schedule;
        private int? _successRetentionPeriodInDays;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// of the Amazon S3 bucket can't include a period (.).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property BrowserConfigs. 
        /// <para>
        /// CloudWatch Synthetics now supports multibrowser canaries for <c>syn-nodejs-puppeteer-11.0</c>
        /// and <c>syn-nodejs-playwright-3.0</c> runtimes. This feature allows you to run your
        /// canaries on both Firefox and Chrome browsers. To create a multibrowser canary, you
        /// need to specify the BrowserConfigs with a list of browsers you want to use.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified, <c>browserConfigs</c> defaults to Chrome.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<BrowserConfig> BrowserConfigs
        {
            get { return this._browserConfigs; }
            set { this._browserConfigs = value; }
        }

        // Check to see if BrowserConfigs property is set
        internal bool IsSetBrowserConfigs()
        {
            return this._browserConfigs != null && (this._browserConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A structure that includes the entry point from which the canary should start running
        /// your script. If the script is stored in an Amazon S3 bucket, the bucket name, key,
        /// and version are also included. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  <c>logs:PutLogEvents</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// The number of days to retain data about failed runs of this canary. If you omit this
        /// field, the default of 31 days is used. The valid range is 1 to 455 days.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the range of information returned by <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanaryRuns.html">GetCanaryRuns</a>,
        /// as well as the range of information displayed in the Synthetics console. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int? FailureRetentionPeriodInDays
        {
            get { return this._failureRetentionPeriodInDays; }
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
        /// The name for this canary. Be sure to give it a descriptive name that distinguishes
        /// it from other canaries in your account.
        /// </para>
        ///  
        /// <para>
        /// Do not include secrets or proprietary information in your canary names. The canary
        /// name makes up part of the canary ARN, and the ARN is included in outbound calls over
        /// the internet. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
        /// Considerations for Synthetics Canaries</a>.
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
        /// when the canary is deleted. If you omit this parameter, the default of <c>AUTOMATIC</c>
        /// is used, which means that the Lambda functions and layers will be deleted when the
        /// canary is deleted.
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
        /// Gets and sets the property ResourcesToReplicateTags. 
        /// <para>
        /// To have the tags that you apply to this canary also be applied to the Lambda function
        /// that the canary uses, specify this parameter with the value <c>lambda-function</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter and don't specify any tags in the <c>Tags</c> parameter,
        /// the canary creation fails.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourcesToReplicateTags
        {
            get { return this._resourcesToReplicateTags; }
            set { this._resourcesToReplicateTags = value; }
        }

        // Check to see if ResourcesToReplicateTags property is set
        internal bool IsSetResourcesToReplicateTags()
        {
            return this._resourcesToReplicateTags != null && (this._resourcesToReplicateTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RunConfig. 
        /// <para>
        /// A structure that contains the configuration for individual canary runs, such as timeout
        /// value and environment variables.
        /// </para>
        ///  <important> 
        /// <para>
        /// Environment variable keys and values are encrypted at rest using Amazon Web Services
        /// owned KMS keys. However, the environment variables are not encrypted on the client
        /// side. Do not store sensitive information in them.
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
        /// and more information about runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// A structure that contains information about how often the canary is to run and when
        /// these test runs are to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The number of days to retain data about successful runs of this canary. If you omit
        /// this field, the default of 31 days is used. The valid range is 1 to 455 days.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the range of information returned by <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanaryRuns.html">GetCanaryRuns</a>,
        /// as well as the range of information displayed in the Synthetics console. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int? SuccessRetentionPeriodInDays
        {
            get { return this._successRetentionPeriodInDays; }
            set { this._successRetentionPeriodInDays = value; }
        }

        // Check to see if SuccessRetentionPeriodInDays property is set
        internal bool IsSetSuccessRetentionPeriodInDays()
        {
            return this._successRetentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the canary. You can associate as many
        /// as 50 tags with a canary.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only the
        /// resources that have certain tag values.
        /// </para>
        ///  
        /// <para>
        /// To have the tags that you apply to this canary also be applied to the Lambda function
        /// that the canary uses, specify this parameter with the value <c>lambda-function</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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