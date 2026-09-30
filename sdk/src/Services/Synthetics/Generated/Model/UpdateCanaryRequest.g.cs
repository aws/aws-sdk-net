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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateCanary operation. Updates the configuration
    /// of a canary that has already been created. <para> For multibrowser canaries, you can
    /// add or remove browsers by updating the browserConfig list in the update call. For
    /// example: </para> <ul> <li> <para> To add Firefox to a canary that currently uses Chrome,
    /// specify browserConfigs as [CHROME, FIREFOX] </para> </li> <li> <para> To remove Firefox
    /// and keep only Chrome, specify browserConfigs as [CHROME] </para> </li> </ul> <para>
    /// You can't use this operation to update the tags of an existing canary. To change the
    /// tags of an existing canary, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// </para> <note> <para> When you use the <c>dryRunId</c> field when updating a canary,
    /// the only other field you can provide is the <c>Schedule</c>. Adding any other field
    /// will thrown an exception. </para> </note>
    /// </summary>
    public partial class UpdateCanaryRequest : AmazonSyntheticsRequest
    {
        /// <summary>
        /// Gets and sets the property AddReplicaLocations. 
        /// <para>
        /// A list of locations (Amazon Web Services Regions) to add as replicas for the canary.
        /// Each location specifies a Region and optional VPC configuration for the replica. You
        /// can add up to 50 replica locations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<AddReplicaLocationInput> AddReplicaLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<AddReplicaLocationInput>() : null;

        /// <summary>
        /// Checks to see if the AddReplicaLocations property is set.
        /// </summary>
        internal bool IsSetAddReplicaLocations() => this.AddReplicaLocations != null && (this.AddReplicaLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ArtifactConfig. 
        /// <para>
        /// A structure that contains the configuration for canary artifacts, including the encryption-at-rest
        /// settings for artifacts that the canary uploads to Amazon S3.
        /// </para>
        /// </summary>
        public ArtifactConfigInput ArtifactConfig { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactConfig property is set.
        /// </summary>
        internal bool IsSetArtifactConfig() => this.ArtifactConfig != null;

        /// <summary>
        /// Gets and sets the property ArtifactS3Location. 
        /// <para>
        /// The location in Amazon S3 where Synthetics stores artifacts from the test runs of
        /// this canary. Artifacts include the log file, screenshots, and HAR files. The name
        /// of the Amazon S3 bucket can't include a period (.).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ArtifactS3Location { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactS3Location property is set.
        /// </summary>
        internal bool IsSetArtifactS3Location() => this.ArtifactS3Location != null;

        /// <summary>
        /// Gets and sets the property BrowserConfigs. 
        /// <para>
        /// A structure that specifies the browser type to use for a canary run. CloudWatch Synthetics
        /// supports running canaries on both <c>CHROME</c> and <c>FIREFOX</c> browsers.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified, <c>browserConfigs</c> defaults to Chrome.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<BrowserConfig> BrowserConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<BrowserConfig>() : null;

        /// <summary>
        /// Checks to see if the BrowserConfigs property is set.
        /// </summary>
        internal bool IsSetBrowserConfigs() => this.BrowserConfigs != null && (this.BrowserConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A structure that includes the entry point from which the canary should start running
        /// your script. If the script is stored in an Amazon S3 bucket, the bucket name, key,
        /// and version are also included. 
        /// </para>
        /// </summary>
        public CanaryCodeInput Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// Update the existing canary using the updated configurations from the DryRun associated
        /// with the DryRunId.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the <c>dryRunId</c> field when updating a canary, the only other field
        /// you can provide is the <c>Schedule</c>. Adding any other field will thrown an exception.
        /// </para>
        ///  </note>
        /// </summary>
        public string DryRunId { get; set; }

        /// <summary>
        /// Checks to see if the DryRunId property is set.
        /// </summary>
        internal bool IsSetDryRunId() => this.DryRunId != null;

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
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FailureRetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain data about failed runs of this canary.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the range of information returned by <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanaryRuns.html">GetCanaryRuns</a>,
        /// as well as the range of information displayed in the Synthetics console. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public int? FailureRetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the FailureRetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetFailureRetentionPeriodInDays() => this.FailureRetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer-managed AWS Key Management Service
        /// (AWS KMS) key used to encrypt the canary's AWS Lambda function environment variables
        /// at rest. If you don't specify a value, the service uses an AWS-managed key. If you
        /// omit this parameter, the service retains the existing value. To revert to the AWS-managed
        /// key, set this parameter to an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public ProvisionedResourceCleanupSetting ProvisionedResourceCleanup { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedResourceCleanup property is set.
        /// </summary>
        internal bool IsSetProvisionedResourceCleanup() => this.ProvisionedResourceCleanup != null;

        /// <summary>
        /// Gets and sets the property RemoveReplicaLocations. 
        /// <para>
        /// A list of locations (Amazon Web Services Regions) to remove as replicas for the canary.
        /// You must specify at least one location to remove. All replicas can be removed in a
        /// single API call and you cannot remove the primary location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> RemoveReplicaLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveReplicaLocations property is set.
        /// </summary>
        internal bool IsSetRemoveReplicaLocations() => this.RemoveReplicaLocations != null && (this.RemoveReplicaLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunConfig. 
        /// <para>
        /// A structure that contains the timeout value that is used for each individual run of
        /// the canary.
        /// </para>
        ///  <important> 
        /// <para>
        /// Environment variable keys and values are encrypted at rest using Amazon Web Services
        /// owned KMS keys. However, the environment variables are not encrypted on the client
        /// side. Do not store sensitive information in them.
        /// </para>
        ///  </important>
        /// </summary>
        public CanaryRunConfigInput RunConfig { get; set; }

        /// <summary>
        /// Checks to see if the RunConfig property is set.
        /// </summary>
        internal bool IsSetRunConfig() => this.RunConfig != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersion. 
        /// <para>
        /// Specifies the runtime version to use for the canary. For a list of valid runtime versions
        /// and for more information about runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A structure that contains information about how often the canary is to run, and when
        /// these runs are to stop.
        /// </para>
        /// </summary>
        public CanaryScheduleInput Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SuccessRetentionPeriodInDays. 
        /// <para>
        /// The number of days to retain data about successful runs of this canary.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the range of information returned by <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanaryRuns.html">GetCanaryRuns</a>,
        /// as well as the range of information displayed in the Synthetics console. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public int? SuccessRetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the SuccessRetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetSuccessRetentionPeriodInDays() => this.SuccessRetentionPeriodInDays.HasValue;

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
        public VisualReferenceInput VisualReference { get; set; }

        /// <summary>
        /// Checks to see if the VisualReference property is set.
        /// </summary>
        internal bool IsSetVisualReference() => this.VisualReference != null;

        /// <summary>
        /// Gets and sets the property VisualReferences. 
        /// <para>
        /// A list of visual reference configurations for the canary, one for each browser type
        /// that the canary is configured to run on. Visual references are used for visual monitoring
        /// comparisons.
        /// </para>
        ///  
        /// <para>
        ///  <c>syn-nodejs-puppeteer-11.0</c> and above, and <c>syn-nodejs-playwright-3.0</c>
        /// and above, only supports <c>visualReferences</c>. <c>visualReference</c> field is
        /// not supported.
        /// </para>
        ///  
        /// <para>
        /// Versions older than <c>syn-nodejs-puppeteer-11.0</c> supports both <c>visualReference</c>
        /// and <c>visualReferences</c> for backward compatibility. It is recommended to use <c>visualReferences</c>
        /// for consistency and future compatibility.
        /// </para>
        ///  
        /// <para>
        /// For multibrowser visual monitoring, you can update the baseline for all configured
        /// browsers in a single update call by specifying a list of VisualReference objects,
        /// one per browser. Each VisualReference object maps to a specific browser configuration,
        /// allowing you to manage visual baselines for multiple browsers simultaneously.
        /// </para>
        ///  
        /// <para>
        /// For single configuration canaries using Chrome browser (default browser), use visualReferences
        /// for <c>syn-nodejs-puppeteer-11.0</c> and above, and <c>syn-nodejs-playwright-3.0</c>
        /// and above canaries. The browserType in the visualReference object is not mandatory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<VisualReferenceInput> VisualReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<VisualReferenceInput>() : null;

        /// <summary>
        /// Checks to see if the VisualReferences property is set.
        /// </summary>
        internal bool IsSetVisualReferences() => this.VisualReferences != null && (this.VisualReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If this canary is to test an endpoint in a VPC, this structure contains information
        /// about the subnet and security groups of the VPC endpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_VPC.html">
        /// Running a Canary in a VPC</a>.
        /// </para>
        /// </summary>
        public VpcConfigInput VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
