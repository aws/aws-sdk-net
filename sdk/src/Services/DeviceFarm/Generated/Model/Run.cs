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

/*
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a test run on a set of devices with a given app package, test parameters,
    /// etc.
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
        private int? _totalJobs;
        private TestType _type;
        private string _webUrl;

        /// <summary>
        /// Gets and sets the property AppUpload. 
        /// <para>
        /// An app to upload or that has been uploaded.
        /// </para>
        /// </summary>
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
        /// Specifies the billing method for a test run: <code>metered</code> or <code>unmetered</code>.
        /// If the parameter is not specified, the default value is <code>metered</code>.
        /// </para>
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
        public int CompletedJobs
        {
            get { return this._completedJobs.GetValueOrDefault(); }
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
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
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
        /// Output <code>CustomerArtifactPaths</code> object for the test run.
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
        /// Gets and sets the property EventCount. 
        /// <para>
        /// For fuzz tests, this is the number of events, between 1 and 10000, that the UI fuzz
        /// test should perform.
        /// </para>
        /// </summary>
        public int EventCount
        {
            get { return this._eventCount.GetValueOrDefault(); }
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
        /// The number of minutes the job will execute before it times out.
        /// </para>
        /// </summary>
        public int JobTimeoutMinutes
        {
            get { return this._jobTimeoutMinutes.GetValueOrDefault(); }
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
        /// Read-only URL for an object in S3 bucket where you can get the parsing results of
        /// the test package. If the test package doesn't parse, the reason why it doesn't parse
        /// appears in the file that this URL points to.
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
        /// ANDROID: The Android platform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOS: The iOS platform.
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
        /// PENDING: A pending condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PASSED: A passing condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARNED: A warning condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED: A failed condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SKIPPED: A skipped condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERRORED: An error condition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED: A stopped condition.
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
        /// Supporting field for the result field. Set only if <code>result</code> is <code>SKIPPED</code>.
        /// <code>PARSING_FAILED</code> if the result is skipped because of test package parsing
        /// failure.
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
        public int Seed
        {
            get { return this._seed.GetValueOrDefault(); }
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
        /// When set to <code>true</code>, for private devices, Device Farm will not sign your
        /// app again. For public devices, Device Farm always signs your apps again and this parameter
        /// has no effect.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your app(s), see <a href="https://aws.amazon.com/device-farm/faq/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool SkipAppResign
        {
            get { return this._skipAppResign.GetValueOrDefault(); }
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
        public DateTime Started
        {
            get { return this._started.GetValueOrDefault(); }
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
        /// PENDING: A pending status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_CONCURRENCY: A pending concurrency status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_DEVICE: A pending device status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING: A processing status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCHEDULING: A scheduling status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PREPARING: A preparing status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING: A running status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED: A completed status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPING: A stopping status.
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
        public DateTime Stopped
        {
            get { return this._stopped.GetValueOrDefault(); }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalJobs. 
        /// <para>
        /// The total number of jobs for the run.
        /// </para>
        /// </summary>
        public int TotalJobs
        {
            get { return this._totalJobs.GetValueOrDefault(); }
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
        /// BUILTIN_FUZZ: The built-in fuzz type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BUILTIN_EXPLORER: For Android, an app explorer that will traverse an Android app,
        /// interacting with it and capturing screenshots at the same time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT: The Appium Java JUnit type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG: The Appium Java TestNG type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON: The Appium Python type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT: The Appium Java JUnit type for Web apps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG: The Appium Java TestNG type for Web apps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON: The Appium Python type for Web apps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CALABASH: The Calabash type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION: The Instrumentation type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UIAUTOMATION: The uiautomation type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UIAUTOMATOR: The uiautomator type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST: The XCode test type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI: The XCode UI test type.
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