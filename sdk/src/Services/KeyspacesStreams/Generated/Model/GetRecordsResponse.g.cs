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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// This is the response object from the GetRecords operation.
    /// </summary>
    public partial class GetRecordsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeRecords. 
        /// <para>
        ///  An array of change data records retrieved from the specified shard. Each record represents
        /// a single data modification (insert, update, or delete) to a row in the Amazon Keyspaces
        /// table. Records include the primary key columns and information about what data was
        /// modified. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Record> ChangeRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<Record>() : null;

        /// <summary>
        /// Checks to see if the ChangeRecords property is set.
        /// </summary>
        internal bool IsSetChangeRecords() => this.ChangeRecords != null && (this.ChangeRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IteratorDescription. 
        /// <para>
        ///  Provides information about the current iterator at the time GetRecords request was
        /// processed by Keyspaces. 
        /// </para>
        /// </summary>
        public IteratorDescription IteratorDescription { get; set; }

        /// <summary>
        /// Checks to see if the IteratorDescription property is set.
        /// </summary>
        internal bool IsSetIteratorDescription() => this.IteratorDescription != null;

        /// <summary>
        /// Gets and sets the property NextShardIterator. 
        /// <para>
        ///  The next position in the shard from which to start sequentially reading data records.
        /// If null, the shard has been closed and the requested iterator will not return any
        /// more data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextShardIterator { get; set; }

        /// <summary>
        /// Checks to see if the NextShardIterator property is set.
        /// </summary>
        internal bool IsSetNextShardIterator() => this.NextShardIterator != null;
    }
}
