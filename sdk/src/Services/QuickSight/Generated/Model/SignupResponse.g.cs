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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A <c>SignupResponse</c> object that contains a summary of a newly created account.
    /// </summary>
    public partial class SignupResponse
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your Quick Sight account.
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The type of Active Directory that is being used to authenticate the Amazon Quick Sight
        /// account. Valid values are <c>SIMPLE_AD</c>, <c>AD_CONNECTOR</c>, and <c>MICROSOFT_AD</c>.
        /// </para>
        /// </summary>
        public string DirectoryType { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryType property is set.
        /// </summary>
        internal bool IsSetDirectoryType() => this.DirectoryType != null;

        /// <summary>
        /// Gets and sets the property IAMUser. 
        /// <para>
        /// A Boolean that is <c>TRUE</c> if the Amazon Quick Sight uses IAM as an authentication
        /// method.
        /// </para>
        /// </summary>
        public bool? IAMUser { get; set; }

        /// <summary>
        /// Checks to see if the IAMUser property is set.
        /// </summary>
        internal bool IsSetIAMUser() => this.IAMUser.HasValue;

        /// <summary>
        /// Gets and sets the property UserLoginName. 
        /// <para>
        /// The user login name for your Amazon Quick Sight account.
        /// </para>
        /// </summary>
        public string UserLoginName { get; set; }

        /// <summary>
        /// Checks to see if the UserLoginName property is set.
        /// </summary>
        internal bool IsSetUserLoginName() => this.UserLoginName != null;
    }
}
