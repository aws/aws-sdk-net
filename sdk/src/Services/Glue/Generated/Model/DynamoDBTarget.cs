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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an Amazon DynamoDB table to crawl.
    /// </summary>
    public partial class DynamoDBTarget
    {
        private string _path;
        private bool? _scanAll;
        private double? _scanRate;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The name of the DynamoDB table to crawl.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ScanAll. 
        /// <para>
        /// Indicates whether to scan all the records, or to sample rows from the table. Scanning
        /// all the records can take a long time when the table is not a high throughput table.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>true</c> means to scan all records, while a value of <c>false</c> means
        /// to sample the records. If no value is specified, the value defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ScanAll
        {
            get { return this._scanAll; }
            set { this._scanAll = value; }
        }

        // Check to see if ScanAll property is set
        internal bool IsSetScanAll()
        {
            return this._scanAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanRate. 
        /// <para>
        /// The percentage of the configured read capacity units to use by the Glue crawler. Read
        /// capacity units is a term defined by DynamoDB, and is a numeric value that acts as
        /// rate limiter for the number of reads that can be performed on that table per second.
        /// </para>
        ///  
        /// <para>
        /// The valid values are null or a value between 0.1 to 1.5. A null value is used when
        /// user does not provide a value, and defaults to 0.5 of the configured Read Capacity
        /// Unit (for provisioned tables), or 0.25 of the max configured Read Capacity Unit (for
        /// tables using on-demand mode).
        /// </para>
        /// </summary>
        public double? ScanRate
        {
            get { return this._scanRate; }
            set { this._scanRate = value; }
        }

        // Check to see if ScanRate property is set
        internal bool IsSetScanRate()
        {
            return this._scanRate.HasValue; 
        }

    }
}