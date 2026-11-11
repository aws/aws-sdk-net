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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the identity of a user.
    /// 
    ///  <note> 
    /// <para>
    /// For Connect Customer instances that are created with the <c>EXISTING_DIRECTORY</c>
    /// identity management type, <c>FirstName</c>, <c>LastName</c>, and <c>Email</c> cannot
    /// be updated from within Connect Customer because they are managed by the directory.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// The <c>FirstName</c> and <c>LastName</c> length constraints below apply only to instances
    /// using SAML for identity management. If you are using Connect Customer for identity
    /// management, the length constraints are 1-255 for <c>FirstName</c>, and 1-256 for <c>LastName</c>.
    /// 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UserIdentityInfo
    {
        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address. If you are using SAML for identity management and include this
        /// parameter, an error is returned.
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
        /// The first name. This is required if you are using Connect Customer or SAML for identity
        /// management. Inputs must be in Unicode Normalization Form C (NFC). Text containing
        /// characters in a non-NFC form (for example, decomposed characters or combining marks)
        /// are not accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 255)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name. This is required if you are using Connect Customer or SAML for identity
        /// management. Inputs must be in Unicode Normalization Form C (NFC). Text containing
        /// characters in a non-NFC form (for example, decomposed characters or combining marks)
        /// are not accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 300)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property Mobile. 
        /// <para>
        /// The user's mobile number.
        /// </para>
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Checks to see if the Mobile property is set.
        /// </summary>
        internal bool IsSetMobile() => this.Mobile != null;

        /// <summary>
        /// Gets and sets the property SecondaryEmail. 
        /// <para>
        /// The user's secondary email address. If you provide a secondary email, the user receives
        /// email notifications - other than password reset notifications - to this email address
        /// instead of to their primary email address.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>(?=^.{0,265}$)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,63}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SecondaryEmail { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryEmail property is set.
        /// </summary>
        internal bool IsSetSecondaryEmail() => this.SecondaryEmail != null;
    }
}
