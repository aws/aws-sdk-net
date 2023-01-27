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
        private string _alias;
        private List<TransformOperation> _dataTransforms = new List<TransformOperation>();
        private LogicalTableSource _source;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// A display name for the logical table.
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
        /// Gets and sets the property DataTransforms. 
        /// <para>
        /// Transform operations that act on this logical table. For this structure to be valid,
        /// only one of the attributes can be non-null. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public List<TransformOperation> DataTransforms
        {
            get { return this._dataTransforms; }
            set { this._dataTransforms = value; }
        }

        // Check to see if DataTransforms property is set
        internal bool IsSetDataTransforms()
        {
            return this._dataTransforms != null && this._dataTransforms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Source of this logical table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogicalTableSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}