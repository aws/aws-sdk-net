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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a Delta Sync configuration.
    /// </summary>
    public partial class DeltaSyncConfig
    {
        /// <summary>
        /// Gets and sets the property BaseTableTTL. 
        /// <para>
        /// The number of minutes that an Item is stored in the data source.
        /// </para>
        /// </summary>
        public long? BaseTableTTL { get; set; }

        /// <summary>
        /// Checks to see if the BaseTableTTL property is set.
        /// </summary>
        internal bool IsSetBaseTableTTL() => this.BaseTableTTL.HasValue;

        /// <summary>
        /// Gets and sets the property DeltaSyncTableName. 
        /// <para>
        /// The Delta Sync table name.
        /// </para>
        /// </summary>
        public string DeltaSyncTableName { get; set; }

        /// <summary>
        /// Checks to see if the DeltaSyncTableName property is set.
        /// </summary>
        internal bool IsSetDeltaSyncTableName() => this.DeltaSyncTableName != null;

        /// <summary>
        /// Gets and sets the property DeltaSyncTableTTL. 
        /// <para>
        /// The number of minutes that a Delta Sync log entry is stored in the Delta Sync table.
        /// </para>
        /// </summary>
        public long? DeltaSyncTableTTL { get; set; }

        /// <summary>
        /// Checks to see if the DeltaSyncTableTTL property is set.
        /// </summary>
        internal bool IsSetDeltaSyncTableTTL() => this.DeltaSyncTableTTL.HasValue;
    }
}
