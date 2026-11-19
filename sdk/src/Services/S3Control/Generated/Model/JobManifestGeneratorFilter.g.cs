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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The filter used to describe a set of objects for the job's manifest.
    /// </summary>
    public partial class JobManifestGeneratorFilter
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that were
        /// created after this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that were
        /// created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property EligibleForReplication. 
        /// <para>
        /// Include objects in the generated manifest only if they are eligible for replication
        /// according to the Replication configuration on the source bucket.
        /// </para>
        /// </summary>
        public bool? EligibleForReplication { get; set; }

        /// <summary>
        /// Checks to see if the EligibleForReplication property is set.
        /// </summary>
        internal bool IsSetEligibleForReplication() => this.EligibleForReplication.HasValue;

        /// <summary>
        /// Gets and sets the property KeyNameConstraint. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose object
        /// keys match the string constraints specified for <c>MatchAnyPrefix</c>, <c>MatchAnySuffix</c>,
        /// and <c>MatchAnySubstring</c>.
        /// </para>
        /// </summary>
        public KeyNameConstraint KeyNameConstraint { get; set; }

        /// <summary>
        /// Checks to see if the KeyNameConstraint property is set.
        /// </summary>
        internal bool IsSetKeyNameConstraint() => this.KeyNameConstraint != null;

        /// <summary>
        /// Gets and sets the property MatchAnyObjectEncryption. 
        /// <para>
        /// If provided, the generated object list includes only source bucket objects with the
        /// indicated server-side encryption type (SSE-S3, SSE-KMS, DSSE-KMS, SSE-C, or NOT-SSE).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<ObjectEncryptionFilter> MatchAnyObjectEncryption { get; set; } = AWSConfigs.InitializeCollections ? new List<ObjectEncryptionFilter>() : null;

        /// <summary>
        /// Checks to see if the MatchAnyObjectEncryption property is set.
        /// </summary>
        internal bool IsSetMatchAnyObjectEncryption() => this.MatchAnyObjectEncryption != null && (this.MatchAnyObjectEncryption.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchAnyStorageClass. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that are stored
        /// with the specified storage class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnyStorageClass { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnyStorageClass property is set.
        /// </summary>
        internal bool IsSetMatchAnyStorageClass() => this.MatchAnyStorageClass != null && (this.MatchAnyStorageClass.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectReplicationStatuses. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects that have
        /// one of the specified Replication statuses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ObjectReplicationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ObjectReplicationStatuses property is set.
        /// </summary>
        internal bool IsSetObjectReplicationStatuses() => this.ObjectReplicationStatuses != null && (this.ObjectReplicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThanBytes. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose file
        /// size is greater than the specified number of bytes.
        /// </para>
        /// </summary>
        public long? ObjectSizeGreaterThanBytes { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeGreaterThanBytes property is set.
        /// </summary>
        internal bool IsSetObjectSizeGreaterThanBytes() => this.ObjectSizeGreaterThanBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThanBytes. 
        /// <para>
        /// If provided, the generated manifest includes only source bucket objects whose file
        /// size is less than the specified number of bytes.
        /// </para>
        /// </summary>
        public long? ObjectSizeLessThanBytes { get; set; }

        /// <summary>
        /// Checks to see if the ObjectSizeLessThanBytes property is set.
        /// </summary>
        internal bool IsSetObjectSizeLessThanBytes() => this.ObjectSizeLessThanBytes.HasValue;
    }
}
