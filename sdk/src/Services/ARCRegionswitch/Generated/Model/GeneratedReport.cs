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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Information about a generated execution report.
    /// </summary>
    public partial class GeneratedReport
    {
        private DateTime? _reportGenerationTime;
        private ReportOutput _reportOutput;

        /// <summary>
        /// Gets and sets the property ReportGenerationTime. 
        /// <para>
        /// The timestamp when the report was generated.
        /// </para>
        /// </summary>
        public DateTime ReportGenerationTime
        {
            get { return this._reportGenerationTime.GetValueOrDefault(); }
            set { this._reportGenerationTime = value; }
        }

        // Check to see if ReportGenerationTime property is set
        internal bool IsSetReportGenerationTime()
        {
            return this._reportGenerationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportOutput. 
        /// <para>
        /// The output location or cause of a failure in report generation.
        /// </para>
        /// </summary>
        public ReportOutput ReportOutput
        {
            get { return this._reportOutput; }
            set { this._reportOutput = value; }
        }

        // Check to see if ReportOutput property is set
        internal bool IsSetReportOutput()
        {
            return this._reportOutput != null;
        }

    }
}