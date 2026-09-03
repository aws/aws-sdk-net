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

namespace Amazon.SupportApp.Model
{
    /// <summary>
    /// This is the response object from the UpdateSlackChannelConfiguration operation.
    /// </summary>
    public partial class UpdateSlackChannelConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel ID in Slack. This ID identifies a channel within a Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the Slack channel that you configure for the Amazon Web Services Support
        /// App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChannelRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that you want to use to perform operations
        /// on Amazon Web Services. For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/support-app-permissions.html">Managing
        /// access to the Amazon Web Services Support App</a> in the <i>Amazon Web Services Support
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31, Max = 2048)]
        public string ChannelRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelRoleArn property is set.
        /// </summary>
        internal bool IsSetChannelRoleArn() => this.ChannelRoleArn != null;

        /// <summary>
        /// Gets and sets the property NotifyOnAddCorrespondenceToCase. 
        /// <para>
        /// Whether you want to get notified when a support case has a new correspondence.
        /// </para>
        /// </summary>
        public bool? NotifyOnAddCorrespondenceToCase { get; set; }

        /// <summary>
        /// Checks to see if the NotifyOnAddCorrespondenceToCase property is set.
        /// </summary>
        internal bool IsSetNotifyOnAddCorrespondenceToCase() => this.NotifyOnAddCorrespondenceToCase.HasValue;

        /// <summary>
        /// Gets and sets the property NotifyOnCaseSeverity. 
        /// <para>
        /// The case severity for a support case that you want to receive notifications.
        /// </para>
        /// </summary>
        public NotificationSeverityLevel NotifyOnCaseSeverity { get; set; }

        /// <summary>
        /// Checks to see if the NotifyOnCaseSeverity property is set.
        /// </summary>
        internal bool IsSetNotifyOnCaseSeverity() => this.NotifyOnCaseSeverity != null;

        /// <summary>
        /// Gets and sets the property NotifyOnCreateOrReopenCase. 
        /// <para>
        /// Whether you want to get notified when a support case is created or reopened.
        /// </para>
        /// </summary>
        public bool? NotifyOnCreateOrReopenCase { get; set; }

        /// <summary>
        /// Checks to see if the NotifyOnCreateOrReopenCase property is set.
        /// </summary>
        internal bool IsSetNotifyOnCreateOrReopenCase() => this.NotifyOnCreateOrReopenCase.HasValue;

        /// <summary>
        /// Gets and sets the property NotifyOnResolveCase. 
        /// <para>
        /// Whether you want to get notified when a support case is resolved.
        /// </para>
        /// </summary>
        public bool? NotifyOnResolveCase { get; set; }

        /// <summary>
        /// Checks to see if the NotifyOnResolveCase property is set.
        /// </summary>
        internal bool IsSetNotifyOnResolveCase() => this.NotifyOnResolveCase.HasValue;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The team ID in Slack. This ID uniquely identifies a Slack workspace, such as <c>T012ABCDEFG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;
    }
}
