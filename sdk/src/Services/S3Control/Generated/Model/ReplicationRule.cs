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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Specifies which S3 on Outposts objects to replicate and where to store the replicas.
    /// </summary>
    public partial class ReplicationRule
    {
        private string _bucket;
        private DeleteMarkerReplication _deleteMarkerReplication;
        private Destination _destination;
        private ExistingObjectReplication _existingObjectReplication;
        private ReplicationRuleFilter _filter;
        private string _id;
        private string _prefix;
        private int? _priority;
        private SourceSelectionCriteria _sourceSelectionCriteria;
        private ReplicationRuleStatus _status;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access point for the source Outposts bucket
        /// that you want S3 on Outposts to replicate the objects from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteMarkerReplication. 
        /// <para>
        /// Specifies whether S3 on Outposts replicates delete markers. If you specify a <code>Filter</code>
        /// element in your replication configuration, you must also include a <code>DeleteMarkerReplication</code>
        /// element. If your <code>Filter</code> includes a <code>Tag</code> element, the <code>DeleteMarkerReplication</code>
        /// element's <code>Status</code> child element must be set to <code>Disabled</code>,
        /// because S3 on Outposts doesn't support replicating delete markers for tag-based rules.
        /// </para>
        ///  
        /// <para>
        /// For more information about delete marker replication, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OutpostsReplication.html#outposts-replication-what-is-replicated">How
        /// delete operations affect replication</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
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
        /// A container for information about the replication destination and its configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
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
        /// An optional configuration to replicate existing source bucket objects. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
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
        /// <para>
        /// A filter that identifies the subset of objects to which the replication rule applies.
        /// A <code>Filter</code> element must specify exactly one <code>Prefix</code>, <code>Tag</code>,
        /// or <code>And</code> child element.
        /// </para>
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
        /// Gets and sets the property ID. 
        /// <para>
        /// A unique identifier for the rule. The maximum value is 255 characters.
        /// </para>
        /// </summary>
        public string ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetID()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An object key name prefix that identifies the object or objects to which the rule
        /// applies. The maximum prefix length is 1,024 characters. To include all objects in
        /// an Outposts bucket, specify an empty string.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you're using XML requests, you must replace special characters (such as carriage
        /// returns) in object keys with their equivalent XML entity codes. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML-related object key constraints</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("Prefix has been deprecated")]
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
        /// rules conflict. S3 on Outposts attempts to replicate objects according to all replication
        /// rules. However, if there are two or more rules with the same destination Outposts
        /// bucket, then objects will be replicated according to the rule with the highest priority.
        /// The higher the number, the higher the priority. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/replication-between-outposts.html">Creating
        /// replication rules between Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
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
        /// A container that describes additional filters for identifying the source Outposts
        /// objects that you want to replicate. You can choose to enable or disable the replication
        /// of these objects.
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