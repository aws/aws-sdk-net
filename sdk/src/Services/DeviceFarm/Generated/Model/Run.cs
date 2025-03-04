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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private string _appUpload;
        private string _arn;
        private BillingMethod _billingMethod;
        private int? _completedJobs;
        private Counters _counters;
        private DateTime? _created;
        private CustomerArtifactPaths _customerArtifactPaths;
        private DeviceMinutes _deviceMinutes;
        private string _devicePoolArn;
        private DeviceProxy _deviceProxy;
        private DeviceSelectionResult _deviceSelectionResult;
        private int? _eventCount;
        private int? _jobTimeoutMinutes;
        private string _locale;
        private Location _location;
        private string _message;
        private string _name;
        private NetworkProfile _networkProfile;
        private string _parsingResultUrl;
        private DevicePlatform _platform;
        private Radios _radios;
        private ExecutionResult _result;
        private ExecutionResultCode _resultCode;
        private int? _seed;
        private bool? _skipAppResign;
        private DateTime? _started;
        private ExecutionStatus _status;
        private DateTime? _stopped;
        private string _testSpecArn;
        private int? _totalJobs;
        private TestType _type;
        private VpcConfig _vpcConfig;
        private string _webUrl;

        /// <summary>
        /// Gets and sets the property AppUpload. 
        /// <para>
        /// An app to upload or that has been uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string AppUpload
        {
            get { return this._appUpload; }
            set { this._appUpload = value; }
        }

        // Check to see if AppUpload property is set
        internal bool IsSetAppUpload()
        {
            return this._appUpload != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The run's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

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
        public BillingMethod BillingMethod
        {
            get { return this._billingMethod; }
            set { this._billingMethod = value; }
        }

        // Check to see if BillingMethod property is set
        internal bool IsSetBillingMethod()
        {
            return this._billingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedJobs. 
        /// <para>
        /// The total number of completed jobs.
        /// </para>
        /// </summary>
        public int? CompletedJobs
        {
            get { return this._completedJobs; }
            set { this._completedJobs = value; }
        }

        // Check to see if CompletedJobs property is set
        internal bool IsSetCompletedJobs()
        {
            return this._completedJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Counters. 
        /// <para>
        /// The run's result counters.
        /// </para>
        /// </summary>
        public Counters Counters
        {
            get { return this._counters; }
            set { this._counters = value; }
        }

        // Check to see if Counters property is set
        internal bool IsSetCounters()
        {
            return this._counters != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// When the run was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerArtifactPaths. 
        /// <para>
        /// Output <c>CustomerArtifactPaths</c> object for the test run.
        /// </para>
        /// </summary>
        public CustomerArtifactPaths CustomerArtifactPaths
        {
            get { return this._customerArtifactPaths; }
            set { this._customerArtifactPaths = value; }
        }

        // Check to see if CustomerArtifactPaths property is set
        internal bool IsSetCustomerArtifactPaths()
        {
            return this._customerArtifactPaths != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// Represents the total (metered or unmetered) minutes used by the test run.
        /// </para>
        /// </summary>
        public DeviceMinutes DeviceMinutes
        {
            get { return this._deviceMinutes; }
            set { this._deviceMinutes = value; }
        }

        // Check to see if DeviceMinutes property is set
        internal bool IsSetDeviceMinutes()
        {
            return this._deviceMinutes != null;
        }

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The ARN of the device pool for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string DevicePoolArn
        {
            get { return this._devicePoolArn; }
            set { this._devicePoolArn = value; }
        }

        // Check to see if DevicePoolArn property is set
        internal bool IsSetDevicePoolArn()
        {
            return this._devicePoolArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy configured for the devices in the run.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy
        {
            get { return this._deviceProxy; }
            set { this._deviceProxy = value; }
        }

        // Check to see if DeviceProxy property is set
        internal bool IsSetDeviceProxy()
        {
            return this._deviceProxy != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSelectionResult. 
        /// <para>
        /// The results of a device filter used to select the devices for a test run.
        /// </para>
        /// </summary>
        public DeviceSelectionResult DeviceSelectionResult
        {
            get { return this._deviceSelectionResult; }
            set { this._deviceSelectionResult = value; }
        }

        // Check to see if DeviceSelectionResult property is set
        internal bool IsSetDeviceSelectionResult()
        {
            return this._deviceSelectionResult != null;
        }

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// For fuzz tests, this is the number of events, between 1 and 10000, that the UI fuzz
        /// test should perform.
        /// </para>
        /// </summary>
        public int? EventCount
        {
            get { return this._eventCount; }
            set { this._eventCount = value; }
        }

        // Check to see if EventCount property is set
        internal bool IsSetEventCount()
        {
            return this._eventCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobTimeoutMinutes. 
        /// <para>
        /// The number of minutes the job executes before it times out.
        /// </para>
        /// </summary>
        public int? JobTimeoutMinutes
        {
            get { return this._jobTimeoutMinutes; }
            set { this._jobTimeoutMinutes = value; }
        }

        // Check to see if JobTimeoutMinutes property is set
        internal bool IsSetJobTimeoutMinutes()
        {
            return this._jobTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// Information about the locale that is used for the run.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location that is used for the run.
        /// </para>
        /// </summary>
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the run's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The run's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property NetworkProfile. 
        /// <para>
        /// The network profile being used for a test run.
        /// </para>
        /// </summary>
        public NetworkProfile NetworkProfile
        {
            get { return this._networkProfile; }
            set { this._networkProfile = value; }
        }

        // Check to see if NetworkProfile property is set
        internal bool IsSetNetworkProfile()
        {
            return this._networkProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ParsingResultUrl. 
        /// <para>
        /// Read-only URL for an object in an S3 bucket where you can get the parsing results
        /// of the test package. If the test package doesn't parse, the reason why it doesn't
        /// parse appears in the file that this URL points to.
        /// </para>
        /// </summary>
        public string ParsingResultUrl
        {
            get { return this._parsingResultUrl; }
            set { this._parsingResultUrl = value; }
        }

        // Check to see if ParsingResultUrl property is set
        internal bool IsSetParsingResultUrl()
        {
            return this._parsingResultUrl != null;
        }

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
        public DevicePlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Radios. 
        /// <para>
        /// Information about the radio states for the run.
        /// </para>
        /// </summary>
        public Radios Radios
        {
            get { return this._radios; }
            set { this._radios = value; }
        }

        // Check to see if Radios property is set
        internal bool IsSetRadios()
        {
            return this._radios != null;
        }

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
        public ExecutionResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property ResultCode. 
        /// <para>
        /// Supporting field for the result field. Set only if <c>result</c> is <c>SKIPPED</c>.
        /// <c>PARSING_FAILED</c> if the result is skipped because of test package parsing failure.
        /// </para>
        /// </summary>
        public ExecutionResultCode ResultCode
        {
            get { return this._resultCode; }
            set { this._resultCode = value; }
        }

        // Check to see if ResultCode property is set
        internal bool IsSetResultCode()
        {
            return this._resultCode != null;
        }

        /// <summary>
        /// Gets and sets the property Seed. 
        /// <para>
        /// For fuzz tests, this is a seed to use for randomizing the UI fuzz test. Using the
        /// same seed value between tests ensures identical event sequences.
        /// </para>
        /// </summary>
        public int? Seed
        {
            get { return this._seed; }
            set { this._seed = value; }
        }

        // Check to see if Seed property is set
        internal bool IsSetSeed()
        {
            return this._seed.HasValue; 
        }

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
        public bool? SkipAppResign
        {
            get { return this._skipAppResign; }
            set { this._skipAppResign = value; }
        }

        // Check to see if SkipAppResign property is set
        internal bool IsSetSkipAppResign()
        {
            return this._skipAppResign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The run's start time.
        /// </para>
        /// </summary>
        public DateTime? Started
        {
            get { return this._started; }
            set { this._started = value; }
        }

        // Check to see if Started property is set
        internal bool IsSetStarted()
        {
            return this._started.HasValue; 
        }

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
        public ExecutionStatus Status
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
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The run's stop time.
        /// </para>
        /// </summary>
        public DateTime? Stopped
        {
            get { return this._stopped; }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestSpecArn. 
        /// <para>
        /// The ARN of the YAML-formatted test specification for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string TestSpecArn
        {
            get { return this._testSpecArn; }
            set { this._testSpecArn = value; }
        }

        // Check to see if TestSpecArn property is set
        internal bool IsSetTestSpecArn()
        {
            return this._testSpecArn != null;
        }

        /// <summary>
        /// Gets and sets the property TotalJobs. 
        /// <para>
        /// The total number of jobs for the run.
        /// </para>
        /// </summary>
        public int? TotalJobs
        {
            get { return this._totalJobs; }
            set { this._totalJobs = value; }
        }

        // Check to see if TotalJobs property is set
        internal bool IsSetTotalJobs()
        {
            return this._totalJobs.HasValue; 
        }

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
        public TestType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC security groups and subnets that are attached to a project.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WebUrl. 
        /// <para>
        /// The Device Farm console URL for the recording of the run.
        /// </para>
        /// </summary>
        public string WebUrl
        {
            get { return this._webUrl; }
            set { this._webUrl = value; }
        }

        // Check to see if WebUrl property is set
        internal bool IsSetWebUrl()
        {
            return this._webUrl != null;
        }

    }
}