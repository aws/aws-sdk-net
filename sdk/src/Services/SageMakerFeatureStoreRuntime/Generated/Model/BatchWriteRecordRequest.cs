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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
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
namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the BatchWriteRecord operation.
    /// Writes a batch of <c>Records</c> to one or more <c>FeatureGroup</c>s. Use this API
    /// for bulk ingestion of records into the <c>OnlineStore</c> and <c>OfflineStore</c>.
    /// 
    ///  
    /// <para>
    /// You can set the ingested records to expire at a given time to live (TTL) duration
    /// after the record's event time by specifying the <c>TtlDuration</c> parameter. A request
    /// level <c>TtlDuration</c> applies to all entries that do not specify their own <c>TtlDuration</c>.
    /// </para>
    /// </summary>
    public partial class BatchWriteRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private List<BatchWriteRecordEntry> _entries = AWSConfigs.InitializeCollections ? new List<BatchWriteRecordEntry>() : null;
        private TtlDuration _ttlDuration;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// A list of records to write. Each entry specifies the <c>FeatureGroup</c>, the record
        /// data, and optionally target stores and a TTL duration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<BatchWriteRecordEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TtlDuration. 
        /// <para>
        /// Time to live duration applied to all entries in the batch that do not specify their
        /// own <c>TtlDuration</c>; <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>.
        /// For information on HardDelete, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html">DeleteRecord</a>
        /// API in the Amazon SageMaker API Reference guide.
        /// </para>
        /// </summary>
        public TtlDuration TtlDuration
        {
            get { return this._ttlDuration; }
            set { this._ttlDuration = value; }
        }

        // Check to see if TtlDuration property is set
        internal bool IsSetTtlDuration()
        {
            return this._ttlDuration != null;
        }

    }
}