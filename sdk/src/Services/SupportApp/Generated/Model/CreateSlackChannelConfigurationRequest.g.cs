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
    /// Container for the parameters to the CreateSlackChannelConfiguration operation. Creates
    /// a Slack channel configuration for your Amazon Web Services account. <note> <ul> <li>
    /// <para> You can add up to 5 Slack workspaces for your account. </para> </li> <li> <para>
    /// You can add up to 20 Slack channels for your account. </para> </li> </ul> </note>
    /// <para> A Slack channel can have up to 100 Amazon Web Services accounts. This means
    /// that only 100 accounts can add the same Slack channel to the Amazon Web Services Support
    /// App. We recommend that you only add the accounts that you need to manage support cases
    /// for your organization. This can reduce the notifications about case updates that you
    /// receive in the Slack channel. </para> <note> <para> We recommend that you choose a
    /// private Slack channel so that only members in that channel have read and write access
    /// to your support cases. Anyone in your Slack channel can create, update, or resolve
    /// support cases for your account. Users require an invitation to join private channels.
    /// </para> </note>
    /// </summary>
    public partial class CreateSlackChannelConfigurationRequest : AmazonSupportAppRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel ID in Slack. This ID identifies a channel within a Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
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
        [AWSProperty(Required = true, Min = 31, Max = 2048)]
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
        ///  
        /// <para>
        /// If you specify <c>high</c> or <c>all</c>, you must specify <c>true</c> for at least
        /// one of the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>notifyOnAddCorrespondenceToCase</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>notifyOnCreateOrReopenCase</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>notifyOnResolveCase</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <c>none</c>, the following parameters must be null or <c>false</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>notifyOnAddCorrespondenceToCase</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>notifyOnCreateOrReopenCase</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>notifyOnResolveCase</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you don't specify these parameters in your request, they default to <c>false</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;
    }
}
