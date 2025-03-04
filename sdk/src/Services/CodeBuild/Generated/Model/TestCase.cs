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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a test case created using a framework such as NUnit or Cucumber.
    /// A test case might be a unit test or a configuration test.
    /// </summary>
    public partial class TestCase
    {
        private long? _durationInNanoSeconds;
        private DateTime? _expired;
        private string _message;
        private string _name;
        private string _prefix;
        private string _reportArn;
        private string _status;
        private string _testRawDataPath;
        private string _testSuiteName;

        /// <summary>
        /// Gets and sets the property DurationInNanoSeconds. 
        /// <para>
        ///  The number of nanoseconds it took to run this test case. 
        /// </para>
        /// </summary>
        public long? DurationInNanoSeconds
        {
            get { return this._durationInNanoSeconds; }
            set { this._durationInNanoSeconds = value; }
        }

        // Check to see if DurationInNanoSeconds property is set
        internal bool IsSetDurationInNanoSeconds()
        {
            return this._durationInNanoSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        ///  The date and time a test case expires. A test case expires 30 days after it is created.
        /// An expired test case is not available to view in CodeBuild. 
        /// </para>
        /// </summary>
        public DateTime? Expired
        {
            get { return this._expired; }
            set { this._expired = value; }
        }

        // Check to see if Expired property is set
        internal bool IsSetExpired()
        {
            return this._expired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  A message associated with a test case. For example, an error message or stack trace.
        /// 
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
        ///  The name of the test case. 
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
        /// Gets and sets the property Prefix. 
        /// <para>
        ///  A string that is applied to a series of related test cases. CodeBuild generates the
        /// prefix. The prefix depends on the framework used to generate the tests. 
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property ReportArn. 
        /// <para>
        ///  The ARN of the report to which the test case belongs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReportArn
        {
            get { return this._reportArn; }
            set { this._reportArn = value; }
        }

        // Check to see if ReportArn property is set
        internal bool IsSetReportArn()
        {
            return this._reportArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status returned by the test case after it was run. Valid statuses are <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>ERROR</c>, <c>SKIPPED</c>, and <c>UNKNOWN</c>. 
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TestRawDataPath. 
        /// <para>
        ///  The path to the raw data file that contains the test result. 
        /// </para>
        /// </summary>
        public string TestRawDataPath
        {
            get { return this._testRawDataPath; }
            set { this._testRawDataPath = value; }
        }

        // Check to see if TestRawDataPath property is set
        internal bool IsSetTestRawDataPath()
        {
            return this._testRawDataPath != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteName. 
        /// <para>
        /// The name of the test suite that the test case is a part of.
        /// </para>
        /// </summary>
        public string TestSuiteName
        {
            get { return this._testSuiteName; }
            set { this._testSuiteName = value; }
        }

        // Check to see if TestSuiteName property is set
        internal bool IsSetTestSuiteName()
        {
            return this._testSuiteName != null;
        }

    }
}