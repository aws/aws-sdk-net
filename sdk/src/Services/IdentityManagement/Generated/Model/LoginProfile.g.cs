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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the user name and password create date for a user.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateLoginProfile.html">CreateLoginProfile</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetLoginProfile.html">GetLoginProfile</a>
    /// operations. 
    /// </para>
    /// </summary>
    public partial class LoginProfile
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public LoginProfile() { }

        /// <summary>
        /// Instantiates LoginProfile with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user, which can be used for signing in to the Amazon Web Services Management Console.</param>
        /// <param name="createDate">The date when the password for the user was created.</param>
        public LoginProfile(string userName, DateTime? createDate)
        {
            this.UserName = userName;
            this.CreateDate = createDate;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the password for the user was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordResetRequired. 
        /// <para>
        /// Specifies whether the user is required to set a new password on next sign-in.
        /// </para>
        /// </summary>
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// Checks to see if the PasswordResetRequired property is set.
        /// </summary>
        internal bool IsSetPasswordResetRequired() => this.PasswordResetRequired.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user, which can be used for signing in to the Amazon Web Services
        /// Management Console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
