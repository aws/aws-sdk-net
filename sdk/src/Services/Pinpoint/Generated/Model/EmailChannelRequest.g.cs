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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the email channel for an application.
    /// </summary>
    public partial class EmailChannelRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_ConfigurationSet.html">Amazon
        /// SES configuration set</a> that you want to apply to messages that you send through
        /// the channel.
        /// </para>
        /// </summary>
        public string ConfigurationSet { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSet property is set.
        /// </summary>
        internal bool IsSetConfigurationSet() => this.ConfigurationSet != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the email channel for the application.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address that you want to send email from when you send email through
        /// the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity, verified with Amazon Simple Email
        /// Service (Amazon SES), that you want to use when you send email through the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property OrchestrationSendingRoleArn. 
        /// <para>
        /// The ARN of an IAM role for Amazon Pinpoint to use to send email from your campaigns
        /// or journeys through Amazon SES.
        /// </para>
        /// </summary>
        public string OrchestrationSendingRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the OrchestrationSendingRoleArn property is set.
        /// </summary>
        internal bool IsSetOrchestrationSendingRoleArn() => this.OrchestrationSendingRoleArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that you want Amazon
        /// Pinpoint to use when it submits email-related event data for the channel.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
