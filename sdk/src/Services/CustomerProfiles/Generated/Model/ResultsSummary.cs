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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The summary of results for an upload job, including the number of updated, created,
    /// and failed records.
    /// </summary>
    public partial class ResultsSummary
    {
        private long? _createdRecords;
        private long? _failedRecords;
        private long? _updatedRecords;

        /// <summary>
        /// Gets and sets the property CreatedRecords. 
        /// <para>
        /// The number of records that were newly created during the upload job. 
        /// </para>
        /// </summary>
        public long? CreatedRecords
        {
            get { return this._createdRecords; }
            set { this._createdRecords = value; }
        }

        // Check to see if CreatedRecords property is set
        internal bool IsSetCreatedRecords()
        {
            return this._createdRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedRecords. 
        /// <para>
        /// The number of records that failed to be processed during the upload job. 
        /// </para>
        /// </summary>
        public long? FailedRecords
        {
            get { return this._failedRecords; }
            set { this._failedRecords = value; }
        }

        // Check to see if FailedRecords property is set
        internal bool IsSetFailedRecords()
        {
            return this._failedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedRecords. 
        /// <para>
        /// The number of records that were updated during the upload job. 
        /// </para>
        /// </summary>
        public long? UpdatedRecords
        {
            get { return this._updatedRecords; }
            set { this._updatedRecords = value; }
        }

        // Check to see if UpdatedRecords property is set
        internal bool IsSetUpdatedRecords()
        {
            return this._updatedRecords.HasValue; 
        }

    }
}