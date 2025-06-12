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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The row filter.
    /// </summary>
    public partial class RowFilter
    {
        private List<RowFilter> _and = AWSConfigs.InitializeCollections ? new List<RowFilter>() : null;
        private RowFilterExpression _expression;
        private List<RowFilter> _or = AWSConfigs.InitializeCollections ? new List<RowFilter>() : null;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// The 'and' clause of the row filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RowFilter> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && (this._and.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression of the row filter.
        /// </para>
        /// </summary>
        public RowFilterExpression Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// The 'or' clause of the row filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RowFilter> Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null && (this._or.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}