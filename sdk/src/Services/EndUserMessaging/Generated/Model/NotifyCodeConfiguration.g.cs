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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// Contains the settings of a notify code configuration, which is a reusable one-time
    /// passcode policy.
    /// </summary>
    public partial class NotifyCodeConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChannelParameters. 
        /// <para>
        /// The channel-specific parameters used to render and deliver the one-time passcode.
        /// A configuration can carry parameters for every channel at once, and the send route
        /// selects the matching channel at send time.
        /// </para>
        /// </summary>
        public ChannelParameters ChannelParameters { get; set; }

        /// <summary>
        /// Checks to see if the ChannelParameters property is set.
        /// </summary>
        internal bool IsSetChannelParameters() => this.ChannelParameters != null;

        /// <summary>
        /// Gets and sets the property CodeConfigurationParameters. 
        /// <para>
        /// The passcode policy parameters, including the code type, length, validity period,
        /// and maximum number of attempts.
        /// </para>
        /// </summary>
        public CodeConfigurationParameters CodeConfigurationParameters { get; set; }

        /// <summary>
        /// Checks to see if the CodeConfigurationParameters property is set.
        /// </summary>
        internal bool IsSetCodeConfigurationParameters() => this.CodeConfigurationParameters != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the resource was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 256)]
        public string NotifyCodeConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotifyCodeConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotifyCodeConfigurationArn() => this.NotifyCodeConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationId. 
        /// <para>
        /// The unique identifier of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string NotifyCodeConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the NotifyCodeConfigurationId property is set.
        /// </summary>
        internal bool IsSetNotifyCodeConfigurationId() => this.NotifyCodeConfigurationId != null;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationName. 
        /// <para>
        /// The name of the notify code configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string NotifyCodeConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the NotifyCodeConfigurationName property is set.
        /// </summary>
        internal bool IsSetNotifyCodeConfigurationName() => this.NotifyCodeConfigurationName != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
