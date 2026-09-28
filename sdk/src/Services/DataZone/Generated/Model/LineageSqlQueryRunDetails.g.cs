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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The SQL query run details of a data lineage run.
    /// </summary>
    public partial class LineageSqlQueryRunDetails
    {
        /// <summary>
        /// Gets and sets the property ErrorMessages. 
        /// <para>
        /// The error message of the SQL query run details of a data lineage run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> ErrorMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ErrorMessages property is set.
        /// </summary>
        internal bool IsSetErrorMessages() => this.ErrorMessages != null && (this.ErrorMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumQueriesFailed. 
        /// <para>
        /// The number of queries that failed in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public int? NumQueriesFailed { get; set; }

        /// <summary>
        /// Checks to see if the NumQueriesFailed property is set.
        /// </summary>
        internal bool IsSetNumQueriesFailed() => this.NumQueriesFailed.HasValue;

        /// <summary>
        /// Gets and sets the property QueryEndTime. 
        /// <para>
        /// The query end time in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public DateTime? QueryEndTime { get; set; }

        /// <summary>
        /// Checks to see if the QueryEndTime property is set.
        /// </summary>
        internal bool IsSetQueryEndTime() => this.QueryEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryStartTime. 
        /// <para>
        /// The query start time in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public DateTime? QueryStartTime { get; set; }

        /// <summary>
        /// Checks to see if the QueryStartTime property is set.
        /// </summary>
        internal bool IsSetQueryStartTime() => this.QueryStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TotalQueriesProcessed. 
        /// <para>
        /// The total queries processed in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public int? TotalQueriesProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalQueriesProcessed property is set.
        /// </summary>
        internal bool IsSetTotalQueriesProcessed() => this.TotalQueriesProcessed.HasValue;
    }
}
