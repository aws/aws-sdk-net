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
    /// Information about a test report.
    /// </summary>
    public partial class TestReportSummary
    {
        private long? _durationInNanoSeconds;
        private Dictionary<string, int> _statusCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private int? _total;

        /// <summary>
        /// Gets and sets the property DurationInNanoSeconds. 
        /// <para>
        ///  The number of nanoseconds it took to run all of the test cases in this report. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusCounts. 
        /// <para>
        ///  A map that contains the number of each type of status returned by the test results
        /// in this <c>TestReportSummary</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, int> StatusCounts
        {
            get { return this._statusCounts; }
            set { this._statusCounts = value; }
        }

        // Check to see if StatusCounts property is set
        internal bool IsSetStatusCounts()
        {
            return this._statusCounts != null && (this._statusCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        ///  The number of test cases in this <c>TestReportSummary</c>. The total includes truncated
        /// test cases. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}