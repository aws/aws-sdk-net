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
    /// The filter used to describe a set of objects for the job's manifest.
    /// </summary>
    public partial class JobManifestGeneratorFilter
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private bool? _eligibleForReplication;
        private KeyNameConstraint _keyNameConstraint;
        private List<string> _matchAnyStorageClass = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _objectReplicationStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _objectSizeGreaterThanBytes;
        private long? _objectSizeLessThanBytes;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that were
        /// created after this time.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that were
        /// created before this time.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EligibleForReplication. 
        /// <para>
        /// Include objects in the generated manifest only if they are eligible for replication
        /// according to the Replication configuration on the source bucket.
        /// </para>
        /// </summary>
        public bool EligibleForReplication
        {
            get { return this._eligibleForReplication.GetValueOrDefault(); }
            set { this._eligibleForReplication = value; }
        }

        // Check to see if EligibleForReplication property is set
        internal bool IsSetEligibleForReplication()
        {
            return this._eligibleForReplication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyNameConstraint. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose object
        /// keys match the string constraints specified for <c>MatchAnyPrefix</c>, <c>MatchAnySuffix</c>,
        /// and <c>MatchAnySubstring</c>.
        /// </para>
        /// </summary>
        public KeyNameConstraint KeyNameConstraint
        {
            get { return this._keyNameConstraint; }
            set { this._keyNameConstraint = value; }
        }

        // Check to see if KeyNameConstraint property is set
        internal bool IsSetKeyNameConstraint()
        {
            return this._keyNameConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property MatchAnyStorageClass. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that are stored
        /// with the specified storage class.
        /// </para>
        /// </summary>
        public List<string> MatchAnyStorageClass
        {
            get { return this._matchAnyStorageClass; }
            set { this._matchAnyStorageClass = value; }
        }

        // Check to see if MatchAnyStorageClass property is set
        internal bool IsSetMatchAnyStorageClass()
        {
            return this._matchAnyStorageClass != null && (this._matchAnyStorageClass.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ObjectReplicationStatuses. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that have
        /// one of the specified Replication statuses.
        /// </para>
        /// </summary>
        public List<string> ObjectReplicationStatuses
        {
            get { return this._objectReplicationStatuses; }
            set { this._objectReplicationStatuses = value; }
        }

        // Check to see if ObjectReplicationStatuses property is set
        internal bool IsSetObjectReplicationStatuses()
        {
            return this._objectReplicationStatuses != null && (this._objectReplicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThanBytes. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose file
        /// size is greater than the specified number of bytes.
        /// </para>
        /// </summary>
        public long ObjectSizeGreaterThanBytes
        {
            get { return this._objectSizeGreaterThanBytes.GetValueOrDefault(); }
            set { this._objectSizeGreaterThanBytes = value; }
        }

        // Check to see if ObjectSizeGreaterThanBytes property is set
        internal bool IsSetObjectSizeGreaterThanBytes()
        {
            return this._objectSizeGreaterThanBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThanBytes. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose file
        /// size is less than the specified number of bytes.
        /// </para>
        /// </summary>
        public long ObjectSizeLessThanBytes
        {
            get { return this._objectSizeLessThanBytes.GetValueOrDefault(); }
            set { this._objectSizeLessThanBytes = value; }
        }

        // Check to see if ObjectSizeLessThanBytes property is set
        internal bool IsSetObjectSizeLessThanBytes()
        {
            return this._objectSizeLessThanBytes.HasValue; 
        }

    }
}