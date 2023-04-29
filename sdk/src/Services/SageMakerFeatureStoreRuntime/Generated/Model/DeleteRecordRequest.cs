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
    /// Deletes a <code>Record</code> from a <code>FeatureGroup</code> in the <code>OnlineStore</code>.
    /// Feature Store supports both <code>SOFT_DELETE</code> and <code>HARD_DELETE</code>.
    /// For <code>SOFT_DELETE</code> (default), feature columns are set to <code>null</code>
    /// and the record is no longer retrievable by <code>GetRecord</code> or <code>BatchGetRecord</code>.
    /// For<code> HARD_DELETE</code>, the complete <code>Record</code> is removed from the
    /// <code>OnlineStore</code>. In both cases, Feature Store appends the deleted record
    /// marker to the <code>OfflineStore</code> with feature values set to <code>null</code>,
    /// <code>is_deleted</code> value set to <code>True</code>, and <code>EventTime</code>
    /// set to the delete input <code>EventTime</code>.
    /// 
    ///  
    /// <para>
    /// Note that the <code>EventTime</code> specified in <code>DeleteRecord</code> should
    /// be set later than the <code>EventTime</code> of the existing record in the <code>OnlineStore</code>
    /// for that <code>RecordIdentifer</code>. If it is not, the deletion does not occur:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <code>SOFT_DELETE</code>, the existing (undeleted) record remains in the <code>OnlineStore</code>,
    /// though the delete record marker is still written to the <code>OfflineStore</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HARD_DELETE</code> returns <code>EventTime</code>: <code>400 ValidationException</code>
    /// to indicate that the delete operation failed. No delete record marker is written to
    /// the <code>OfflineStore</code>.
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
        /// is set to <code>SoftDelete</code>.
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
        /// Timestamp indicating when the deletion event occurred. <code>EventTime</code> can
        /// be used to query data at a certain point in time.
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
        /// The name of the feature group to delete the record from. 
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
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value for the <code>RecordIdentifier</code> that uniquely identifies the record,
        /// in string format. 
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
        /// deletes the record from all of the stores that you're using for the <code>FeatureGroup</code>.
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