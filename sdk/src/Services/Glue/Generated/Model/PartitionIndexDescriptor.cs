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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private List<BackfillError> _backfillErrors = AWSConfigs.InitializeCollections ? new List<BackfillError>() : null;
        private string _indexName;
        private PartitionIndexStatus _indexStatus;
        private List<KeySchemaElement> _keys = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Gets and sets the property BackfillErrors. 
        /// <para>
        /// A list of errors that can occur when registering partition indexes for an existing
        /// table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BackfillError> BackfillErrors
        {
            get { return this._backfillErrors; }
            set { this._backfillErrors = value; }
        }

        // Check to see if BackfillErrors property is set
        internal bool IsSetBackfillErrors()
        {
            return this._backfillErrors != null && (this._backfillErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the partition index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

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
        [AWSProperty(Required=true)]
        public PartitionIndexStatus IndexStatus
        {
            get { return this._indexStatus; }
            set { this._indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this._indexStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// A list of one or more keys, as <c>KeySchemaElement</c> structures, for the partition
        /// index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<KeySchemaElement> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && (this._keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}