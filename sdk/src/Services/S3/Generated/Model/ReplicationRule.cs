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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies which Amazon S3 objects to replicate and where to store the replicas.
    /// </summary>
    public partial class ReplicationRule
    {
        private DeleteMarkerReplication _deleteMarkerReplication;
        private ReplicationDestination _destination;
        private ExistingObjectReplication _existingObjectReplication;
        private ReplicationRuleFilter _filter;
        private string _id;
        private string _prefix;
        private int? _priority;
        private SourceSelectionCriteria _sourceSelectionCriteria;
        private ReplicationRuleStatus _status;

        /// <summary>
        /// Gets and sets the property DeleteMarkerReplication.
        /// </summary>
        public DeleteMarkerReplication DeleteMarkerReplication
        {
            get { return this._deleteMarkerReplication; }
            set { this._deleteMarkerReplication = value; }
        }

        // Check to see if DeleteMarkerReplication property is set
        internal bool IsSetDeleteMarkerReplication()
        {
            return this._deleteMarkerReplication != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// A container for information about the replication destination and its configurations
        /// including enabling the S3 Replication Time Control (S3 RTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingObjectReplication. 
        /// <para>
        /// Optional configuration to replicate existing source bucket objects. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is no longer supported. To replicate existing objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-batch-replication-batch.html">Replicating
        /// existing objects with S3 Batch Replication</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public ExistingObjectReplication ExistingObjectReplication
        {
            get { return this._existingObjectReplication; }
            set { this._existingObjectReplication = value; }
        }

        // Check to see if ExistingObjectReplication property is set
        internal bool IsSetExistingObjectReplication()
        {
            return this._existingObjectReplication != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public ReplicationRuleFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the rule. The maximum value is 255 characters.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An object key name prefix that identifies the object or objects to which the rule
        /// applies. The maximum prefix length is 1,024 characters. To include all objects in
        /// a bucket, specify an empty string. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("This property is deprecated. Use Filter instead.")]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority indicates which rule has precedence whenever two or more replication
        /// rules conflict. Amazon S3 will attempt to replicate objects according to all replication
        /// rules. However, if there are two or more rules with the same destination bucket, then
        /// objects will be replicated according to the rule with the highest priority. The higher
        /// the number, the higher the priority. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/replication.html">Replication</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceSelectionCriteria. 
        /// <para>
        /// A container that describes additional filters for identifying the source objects that
        /// you want to replicate. You can choose to enable or disable the replication of these
        /// objects. Currently, Amazon S3 supports only the filter that you can specify for objects
        /// created with server-side encryption using a customer managed key stored in Amazon
        /// Web Services Key Management Service (SSE-KMS).
        /// </para>
        /// </summary>
        public SourceSelectionCriteria SourceSelectionCriteria
        {
            get { return this._sourceSelectionCriteria; }
            set { this._sourceSelectionCriteria = value; }
        }

        // Check to see if SourceSelectionCriteria property is set
        internal bool IsSetSourceSelectionCriteria()
        {
            return this._sourceSelectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether the rule is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicationRuleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}