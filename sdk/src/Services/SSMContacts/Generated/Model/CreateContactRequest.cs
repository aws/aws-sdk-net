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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContact operation.
    /// Contacts are either the contacts that Incident Manager engages during an incident
    /// or the escalation plans that Incident Manager uses to engage contacts in phases during
    /// an incident.
    /// </summary>
    public partial class CreateContactRequest : AmazonSSMContactsRequest
    {
        private string _alias;
        private string _displayName;
        private string _idempotencyToken;
        private Plan _plan;
        private List<Tag> _tags = new List<Tag>();
        private ContactType _type;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The short name to quickly identify a contact or escalation plan. The contact alias
        /// must be unique and identifiable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The full name of the contact or escalation plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token ensuring that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// A list of stages. A contact has an engagement plan with stages that contact specified
        /// contact channels. An escalation plan uses stages that contact specified contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Plan Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }

        // Check to see if Plan property is set
        internal bool IsSetPlan()
        {
            return this._plan != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds a tag to the target. You can only tag resources created in the first Region of
        /// your replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// To create an escalation plan use <code>ESCALATION</code>. To create a contact use
        /// <code>PERSONAL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}