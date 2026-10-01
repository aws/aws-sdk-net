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

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecord operation. Deletes a <c>Record</c>
    /// from a <c>FeatureGroup</c> in the <c>OnlineStore</c>. Feature Store supports both
    /// <c>SoftDelete</c> and <c>HardDelete</c>. For <c>SoftDelete</c> (default), feature
    /// columns are set to <c>null</c> and the record is no longer retrievable by <c>GetRecord</c>
    /// or <c>BatchGetRecord</c>. For <c>HardDelete</c>, the complete <c>Record</c> is removed
    /// from the <c>OnlineStore</c>. In both cases, Feature Store appends the deleted record
    /// marker to the <c>OfflineStore</c>. The deleted record marker is a record with the
    /// same <c>RecordIdentifer</c> as the original, but with <c>is_deleted</c> value set
    /// to <c>True</c>, <c>EventTime</c> set to the delete input <c>EventTime</c>, and other
    /// feature values set to <c>null</c>. <para> Note that the <c>EventTime</c> specified
    /// in <c>DeleteRecord</c> should be set later than the <c>EventTime</c> of the existing
    /// record in the <c>OnlineStore</c> for that <c>RecordIdentifer</c>. If it is not, the
    /// deletion does not occur: </para> <ul> <li> <para> For <c>SoftDelete</c>, the existing
    /// (not deleted) record remains in the <c>OnlineStore</c>, though the delete record marker
    /// is still written to the <c>OfflineStore</c>. </para> </li> <li> <para> <c>HardDelete</c>
    /// returns <c>EventTime</c>: <c>400 ValidationException</c> to indicate that the delete
    /// operation failed. No delete record marker is written to the <c>OfflineStore</c>. </para>
    /// </li> </ul> <para> When a record is deleted from the <c>OnlineStore</c>, the deleted
    /// record marker is appended to the <c>OfflineStore</c>. If you have the Iceberg table
    /// format enabled for your <c>OfflineStore</c>, you can remove all history of a record
    /// from the <c>OfflineStore</c> using Amazon Athena or Apache Spark. For information
    /// on how to hard delete a record from the <c>OfflineStore</c> with the Iceberg table
    /// format enabled, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/feature-store-delete-records.html#feature-store-delete-records-offline-store">Delete
    /// records from the offline store</a>. </para>
    /// </summary>
    public partial class DeleteRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property DeletionMode. 
        /// <para>
        /// The name of the deletion mode for deleting the record. By default, the deletion mode
        /// is set to <c>SoftDelete</c>.
        /// </para>
        /// </summary>
        public DeletionMode DeletionMode { get; set; }

        /// <summary>
        /// Checks to see if the DeletionMode property is set.
        /// </summary>
        internal bool IsSetDeletionMode() => this.DeletionMode != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// Timestamp indicating when the deletion event occurred. <c>EventTime</c> can be used
        /// to query data at a certain point in time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 358400)]
        public string EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime != null;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group to delete the record from.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string FeatureGroupName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupName property is set.
        /// </summary>
        internal bool IsSetFeatureGroupName() => this.FeatureGroupName != null;

        /// <summary>
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value for the <c>RecordIdentifier</c> that uniquely identifies the record, in
        /// string format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 358400)]
        public string RecordIdentifierValueAsString { get; set; }

        /// <summary>
        /// Checks to see if the RecordIdentifierValueAsString property is set.
        /// </summary>
        internal bool IsSetRecordIdentifierValueAsString() => this.RecordIdentifierValueAsString != null;

        /// <summary>
        /// Gets and sets the property TargetStores. 
        /// <para>
        /// A list of stores from which you're deleting the record. By default, Feature Store
        /// deletes the record from all of the stores that you're using for the <c>FeatureGroup</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> TargetStores { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetStores property is set.
        /// </summary>
        internal bool IsSetTargetStores() => this.TargetStores != null && (this.TargetStores.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
