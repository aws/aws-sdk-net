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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
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
        private string _channelId;
        private string _channelName;
        private string _channelRoleArn;
        private bool? _notifyOnAddCorrespondenceToCase;
        private NotificationSeverityLevel _notifyOnCaseSeverity;
        private bool? _notifyOnCreateOrReopenCase;
        private bool? _notifyOnResolveCase;
        private string _teamId;

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The channel ID in Slack. This ID identifies a channel within a Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the Slack channel that you configure for the Amazon Web Services Support
        /// App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that you want to use to perform operations
        /// on Amazon Web Services. For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/support-app-permissions.html">Managing
        /// access to the Amazon Web Services Support App</a> in the <i>Amazon Web Services Support
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31, Max=2048)]
        public string ChannelRoleArn
        {
            get { return this._channelRoleArn; }
            set { this._channelRoleArn = value; }
        }

        // Check to see if ChannelRoleArn property is set
        internal bool IsSetChannelRoleArn()
        {
            return this._channelRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyOnAddCorrespondenceToCase. 
        /// <para>
        /// Whether you want to get notified when a support case has a new correspondence.
        /// </para>
        /// </summary>
        public bool? NotifyOnAddCorrespondenceToCase
        {
            get { return this._notifyOnAddCorrespondenceToCase; }
            set { this._notifyOnAddCorrespondenceToCase = value; }
        }

        // Check to see if NotifyOnAddCorrespondenceToCase property is set
        internal bool IsSetNotifyOnAddCorrespondenceToCase()
        {
            return this._notifyOnAddCorrespondenceToCase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotifyOnCaseSeverity. 
        /// <para>
        /// The case severity for a support case that you want to receive notifications.
        /// </para>
        /// </summary>
        public NotificationSeverityLevel NotifyOnCaseSeverity
        {
            get { return this._notifyOnCaseSeverity; }
            set { this._notifyOnCaseSeverity = value; }
        }

        // Check to see if NotifyOnCaseSeverity property is set
        internal bool IsSetNotifyOnCaseSeverity()
        {
            return this._notifyOnCaseSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyOnCreateOrReopenCase. 
        /// <para>
        /// Whether you want to get notified when a support case is created or reopened.
        /// </para>
        /// </summary>
        public bool? NotifyOnCreateOrReopenCase
        {
            get { return this._notifyOnCreateOrReopenCase; }
            set { this._notifyOnCreateOrReopenCase = value; }
        }

        // Check to see if NotifyOnCreateOrReopenCase property is set
        internal bool IsSetNotifyOnCreateOrReopenCase()
        {
            return this._notifyOnCreateOrReopenCase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotifyOnResolveCase. 
        /// <para>
        /// Whether you want to get notified when a support case is resolved.
        /// </para>
        /// </summary>
        public bool? NotifyOnResolveCase
        {
            get { return this._notifyOnResolveCase; }
            set { this._notifyOnResolveCase = value; }
        }

        // Check to see if NotifyOnResolveCase property is set
        internal bool IsSetNotifyOnResolveCase()
        {
            return this._notifyOnResolveCase.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The team ID in Slack. This ID uniquely identifies a Slack workspace, such as <c>T012ABCDEFG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

    }
}