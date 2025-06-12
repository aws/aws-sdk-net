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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContactList operation.
    /// Creates a contact list.
    /// </summary>
    public partial class CreateContactListRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _contactListName;
        private string _description;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<Topic> _topics = AWSConfigs.InitializeCollections ? new List<Topic>() : null;

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a contact list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// An interest group, theme, or label within a list. A contact list can have multiple
        /// topics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Topic> Topics
        {
            get { return this._topics; }
            set { this._topics = value; }
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this._topics != null && (this._topics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}