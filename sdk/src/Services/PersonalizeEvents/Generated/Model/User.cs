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
    /// Represents user metadata added to a Users dataset using the <code>PutUsers</code>
    /// API. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/importing-users.html">Importing
    /// Users Incrementally</a>.
    /// </summary>
    public partial class User
    {
        private string _properties;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A string map of user-specific metadata. Each element in the map consists of a key-value
        /// pair. For example, <code>{"numberOfVideosWatched": "45"}</code>.
        /// </para>
        ///  
        /// <para>
        /// The keys use camel case names that match the fields in the schema for the Users dataset.
        /// In the previous example, the <code>numberOfVideosWatched</code> matches the 'NUMBER_OF_VIDEOS_WATCHED'
        /// field defined in the Users schema. For categorical string data, to include multiple
        /// categories for a single user, separate each category with a pipe separator (<code>|</code>).
        /// For example, <code>\"Member|Frequent shopper\"</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}