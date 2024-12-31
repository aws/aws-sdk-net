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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains the details of the sender-provided contact person for the
    /// <c>EngagementInvitation</c>.
    /// </summary>
    public partial class SenderContact
    {
        private string _businessTitle;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _phone;

        /// <summary>
        /// Gets and sets the property BusinessTitle. 
        /// <para>
        /// The sender-provided contact's title (job title or role) associated with the <c>EngagementInvitation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=80)]
        public string BusinessTitle
        {
            get { return this._businessTitle; }
            set { this._businessTitle = value; }
        }

        // Check to see if BusinessTitle property is set
        internal bool IsSetBusinessTitle()
        {
            return this._businessTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The sender-provided contact's email address associated with the <c>EngagementInvitation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=80)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The sender-provided contact's last name associated with the <c>EngagementInvitation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=80)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The sender-provided contact's first name associated with the <c>EngagementInvitation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=80)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// The sender-provided contact's phone number associated with the <c>EngagementInvitation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        // Check to see if Phone property is set
        internal bool IsSetPhone()
        {
            return this._phone != null;
        }

    }
}