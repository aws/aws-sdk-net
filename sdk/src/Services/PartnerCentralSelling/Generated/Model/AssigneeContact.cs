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
    /// Represents the contact details of the individual assigned to manage the opportunity
    /// within the partner organization. This helps to ensure that there is a point of contact
    /// for the opportunity's progress.
    /// </summary>
    public partial class AssigneeContact
    {
        private string _businessTitle;
        private string _email;
        private string _firstName;
        private string _lastName;

        /// <summary>
        /// Gets and sets the property BusinessTitle. 
        /// <para>
        /// Specifies the business title of the assignee managing the opportunity. This helps
        /// clarify the individual's role and responsibilities within the organization. Use the
        /// value <c>PartnerAccountManager</c> to update details of the opportunity owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=80)]
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
        /// Provides the email address of the assignee. This email is used for communications
        /// and notifications related to the opportunity.
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
        /// Specifies the first name of the assignee managing the opportunity. The system automatically
        /// retrieves this value from the user profile by referencing the associated email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=80)]
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
        /// Specifies the last name of the assignee managing the opportunity. The system automatically
        /// retrieves this value from the user profile by referencing the associated email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=80)]
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

    }
}