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
    /// The anti-pattern report result.
    /// </summary>
    public partial class AntipatternReportResult
    {
        private AnalyzerNameUnion _analyzerName;
        private S3Object _antiPatternReportS3Object;
        private AntipatternReportStatus _antipatternReportStatus;
        private string _antipatternReportStatusMessage;

        /// <summary>
        /// Gets and sets the property AnalyzerName. 
        /// <para>
        /// The analyzer name.
        /// </para>
        /// </summary>
        public AnalyzerNameUnion AnalyzerName
        {
            get { return this._analyzerName; }
            set { this._analyzerName = value; }
        }

        // Check to see if AnalyzerName property is set
        internal bool IsSetAnalyzerName()
        {
            return this._analyzerName != null;
        }

        /// <summary>
        /// Gets and sets the property AntiPatternReportS3Object.
        /// </summary>
        public S3Object AntiPatternReportS3Object
        {
            get { return this._antiPatternReportS3Object; }
            set { this._antiPatternReportS3Object = value; }
        }

        // Check to see if AntiPatternReportS3Object property is set
        internal bool IsSetAntiPatternReportS3Object()
        {
            return this._antiPatternReportS3Object != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportStatus. 
        /// <para>
        /// The status of the anti-pattern report generation.
        /// </para>
        /// </summary>
        public AntipatternReportStatus AntipatternReportStatus
        {
            get { return this._antipatternReportStatus; }
            set { this._antipatternReportStatus = value; }
        }

        // Check to see if AntipatternReportStatus property is set
        internal bool IsSetAntipatternReportStatus()
        {
            return this._antipatternReportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportStatusMessage. 
        /// <para>
        /// The status message for the anti-pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AntipatternReportStatusMessage
        {
            get { return this._antipatternReportStatusMessage; }
            set { this._antipatternReportStatusMessage = value; }
        }

        // Check to see if AntipatternReportStatusMessage property is set
        internal bool IsSetAntipatternReportStatusMessage()
        {
            return this._antipatternReportStatusMessage != null;
        }

    }
}