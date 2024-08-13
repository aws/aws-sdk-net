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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Statistics about the execution of an export job.
    /// </summary>
    public partial class ExportStatistics
    {
        private int? _exportedRecordsCount;
        private int? _processedRecordsCount;

        /// <summary>
        /// Gets and sets the property ExportedRecordsCount. 
        /// <para>
        /// The number of records that were exported to the final export file.
        /// </para>
        ///  
        /// <para>
        /// This value might not be available for all export source types
        /// </para>
        /// </summary>
        public int? ExportedRecordsCount
        {
            get { return this._exportedRecordsCount; }
            set { this._exportedRecordsCount = value; }
        }

        // Check to see if ExportedRecordsCount property is set
        internal bool IsSetExportedRecordsCount()
        {
            return this._exportedRecordsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessedRecordsCount. 
        /// <para>
        /// The number of records that were processed to generate the final export file.
        /// </para>
        /// </summary>
        public int? ProcessedRecordsCount
        {
            get { return this._processedRecordsCount; }
            set { this._processedRecordsCount = value; }
        }

        // Check to see if ProcessedRecordsCount property is set
        internal bool IsSetProcessedRecordsCount()
        {
            return this._processedRecordsCount.HasValue; 
        }

    }
}