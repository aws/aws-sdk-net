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
    /// Container for the parameters to the DeleteSlackChannelConfiguration operation. Deletes
    /// a Slack channel configuration from your Amazon Web Services account. This operation
    /// doesn't delete your Slack channel.
    /// </summary>
    public partial class DeleteSlackChannelConfigurationRequest : AmazonSupportAppRequest
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
