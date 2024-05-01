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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about a notification channel. A notification channel is used to notify
    /// you when DevOps Guru creates an insight. The one supported notification channel is
    /// Amazon Simple Notification Service (Amazon SNS). 
    /// 
    ///  
    /// <para>
    /// If you use an Amazon SNS topic in another account, you must attach a policy to it
    /// that grants DevOps Guru permission to send it notifications. DevOps Guru adds the
    /// required policy on your behalf to send notifications using Amazon SNS in your account.
    /// DevOps Guru only supports standard SNS topics. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-required-permissions.html">Permissions
    /// for Amazon SNS topics</a>.
    /// </para>
    ///  
    /// <para>
    /// If you use an Amazon SNS topic that is encrypted by an Amazon Web Services Key Management
    /// Service customer-managed key (CMK), then you must add permissions to the CMK. For
    /// more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-kms-permissions.html">Permissions
    /// for Amazon Web Services KMS–encrypted Amazon SNS topics</a>.
    /// </para>
    /// </summary>
    public partial class NotificationChannel
    {
        private NotificationChannelConfig _config;
        private string _id;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        ///  A <c>NotificationChannelConfig</c> object that contains information about configured
        /// notification channels. 
        /// </para>
        /// </summary>
        public NotificationChannelConfig Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of a notification channel. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}