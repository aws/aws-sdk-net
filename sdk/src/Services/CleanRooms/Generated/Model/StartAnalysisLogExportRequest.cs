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
    /// Container for the parameters to the StartAnalysisLogExport operation.
    /// Starts an export of the Apache Spark logs for a protected query to an Amazon S3 bucket
    /// that you own. Use the exported logs to diagnose a query that failed or that ran more
    /// slowly than you expected.
    /// 
    ///  
    /// <para>
    /// Clean Rooms exports a redacted copy of the Spark logs instead of the raw logs. Analyze
    /// the exported logs with the tooling of your choice, such as Spark History Server. For
    /// details about what the exported logs contain, see <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/export-analysis-logs-contents.html">https://docs.aws.amazon.com/clean-rooms/latest/userguide/export-analysis-logs-contents.html</a>.
    /// </para>
    ///  
    /// <para>
    /// The export runs asynchronously and returns with a <c>status</c> of <c>IN_PROGRESS</c>.
    /// Call <c>GetAnalysisLogExport</c> to poll for the final status.
    /// </para>
    ///  <important> 
    /// <para>
    /// To use this operation, you must have the <c>CAN_EXPORT_QUERY_ANALYSIS_LOG</c> ability
    /// for your membership. You must also be the query runner or the query payer. Having
    /// the ability alone is not sufficient.
    /// </para>
    ///  
    /// <para>
    /// The query must have reached a terminal state, and it must have reached the execution
    /// stage. A query that failed validation or that was canceled before it started produces
    /// no Spark logs.
    /// </para>
    ///  
    /// <para>
    /// Log export isn't supported for queries that use differential privacy, and isn't supported
    /// for PySpark jobs.
    /// </para>
    ///  
    /// <para>
    /// The destination bucket must be in the same Amazon Web Services Region as the collaboration.
    /// Cross-Region export isn't supported.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/export-analysis-logs.html">https://docs.aws.amazon.com/clean-rooms/latest/userguide/export-analysis-logs.html</a>.
    /// </para>
    /// </summary>
    public partial class StartAnalysisLogExportRequest : AmazonCleanRoomsRequest
    {
        private string _analysisId;
        private LogExportAnalysisType _analysisType;
        private string _membershipIdentifier;
        private AnalysisLogExportResultConfiguration _resultConfiguration;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The unique identifier of the protected query that you want to export the analysis
        /// logs for.
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
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis that the logs are exported for. Currently, only <c>PROTECTED_QUERY</c>
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
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to export the analysis logs for. Currently
        /// accepts a membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The details needed to write the exported analysis logs.
        /// </para>
        ///  
        /// <para>
        /// You don't need to create an IAM role for log export. Clean Rooms writes the exported
        /// logs using your own identity, so Clean Rooms writes the exported logs only where your
        /// existing permissions allow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalysisLogExportResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

    }
}