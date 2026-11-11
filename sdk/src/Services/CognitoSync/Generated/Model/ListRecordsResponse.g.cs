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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// This is the response object from the ListRecords operation.
    /// </summary>
    public partial class ListRecordsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Count. Total number of records.
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetDeletedAfterRequestedSyncCount. A boolean value
        /// specifying whether to delete the dataset locally.
        /// </summary>
        public bool? DatasetDeletedAfterRequestedSyncCount { get; set; }

        /// <summary>
        /// Checks to see if the DatasetDeletedAfterRequestedSyncCount property is set.
        /// </summary>
        internal bool IsSetDatasetDeletedAfterRequestedSyncCount() => this.DatasetDeletedAfterRequestedSyncCount.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetExists. Indicates whether the dataset exists.
        /// </summary>
        public bool? DatasetExists { get; set; }

        /// <summary>
        /// Checks to see if the DatasetExists property is set.
        /// </summary>
        internal bool IsSetDatasetExists() => this.DatasetExists.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetSyncCount. Server sync count for this dataset.
        /// </summary>
        public long? DatasetSyncCount { get; set; }

        /// <summary>
        /// Checks to see if the DatasetSyncCount property is set.
        /// </summary>
        internal bool IsSetDatasetSyncCount() => this.DatasetSyncCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. The user/device that made the last change
        /// to this record.
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property MergedDatasetNames. Names of merged datasets.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MergedDatasetNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MergedDatasetNames property is set.
        /// </summary>
        internal bool IsSetMergedDatasetNames() => this.MergedDatasetNames != null && (this.MergedDatasetNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. A pagination token for obtaining the next page
        /// of results.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Records. A list of all records.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Record> Records { get; set; } = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Checks to see if the Records property is set.
        /// </summary>
        internal bool IsSetRecords() => this.Records != null && (this.Records.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SyncSessionToken. A token containing a session ID, identity
        /// ID, and expiration.
        /// </summary>
        public string SyncSessionToken { get; set; }

        /// <summary>
        /// Checks to see if the SyncSessionToken property is set.
        /// </summary>
        internal bool IsSetSyncSessionToken() => this.SyncSessionToken != null;
    }
}
