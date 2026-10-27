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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a test case created using a framework such as NUnit or Cucumber.
    /// A test case might be a unit test or a configuration test.
    /// </summary>
    public partial class TestCase
    {
        /// <summary>
        /// Gets and sets the property DurationInNanoSeconds. 
        /// <para>
        ///  The number of nanoseconds it took to run this test case. 
        /// </para>
        /// </summary>
        public long? DurationInNanoSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInNanoSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInNanoSeconds() => this.DurationInNanoSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Expired. 
        /// <para>
        ///  The date and time a test case expires. A test case expires 30 days after it is created.
        /// An expired test case is not available to view in CodeBuild. 
        /// </para>
        /// </summary>
        public DateTime? Expired { get; set; }

        /// <summary>
        /// Checks to see if the Expired property is set.
        /// </summary>
        internal bool IsSetExpired() => this.Expired.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  A message associated with a test case. For example, an error message or stack trace.
        /// 
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the test case. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        ///  A string that is applied to a series of related test cases. CodeBuild generates the
        /// prefix. The prefix depends on the framework used to generate the tests. 
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property ReportArn. 
        /// <para>
        ///  The ARN of the report to which the test case belongs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ReportArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportArn property is set.
        /// </summary>
        internal bool IsSetReportArn() => this.ReportArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status returned by the test case after it was run. Valid statuses are <c>SUCCEEDED</c>,
        /// <c>FAILED</c>, <c>ERROR</c>, <c>SKIPPED</c>, and <c>UNKNOWN</c>. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestRawDataPath. 
        /// <para>
        ///  The path to the raw data file that contains the test result. 
        /// </para>
        /// </summary>
        public string TestRawDataPath { get; set; }

        /// <summary>
        /// Checks to see if the TestRawDataPath property is set.
        /// </summary>
        internal bool IsSetTestRawDataPath() => this.TestRawDataPath != null;

        /// <summary>
        /// Gets and sets the property TestSuiteName. 
        /// <para>
        /// The name of the test suite that the test case is a part of.
        /// </para>
        /// </summary>
        public string TestSuiteName { get; set; }

        /// <summary>
        /// Checks to see if the TestSuiteName property is set.
        /// </summary>
        internal bool IsSetTestSuiteName() => this.TestSuiteName != null;
    }
}
