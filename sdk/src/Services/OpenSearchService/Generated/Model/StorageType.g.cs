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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// A list of storage types for an Amazon OpenSearch Service domain that are available
    /// for a given intance type.
    /// </summary>
    public partial class StorageType
    {
        /// <summary>
        /// Gets and sets the property StorageSubTypeName. 
        /// <para>
        /// The storage sub-type, such as <c>gp3</c> or <c>io1</c>.
        /// </para>
        /// </summary>
        public string StorageSubTypeName { get; set; }

        /// <summary>
        /// Checks to see if the StorageSubTypeName property is set.
        /// </summary>
        internal bool IsSetStorageSubTypeName() => this.StorageSubTypeName != null;

        /// <summary>
        /// Gets and sets the property StorageTypeLimits. 
        /// <para>
        /// Limits that are applicable for the given storage type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageTypeLimit> StorageTypeLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<StorageTypeLimit>() : null;

        /// <summary>
        /// Checks to see if the StorageTypeLimits property is set.
        /// </summary>
        internal bool IsSetStorageTypeLimits() => this.StorageTypeLimits != null && (this.StorageTypeLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageTypeName. 
        /// <para>
        /// The name of the storage type.
        /// </para>
        /// </summary>
        public string StorageTypeName { get; set; }

        /// <summary>
        /// Checks to see if the StorageTypeName property is set.
        /// </summary>
        internal bool IsSetStorageTypeName() => this.StorageTypeName != null;
    }
}
