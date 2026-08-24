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
    /// Contains aggregated test-level metrics for a job.
    /// </summary>
    public partial class TestReport
    {
        private string _message;
        private TestReportMetrics _metrics;
        private string _testDetailsUrl;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message associated with the test report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The aggregated test-level metrics for the job.
        /// </para>
        /// </summary>
        public TestReportMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property TestDetailsUrl. 
        /// <para>
        /// A URL to the detailed test results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string TestDetailsUrl
        {
            get { return this._testDetailsUrl; }
            set { this._testDetailsUrl = value; }
        }

        // Check to see if TestDetailsUrl property is set
        internal bool IsSetTestDetailsUrl()
        {
            return this._testDetailsUrl != null;
        }

    }
}