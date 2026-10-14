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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContact operation. Contacts are either the
    /// contacts that Incident Manager engages during an incident or the escalation plans
    /// that Incident Manager uses to engage contacts in phases during an incident.
    /// </summary>
    public partial class CreateContactRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The short name to quickly identify a contact or escalation plan. The contact alias
        /// must be unique and identifiable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The full name of the contact or escalation plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// A list of stages. A contact has an engagement plan with stages that contact specified
        /// contact channels. An escalation plan uses stages that contact specified contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Plan Plan { get; set; }

        /// <summary>
        /// Checks to see if the Plan property is set.
        /// </summary>
        internal bool IsSetPlan() => this.Plan != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds a tag to the target. You can only tag resources created in the first Region of
        /// your replication set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of contact to create.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PERSONAL</c>: A single, individual contact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ESCALATION</c>: An escalation plan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONCALL_SCHEDULE</c>: An on-call schedule.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContactType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
