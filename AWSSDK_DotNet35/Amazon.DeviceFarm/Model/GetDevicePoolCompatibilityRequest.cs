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
    /// Container for the parameters to the GetDevicePoolCompatibility operation.
    /// Gets information about compatibility with a device pool.
    /// </summary>
    public partial class GetDevicePoolCompatibilityRequest : AmazonDeviceFarmRequest
    {
        private string _appArn;
        private string _devicePoolArn;
        private TestType _testType;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of the app that is associated with the specified device pool.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The device pool's ARN.
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
        /// APPIUM_JAVA_JUNIT: The Appium Java JUnit type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_TESTNG: The Appium Java TestNG type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// BUILTIN_EXPLORER: For Android, an app explorer that will traverse an Android app,
        /// interacting with it and capturing screenshots at the same time.
        /// </para>
        /// </li> <li>
        /// <para>
        /// BUILTIN_FUZZ: The built-in fuzz type.
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
        /// UIAUTOMATION: The UI Automation type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATOR: The uiautomator type.
        /// </para>
        /// </li> <li>
        /// <para>
        /// XCTEST: The XCTest type.
        /// </para>
        /// </li> </ul>
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