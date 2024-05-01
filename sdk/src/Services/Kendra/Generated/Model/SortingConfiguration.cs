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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies the document attribute to use to sort the response to a Amazon Kendra query.
    /// You can specify a single attribute for sorting. The attribute must have the <c>Sortable</c>
    /// flag set to <c>true</c>, otherwise Amazon Kendra returns an exception.
    /// 
    ///  
    /// <para>
    /// You can sort attributes of the following types.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Date value
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Long value
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// String value
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't sort attributes of the following type.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// String list value
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SortingConfiguration
    {
        private string _documentAttributeKey;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property DocumentAttributeKey. 
        /// <para>
        /// The name of the document attribute used to sort the response. You can use any field
        /// that has the <c>Sortable</c> flag set to true.
        /// </para>
        ///  
        /// <para>
        /// You can also sort by any of the following built-in attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// _category
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _created_at
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _last_updated_at
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _version
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _view_count
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string DocumentAttributeKey
        {
            get { return this._documentAttributeKey; }
            set { this._documentAttributeKey = value; }
        }

        // Check to see if DocumentAttributeKey property is set
        internal bool IsSetDocumentAttributeKey()
        {
            return this._documentAttributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order that the results should be returned in. In case of ties, the relevance assigned
        /// to the result by Amazon Kendra is used as the tie-breaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}