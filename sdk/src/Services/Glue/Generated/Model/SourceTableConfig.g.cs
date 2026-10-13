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
    /// Properties used by the source leg to process data from the source.
    /// </summary>
    public partial class SourceTableConfig
    {
        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A list of fields used for column-level filtering. Currently unsupported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterPredicate. 
        /// <para>
        /// A condition clause used for row-level filtering. Currently unsupported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FilterPredicate { get; set; }

        /// <summary>
        /// Checks to see if the FilterPredicate property is set.
        /// </summary>
        internal bool IsSetFilterPredicate() => this.FilterPredicate != null;

        /// <summary>
        /// Gets and sets the property PrimaryKey. 
        /// <para>
        /// Provide the primary key set for this table. Currently supported specifically for SAP
        /// <c>EntityOf</c> entities upon request. Contact Amazon Web Services Support to make
        /// this feature available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrimaryKey { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrimaryKey property is set.
        /// </summary>
        internal bool IsSetPrimaryKey() => this.PrimaryKey != null && (this.PrimaryKey.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordUpdateField. 
        /// <para>
        /// Incremental pull timestamp-based field. Currently unsupported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RecordUpdateField { get; set; }

        /// <summary>
        /// Checks to see if the RecordUpdateField property is set.
        /// </summary>
        internal bool IsSetRecordUpdateField() => this.RecordUpdateField != null;
    }
}
