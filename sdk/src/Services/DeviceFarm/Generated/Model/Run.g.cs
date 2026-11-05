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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a test run on a set of devices with a given app package, test parameters,
    /// and so on.
    /// </summary>
    public partial class Run
    {
        /// <summary>
        /// Gets and sets the property AppUpload. 
        /// <para>
        /// An app to upload or that has been uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string AppUpload { get; set; }

        /// <summary>
        /// Checks to see if the AppUpload property is set.
        /// </summary>
        internal bool IsSetAppUpload() => this.AppUpload != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The run's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// Specifies the billing method for a test run: <c>metered</c> or <c>unmetered</c>. If
        /// the parameter is not specified, the default value is <c>metered</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have unmetered device slots, you must set this to <c>unmetered</c> to use them.
        /// Otherwise, the run is counted toward metered device minutes.
        /// </para>
        ///  </note>
        /// </summary>
        public BillingMethod BillingMethod { get; set; }

        /// <summary>
        /// Checks to see if the BillingMethod property is set.
        /// </summary>
        internal bool IsSetBillingMethod() => this.BillingMethod != null;

        /// <summary>
        /// Gets and sets the property CompletedJobs. 
        /// <para>
        /// The total number of completed jobs.
        /// </para>
        /// </summary>
        public int? CompletedJobs { get; set; }

        /// <summary>
        /// Checks to see if the CompletedJobs property is set.
        /// </summary>
        internal bool IsSetCompletedJobs() => this.CompletedJobs.HasValue;

        /// <summary>
        /// Gets and sets the property Counters. 
        /// <para>
        /// The run's result counters.
        /// </para>
        /// </summary>
        public Counters Counters { get; set; }

        /// <summary>
        /// Checks to see if the Counters property is set.
        /// </summary>
        internal bool IsSetCounters() => this.Counters != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// When the run was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerArtifactPaths. 
        /// <para>
        /// Output <c>CustomerArtifactPaths</c> object for the test run.
        /// </para>
        /// </summary>
        public CustomerArtifactPaths CustomerArtifactPaths { get; set; }

        /// <summary>
        /// Checks to see if the CustomerArtifactPaths property is set.
        /// </summary>
        internal bool IsSetCustomerArtifactPaths() => this.CustomerArtifactPaths != null;

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// Represents the total (metered or unmetered) minutes used by the test run.
        /// </para>
        /// </summary>
        public DeviceMinutes DeviceMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DeviceMinutes property is set.
        /// </summary>
        internal bool IsSetDeviceMinutes() => this.DeviceMinutes != null;

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The ARN of the device pool for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string DevicePoolArn { get; set; }

        /// <summary>
        /// Checks to see if the DevicePoolArn property is set.
        /// </summary>
        internal bool IsSetDevicePoolArn() => this.DevicePoolArn != null;

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy configured for the devices in the run.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProxy property is set.
        /// </summary>
        internal bool IsSetDeviceProxy() => this.DeviceProxy != null;

        /// <summary>
        /// Gets and sets the property DeviceSelectionResult. 
        /// <para>
        /// The results of a device filter used to select the devices for a test run.
        /// </para>
        /// </summary>
        public DeviceSelectionResult DeviceSelectionResult { get; set; }

        /// <summary>
        /// Checks to see if the DeviceSelectionResult property is set.
        /// </summary>
        internal bool IsSetDeviceSelectionResult() => this.DeviceSelectionResult != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// Environment variables associated with the run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<EnvironmentVariable> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// For fuzz tests, this is the number of events, between 1 and 10000, that the UI fuzz
        /// test should perform.
        /// </para>
        /// </summary>
        public int? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The IAM role associated with the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The insights for the run, including the report status and job-level metrics. This
        /// field contains data only if you specified <c>insightsTypes</c> when you scheduled
        /// the run.
        /// </para>
        /// </summary>
        public RunInsights Insights { get; set; }

        /// <summary>
        /// Checks to see if the Insights property is set.
        /// </summary>
        internal bool IsSetInsights() => this.Insights != null;

        /// <summary>
        /// Gets and sets the property InsightsTypes. 
        /// <para>
        /// The types of insights requested for the run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> InsightsTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsightsTypes property is set.
        /// </summary>
        internal bool IsSetInsightsTypes() => this.InsightsTypes != null && (this.InsightsTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobTimeoutMinutes. 
        /// <para>
        /// The number of minutes the job executes before it times out.
        /// </para>
        /// </summary>
        public int? JobTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the JobTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetJobTimeoutMinutes() => this.JobTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// Information about the locale that is used for the run.
        /// </para>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location that is used for the run.
        /// </para>
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the run's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The run's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkProfile. 
        /// <para>
        /// The network profile being used for a test run.
        /// </para>
        /// </summary>
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Checks to see if the NetworkProfile property is set.
        /// </summary>
        internal bool IsSetNetworkProfile() => this.NetworkProfile != null;

        /// <summary>
        /// Gets and sets the property ParsingResultUrl. 
        /// <para>
        /// Read-only URL for an object in an S3 bucket where you can get the parsing results
        /// of the test package. If the test package doesn't parse, the reason why it doesn't
        /// parse appears in the file that this URL points to.
        /// </para>
        /// </summary>
        public string ParsingResultUrl { get; set; }

        /// <summary>
        /// Checks to see if the ParsingResultUrl property is set.
        /// </summary>
        internal bool IsSetParsingResultUrl() => this.ParsingResultUrl != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The run's platform.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ANDROID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevicePlatform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Radios. 
        /// <para>
        /// Information about the radio states for the run.
        /// </para>
        /// </summary>
        public Radios Radios { get; set; }

        /// <summary>
        /// Checks to see if the Radios property is set.
        /// </summary>
        internal bool IsSetRadios() => this.Radios != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The run's result.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PASSED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARNED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SKIPPED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERRORED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property ResultCode. 
        /// <para>
        /// Supporting field for the result field. Set only if <c>result</c> is <c>SKIPPED</c>.
        /// <c>PARSING_FAILED</c> if the result is skipped because of test package parsing failure.
        /// </para>
        /// </summary>
        public ExecutionResultCode ResultCode { get; set; }

        /// <summary>
        /// Checks to see if the ResultCode property is set.
        /// </summary>
        internal bool IsSetResultCode() => this.ResultCode != null;

        /// <summary>
        /// Gets and sets the property Seed. 
        /// <para>
        /// For fuzz tests, this is a seed to use for randomizing the UI fuzz test. Using the
        /// same seed value between tests ensures identical event sequences.
        /// </para>
        /// </summary>
        public int? Seed { get; set; }

        /// <summary>
        /// Checks to see if the Seed property is set.
        /// </summary>
        internal bool IsSetSeed() => this.Seed.HasValue;

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <c>true</c>, for private devices, Device Farm does not sign your app again.
        /// For public devices, Device Farm always signs your apps again.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your apps, see <a href="http://aws.amazon.com/device-farm/faqs/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool? SkipAppResign { get; set; }

        /// <summary>
        /// Checks to see if the SkipAppResign property is set.
        /// </summary>
        internal bool IsSetSkipAppResign() => this.SkipAppResign.HasValue;

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The run's start time.
        /// </para>
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Checks to see if the Started property is set.
        /// </summary>
        internal bool IsSetStarted() => this.Started.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The run's status.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_CONCURRENCY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_DEVICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCHEDULING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PREPARING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPING
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The run's stop time.
        /// </para>
        /// </summary>
        public DateTime? Stopped { get; set; }

        /// <summary>
        /// Checks to see if the Stopped property is set.
        /// </summary>
        internal bool IsSetStopped() => this.Stopped.HasValue;

        /// <summary>
        /// Gets and sets the property TestSpecArn. 
        /// <para>
        /// The ARN of the YAML-formatted test specification for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string TestSpecArn { get; set; }

        /// <summary>
        /// Checks to see if the TestSpecArn property is set.
        /// </summary>
        internal bool IsSetTestSpecArn() => this.TestSpecArn != null;

        /// <summary>
        /// Gets and sets the property TotalJobs. 
        /// <para>
        /// The total number of jobs for the run.
        /// </para>
        /// </summary>
        public int? TotalJobs { get; set; }

        /// <summary>
        /// Checks to see if the TotalJobs property is set.
        /// </summary>
        internal bool IsSetTotalJobs() => this.TotalJobs.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The run's type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BUILTIN_FUZZ
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_NODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_RUBY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_NODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_RUBY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TestType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC security groups and subnets that are attached to a project.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;

        /// <summary>
        /// Gets and sets the property WebUrl. 
        /// <para>
        /// The Device Farm console URL for the recording of the run.
        /// </para>
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebUrl property is set.
        /// </summary>
        internal bool IsSetWebUrl() => this.WebUrl != null;
    }
}
