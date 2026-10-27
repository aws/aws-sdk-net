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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the storage for a user.
    /// </summary>
    public partial class StorageRuleType
    {
        /// <summary>
        /// Gets and sets the property StorageAllocatedInBytes. 
        /// <para>
        /// The amount of storage allocated, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StorageAllocatedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the StorageAllocatedInBytes property is set.
        /// </summary>
        internal bool IsSetStorageAllocatedInBytes() => this.StorageAllocatedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage.
        /// </para>
        /// </summary>
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
