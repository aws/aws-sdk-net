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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// This is the response object from the GetContactList operation.
    /// </summary>
    public partial class GetContactListResponse : AmazonWebServiceResponse
    {
        private string _contactListName;
        private DateTime? _createdTimestamp;
        private string _description;
        private DateTime? _lastUpdatedTimestamp;
        private List<Tag> _tags = new List<Tag>();
        private List<Topic> _topics = new List<Topic>();

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list.
        /// </para>
        /// </summary>
        public string ContactListName
        {
            get { return this._contactListName; }
            set { this._contactListName = value; }
        }

        // Check to see if ContactListName property is set
        internal bool IsSetContactListName()
        {
            return this._contactListName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// A timestamp noting when the contact list was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the contact list is about.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// A timestamp noting the last time the contact list was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a contact list.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// An interest group, theme, or label within a list. A contact list can have multiple
        /// topics.
        /// </para>
        /// </summary>
        public List<Topic> Topics
        {
            get { return this._topics; }
            set { this._topics = value; }
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this._topics != null && this._topics.Count > 0; 
        }

    }
}