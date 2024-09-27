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
    /// Represents a device.
    /// </summary>
    public partial class Job
    {
        private string _arn;
        private Counters _counters;
        private DateTime? _created;
        private Device _device;
        private DeviceMinutes _deviceMinutes;
        private string _instanceArn;
        private string _message;
        private string _name;
        private ExecutionResult _result;
        private DateTime? _started;
        private ExecutionStatus _status;
        private DateTime? _stopped;
        private TestType _type;
        private bool? _videoCapture;
        private string _videoEndpoint;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The job's ARN.
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
        /// Gets and sets the property Counters. 
        /// <para>
        /// The job's result counters.
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
        /// When the job was created.
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
        /// Gets and sets the property Device. 
        /// <para>
        /// The device (phone or tablet).
        /// </para>
        /// </summary>
        public Device Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// Represents the total (metered or unmetered) minutes used by the job.
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
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the job's result.
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
        /// The job's name.
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
        /// Gets and sets the property Result. 
        /// <para>
        /// The job's result.
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
        /// Gets and sets the property Started. 
        /// <para>
        /// The job's start time.
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
        /// The job's status.
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
        /// The job's stop time.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The job's type.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include the following:
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
        /// Gets and sets the property VideoCapture. 
        /// <para>
        /// This value is set to true if video capture is enabled. Otherwise, it is set to false.
        /// </para>
        /// </summary>
        public bool? VideoCapture
        {
            get { return this._videoCapture; }
            set { this._videoCapture = value; }
        }

        // Check to see if VideoCapture property is set
        internal bool IsSetVideoCapture()
        {
            return this._videoCapture.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VideoEndpoint. 
        /// <para>
        /// The endpoint for streaming device video.
        /// </para>
        /// </summary>
        public string VideoEndpoint
        {
            get { return this._videoEndpoint; }
            set { this._videoEndpoint = value; }
        }

        // Check to see if VideoEndpoint property is set
        internal bool IsSetVideoEndpoint()
        {
            return this._videoEndpoint != null;
        }

    }
}