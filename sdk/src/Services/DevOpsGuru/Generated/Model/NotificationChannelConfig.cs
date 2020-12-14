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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about notification channels you have configured with DevOps Guru. The
    /// one supported notification channel is Amazon Simple Notification Service (Amazon SNS).
    /// </summary>
    public partial class NotificationChannelConfig
    {
        private SnsChannelConfig _sns;

        /// <summary>
        /// Gets and sets the property Sns. 
        /// <para>
        ///  Information about a notification channel configured in DevOps Guru to send notifications
        /// when insights are created. 
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon SNS topic in another account, you must attach a policy to it
        /// that grants DevOps Guru permission to it notifications. DevOps Guru adds the required
        /// policy on your behalf to send notifications using Amazon SNS in your account. For
        /// more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-required-permissions.html">Permissions
        /// for cross account Amazon SNS topics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use an Amazon SNS topic that is encrypted by an AWS Key Management Service
        /// customer-managed key (CMK), then you must add permissions to the CMK. For more information,
        /// see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/sns-kms-permissions.html">Permissions
        /// for AWS KMS–encrypted Amazon SNS topics</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnsChannelConfig Sns
        {
            get { return this._sns; }
            set { this._sns = value; }
        }

        // Check to see if Sns property is set
        internal bool IsSetSns()
        {
            return this._sns != null;
        }

    }
}