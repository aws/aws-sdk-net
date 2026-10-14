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
    /// Container for the parameters to the UpdateNotifyCodeConfiguration operation. Updates
    /// the mutable fields of a notify code configuration. Only the fields that you supply
    /// are changed. For the template and language fields, supplying an empty value clears
    /// the currently stored value.
    /// </summary>
    public partial class UpdateNotifyCodeConfigurationRequest : AmazonEndUserMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelParameters. 
        /// <para>
        /// The updated channel-specific parameters used to render and deliver the one-time passcode.
        /// This is a loose, nested update: when you omit a channel, that channel's parameters
        /// remain unchanged. Within a supplied channel, an empty string on a string member, or
        /// an empty map on the destination-country parameters, clears the currently stored value,
        /// and absent members preserve the current value.
        /// </para>
        /// </summary>
        public UpdateChannelParameters ChannelParameters { get; set; }

        /// <summary>
        /// Checks to see if the ChannelParameters property is set.
        /// </summary>
        internal bool IsSetChannelParameters() => this.ChannelParameters != null;

        /// <summary>
        /// Gets and sets the property CodeConfigurationParameters. 
        /// <para>
        /// The updated passcode policy parameters, including the code type, length, validity
        /// period, and maximum number of attempts. When you omit a member, its current value
        /// is preserved.
        /// </para>
        /// </summary>
        public UpdateCodeConfigurationParameters CodeConfigurationParameters { get; set; }

        /// <summary>
        /// Checks to see if the CodeConfigurationParameters property is set.
        /// </summary>
        internal bool IsSetCodeConfigurationParameters() => this.CodeConfigurationParameters != null;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Specifies whether deletion protection is enabled. When enabled, the resource cannot
        /// be deleted until deletion protection is turned off.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property NotifyCodeConfigurationId. 
        /// <para>
        /// The unique identifier of the notify code configuration. You can specify either the
        /// bare ID or the full Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
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
        [AWSProperty(Min = 1, Max = 64)]
        public string NotifyCodeConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the NotifyCodeConfigurationName property is set.
        /// </summary>
        internal bool IsSetNotifyCodeConfigurationName() => this.NotifyCodeConfigurationName != null;
    }
}
