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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the GetVaultNotifications operation.
    /// This operation retrieves the <code>notification-configuration</code> subresource of
    /// the specified vault.
    /// 
    ///  
    /// <para>
    /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
    /// If a notification configuration for a vault is not set, the operation returns a <code>404
    /// Not Found</code> error. For more information about vault notifications, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
    /// Vault Notifications in Amazon S3 Glacier</a>. 
    /// </para>
    ///  
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
    /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html">Get
    /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class GetVaultNotificationsRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _vaultName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetVaultNotificationsRequest() { }

        /// <summary>
        /// Instantiates GetVaultNotificationsRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        public GetVaultNotificationsRequest(string vaultName)
        {
            _vaultName = vaultName;
        }

        /// <summary>
        /// Instantiates GetVaultNotificationsRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <code>AccountId</code> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<code>-</code>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        public GetVaultNotificationsRequest(string accountId, string vaultName)
        {
            _accountId = accountId;
            _vaultName = vaultName;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>AccountId</code> value is the AWS account ID of the account that owns the
        /// vault. You can either specify an AWS account ID or optionally a single '<code>-</code>'
        /// (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with
        /// the credentials used to sign the request. If you use an account ID, do not include
        /// any hyphens ('-') in the ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VaultName
        {
            get { return this._vaultName; }
            set { this._vaultName = value; }
        }

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this._vaultName != null;
        }

    }
}