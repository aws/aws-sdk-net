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
    /// Provides information about the status and settings of the email channel for an application.
    /// </summary>
    public partial class EmailChannelResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the email channel applies to.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_ConfigurationSet.html">Amazon
        /// SES configuration set</a> that's applied to messages that are sent through the channel.
        /// </para>
        /// </summary>
        public string ConfigurationSet { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSet property is set.
        /// </summary>
        internal bool IsSetConfigurationSet() => this.ConfigurationSet != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the email channel was enabled.
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the email channel is enabled for the application.
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
        /// The verified email address that email is sent from when you send email through the
        /// channel.
        /// </para>
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property HasCredential. 
        /// <para>
        /// (Not used) This property is retained only for backward compatibility.
        /// </para>
        /// </summary>
        public bool? HasCredential { get; set; }

        /// <summary>
        /// Checks to see if the HasCredential property is set.
        /// </summary>
        internal bool IsSetHasCredential() => this.HasCredential.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// (Deprecated) An identifier for the email channel. This property is retained only for
        /// backward compatibility.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity, verified with Amazon Simple Email
        /// Service (Amazon SES), that's used when you send email through the channel.
        /// </para>
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Specifies whether the email channel is archived.
        /// </para>
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Checks to see if the IsArchived property is set.
        /// </summary>
        internal bool IsSetIsArchived() => this.IsArchived.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The user who last modified the email channel.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the email channel was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property MessagesPerSecond. 
        /// <para>
        /// The maximum number of emails that can be sent through the channel each second.
        /// </para>
        /// </summary>
        public int? MessagesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MessagesPerSecond property is set.
        /// </summary>
        internal bool IsSetMessagesPerSecond() => this.MessagesPerSecond.HasValue;

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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The type of messaging or notification platform for the channel. For the email channel,
        /// this value is EMAIL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the AWS Identity and Access Management (IAM) role that Amazon Pinpoint
        /// uses to submit email-related event data for the channel.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the email channel.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
