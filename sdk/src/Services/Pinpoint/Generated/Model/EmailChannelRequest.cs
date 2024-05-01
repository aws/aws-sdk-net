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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private string _configurationSet;
        private bool? _enabled;
        private string _fromAddress;
        private string _identity;
        private string _orchestrationSendingRoleArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_ConfigurationSet.html">Amazon
        /// SES configuration set</a> that you want to apply to messages that you send through
        /// the channel.
        /// </para>
        /// </summary>
        public string ConfigurationSet
        {
            get { return this._configurationSet; }
            set { this._configurationSet = value; }
        }

        // Check to see if ConfigurationSet property is set
        internal bool IsSetConfigurationSet()
        {
            return this._configurationSet != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the email channel for the application.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromAddress.  
        /// <para>
        /// The verified email address that you want to send email from when you send email through
        /// the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Identity.  
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity, verified with Amazon Simple Email
        /// Service (Amazon SES), that you want to use when you send email through the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationSendingRoleArn. 
        /// <para>
        /// The ARN of an IAM role for Amazon Pinpoint to use to send email from your campaigns
        /// or journeys through Amazon SES.
        /// </para>
        /// </summary>
        public string OrchestrationSendingRoleArn
        {
            get { return this._orchestrationSendingRoleArn; }
            set { this._orchestrationSendingRoleArn = value; }
        }

        // Check to see if OrchestrationSendingRoleArn property is set
        internal bool IsSetOrchestrationSendingRoleArn()
        {
            return this._orchestrationSendingRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn.  
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that you want Amazon
        /// Pinpoint to use when it submits email-related event data for the channel.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}