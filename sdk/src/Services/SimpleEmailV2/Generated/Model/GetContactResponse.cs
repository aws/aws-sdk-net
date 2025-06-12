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
    /// This is the response object from the GetContact operation.
    /// </summary>
    public partial class GetContactResponse : AmazonWebServiceResponse
    {
        private string _attributesData;
        private string _contactListName;
        private DateTime? _createdTimestamp;
        private string _emailAddress;
        private DateTime? _lastUpdatedTimestamp;
        private List<TopicPreference> _topicDefaultPreferences = AWSConfigs.InitializeCollections ? new List<TopicPreference>() : null;
        private List<TopicPreference> _topicPreferences = AWSConfigs.InitializeCollections ? new List<TopicPreference>() : null;
        private bool? _unsubscribeAll;

        /// <summary>
        /// Gets and sets the property AttributesData. 
        /// <para>
        /// The attribute data attached to a contact.
        /// </para>
        /// </summary>
        public string AttributesData
        {
            get { return this._attributesData; }
            set { this._attributesData = value; }
        }

        // Check to see if AttributesData property is set
        internal bool IsSetAttributesData()
        {
            return this._attributesData != null;
        }

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list to which the contact belongs.
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
        /// A timestamp noting when the contact was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The contact's email address.
        /// </para>
        /// </summary>
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// A timestamp noting the last time the contact's information was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicDefaultPreferences. 
        /// <para>
        /// The default topic preferences applied to the contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicPreference> TopicDefaultPreferences
        {
            get { return this._topicDefaultPreferences; }
            set { this._topicDefaultPreferences = value; }
        }

        // Check to see if TopicDefaultPreferences property is set
        internal bool IsSetTopicDefaultPreferences()
        {
            return this._topicDefaultPreferences != null && (this._topicDefaultPreferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicPreferences. 
        /// <para>
        /// The contact's preference for being opted-in to or opted-out of a topic.&gt;
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicPreference> TopicPreferences
        {
            get { return this._topicPreferences; }
            set { this._topicPreferences = value; }
        }

        // Check to see if TopicPreferences property is set
        internal bool IsSetTopicPreferences()
        {
            return this._topicPreferences != null && (this._topicPreferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsubscribeAll. 
        /// <para>
        /// A boolean value status noting if the contact is unsubscribed from all contact list
        /// topics.
        /// </para>
        /// </summary>
        public bool? UnsubscribeAll
        {
            get { return this._unsubscribeAll; }
            set { this._unsubscribeAll = value; }
        }

        // Check to see if UnsubscribeAll property is set
        internal bool IsSetUnsubscribeAll()
        {
            return this._unsubscribeAll.HasValue; 
        }

    }
}