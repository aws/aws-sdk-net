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
    /// Container for the parameters to the GetDevicePoolCompatibility operation.
    /// Gets information about compatibility with a device pool.
    /// </summary>
    public partial class GetDevicePoolCompatibilityRequest : AmazonDeviceFarmRequest
    {
        private string _appArn;
        private ScheduleRunConfiguration _configuration;
        private string _devicePoolArn;
        private string _projectArn;
        private ScheduleRunTest _test;
        private TestType _testType;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of the app that is associated with the specified device pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// An object that contains information about the settings for a run.
        /// </para>
        /// </summary>
        public ScheduleRunConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The device pool's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for which you want to check device pool compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the uploaded test to be run against the device pool.
        /// </para>
        /// </summary>
        public ScheduleRunTest Test
        {
            get { return this._test; }
            set { this._test = value; }
        }

        // Check to see if Test property is set
        internal bool IsSetTest()
        {
            return this._test != null;
        }

        /// <summary>
        /// Gets and sets the property TestType. 
        /// <para>
        /// The test type for the specified device pool.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BUILTIN_FUZZ.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_NODE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_RUBY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_NODE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_RUBY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TestType TestType
        {
            get { return this._testType; }
            set { this._testType = value; }
        }

        // Check to see if TestType property is set
        internal bool IsSetTestType()
        {
            return this._testType != null;
        }

    }
}