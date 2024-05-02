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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Represents action metadata added to an Action dataset using the <c>PutActions</c>
    /// API. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-actions.html">Importing
    /// actions individually</a>.
    /// </summary>
    public partial class Action
    {
        private string _actionId;
        private string _properties;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID associated with the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of action-specific metadata. Each element in the map consists of a key-value
        /// pair. For example, <c>{"value": "100"}</c>.
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the schema for the Actions
        /// dataset. In the previous example, the <c>value</c> matches the 'VALUE' field defined
        /// in the Actions schema. For categorical string data, to include multiple categories
        /// for a single action, separate each category with a pipe separator (<c>|</c>). For
        /// example, <c>\"Deluxe|Premium\"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32000)]
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