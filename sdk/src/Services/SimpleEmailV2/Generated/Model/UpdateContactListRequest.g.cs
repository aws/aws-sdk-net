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
    /// Container for the parameters to the UpdateContactList operation. Updates contact list
    /// metadata. This operation does a complete replacement.
    /// </summary>
    public partial class UpdateContactListRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContactListName { get; set; }

        /// <summary>
        /// Checks to see if the ContactListName property is set.
        /// </summary>
        internal bool IsSetContactListName() => this.ContactListName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the contact list is about.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// An interest group, theme, or label within a list. A contact list can have multiple
        /// topics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Topic> Topics { get; set; } = AWSConfigs.InitializeCollections ? new List<Topic>() : null;

        /// <summary>
        /// Checks to see if the Topics property is set.
        /// </summary>
        internal bool IsSetTopics() => this.Topics != null && (this.Topics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
