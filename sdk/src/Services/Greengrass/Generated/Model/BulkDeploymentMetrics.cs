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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Relevant metrics on input records processed during bulk deployment.
    /// </summary>
    public partial class BulkDeploymentMetrics
    {
        private int? _invalidInputRecords;
        private int? _recordsProcessed;
        private int? _retryAttempts;

        /// <summary>
        /// Gets and sets the property InvalidInputRecords. The total number of records that returned
        /// a non-retryable error. For example, this can occur if a group record from the input
        /// file uses an invalid format or specifies a nonexistent group version, or if the execution
        /// role doesn't grant permission to deploy a group or group version.
        /// </summary>
        public int? InvalidInputRecords
        {
            get { return this._invalidInputRecords; }
            set { this._invalidInputRecords = value; }
        }

        // Check to see if InvalidInputRecords property is set
        internal bool IsSetInvalidInputRecords()
        {
            return this._invalidInputRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsProcessed. The total number of group records from
        /// the input file that have been processed so far, or attempted.
        /// </summary>
        public int? RecordsProcessed
        {
            get { return this._recordsProcessed; }
            set { this._recordsProcessed = value; }
        }

        // Check to see if RecordsProcessed property is set
        internal bool IsSetRecordsProcessed()
        {
            return this._recordsProcessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryAttempts. The total number of deployment attempts
        /// that returned a retryable error. For example, a retry is triggered if the attempt
        /// to deploy a group returns a throttling error. ''StartBulkDeployment'' retries a group
        /// deployment up to five times.
        /// </summary>
        public int? RetryAttempts
        {
            get { return this._retryAttempts; }
            set { this._retryAttempts = value; }
        }

        // Check to see if RetryAttempts property is set
        internal bool IsSetRetryAttempts()
        {
            return this._retryAttempts.HasValue; 
        }

    }
}