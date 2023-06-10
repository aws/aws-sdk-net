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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// The error in server analysis.
    /// </summary>
    public partial class Result
    {
        private AnalysisStatusUnion _analysisStatus;
        private AnalysisType _analysisType;
        private List<AntipatternReportResult> _antipatternReportResultList = new List<AntipatternReportResult>();
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public AnalysisStatusUnion AnalysisStatus
        {
            get { return this._analysisStatus; }
            set { this._analysisStatus = value; }
        }

        // Check to see if AnalysisStatus property is set
        internal bool IsSetAnalysisStatus()
        {
            return this._analysisStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public AnalysisType AnalysisType
        {
            get { return this._analysisType; }
            set { this._analysisType = value; }
        }

        // Check to see if AnalysisType property is set
        internal bool IsSetAnalysisType()
        {
            return this._analysisType != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportResultList. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public List<AntipatternReportResult> AntipatternReportResultList
        {
            get { return this._antipatternReportResultList; }
            set { this._antipatternReportResultList = value; }
        }

        // Check to see if AntipatternReportResultList property is set
        internal bool IsSetAntipatternReportResultList()
        {
            return this._antipatternReportResultList != null && this._antipatternReportResultList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}