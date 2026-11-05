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
    /// Container for the parameters to the GetDevicePoolCompatibility operation. Gets information
    /// about compatibility with a device pool.
    /// </summary>
    public partial class GetDevicePoolCompatibilityRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of the app that is associated with the specified device pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// An object that contains information about the settings for a run.
        /// </para>
        /// </summary>
        public ScheduleRunConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The device pool's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string DevicePoolArn { get; set; }

        /// <summary>
        /// Checks to see if the DevicePoolArn property is set.
        /// </summary>
        internal bool IsSetDevicePoolArn() => this.DevicePoolArn != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for which you want to check device pool compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the uploaded test to be run against the device pool.
        /// </para>
        /// </summary>
        public ScheduleRunTest Test { get; set; }

        /// <summary>
        /// Checks to see if the Test property is set.
        /// </summary>
        internal bool IsSetTest() => this.Test != null;

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
        public TestType TestType { get; set; }

        /// <summary>
        /// Checks to see if the TestType property is set.
        /// </summary>
        internal bool IsSetTestType() => this.TestType != null;
    }
}
