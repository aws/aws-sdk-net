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
    /// Represents additional test settings.
    /// </summary>
    public partial class ScheduleRunTest
    {
        private string _filter;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _testPackageArn;
        private TestType _type;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The test's filter.
        /// </para>
        /// </summary>
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The test's parameters, such as test framework parameters and fixture settings.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TestPackageArn. 
        /// <para>
        /// The ARN of the uploaded test that will be run.
        /// </para>
        /// </summary>
        public string TestPackageArn
        {
            get { return this._testPackageArn; }
            set { this._testPackageArn = value; }
        }

        // Check to see if TestPackageArn property is set
        internal bool IsSetTestPackageArn()
        {
            return this._testPackageArn != null;
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