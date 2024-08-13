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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Amazon Timestream endpoint.
    /// </summary>
    public partial class TimestreamSettings
    {
        private bool? _cdcInsertsAndUpdates;
        private string _databaseName;
        private bool? _enableMagneticStoreWrites;
        private int? _magneticDuration;
        private int? _memoryDuration;

        /// <summary>
        /// Gets and sets the property CdcInsertsAndUpdates. 
        /// <para>
        /// Set this attribute to <c>true</c> to specify that DMS only applies inserts and updates,
        /// and not deletes. Amazon Timestream does not allow deleting records, so if this value
        /// is <c>false</c>, DMS nulls out the corresponding record in the Timestream database
        /// rather than deleting it.
        /// </para>
        /// </summary>
        public bool? CdcInsertsAndUpdates
        {
            get { return this._cdcInsertsAndUpdates; }
            set { this._cdcInsertsAndUpdates = value; }
        }

        // Check to see if CdcInsertsAndUpdates property is set
        internal bool IsSetCdcInsertsAndUpdates()
        {
            return this._cdcInsertsAndUpdates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableMagneticStoreWrites. 
        /// <para>
        /// Set this attribute to <c>true</c> to enable memory store writes. When this value is
        /// <c>false</c>, DMS does not write records that are older in days than the value specified
        /// in <c>MagneticDuration</c>, because Amazon Timestream does not allow memory writes
        /// by default. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/storage.html">Storage</a>
        /// in the <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/">Amazon
        /// Timestream Developer Guide</a>.
        /// </para>
        /// </summary>
        public bool? EnableMagneticStoreWrites
        {
            get { return this._enableMagneticStoreWrites; }
            set { this._enableMagneticStoreWrites = value; }
        }

        // Check to see if EnableMagneticStoreWrites property is set
        internal bool IsSetEnableMagneticStoreWrites()
        {
            return this._enableMagneticStoreWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MagneticDuration. 
        /// <para>
        /// Set this attribute to specify the default magnetic duration applied to the Amazon
        /// Timestream tables in days. This is the number of days that records remain in magnetic
        /// store before being discarded. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/storage.html">Storage</a>
        /// in the <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/">Amazon
        /// Timestream Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MagneticDuration
        {
            get { return this._magneticDuration; }
            set { this._magneticDuration = value; }
        }

        // Check to see if MagneticDuration property is set
        internal bool IsSetMagneticDuration()
        {
            return this._magneticDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MemoryDuration. 
        /// <para>
        /// Set this attribute to specify the length of time to store all of the tables in memory
        /// that are migrated into Amazon Timestream from the source database. Time is measured
        /// in units of hours. When Timestream data comes in, it first resides in memory for the
        /// specified duration, which allows quick access to it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MemoryDuration
        {
            get { return this._memoryDuration; }
            set { this._memoryDuration = value; }
        }

        // Check to see if MemoryDuration property is set
        internal bool IsSetMemoryDuration()
        {
            return this._memoryDuration.HasValue; 
        }

    }
}