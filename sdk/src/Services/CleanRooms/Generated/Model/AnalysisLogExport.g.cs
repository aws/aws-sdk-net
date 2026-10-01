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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// An export of the redacted Apache Spark logs for a protected query.
    /// </summary>
    public partial class AnalysisLogExport
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The unique identifier of the protected query that the analysis logs were exported
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property AnalysisLogExportId. 
        /// <para>
        /// The unique identifier of the analysis log export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AnalysisLogExportId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisLogExportId property is set.
        /// </summary>
        internal bool IsSetAnalysisLogExportId() => this.AnalysisLogExportId != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The type of analysis that the logs were exported for. Currently, only <c>PROTECTED_QUERY</c>
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogExportAnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the analysis log export was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The analysis log export error. This is present only when the export <c>status</c>
        /// is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public AnalysisLogExportError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique identifier of the membership that the analysis log export belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// Contains the details needed to write the exported analysis logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisLogExportResultConfiguration ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

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
        ///  <c>FAILED</c> – The export failed. See the <c>error</c> field for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisLogExportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the analysis log export was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
