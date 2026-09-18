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
    /// An object that contains metrics about an ID mapping job, including counts of input
    /// records, processed records, and mapped records between source and target identifiers.
    /// </summary>
    public partial class IdMappingJobMetrics
    {
        /// <summary>
        /// Gets and sets the property DeleteRecordsProcessed. 
        /// <para>
        /// The number of records processed that were marked for deletion in the input file using
        /// the DELETE schema mapping field. These are the records to be removed from the ID mapping
        /// table.
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
        /// The total number of records that were input for processing.
        /// </para>
        /// </summary>
        public int? InputRecords { get; set; }

        /// <summary>
        /// Checks to see if the InputRecords property is set.
        /// </summary>
        internal bool IsSetInputRecords() => this.InputRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MappedRecordsRemoved. 
        /// <para>
        ///  The number of mapped records removed.
        /// </para>
        /// </summary>
        public int? MappedRecordsRemoved { get; set; }

        /// <summary>
        /// Checks to see if the MappedRecordsRemoved property is set.
        /// </summary>
        internal bool IsSetMappedRecordsRemoved() => this.MappedRecordsRemoved.HasValue;

        /// <summary>
        /// Gets and sets the property MappedSourceRecordsRemoved. 
        /// <para>
        ///  The number of source records removed due to ID mapping.
        /// </para>
        /// </summary>
        public int? MappedSourceRecordsRemoved { get; set; }

        /// <summary>
        /// Checks to see if the MappedSourceRecordsRemoved property is set.
        /// </summary>
        internal bool IsSetMappedSourceRecordsRemoved() => this.MappedSourceRecordsRemoved.HasValue;

        /// <summary>
        /// Gets and sets the property MappedTargetRecordsRemoved. 
        /// <para>
        ///  The number of mapped target records removed.
        /// </para>
        /// </summary>
        public int? MappedTargetRecordsRemoved { get; set; }

        /// <summary>
        /// Checks to see if the MappedTargetRecordsRemoved property is set.
        /// </summary>
        internal bool IsSetMappedTargetRecordsRemoved() => this.MappedTargetRecordsRemoved.HasValue;

        /// <summary>
        /// Gets and sets the property NewMappedRecords. 
        /// <para>
        ///  The number of new mapped records.
        /// </para>
        /// </summary>
        public int? NewMappedRecords { get; set; }

        /// <summary>
        /// Checks to see if the NewMappedRecords property is set.
        /// </summary>
        internal bool IsSetNewMappedRecords() => this.NewMappedRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NewMappedSourceRecords. 
        /// <para>
        ///  The number of new source records mapped.
        /// </para>
        /// </summary>
        public int? NewMappedSourceRecords { get; set; }

        /// <summary>
        /// Checks to see if the NewMappedSourceRecords property is set.
        /// </summary>
        internal bool IsSetNewMappedSourceRecords() => this.NewMappedSourceRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NewMappedTargetRecords. 
        /// <para>
        ///  The number of new mapped target records.
        /// </para>
        /// </summary>
        public int? NewMappedTargetRecords { get; set; }

        /// <summary>
        /// Checks to see if the NewMappedTargetRecords property is set.
        /// </summary>
        internal bool IsSetNewMappedTargetRecords() => this.NewMappedTargetRecords.HasValue;

        /// <summary>
        /// Gets and sets the property NewUniqueRecordsLoaded. 
        /// <para>
        /// The number of new unique records processed in the current job run, after removing
        /// duplicates. This metric excludes deletion-related records. Duplicates are determined
        /// by the field marked as UNIQUE_ID in your schema mapping. Records sharing the same
        /// value in this field are considered duplicates. For example, if your current run processes
        /// five new records with the same UNIQUE_ID value, they would count as one new unique
        /// record in this metric.
        /// </para>
        /// </summary>
        public int? NewUniqueRecordsLoaded { get; set; }

        /// <summary>
        /// Checks to see if the NewUniqueRecordsLoaded property is set.
        /// </summary>
        internal bool IsSetNewUniqueRecordsLoaded() => this.NewUniqueRecordsLoaded.HasValue;

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
        /// Gets and sets the property TotalMappedRecords. 
        /// <para>
        ///  The total number of records that were mapped.
        /// </para>
        /// </summary>
        public int? TotalMappedRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalMappedRecords property is set.
        /// </summary>
        internal bool IsSetTotalMappedRecords() => this.TotalMappedRecords.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMappedSourceRecords. 
        /// <para>
        ///  The total number of mapped source records.
        /// </para>
        /// </summary>
        public int? TotalMappedSourceRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalMappedSourceRecords property is set.
        /// </summary>
        internal bool IsSetTotalMappedSourceRecords() => this.TotalMappedSourceRecords.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMappedTargetRecords. 
        /// <para>
        ///  The total number of distinct mapped target records.
        /// </para>
        /// </summary>
        public int? TotalMappedTargetRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalMappedTargetRecords property is set.
        /// </summary>
        internal bool IsSetTotalMappedTargetRecords() => this.TotalMappedTargetRecords.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRecordsProcessed. 
        /// <para>
        /// The total number of records that were processed.
        /// </para>
        /// </summary>
        public int? TotalRecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecordsProcessed property is set.
        /// </summary>
        internal bool IsSetTotalRecordsProcessed() => this.TotalRecordsProcessed.HasValue;

        /// <summary>
        /// Gets and sets the property UniqueRecordsLoaded. 
        /// <para>
        /// The number of de-duplicated processed records across all runs, excluding deletion-related
        /// records. Duplicates are determined by the field marked as UNIQUE_ID in your schema
        /// mapping. Records sharing the same value in this field are considered duplicates. For
        /// example, if you specified "customer_id" as a UNIQUE_ID field and had three records
        /// with the same customer_id value, they would count as one unique record in this metric.
        /// 
        /// </para>
        /// </summary>
        public int? UniqueRecordsLoaded { get; set; }

        /// <summary>
        /// Checks to see if the UniqueRecordsLoaded property is set.
        /// </summary>
        internal bool IsSetUniqueRecordsLoaded() => this.UniqueRecordsLoaded.HasValue;
    }
}
