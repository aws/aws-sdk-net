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
    /// A transform operation that combines rows from two data sources by stacking them vertically
    /// (union operation).
    /// </summary>
    public partial class AppendOperation
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property AppendedColumns. 
        /// <para>
        /// The list of columns to include in the appended result, mapping columns from both sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public List<AppendedColumn> AppendedColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<AppendedColumn>() : null;

        /// <summary>
        /// Checks to see if the AppendedColumns property is set.
        /// </summary>
        internal bool IsSetAppendedColumns() => this.AppendedColumns != null && (this.AppendedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirstSource. 
        /// <para>
        /// The first data source to be included in the append operation.
        /// </para>
        /// </summary>
        public TransformOperationSource FirstSource { get; set; }

        /// <summary>
        /// Checks to see if the FirstSource property is set.
        /// </summary>
        internal bool IsSetFirstSource() => this.FirstSource != null;

        /// <summary>
        /// Gets and sets the property SecondSource. 
        /// <para>
        /// The second data source to be appended to the first source.
        /// </para>
        /// </summary>
        public TransformOperationSource SecondSource { get; set; }

        /// <summary>
        /// Checks to see if the SecondSource property is set.
        /// </summary>
        internal bool IsSetSecondSource() => this.SecondSource != null;
    }
}
