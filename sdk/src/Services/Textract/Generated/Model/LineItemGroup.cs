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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// A grouping of tables which contain LineItems, with each table identified by the table's
    /// <c>LineItemGroupIndex</c>.
    /// </summary>
    public partial class LineItemGroup
    {
        private int? _lineItemGroupIndex;
        private List<LineItemFields> _lineItems = AWSConfigs.InitializeCollections ? new List<LineItemFields>() : null;

        /// <summary>
        /// Gets and sets the property LineItemGroupIndex. 
        /// <para>
        /// The number used to identify a specific table in a document. The first table encountered
        /// will have a LineItemGroupIndex of 1, the second 2, etc.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? LineItemGroupIndex
        {
            get { return this._lineItemGroupIndex; }
            set { this._lineItemGroupIndex = value; }
        }

        // Check to see if LineItemGroupIndex property is set
        internal bool IsSetLineItemGroupIndex()
        {
            return this._lineItemGroupIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineItems. 
        /// <para>
        /// The breakdown of information on a particular line of a table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineItemFields> LineItems
        {
            get { return this._lineItems; }
            set { this._lineItems = value; }
        }

        // Check to see if LineItems property is set
        internal bool IsSetLineItems()
        {
            return this._lineItems != null && (this._lineItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}