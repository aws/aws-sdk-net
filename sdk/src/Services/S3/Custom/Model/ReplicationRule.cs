/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Rule that specifies the replication configuration.
    /// </summary>
    public class ReplicationRule
    {
        private string id;
        private int? priority;
        private string prefix;
        private ReplicationRuleFilter filter;
        private ReplicationRuleStatus status;
        private ReplicationDestination destination;
        private SourceSelectionCriteria sourceSelectionCriteria;
        private ExistingObjectReplication existingObjectReplication;
        private DeleteMarkerReplication deleteMarkerReplication;

        /// <summary>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Checks to see if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return !System.String.IsNullOrEmpty(this.id);
        }

        /// <summary>
        /// <p>The priority associated with the rule. If you specify multiple rules in a
        /// replication configuration, then Amazon S3 applies rule priority in the event
        /// there are conflicts (two or more rules identify the same object based on
        /// filter specified). The rule with higher priority takes precedence. For
        /// example,</p> <ul> <li> <p>Same object quality prefix based filter criteria
        /// If prefixes you specified in multiple rules overlap. </p> </li> <li> <p>Same
        /// object qualify tag based filter criteria specified in multiple rules</p> </li>
        /// </ul> <p>For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/crr.html">
        /// Cross-Region Replication (CRR)</a> in the Amazon S3 Developer Guide.</p>
        /// </summary>
        public int Priority
        {
            get { return this.priority.GetValueOrDefault(); }
            set { this.priority = value; }
        }

        /// <summary>
        /// Checks to see if Priority property is set.
        /// </summary>
        /// <returns>true if Priority property is set.</returns>
        internal bool IsSetPriority()
        {
            return this.priority.HasValue;
        }

        /// <summary>
        /// Object keyname prefix identifying one or more objects to which the
        /// rule applies. Maximum prefix length can be up to 1,024 characters.
        /// </summary>
        [Obsolete("This property is deprecated. Use Filter instead.")]
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Checks to see if Prefix property is set.
        /// </summary>
        /// <returns>true if Prefix property is set.</returns>
        internal bool IsSetPrefix()
        {
            return !System.String.IsNullOrEmpty(this.prefix);
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public ReplicationRuleFilter Filter
        {
            get { return this.filter; }
            set { this.filter = value; }
        }

        /// <summary>
        /// Checks to see if Filter property is set.
        /// </summary>
        /// <returns>true if Filter property is set.</returns>
        internal bool IsSetFilter()
        {
            return this.filter != null;
        }

        /// <summary>
        /// Whether the rule is applied or ignored.
        /// </summary>
        public ReplicationRuleStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Checks to see if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Container for replication destination information.
        /// </summary>
        public ReplicationDestination Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        /// <summary>
        /// Checks to see if Destination property is set.
        /// </summary>
        /// <returns>true if Destination property is set.</returns>
        internal bool IsSetDestination()
        {
            return this.destination != null;
        }

        /// <summary>
        /// <p> Container that describes additional filters in identifying source objects that
        /// you want to replicate. Currently, Amazon S3 supports only the filter that you can
        /// specify for objects created with server-side encryption using an AWS KMS-managed
        /// key. You can choose to enable or disable replication of these objects. </p> <p> if
        /// you want Amazon S3 to replicate objects created with server-side encryption using
        /// AWS KMS-managed keys. </p>
        /// </summary>
        public SourceSelectionCriteria SourceSelectionCriteria
        {
            get { return this.sourceSelectionCriteria; }
            set { this.sourceSelectionCriteria = value; }
        }
        // Check to see if SourceSelectionCriteria property is set
        internal bool IsSetSourceSelectionCriteria()
        {
            return this.sourceSelectionCriteria != null;
        }

        /// <summary>
        /// A container that specifies information about existing object replication. 
        /// You can choose whether to enable or disable the replication of existing objects.
        /// </summary>
        public ExistingObjectReplication ExistingObjectReplication
        {
            get { return this.existingObjectReplication; }
            set { this.existingObjectReplication = value; }
        }
        /// <summary>
        /// Checks to see if ExistingObjectReplication property is set.
        /// </summary>
        /// <returns>true if ExistingObjectReplication property is set.</returns>
        internal bool IsSetExistingObjectReplication()
        {
            return this.existingObjectReplication != null;
        }

        /// <summary>
        /// Specifies whether Amazon S3 should replicate delete makers.
        /// </summary>
        public DeleteMarkerReplication DeleteMarkerReplication
        {
            get { return this.deleteMarkerReplication; }
            set { this.deleteMarkerReplication = value; }
        }

        /// <summary>
        /// Checks to see if DeleteMarkerReplication property is set.
        /// </summary>
        /// <returns>true if DeleteMarkerReplication property is set.</returns>
        internal bool IsSetDeleteMarkerReplication()
        {
            return this.deleteMarkerReplication != null;
        }
    }
}
