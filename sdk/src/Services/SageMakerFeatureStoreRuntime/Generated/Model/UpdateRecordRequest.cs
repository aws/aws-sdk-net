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
    /// Container for the parameters to the UpdateRecord operation.
    /// Updates one or more feature values for an existing record in the specified feature
    /// group. Features that you do not include in the request remain unchanged. You can update
    /// up to 100 features per call.
    /// 
    ///  <important> 
    /// <para>
    /// This operation is available only for feature groups that use the <c>Standard_V2</c>
    /// or <c>InMemory</c> online store type.
    /// </para>
    ///  </important> 
    /// <para>
    /// The record must already exist. If the record does not exist or has been soft-deleted,
    /// the operation returns a <c>ResourceNotFound</c> error. To create a record, use <c>PutRecord</c>.
    /// </para>
    ///  
    /// <para>
    /// If you provide an <c>EventTime</c> that is older than the record's current <c>EventTime</c>,
    /// the service rejects the update with a <c>ConflictException</c>. If the <c>EventTime</c>
    /// is equal to or newer than the current value, the service applies the update. If you
    /// omit <c>EventTime</c>, the service keeps the record's existing <c>EventTime</c> and
    /// applies the update.
    /// </para>
    ///  
    /// <para>
    /// If you specify a <c>TtlDuration</c>, you must also provide an <c>EventTime</c> in
    /// the request. Otherwise, the operation returns a <c>ValidationError</c>.
    /// </para>
    /// </summary>
    public partial class UpdateRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private string _featureGroupName;
        private List<FeatureValue> _features = AWSConfigs.InitializeCollections ? new List<FeatureValue>() : null;
        private string _recordIdentifierValueAsString;
        private List<string> _targetStores = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TtlDuration _ttlDuration;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The identifier for the feature group that contains the record to update. You can specify
        /// one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The feature group name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The feature group Amazon Resource Name (ARN).
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Features. 
        /// <para>
        /// The feature values to write to the record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<FeatureValue> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value that uniquely identifies the record in the feature group. This must match
        /// the value defined by the feature group's record identifier feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=358400)]
        public string RecordIdentifierValueAsString
        {
            get { return this._recordIdentifierValueAsString; }
            set { this._recordIdentifierValueAsString = value; }
        }

        // Check to see if RecordIdentifierValueAsString property is set
        internal bool IsSetRecordIdentifierValueAsString()
        {
            return this._recordIdentifierValueAsString != null;
        }

        /// <summary>
        /// Gets and sets the property TargetStores. 
        /// <para>
        /// The target stores for the record update. By default, Amazon SageMaker Feature Store
        /// updates the record in all stores associated with the <c>FeatureGroup</c>.
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
        /// The time-to-live (TTL) duration for the record. Amazon SageMaker Feature Store deletes
        /// the record when <c>EventTime</c> + <c>TtlDuration</c> elapses. If you omit this parameter,
        /// the record's existing TTL setting remains unchanged. For information about <c>HardDelete</c>,
        /// see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html">DeleteRecord</a>
        /// operation in the Amazon SageMaker API Reference.
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