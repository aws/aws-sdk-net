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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A semantic table that represents the final analytical structure of the data.
    /// </summary>
    public partial class SemanticTable
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for the semantic table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property DestinationTableId. 
        /// <para>
        /// The identifier of the destination table from data preparation that provides data to
        /// this semantic table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DestinationTableId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableId property is set.
        /// </summary>
        internal bool IsSetDestinationTableId() => this.DestinationTableId != null;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionConfiguration. 
        /// <para>
        /// Configuration for row level security that control data access for this semantic table.
        /// </para>
        /// </summary>
        public RowLevelPermissionConfiguration RowLevelPermissionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RowLevelPermissionConfiguration property is set.
        /// </summary>
        internal bool IsSetRowLevelPermissionConfiguration() => this.RowLevelPermissionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SemanticMetadata. 
        /// <para>
        /// The column-level semantic metadata for this semantic table.
        /// </para>
        /// </summary>
        public TableSemanticMetadata SemanticMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SemanticMetadata property is set.
        /// </summary>
        internal bool IsSetSemanticMetadata() => this.SemanticMetadata != null;
    }
}
