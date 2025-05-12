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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
    /// An object that contains metrics about an ID mapping job, including counts of input
    /// records, processed records, and mapped records between source and target identifiers.
    /// </summary>
    public partial class IdMappingJobMetrics
    {
        private int? _inputRecords;
        private int? _recordsNotProcessed;
        private int? _totalMappedRecords;
        private int? _totalMappedSourceRecords;
        private int? _totalMappedTargetRecords;
        private int? _totalRecordsProcessed;
        private int? _uniqueRecordsLoaded;

        /// <summary>
        /// Gets and sets the property InputRecords. 
        /// <para>
        /// The total number of records that were input for processing.
        /// </para>
        /// </summary>
        public int? InputRecords
        {
            get { return this._inputRecords; }
            set { this._inputRecords = value; }
        }

        // Check to see if InputRecords property is set
        internal bool IsSetInputRecords()
        {
            return this._inputRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsNotProcessed. 
        /// <para>
        /// The total number of records that did not get processed.
        /// </para>
        /// </summary>
        public int? RecordsNotProcessed
        {
            get { return this._recordsNotProcessed; }
            set { this._recordsNotProcessed = value; }
        }

        // Check to see if RecordsNotProcessed property is set
        internal bool IsSetRecordsNotProcessed()
        {
            return this._recordsNotProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMappedRecords. 
        /// <para>
        ///  The total number of records that were mapped.
        /// </para>
        /// </summary>
        public int? TotalMappedRecords
        {
            get { return this._totalMappedRecords; }
            set { this._totalMappedRecords = value; }
        }

        // Check to see if TotalMappedRecords property is set
        internal bool IsSetTotalMappedRecords()
        {
            return this._totalMappedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMappedSourceRecords. 
        /// <para>
        ///  The total number of mapped source records.
        /// </para>
        /// </summary>
        public int? TotalMappedSourceRecords
        {
            get { return this._totalMappedSourceRecords; }
            set { this._totalMappedSourceRecords = value; }
        }

        // Check to see if TotalMappedSourceRecords property is set
        internal bool IsSetTotalMappedSourceRecords()
        {
            return this._totalMappedSourceRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMappedTargetRecords. 
        /// <para>
        ///  The total number of distinct mapped target records.
        /// </para>
        /// </summary>
        public int? TotalMappedTargetRecords
        {
            get { return this._totalMappedTargetRecords; }
            set { this._totalMappedTargetRecords = value; }
        }

        // Check to see if TotalMappedTargetRecords property is set
        internal bool IsSetTotalMappedTargetRecords()
        {
            return this._totalMappedTargetRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalRecordsProcessed. 
        /// <para>
        /// The total number of records that were processed.
        /// </para>
        /// </summary>
        public int? TotalRecordsProcessed
        {
            get { return this._totalRecordsProcessed; }
            set { this._totalRecordsProcessed = value; }
        }

        // Check to see if TotalRecordsProcessed property is set
        internal bool IsSetTotalRecordsProcessed()
        {
            return this._totalRecordsProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UniqueRecordsLoaded. 
        /// <para>
        /// The number of records remaining after loading and aggregating duplicate records. Duplicates
        /// are determined by the field marked as UNIQUE_ID in your schema mapping - records sharing
        /// the same value in this field are considered duplicates. For example, if you specified
        /// "customer_id" as a UNIQUE_ID field and had three records with the same customer_id
        /// value, they would count as one unique record in this metric. 
        /// </para>
        /// </summary>
        public int? UniqueRecordsLoaded
        {
            get { return this._uniqueRecordsLoaded; }
            set { this._uniqueRecordsLoaded = value; }
        }

        // Check to see if UniqueRecordsLoaded property is set
        internal bool IsSetUniqueRecordsLoaded()
        {
            return this._uniqueRecordsLoaded.HasValue; 
        }

    }
}