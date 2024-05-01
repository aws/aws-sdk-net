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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the SetVaultNotifications operation.
    /// This operation configures notifications that will be sent when specific events happen
    /// to a vault. By default, you don't get any notifications.
    /// 
    ///  
    /// <para>
    /// To configure vault notifications, send a PUT request to the <c>notification-configuration</c>
    /// subresource of the vault. The request should include a JSON document that provides
    /// an Amazon SNS topic and specific events for which you want Amazon S3 Glacier to send
    /// notifications to the topic.
    /// </para>
    ///  
    /// <para>
    /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
    /// to the topic. You can configure a vault to publish a notification for the following
    /// vault events:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated
    /// for an archive retrieval is completed (<a>InitiateJob</a>). The status of the completed
    /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
    /// same output as returned from <a>DescribeJob</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated
    /// for an inventory retrieval is completed (<a>InitiateJob</a>). The status of the completed
    /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
    /// same output as returned from <a>DescribeJob</a>. 
    /// </para>
    ///  </li> </ul> 
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
    /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
    /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class SetVaultNotificationsRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private string _vaultName;
        private VaultNotificationConfig _vaultNotificationConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetVaultNotificationsRequest() { }

        /// <summary>
        /// Instantiates SetVaultNotificationsRequest with the parameterized properties
        /// </summary>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="vaultNotificationConfig">Provides options for specifying notification configuration.</param>
        public SetVaultNotificationsRequest(string vaultName, VaultNotificationConfig vaultNotificationConfig)
        {
            _vaultName = vaultName;
            _vaultNotificationConfig = vaultNotificationConfig;
        }

        /// <summary>
        /// Instantiates SetVaultNotificationsRequest with the parameterized properties
        /// </summary>
        /// <param name="accountId">The <c>AccountId</c> value is the AWS account ID of the account that owns the vault. You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials used to sign the request. If you use an account ID, do not include any hyphens ('-') in the ID.</param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <param name="vaultNotificationConfig">Provides options for specifying notification configuration.</param>
        public SetVaultNotificationsRequest(string accountId, string vaultName, VaultNotificationConfig vaultNotificationConfig)
        {
            _accountId = accountId;
            _vaultName = vaultName;
            _vaultNotificationConfig = vaultNotificationConfig;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID of the account that owns the vault.
        /// You can either specify an AWS account ID or optionally a single '<c>-</c>' (hyphen),
        /// in which case Amazon S3 Glacier uses the AWS account ID associated with the credentials
        /// used to sign the request. If you use an account ID, do not include any hyphens ('-')
        /// in the ID.
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

        /// <summary>
        /// Gets and sets the property VaultNotificationConfig. 
        /// <para>
        /// Provides options for specifying notification configuration.
        /// </para>
        /// </summary>
        public VaultNotificationConfig VaultNotificationConfig
        {
            get { return this._vaultNotificationConfig; }
            set { this._vaultNotificationConfig = value; }
        }

        // Check to see if VaultNotificationConfig property is set
        internal bool IsSetVaultNotificationConfig()
        {
            return this._vaultNotificationConfig != null;
        }

    }
}