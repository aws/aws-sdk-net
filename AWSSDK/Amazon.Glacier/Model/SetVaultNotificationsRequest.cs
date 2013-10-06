/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>This operation configures notifications that will be sent when specific events happen to a vault. By default, you don't get any
    /// notifications. </para> <para>To configure vault notifications, send a PUT request to the <c>notification-configuration</c> subresource of
    /// the vault. The request should include a JSON document that provides an Amazon SNS topic and specific events for which you want Amazon
    /// Glacier to send notifications to the topic.</para> <para>Amazon SNS topics must grant permission to the vault to be allowed to publish
    /// notifications to the topic. You can configure a vault to publish a notification for the following vault events:</para>
    /// <ul>
    /// <li> <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated for an archive retrieval is completed (InitiateJob).
    /// The status of the completed job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the same output as returned from
    /// DescribeJob. </li>
    /// <li> <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated for an inventory retrieval is completed
    /// (InitiateJob). The status of the completed job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the same output as
    /// returned from DescribeJob. </li>
    /// 
    /// </ul>
    /// <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access Management (IAM) users don't
    /// have any permissions by default. You must grant them explicit permission to perform specific actions. For more information, see Access
    /// Control Using AWS Identity and Access Management (IAM).</para> <para>For conceptual information and underlying REST API, go to Configuring
    /// Vault Notifications in Amazon Glacier and Set Vault Notification Configuration in the <i>Amazon Glacier Developer Guide</i> .
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.Glacier.AmazonGlacier.SetVaultNotifications"/>
    public class SetVaultNotificationsRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;
        private VaultNotificationConfig vaultNotificationConfig;

        /// <summary>
        /// The <c>AccountId</c> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses
        /// the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it.
        ///  
        /// </summary>
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = value; }
        }

        /// <summary>
        /// Sets the AccountId property
        /// </summary>
        /// <param name="accountId">The value to set for the AccountId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetVaultNotificationsRequest WithAccountId(string accountId)
        {
            this.accountId = accountId;
            return this;
        }
            

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this.accountId != null;       
        }

        /// <summary>
        /// The name of the vault.
        ///  
        /// </summary>
        public string VaultName
        {
            get { return this.vaultName; }
            set { this.vaultName = value; }
        }

        /// <summary>
        /// Sets the VaultName property
        /// </summary>
        /// <param name="vaultName">The value to set for the VaultName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetVaultNotificationsRequest WithVaultName(string vaultName)
        {
            this.vaultName = vaultName;
            return this;
        }
            

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;       
        }

        /// <summary>
        /// Provides options for specifying notification configuration.
        ///  
        /// </summary>
        public VaultNotificationConfig VaultNotificationConfig
        {
            get { return this.vaultNotificationConfig; }
            set { this.vaultNotificationConfig = value; }
        }

        /// <summary>
        /// Sets the VaultNotificationConfig property
        /// </summary>
        /// <param name="vaultNotificationConfig">The value to set for the VaultNotificationConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetVaultNotificationsRequest WithVaultNotificationConfig(VaultNotificationConfig vaultNotificationConfig)
        {
            this.vaultNotificationConfig = vaultNotificationConfig;
            return this;
        }
            

        // Check to see if VaultNotificationConfig property is set
        internal bool IsSetVaultNotificationConfig()
        {
            return this.vaultNotificationConfig != null;       
        }
    }
}
    
