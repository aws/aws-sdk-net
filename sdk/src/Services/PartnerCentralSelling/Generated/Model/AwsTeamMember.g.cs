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
    /// Represents an Amazon Web Services team member for the engagement. This structure includes
    /// details such as name, email, and business title.
    /// </summary>
    public partial class AwsTeamMember
    {
        /// <summary>
        /// Gets and sets the property BusinessTitle. 
        /// <para>
        /// Specifies the Amazon Web Services team member's business title and indicates their
        /// organizational role.
        /// </para>
        /// </summary>
        public AwsMemberBusinessTitle BusinessTitle { get; set; }

        /// <summary>
        /// Checks to see if the BusinessTitle property is set.
        /// </summary>
        internal bool IsSetBusinessTitle() => this.BusinessTitle != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Provides the Amazon Web Services team member's email address.
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
        /// Provides the Amazon Web Services team member's first name.
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
        /// Provides the Amazon Web Services team member's last name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;
    }
}
