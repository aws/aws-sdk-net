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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The structure used to create and update a partition.
    /// </summary>
    public partial class PartitionInput
    {
        /// <summary>
        /// Gets and sets the property LastAccessTime. 
        /// <para>
        /// The last time at which the partition was accessed.
        /// </para>
        /// </summary>
        public DateTime? LastAccessTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessTime property is set.
        /// </summary>
        internal bool IsSetLastAccessTime() => this.LastAccessTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastAnalyzedTime. 
        /// <para>
        /// The last time at which column statistics were computed for this partition.
        /// </para>
        /// </summary>
        public DateTime? LastAnalyzedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAnalyzedTime property is set.
        /// </summary>
        internal bool IsSetLastAnalyzedTime() => this.LastAnalyzedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// These key-value pairs define partition parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageDescriptor. 
        /// <para>
        /// Provides information about the physical location where the partition is stored.
        /// </para>
        /// </summary>
        public StorageDescriptor StorageDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the StorageDescriptor property is set.
        /// </summary>
        internal bool IsSetStorageDescriptor() => this.StorageDescriptor != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the partition. Although this parameter is not required by the SDK, you
        /// must specify this parameter for a valid input.
        /// </para>
        ///  
        /// <para>
        /// The values for the keys for the new partition must be passed as an array of String
        /// objects that must be ordered in the same order as the partition keys appearing in
        /// the Amazon S3 prefix. Otherwise Glue will add the values to the wrong keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
