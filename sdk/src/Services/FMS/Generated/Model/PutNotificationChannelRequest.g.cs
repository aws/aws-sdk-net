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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutNotificationChannel operation. Designates the
    /// IAM role and Amazon Simple Notification Service (SNS) topic that Firewall Manager
    /// uses to record SNS logs. <para> To perform this action outside of the console, you
    /// must first configure the SNS topic's access policy to allow the <c>SnsRoleName</c>
    /// to publish SNS logs. If the <c>SnsRoleName</c> provided is a role other than the <c>AWSServiceRoleForFMS</c>
    /// service-linked role, this role must have a trust relationship configured to allow
    /// the Firewall Manager service principal <c>fms.amazonaws.com</c> to assume this role.
    /// For information about configuring an SNS access policy, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
    /// roles for Firewall Manager</a> in the <i>Firewall Manager Developer Guide</i>. </para>
    /// </summary>
    public partial class PutNotificationChannelRequest : AmazonFMSRequest
    {
        /// <summary>
        /// Gets and sets the property SnsRoleName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Amazon SNS to record Firewall
        /// Manager activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SnsRoleName { get; set; }

        /// <summary>
        /// Checks to see if the SnsRoleName property is set.
        /// </summary>
        internal bool IsSetSnsRoleName() => this.SnsRoleName != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SNS topic that collects notifications from Firewall
        /// Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;
    }
}
