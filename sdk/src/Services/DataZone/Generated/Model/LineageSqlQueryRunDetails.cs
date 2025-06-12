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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private List<string> _errorMessages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _numQueriesFailed;
        private DateTime? _queryEndTime;
        private DateTime? _queryStartTime;
        private int? _totalQueriesProcessed;

        /// <summary>
        /// Gets and sets the property ErrorMessages. 
        /// <para>
        /// The error message of the SQL query run details of a data lineage run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ErrorMessages
        {
            get { return this._errorMessages; }
            set { this._errorMessages = value; }
        }

        // Check to see if ErrorMessages property is set
        internal bool IsSetErrorMessages()
        {
            return this._errorMessages != null && (this._errorMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumQueriesFailed. 
        /// <para>
        /// The number of queries that failed in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public int? NumQueriesFailed
        {
            get { return this._numQueriesFailed; }
            set { this._numQueriesFailed = value; }
        }

        // Check to see if NumQueriesFailed property is set
        internal bool IsSetNumQueriesFailed()
        {
            return this._numQueriesFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryEndTime. 
        /// <para>
        /// The query end time in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public DateTime? QueryEndTime
        {
            get { return this._queryEndTime; }
            set { this._queryEndTime = value; }
        }

        // Check to see if QueryEndTime property is set
        internal bool IsSetQueryEndTime()
        {
            return this._queryEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryStartTime. 
        /// <para>
        /// The query start time in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public DateTime? QueryStartTime
        {
            get { return this._queryStartTime; }
            set { this._queryStartTime = value; }
        }

        // Check to see if QueryStartTime property is set
        internal bool IsSetQueryStartTime()
        {
            return this._queryStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalQueriesProcessed. 
        /// <para>
        /// The total queries processed in the SQL query run details of a data lineage run.
        /// </para>
        /// </summary>
        public int? TotalQueriesProcessed
        {
            get { return this._totalQueriesProcessed; }
            set { this._totalQueriesProcessed = value; }
        }

        // Check to see if TotalQueriesProcessed property is set
        internal bool IsSetTotalQueriesProcessed()
        {
            return this._totalQueriesProcessed.HasValue; 
        }

    }
}