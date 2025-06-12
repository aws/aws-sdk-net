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
    /// Container for the parameters to the PutRecord operation.
    /// The <c>PutRecord</c> API is used to ingest a list of <c>Records</c> into your feature
    /// group. 
    /// 
    ///  
    /// <para>
    /// If a new record’s <c>EventTime</c> is greater, the new record is written to both the
    /// <c>OnlineStore</c> and <c>OfflineStore</c>. Otherwise, the record is a historic record
    /// and it is written only to the <c>OfflineStore</c>. 
    /// </para>
    ///  
    /// <para>
    /// You can specify the ingestion to be applied to the <c>OnlineStore</c>, <c>OfflineStore</c>,
    /// or both by using the <c>TargetStores</c> request parameter. 
    /// </para>
    ///  
    /// <para>
    /// You can set the ingested record to expire at a given time to live (TTL) duration after
    /// the record’s event time, <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>,
    /// by specifying the <c>TtlDuration</c> parameter. A record level <c>TtlDuration</c>
    /// is set when specifying the <c>TtlDuration</c> parameter using the <c>PutRecord</c>
    /// API call. If the input <c>TtlDuration</c> is <c>null</c> or unspecified, <c>TtlDuration</c>
    /// is set to the default feature group level <c>TtlDuration</c>. A record level <c>TtlDuration</c>
    /// supersedes the group level <c>TtlDuration</c>.
    /// </para>
    /// </summary>
    public partial class PutRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private string _featureGroupName;
        private List<FeatureValue> _record = AWSConfigs.InitializeCollections ? new List<FeatureValue>() : null;
        private List<string> _targetStores = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TtlDuration _ttlDuration;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group that you want to insert
        /// the record into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// List of FeatureValues to be inserted. This will be a full over-write. If you only
        /// want to update few of the feature values, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>GetRecord</c> to retrieve the latest record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the record returned from <c>GetRecord</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>PutRecord</c> to update feature values.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<FeatureValue> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && (this._record.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetStores. 
        /// <para>
        /// A list of stores to which you're adding the record. By default, Feature Store adds
        /// the record to all of the stores that you're using for the <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> TargetStores
        {
            get { return this._targetStores; }
            set { this._targetStores = value; }
        }

        // Check to see if TargetStores property is set
        internal bool IsSetTargetStores()
        {
            return this._targetStores != null && (this._targetStores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TtlDuration. 
        /// <para>
        /// Time to live duration, where the record is hard deleted after the expiration time
        /// is reached; <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>. For information
        /// on HardDelete, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html">DeleteRecord</a>
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