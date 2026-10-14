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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the contact details of the individual assigned to manage the opportunity
    /// within the partner organization. This helps to ensure that there is a point of contact
    /// for the opportunity's progress.
    /// </summary>
    public partial class AssigneeContact
    {
        /// <summary>
        /// Gets and sets the property BusinessTitle. 
        /// <para>
        /// Specifies the business title of the assignee managing the opportunity. This helps
        /// clarify the individual's role and responsibilities within the organization. Use the
        /// value <c>PartnerAccountManager</c> to update details of the opportunity owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string BusinessTitle { get; set; }

        /// <summary>
        /// Checks to see if the BusinessTitle property is set.
        /// </summary>
        internal bool IsSetBusinessTitle() => this.BusinessTitle != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Provides the email address of the assignee. This email is used for communications
        /// and notifications related to the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// Specifies the first name of the assignee managing the opportunity. The system automatically
        /// retrieves this value from the user profile by referencing the associated email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// Specifies the last name of the assignee managing the opportunity. The system automatically
        /// retrieves this value from the user profile by referencing the associated email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// Specifies the contact phone number of the assignee responsible for the opportunity
        /// or engagement. This field enables direct communication for time-sensitive matters
        /// and facilitates coordination between AWS and partner teams.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Checks to see if the Phone property is set.
        /// </summary>
        internal bool IsSetPhone() => this.Phone != null;
    }
}
