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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Represents item metadata added to an Items dataset using the <code>PutItems</code>
    /// API. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-items.html">Importing
    /// Items Incrementally</a>.
    /// </summary>
    public partial class Item
    {
        private string _itemId;
        private string _properties;

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The ID associated with the item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of item-specific metadata. Each element in the map consists of a key-value
        /// pair. For example, <code>{"numberOfRatings": "12"}</code>.
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the schema for the Items dataset.
        /// In the previous example, the <code>numberOfRatings</code> matches the 'NUMBER_OF_RATINGS'
        /// field defined in the Items schema. For categorical string data, to include multiple
        /// categories for a single item, separate each category with a pipe separator (<code>|</code>).
        /// For example, <code>\"Horror|Action\"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=24262)]
        public string Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

    }
}