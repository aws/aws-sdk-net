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
    /// Represents test settings. This data structure is passed in as the test parameter to
    /// ScheduleRun. For an example of the JSON request syntax, see <a>ScheduleRun</a>.
    /// </summary>
    public partial class ScheduleRunTest
    {
        private string _filter;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _testPackageArn;
        private string _testSpecArn;
        private TestType _type;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The test's filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
        /// The test's parameters, such as test framework parameters and fixture settings. Parameters
        /// are represented by name-value pairs of strings.
        /// </para>
        ///  
        /// <para>
        /// For all tests:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>app_performance_monitoring</c>: Performance monitoring is enabled by default.
        /// Set this parameter to false to disable it.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Appium tests (all types):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// appium_version: The Appium version. Currently supported values are 1.6.5 (and later),
        /// latest, and default.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// latest runs the latest Appium version supported by Device Farm (1.9.1).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For default, Device Farm selects a compatible version of Appium for the device. The
        /// current behavior is to run 1.7.2 on Android devices and iOS 9 and earlier and 1.7.2
        /// for iOS 10 and later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This behavior is subject to change.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For fuzz tests (Android only):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// event_count: The number of events, between 1 and 10000, that the UI fuzz test should
        /// perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// throttle: The time, in ms, between 0 and 1000, that the UI fuzz test should wait between
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// seed: A seed to use for randomizing the UI fuzz test. Using the same seed value between
        /// tests ensures identical event sequences.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Instrumentation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// filter: A test filter string. Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running a single test case: <c>com.android.abc.Test1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Running a single test: <c>com.android.abc.Test1#smoke</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Running multiple tests: <c>com.android.abc.Test1,com.android.abc.Test2</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For XCTest and XCTestUI:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// filter: A test filter string. Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running a single test class: <c>LoginTests</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Running a multiple test classes: <c>LoginTests,SmokeTests</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Running a single test: <c>LoginTests/testValid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Running multiple tests: <c>LoginTests/testValid,LoginTests/testInvalid</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TestPackageArn. 
        /// <para>
        /// The ARN of the uploaded test to be run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
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
        /// Gets and sets the property TestSpecArn. 
        /// <para>
        /// The ARN of the YAML-formatted test specification.
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
        [AWSProperty(Required=true)]
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