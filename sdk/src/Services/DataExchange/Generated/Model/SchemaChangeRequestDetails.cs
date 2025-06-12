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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Extra details specific to this schema change type notification.
    /// </summary>
    public partial class SchemaChangeRequestDetails
    {
        private List<SchemaChangeDetails> _changes = AWSConfigs.InitializeCollections ? new List<SchemaChangeDetails>() : null;
        private DateTime? _schemaChangeAt;

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// List of schema changes happening in the scope of this notification. This can have
        /// up to 100 entries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SchemaChangeDetails> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && (this._changes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchemaChangeAt. 
        /// <para>
        /// A date in the future when the schema change is taking effect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SchemaChangeAt
        {
            get { return this._schemaChangeAt; }
            set { this._schemaChangeAt = value; }
        }

        // Check to see if SchemaChangeAt property is set
        internal bool IsSetSchemaChangeAt()
        {
            return this._schemaChangeAt.HasValue; 
        }

    }
}