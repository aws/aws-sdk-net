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
    /// This structure contains all information about one canary in your account.
    /// </summary>
    public partial class Canary
    {
        private ArtifactConfigOutput _artifactConfig;
        private string _artifactS3Location;
        private List<BrowserConfig> _browserConfigs = AWSConfigs.InitializeCollections ? new List<BrowserConfig>() : null;
        private CanaryCodeOutput _code;
        private DryRunConfigOutput _dryRunConfig;
        private string _engineArn;
        private List<EngineConfig> _engineConfigs = AWSConfigs.InitializeCollections ? new List<EngineConfig>() : null;
        private string _executionRoleArn;
        private int? _failureRetentionPeriodInDays;
        private string _id;
        private string _name;
        private ProvisionedResourceCleanupSetting _provisionedResourceCleanup;
        private CanaryRunConfigOutput _runConfig;
        private string _runtimeVersion;
        private CanaryScheduleOutput _schedule;
        private CanaryStatus _status;
        private int? _successRetentionPeriodInDays;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CanaryTimeline _timeline;
        private VisualReferenceOutput _visualReference;
        private List<VisualReferenceOutput> _visualReferences = AWSConfigs.InitializeCollections ? new List<VisualReferenceOutput>() : null;
        private VpcConfigOutput _vpcConfig;

        /// <summary>
        /// Gets and sets the property ArtifactConfig. 
        /// <para>
        /// A structure that contains the configuration for canary artifacts, including the encryption-at-rest
        /// settings for artifacts that the canary uploads to Amazon S3.
        /// </para>
        /// </summary>
        public ArtifactConfigOutput ArtifactConfig
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
        /// The location in Amazon S3 where Synthetics stores artifacts from the runs of this
        /// canary. Artifacts include the log file, screenshots, and HAR files.
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
        /// </summary>
        public CanaryCodeOutput Code
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
        /// Gets and sets the property DryRunConfig. 
        /// <para>
        /// Returns the dry run configurations for a canary.
        /// </para>
        /// </summary>
        public DryRunConfigOutput DryRunConfig
        {
            get { return this._dryRunConfig; }
            set { this._dryRunConfig = value; }
        }

        // Check to see if DryRunConfig property is set
        internal bool IsSetDryRunConfig()
        {
            return this._dryRunConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EngineArn. 
        /// <para>
        /// The ARN of the Lambda function that is used as your canary's engine. For more information
        /// about Lambda ARN format, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-api-permissions-ref.html">Resources
        /// and Conditions for Lambda Actions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EngineArn
        {
            get { return this._engineArn; }
            set { this._engineArn = value; }
        }

        // Check to see if EngineArn property is set
        internal bool IsSetEngineArn()
        {
            return this._engineArn != null;
        }

        /// <summary>
        /// Gets and sets the property EngineConfigs. 
        /// <para>
        /// A list of engine configurations for the canary, one for each browser type that the
        /// canary is configured to run on.
        /// </para>
        ///  
        /// <para>
        /// All runtime versions <c>syn-nodejs-puppeteer-11.0</c> and above, and <c>syn-nodejs-playwright-3.0</c>
        /// and above, use <c>engineConfigs</c> only. You can no longer use <c>engineArn</c> in
        /// these versions.
        /// </para>
        ///  
        /// <para>
        /// Runtime versions older than <c>syn-nodejs-puppeteer-11.0</c> and <c>syn-nodejs-playwright-3.0</c>
        /// continue to support <c>engineArn</c> to ensure backward compatibility.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EngineConfig> EngineConfigs
        {
            get { return this._engineConfigs; }
            set { this._engineConfigs = value; }
        }

        // Check to see if EngineConfigs property is set
        internal bool IsSetEngineConfigs()
        {
            return this._engineConfigs != null && (this._engineConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role used to run the canary. This role must include <c>lambda.amazonaws.com</c>
        /// as a principal in the trust policy.
        /// </para>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this canary.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// when the canary is deleted. If it is <c>AUTOMATIC</c>, the Lambda functions and layers
        /// will be deleted when the canary is deleted.
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
        /// </summary>
        public CanaryRunConfigOutput RunConfig
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
        /// Specifies the runtime version to use for the canary. For more information about runtime
        /// versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
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
        public CanaryScheduleOutput Schedule
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A structure that contains information about the canary's status.
        /// </para>
        /// </summary>
        public CanaryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        /// The list of key-value pairs that are associated with the canary.
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
        /// Gets and sets the property Timeline. 
        /// <para>
        /// A structure that contains information about when the canary was created, modified,
        /// and most recently run.
        /// </para>
        /// </summary>
        public CanaryTimeline Timeline
        {
            get { return this._timeline; }
            set { this._timeline = value; }
        }

        // Check to see if Timeline property is set
        internal bool IsSetTimeline()
        {
            return this._timeline != null;
        }

        /// <summary>
        /// Gets and sets the property VisualReference. 
        /// <para>
        /// If this canary performs visual monitoring by comparing screenshots, this structure
        /// contains the ID of the canary run to use as the baseline for screenshots, and the
        /// coordinates of any parts of the screen to ignore during the visual monitoring comparison.
        /// </para>
        /// </summary>
        public VisualReferenceOutput VisualReference
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<VisualReferenceOutput> VisualReferences
        {
            get { return this._visualReferences; }
            set { this._visualReferences = value; }
        }

        // Check to see if VisualReferences property is set
        internal bool IsSetVisualReferences()
        {
            return this._visualReferences != null && (this._visualReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfigOutput VpcConfig
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