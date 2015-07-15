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
        /// ANDROID_APP: An Android app.
        /// </para>
        /// </li> <li>
        /// <para>
        /// APPIUM_JAVA_TEST_PACKAGE: An Appium Java test package.
        /// </para>
        /// </li> <li>
        /// <para>
        /// CALABASH_TEST_PACKAGE: A Calabash test package.
        /// </para>
        /// </li> <li>
        /// <para>
        /// EXTERNAL_DATA: External data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INSTRUMENTATION_TEST_PACKAGE: An instrumentation test package.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IOS_APP: An iOS app.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATION_TEST_PACKAGE: A UI Automation test package.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UIAUTOMATOR_TEST_PACKAGE: A uiautomator test package.
        /// </para>
        /// </li> <li>
        /// <para>
        /// XCTEST_TEST_PACKAGE: An XCTest test package.
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