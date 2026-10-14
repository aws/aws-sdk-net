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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes an assignment of an Amazon Web Services account to a principal
    /// and the permissions that principal has in the account.
    /// </summary>
    public partial class AccountAssignmentForPrincipal
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID number of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property PermissionSetArn. 
        /// <para>
        /// The ARN of the IAM Identity Center permission set assigned to this principal for this
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string PermissionSetArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionSetArn property is set.
        /// </summary>
        internal bool IsSetPermissionSetArn() => this.PermissionSetArn != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of the principal.
        /// </para>
        /// </summary>
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;
    }
}
