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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// IAM access key details related to a finding.
    /// </summary>
    public partial class AwsIamAccessKeyDetails
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The identifier of the access key.
        /// </para>
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account for the key.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the IAM access key was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal associated with an access key.
        /// </para>
        /// </summary>
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property PrincipalName. 
        /// <para>
        /// The name of the principal.
        /// </para>
        /// </summary>
        public string PrincipalName { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalName property is set.
        /// </summary>
        internal bool IsSetPrincipalName() => this.PrincipalName != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of principal associated with an access key.
        /// </para>
        /// </summary>
        public string PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;

        /// <summary>
        /// Gets and sets the property SessionContext. 
        /// <para>
        /// Information about the session that the key was used for.
        /// </para>
        /// </summary>
        public AwsIamAccessKeySessionContext SessionContext { get; set; }

        /// <summary>
        /// Checks to see if the SessionContext property is set.
        /// </summary>
        internal bool IsSetSessionContext() => this.SessionContext != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the IAM access key related to a finding.
        /// </para>
        /// </summary>
        public AwsIamAccessKeyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user associated with the IAM access key related to a finding.
        /// </para>
        ///  
        /// <para>
        /// The <c>UserName</c> parameter has been replaced with the <c>PrincipalName</c> parameter
        /// because access keys can also be assigned to principals that are not IAM users.
        /// </para>
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use PrincipalName.")]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
