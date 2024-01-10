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
    /// Container for the parameters to the DeleteRecord operation.
    /// Deletes a <c>Record</c> from a <c>FeatureGroup</c> in the <c>OnlineStore</c>. Feature
    /// Store supports both <c>SoftDelete</c> and <c>HardDelete</c>. For <c>SoftDelete</c>
    /// (default), feature columns are set to <c>null</c> and the record is no longer retrievable
    /// by <c>GetRecord</c> or <c>BatchGetRecord</c>. For <c>HardDelete</c>, the complete
    /// <c>Record</c> is removed from the <c>OnlineStore</c>. In both cases, Feature Store
    /// appends the deleted record marker to the <c>OfflineStore</c> with feature values set
    /// to <c>null</c>, <c>is_deleted</c> value set to <c>True</c>, and <c>EventTime</c> set
    /// to the delete input <c>EventTime</c>.
    /// 
    ///  
    /// <para>
    /// Note that the <c>EventTime</c> specified in <c>DeleteRecord</c> should be set later
    /// than the <c>EventTime</c> of the existing record in the <c>OnlineStore</c> for that
    /// <c>RecordIdentifer</c>. If it is not, the deletion does not occur:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <c>SoftDelete</c>, the existing (undeleted) record remains in the <c>OnlineStore</c>,
    /// though the delete record marker is still written to the <c>OfflineStore</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>HardDelete</c> returns <c>EventTime</c>: <c>400 ValidationException</c> to indicate
    /// that the delete operation failed. No delete record marker is written to the <c>OfflineStore</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private DeletionMode _deletionMode;
        private string _eventTime;
        private string _featureGroupName;
        private string _recordIdentifierValueAsString;
        private List<string> _targetStores = new List<string>();

        /// <summary>
        /// Gets and sets the property DeletionMode. 
        /// <para>
        /// The name of the deletion mode for deleting the record. By default, the deletion mode
        /// is set to <c>SoftDelete</c>.
        /// </para>
        /// </summary>
        public DeletionMode DeletionMode
        {
            get { return this._deletionMode; }
            set { this._deletionMode = value; }
        }

        // Check to see if DeletionMode property is set
        internal bool IsSetDeletionMode()
        {
            return this._deletionMode != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// Timestamp indicating when the deletion event occurred. <c>EventTime</c> can be used
        /// to query data at a certain point in time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=358400)]
        public string EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group to delete the record from.
        /// 
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
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value for the <c>RecordIdentifier</c> that uniquely identifies the record, in
        /// string format. 
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
        /// A list of stores from which you're deleting the record. By default, Feature Store
        /// deletes the record from all of the stores that you're using for the <c>FeatureGroup</c>.
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