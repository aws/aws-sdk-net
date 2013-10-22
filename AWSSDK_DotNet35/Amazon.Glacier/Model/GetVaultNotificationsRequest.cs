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
    /// Container for the parameters to the GetVaultNotifications operation.
    /// <para>This operation retrieves the <c>notification-configuration</c> subresource of the specified vault.</para> <para>For information about
    /// setting a notification configuration on a vault, see SetVaultNotifications. If a notification configuration for a vault is not set, the
    /// operation returns a <c>404 Not Found</c> error. For more information about vault notifications, see <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html" >Configuring Vault Notifications in Amazon
    /// Glacier</a> . </para> <para>An AWS account has full permission to perform all operations (actions). However, AWS Identity and Access
    /// Management (IAM) users don't have any permissions by default. You must grant them explicit permission to perform specific actions. For more
    /// information, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html" >Access Control Using AWS
    /// Identity and Access Management (IAM)</a> .</para> <para>For conceptual information and underlying REST API, go to <a
    /// href="http://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html" >Configuring Vault Notifications in Amazon
    /// Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html" >Get Vault Notification
    /// Configuration </a> in the <i>Amazon Glacier Developer Guide</i> .
    /// </para>
    /// </summary>
    public partial class GetVaultNotificationsRequest : AmazonWebServiceRequest
    {
        private string accountId;
        private string vaultName;

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

        // Check to see if VaultName property is set
        internal bool IsSetVaultName()
        {
            return this.vaultName != null;
        }

    }
}
    
