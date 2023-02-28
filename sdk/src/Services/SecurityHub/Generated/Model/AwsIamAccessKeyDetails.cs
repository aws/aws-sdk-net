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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// IAM access key details related to a finding.
    /// </summary>
    public partial class AwsIamAccessKeyDetails
    {
        private string _accessKeyId;
        private string _accountId;
        private string _createdAt;
        private string _principalId;
        private string _principalName;
        private string _principalType;
        private AwsIamAccessKeySessionContext _sessionContext;
        private AwsIamAccessKeyStatus _status;
        private string _userName;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The identifier of the access key.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account for the key.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the IAM access key was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal associated with an access key.
        /// </para>
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalName. 
        /// <para>
        /// The name of the principal.
        /// </para>
        /// </summary>
        public string PrincipalName
        {
            get { return this._principalName; }
            set { this._principalName = value; }
        }

        // Check to see if PrincipalName property is set
        internal bool IsSetPrincipalName()
        {
            return this._principalName != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of principal associated with an access key.
        /// </para>
        /// </summary>
        public string PrincipalType
        {
            get { return this._principalType; }
            set { this._principalType = value; }
        }

        // Check to see if PrincipalType property is set
        internal bool IsSetPrincipalType()
        {
            return this._principalType != null;
        }

        /// <summary>
        /// Gets and sets the property SessionContext. 
        /// <para>
        /// Information about the session that the key was used for.
        /// </para>
        /// </summary>
        public AwsIamAccessKeySessionContext SessionContext
        {
            get { return this._sessionContext; }
            set { this._sessionContext = value; }
        }

        // Check to see if SessionContext property is set
        internal bool IsSetSessionContext()
        {
            return this._sessionContext != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the IAM access key related to a finding.
        /// </para>
        /// </summary>
        public AwsIamAccessKeyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user associated with the IAM access key related to a finding.
        /// </para>
        ///  
        /// <para>
        /// The <code>UserName</code> parameter has been replaced with the <code>PrincipalName</code>
        /// parameter because access keys can also be assigned to principals that are not IAM
        /// users.
        /// </para>
        /// </summary>
        [Obsolete("This filter is deprecated. Instead, use PrincipalName.")]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}