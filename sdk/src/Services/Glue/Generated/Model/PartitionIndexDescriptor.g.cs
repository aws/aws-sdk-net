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
    /// A descriptor for a partition index in a table.
    /// </summary>
    public partial class PartitionIndexDescriptor
    {
        /// <summary>
        /// Gets and sets the property BackfillErrors. 
        /// <para>
        /// A list of errors that can occur when registering partition indexes for an existing
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BackfillError> BackfillErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<BackfillError>() : null;

        /// <summary>
        /// Checks to see if the BackfillErrors property is set.
        /// </summary>
        internal bool IsSetBackfillErrors() => this.BackfillErrors != null && (this.BackfillErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the partition index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// The status of the partition index. 
        /// </para>
        ///  
        /// <para>
        /// The possible statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING: The index is being created. When an index is in a CREATING state, the index
        /// or its table cannot be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE: The index creation succeeds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED: The index creation fails. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING: The index is deleted from the list of indexes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PartitionIndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// A list of one or more keys, as <c>KeySchemaElement</c> structures, for the partition
        /// index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<KeySchemaElement> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
