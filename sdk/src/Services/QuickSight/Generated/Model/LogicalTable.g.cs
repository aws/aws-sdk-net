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
    /// A <i>logical table</i> is a unit that joins and that data transformations operate
    /// on. A logical table has a source, which can be either a physical table or result of
    /// a join. When a logical table points to a physical table, the logical table acts as
    /// a mutable copy of that physical table through transform operations.
    /// </summary>
    public partial class LogicalTable
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// A display name for the logical table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property DataTransforms. 
        /// <para>
        /// Transform operations that act on this logical table. For this structure to be valid,
        /// only one of the attributes can be non-null. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public List<TransformOperation> DataTransforms { get; set; } = AWSConfigs.InitializeCollections ? new List<TransformOperation>() : null;

        /// <summary>
        /// Checks to see if the DataTransforms property is set.
        /// </summary>
        internal bool IsSetDataTransforms() => this.DataTransforms != null && (this.DataTransforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Source of this logical table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogicalTableSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
