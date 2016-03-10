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
    /// Represents a condition that is evaluated.
    /// </summary>
    public partial class Test
    {
        private string _arn;
        private Counters _counters;
        private DateTime? _created;
        private DeviceMinutes _deviceMinutes;
        private string _message;
        private string _name;
        private ExecutionResult _result;
        private DateTime? _started;
        private ExecutionStatus _status;
        private DateTime? _stopped;
        private TestType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The test's ARN.
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
        /// Gets and sets the property Counters. 
        /// <para>
        /// The test's result counters.
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
        /// When the test was created.
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
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// Represents the total (metered or unmetered) minutes used by the test.
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the test's result.
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
        /// The test's name.
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
        /// Gets and sets the property Result. 
        /// <para>
        /// The test's result.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// ERRORED: An error condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// FAILED: A failed condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SKIPPED: A skipped condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// STOPPED: A stopped condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PASSED: A passing condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PENDING: A pending condition.
        /// </para>
        /// </li> <li>
        /// <para>
        /// WARNED: A warning condition.
        /// </para>
        /// </li> </ul>
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
        /// Gets and sets the property Started. 
        /// <para>
        /// The test's start time.
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
        /// The test's status.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// COMPLETED: A completed status.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PENDING: A pending status.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PROCESSING: A processing status.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RUNNING: A running status.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SCHEDULING: A scheduling status.
        /// </para>
        /// </li> </ul>
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
        /// The test's stop time.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The test's type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// BUILTIN_FUZZ: The built-in fuzz type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// BUILTIN_EXPLORER: For Android, an app explorer that will traverse an Android app,
        /// interacting with it and capturing screenshots at the same time.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_JUNIT: The Appium Java JUnit type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_TESTNG: The Appium Java TestNG type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_PYTHON: The Appium Python type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT: The Appium Java JUnit type for Web apps.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG: The Appium Java TestNG type for Web apps.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_WEB_PYTHON: The Appium Python type for Web apps.
        /// </para>
        /// </li> <li>
        /// <para>
        /// CALABASH: The Calabash type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INSTRUMENTATION: The Instrumentation type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATION: The uiautomation type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATOR: The uiautomator type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// XCTEST: The XCode test type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// XCTEST_UI: The XCode UI test type.
        /// </para>
        /// </li> </ul>
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

    }
}