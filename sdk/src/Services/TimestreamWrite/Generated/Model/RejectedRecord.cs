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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Represents records that were not successfully inserted into Timestream due to data
    /// validation issues that must be resolved before reinserting time-series data into the
    /// system.
    /// </summary>
    public partial class RejectedRecord
    {
        private long? _existingVersion;
        private string _reason;
        private int? _recordIndex;

        /// <summary>
        /// Gets and sets the property ExistingVersion. 
        /// <para>
        /// The existing version of the record. This value is populated in scenarios where an
        /// identical record exists with a higher version than the version in the write request.
        /// </para>
        /// </summary>
        public long ExistingVersion
        {
            get { return this._existingVersion.GetValueOrDefault(); }
            set { this._existingVersion = value; }
        }

        // Check to see if ExistingVersion property is set
        internal bool IsSetExistingVersion()
        {
            return this._existingVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        ///  The reason why a record was not successfully inserted into Timestream. Possible causes
        /// of failure include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Measure values are different
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version is not present in the request, <i>or</i> the value of version in the new record
        /// is equal to or lower than the existing value
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If Timestream rejects data for this case, the <code>ExistingVersion</code> field in
        /// the <code>RejectedRecords</code> response will indicate the current record’s version.
        /// To force an update, you can resend the request with a version for the record set to
        /// a value greater than the <code>ExistingVersion</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// When the retention window is updated, you will receive a <code>RejectedRecords</code>
        /// exception if you immediately try to ingest data within the new window. To avoid a
        /// <code>RejectedRecords</code> exception, wait until the duration of the new window
        /// to ingest new data. For further information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/best-practices.html#configuration">
        /// Best Practices for Configuring Timestream</a> and <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/storage.html">the
        /// explanation of how storage works in Timestream</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide. 
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RecordIndex. 
        /// <para>
        ///  The index of the record in the input request for WriteRecords. Indexes begin with
        /// 0. 
        /// </para>
        /// </summary>
        public int RecordIndex
        {
            get { return this._recordIndex.GetValueOrDefault(); }
            set { this._recordIndex = value; }
        }

        // Check to see if RecordIndex property is set
        internal bool IsSetRecordIndex()
        {
            return this._recordIndex.HasValue; 
        }

    }
}