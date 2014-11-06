/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the SetVaultNotifications operation.
    /// This operation configures notifications that will be sent when specific events happen
    /// to a vault. By default, you don't get any notifications. 
    /// 
    ///  
    /// <para>
    /// To configure vault notifications, send a PUT request to the <code class="code">notification-configuration</code>
    /// subresource of the vault. The request should include a JSON document that provides
    /// an Amazon SNS topic and specific events for which you want Amazon Glacier to send
    /// notifications to the topic.
    /// </para>
    ///  
    /// <para>
    /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
    /// to the topic. You can configure a vault to publish a notification for the following
    /// vault events:
    /// </para>
    ///  <ul> <li> <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was
    /// initiated for an archive retrieval is completed (<a>InitiateJob</a>). The status of
    /// the completed job can be "Succeeded" or "Failed". The notification sent to the SNS
    /// topic is the same output as returned from <a>DescribeJob</a>. </li> <li> <b>InventoryRetrievalCompleted</b>
    /// This event occurs when a job that was initiated for an inventory retrieval is completed
    /// (<a>InitiateJob</a>). The status of the completed job can be "Succeeded" or "Failed".
    /// The notification sent to the SNS topic is the same output as returned from <a>DescribeJob</a>.
    /// </li> </ul> 
    /// <para>
    /// An AWS account has full permission to perform all operations (actions). However, AWS
    /// Identity and Access Management (IAM) users don't have any permissions by default.
    /// You must grant them explicit permission to perform specific actions. For more information,
    /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
    /// Control Using AWS Identity and Access Management (IAM)</a>.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
    /// Vault Notifications in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
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
        /// <param name="accountId">The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it. </param>
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
        /// The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account
        /// ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated
        /// with the credentials used to sign the request. If you specify your Account ID, do
        /// not include hyphens in it. 
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
        /// Gets and sets the property VaultName. 
        /// <para>
        /// The name of the vault.
        /// </para>
        /// </summary>
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