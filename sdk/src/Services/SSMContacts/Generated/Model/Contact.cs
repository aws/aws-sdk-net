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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// A personal contact or escalation plan that Incident Manager engages during an incident.
    /// </summary>
    public partial class Contact
    {
        private string _alias;
        private string _contactArn;
        private string _displayName;
        private ContactType _type;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The unique and identifiable alias of the contact or escalation plan.
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
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact or escalation plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Refers to the type of contact. A single contact is type <c>PERSONAL</c> and an escalation
        /// plan is type <c>ESCALATION</c>.
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