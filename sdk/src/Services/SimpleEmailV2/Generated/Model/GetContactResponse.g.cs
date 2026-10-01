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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AttributesData. 
        /// <para>
        /// The attribute data attached to a contact.
        /// </para>
        /// </summary>
        public string AttributesData { get; set; }

        /// <summary>
        /// Checks to see if the AttributesData property is set.
        /// </summary>
        internal bool IsSetAttributesData() => this.AttributesData != null;

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list to which the contact belongs.
        /// </para>
        /// </summary>
        public string ContactListName { get; set; }

        /// <summary>
        /// Checks to see if the ContactListName property is set.
        /// </summary>
        internal bool IsSetContactListName() => this.ContactListName != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// A timestamp noting when the contact was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The contact's email address.
        /// </para>
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// A timestamp noting the last time the contact's information was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TopicDefaultPreferences. 
        /// <para>
        /// The default topic preferences applied to the contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicPreference> TopicDefaultPreferences { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicPreference>() : null;

        /// <summary>
        /// Checks to see if the TopicDefaultPreferences property is set.
        /// </summary>
        internal bool IsSetTopicDefaultPreferences() => this.TopicDefaultPreferences != null && (this.TopicDefaultPreferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicPreferences. 
        /// <para>
        /// The contact's preference for being opted-in to or opted-out of a topic.>
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicPreference> TopicPreferences { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicPreference>() : null;

        /// <summary>
        /// Checks to see if the TopicPreferences property is set.
        /// </summary>
        internal bool IsSetTopicPreferences() => this.TopicPreferences != null && (this.TopicPreferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnsubscribeAll. 
        /// <para>
        /// A boolean value status noting if the contact is unsubscribed from all contact list
        /// topics.
        /// </para>
        /// </summary>
        public bool? UnsubscribeAll { get; set; }

        /// <summary>
        /// Checks to see if the UnsubscribeAll property is set.
        /// </summary>
        internal bool IsSetUnsubscribeAll() => this.UnsubscribeAll.HasValue;
    }
}
