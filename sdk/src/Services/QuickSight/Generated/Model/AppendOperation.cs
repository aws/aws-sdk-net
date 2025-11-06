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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _alias;
        private List<AppendedColumn> _appendedColumns = AWSConfigs.InitializeCollections ? new List<AppendedColumn>() : null;
        private TransformOperationSource _firstSource;
        private TransformOperationSource _secondSource;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AppendedColumns. 
        /// <para>
        /// The list of columns to include in the appended result, mapping columns from both sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public List<AppendedColumn> AppendedColumns
        {
            get { return this._appendedColumns; }
            set { this._appendedColumns = value; }
        }

        // Check to see if AppendedColumns property is set
        internal bool IsSetAppendedColumns()
        {
            return this._appendedColumns != null && (this._appendedColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirstSource. 
        /// <para>
        /// The first data source to be included in the append operation.
        /// </para>
        /// </summary>
        public TransformOperationSource FirstSource
        {
            get { return this._firstSource; }
            set { this._firstSource = value; }
        }

        // Check to see if FirstSource property is set
        internal bool IsSetFirstSource()
        {
            return this._firstSource != null;
        }

        /// <summary>
        /// Gets and sets the property SecondSource. 
        /// <para>
        /// The second data source to be appended to the first source.
        /// </para>
        /// </summary>
        public TransformOperationSource SecondSource
        {
            get { return this._secondSource; }
            set { this._secondSource = value; }
        }

        // Check to see if SecondSource property is set
        internal bool IsSetSecondSource()
        {
            return this._secondSource != null;
        }

    }
}