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
    /// Container for the parameters to the StartCanaryDryRun operation. Use this operation
    /// to start a dry run for a canary that has already been created
    /// </summary>
    public partial class StartCanaryDryRunRequest : AmazonSyntheticsRequest
    {
        /// <summary>
        /// Gets and sets the property ArtifactConfig.
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
        /// </summary>
        public CanaryCodeInput Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role to be used to run the canary. This role must already exist,
        /// and must include <c>lambda.amazonaws.com</c> as a principal in the trust policy. The
        /// role must also have the following permissions:
        /// </para>
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
        /// The number of days to retain data about failed runs of this canary. If you omit this
        /// field, the default of 31 days is used. The valid range is 1 to 455 days.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the canary that you want to dry run. To find canary names, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
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
        public ProvisionedResourceCleanupSetting ProvisionedResourceCleanup { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedResourceCleanup property is set.
        /// </summary>
        internal bool IsSetProvisionedResourceCleanup() => this.ProvisionedResourceCleanup != null;

        /// <summary>
        /// Gets and sets the property RunConfig.
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
        [AWSProperty(Min = 1, Max = 1024)]
        public int? SuccessRetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the SuccessRetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetSuccessRetentionPeriodInDays() => this.SuccessRetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property VisualReference.
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
        /// </summary>
        public VpcConfigInput VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
