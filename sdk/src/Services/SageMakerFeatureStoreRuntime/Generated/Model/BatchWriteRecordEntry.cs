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
    /// An entry to write as part of a <c>BatchWriteRecord</c> request.
    /// </summary>
    public partial class BatchWriteRecordEntry
    {
        private string _featureGroupName;
        private List<FeatureValue> _record = AWSConfigs.InitializeCollections ? new List<FeatureValue>() : null;
        private List<string> _targetStores = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TtlDuration _ttlDuration;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the <c>FeatureGroup</c> to write the record
        /// to.
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
        /// List of FeatureValues to be inserted. This will be a full over-write.
        /// </para>
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
        /// Time to live duration for this entry, where the record is hard deleted after the expiration
        /// time is reached; <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>. This overrides
        /// the request level <c>TtlDuration</c>.
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