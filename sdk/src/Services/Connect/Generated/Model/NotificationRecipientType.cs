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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The type of notification recipient.
    /// </summary>
    public partial class NotificationRecipientType
    {
        private List<string> _userIds = new List<string>();
        private Dictionary<string, string> _userTags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// A list of user IDs.
        /// </para>
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && this._userIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserTags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }. Amazon Connect users with the specified
        /// tags will be notified.
        /// </para>
        /// </summary>
        public Dictionary<string, string> UserTags
        {
            get { return this._userTags; }
            set { this._userTags = value; }
        }

        // Check to see if UserTags property is set
        internal bool IsSetUserTags()
        {
            return this._userTags != null && this._userTags.Count > 0; 
        }

    }
}