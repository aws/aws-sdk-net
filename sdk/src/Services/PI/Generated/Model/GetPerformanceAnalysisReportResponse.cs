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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the GetPerformanceAnalysisReport operation.
    /// </summary>
    public partial class GetPerformanceAnalysisReportResponse : AmazonWebServiceResponse
    {
        private AnalysisReport _analysisReport;

        /// <summary>
        /// Gets and sets the property AnalysisReport. 
        /// <para>
        /// The summary of the performance analysis report created for a time period.
        /// </para>
        /// </summary>
        public AnalysisReport AnalysisReport
        {
            get { return this._analysisReport; }
            set { this._analysisReport = value; }
        }

        // Check to see if AnalysisReport property is set
        internal bool IsSetAnalysisReport()
        {
            return this._analysisReport != null;
        }

    }
}