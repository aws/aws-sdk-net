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
    /// An object that contains a <c>Customer Partner</c>'s contact details.
    /// </summary>
    public partial class Contact
    {
        /// <summary>
        /// Gets and sets the property BusinessTitle. 
        /// <para>
        /// The partner contact's title (job title or role) associated with the <c>Opportunity</c>.
        /// <c>BusinessTitle</c> supports either <c>PartnerAccountManager</c> or <c>OpportunityOwner</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string BusinessTitle { get; set; }

        /// <summary>
        /// Checks to see if the BusinessTitle property is set.
        /// </summary>
        internal bool IsSetBusinessTitle() => this.BusinessTitle != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The contact's email address associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The contact's first name associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The contact's last name associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// The contact's phone number associated with the <c>Opportunity</c>.
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
