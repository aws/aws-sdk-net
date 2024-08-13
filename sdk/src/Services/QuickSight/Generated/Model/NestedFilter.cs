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
    /// A <c>NestedFilter</c> filters data with a subset of data that is defined by the nested
    /// inner filter.
    /// </summary>
    public partial class NestedFilter
    {
        private ColumnIdentifier _column;
        private string _filterId;
        private bool? _includeInnerSet;
        private InnerFilter _innerFilter;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property FilterId. 
        /// <para>
        /// An identifier that uniquely identifies a filter within a dashboard, analysis, or template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterId
        {
            get { return this._filterId; }
            set { this._filterId = value; }
        }

        // Check to see if FilterId property is set
        internal bool IsSetFilterId()
        {
            return this._filterId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeInnerSet. 
        /// <para>
        /// A boolean condition to include or exclude the subset that is defined by the values
        /// of the nested inner filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IncludeInnerSet
        {
            get { return this._includeInnerSet; }
            set { this._includeInnerSet = value; }
        }

        // Check to see if IncludeInnerSet property is set
        internal bool IsSetIncludeInnerSet()
        {
            return this._includeInnerSet.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InnerFilter. 
        /// <para>
        /// The <c>InnerFilter</c> defines the subset of data to be used with the <c>NestedFilter</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InnerFilter InnerFilter
        {
            get { return this._innerFilter; }
            set { this._innerFilter = value; }
        }

        // Check to see if InnerFilter property is set
        internal bool IsSetInnerFilter()
        {
            return this._innerFilter != null;
        }

    }
}