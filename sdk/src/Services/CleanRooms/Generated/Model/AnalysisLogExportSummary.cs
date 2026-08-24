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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A summary of an analysis log export, including its identifier, status, analysis type,
    /// and creation time. Returned by <c>ListAnalysisLogExports</c>.
    /// </summary>
    public partial class AnalysisLogExportSummary
    {
        private string _analysisId;
        private string _analysisLogExportId;
        private LogExportAnalysisType _analysisType;
        private DateTime? _createTime;
        private AnalysisLogExportStatus _status;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The unique identifier of the protected query that the analysis logs were exported
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisLogExportId. 
        /// <para>
        /// The unique identifier of the analysis log export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnalysisLogExportId
        {
            get { return this._analysisLogExportId; }
            set { this._analysisLogExportId = value; }
        }

        // Check to see if AnalysisLogExportId property is set
        internal bool IsSetAnalysisLogExportId()
        {
            return this._analysisLogExportId != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis that the logs were exported for. Currently, only <c>PROTECTED_QUERY</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogExportAnalysisType AnalysisType
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the analysis log export was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analysis log export. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> – The export is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The export completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The export failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisLogExportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}