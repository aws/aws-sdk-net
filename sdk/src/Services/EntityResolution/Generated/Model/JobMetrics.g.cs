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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object containing <c>inputRecords</c>, <c>totalRecordsProcessed</c>, <c>matchIDs</c>,
    /// and <c>recordsNotProcessed</c>.
    /// </summary>
    public partial class JobMetrics
    {
        /// <summary>
        /// Gets and sets the property DeleteRecordsProcessed. 
        /// <para>
        /// The number of records processed that were marked for deletion (<c>DELETE</c> = True)
        /// in the input file. This metric tracks records flagged for removal during the job execution.
        /// </para>
        /// </summary>
        public int? DeleteRecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRecordsProcessed property is set.
        /// </summary>
        internal bool IsSetDeleteRecordsProcessed() => this.DeleteRecordsProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property InputRecords. 
        /// <para>
        /// The total number of input records.
        /// </para>
        /// </summary>
        public int? InputRecords { get; set; }

        /// <summary>
        /// Checks to see if the InputRecords property is set.
        /// </summary>
        internal bool IsSetInputRecords() => this.InputRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MatchIDs. 
        /// <para>
        /// The total number of <c>matchID</c>s generated.
        /// </para>
        /// </summary>
        public int? MatchIDs { get; set; }

        /// <summary>
        /// Checks to see if the MatchIDs property is set.
        /// </summary>
        internal bool IsSetMatchIDs() => this.MatchIDs.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsNotProcessed. 
        /// <para>
        /// The total number of records that did not get processed.
        /// </para>
        /// </summary>
        public int? RecordsNotProcessed { get; set; }

        /// <summary>
        /// Checks to see if the RecordsNotProcessed property is set.
        /// </summary>
        internal bool IsSetRecordsNotProcessed() => this.RecordsNotProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRecordsProcessed. 
        /// <para>
        /// The total number of records processed.
        /// </para>
        /// </summary>
        public int? TotalRecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecordsProcessed property is set.
        /// </summary>
        internal bool IsSetTotalRecordsProcessed() => this.TotalRecordsProcessed.HasValue;
    }
}
