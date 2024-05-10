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
    /// This is the response object from the CreatePerformanceAnalysisReport operation.
    /// </summary>
    public partial class CreatePerformanceAnalysisReportResponse : AmazonWebServiceResponse
    {
        private string _analysisReportId;

        /// <summary>
        /// Gets and sets the property AnalysisReportId. 
        /// <para>
        /// A unique identifier for the created analysis report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AnalysisReportId
        {
            get { return this._analysisReportId; }
            set { this._analysisReportId = value; }
        }

        // Check to see if AnalysisReportId property is set
        internal bool IsSetAnalysisReportId()
        {
            return this._analysisReportId != null;
        }

    }
}