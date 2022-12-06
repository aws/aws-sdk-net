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

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the PutRecord operation.
    /// Used for data ingestion into the <code>FeatureStore</code>. The <code>PutRecord</code>
    /// API writes to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
    /// the record is the latest record for the <code>recordIdentifier</code>, the record
    /// is written to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
    /// the record is a historic record, it is written only to the <code>OfflineStore</code>.
    /// </summary>
    public partial class PutRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private string _featureGroupName;
        private List<FeatureValue> _record = new List<FeatureValue>();
        private List<string> _targetStores = new List<string>();

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the feature group that you want to insert the record into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Use <code>GetRecord</code> to retrieve the latest record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the record returned from <code>GetRecord</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <code>PutRecord</code> to update feature values.
        /// </para>
        ///  </li> </ul>
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
            return this._record != null && this._record.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetStores. 
        /// <para>
        /// A list of stores to which you're adding the record. By default, Feature Store adds
        /// the record to all of the stores that you're using for the <code>FeatureGroup</code>.
        /// </para>
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
            return this._targetStores != null && this._targetStores.Count > 0; 
        }

    }
}