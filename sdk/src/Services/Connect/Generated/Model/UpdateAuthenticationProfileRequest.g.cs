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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAuthenticationProfile operation. This API
    /// is in preview release for Connect Customer and is subject to change. To request access
    /// to this API, contact Amazon Web Services Support. <para> Updates the selected authentication
    /// profile. </para>
    /// </summary>
    public partial class UpdateAuthenticationProfileRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedIps. 
        /// <para>
        /// A list of IP address range strings that are allowed to access the instance. For more
        /// information on how to configure IP addresses, see<a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// session timeouts</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedIps property is set.
        /// </summary>
        internal bool IsSetAllowedIps() => this.AllowedIps != null && (this.AllowedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticationProfileId. 
        /// <para>
        /// A unique identifier for the authentication profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string AuthenticationProfileId { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationProfileId property is set.
        /// </summary>
        internal bool IsSetAuthenticationProfileId() => this.AuthenticationProfileId != null;

        /// <summary>
        /// Gets and sets the property BlockedIps. 
        /// <para>
        /// A list of IP address range strings that are blocked from accessing the instance. For
        /// more information on how to configure IP addresses, For more information on how to
        /// configure IP addresses, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-ip-based-ac">Configure
        /// IP-based access control</a> in the <i>Connect Customer Administrator Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BlockedIps property is set.
        /// </summary>
        internal bool IsSetBlockedIps() => this.BlockedIps != null && (this.BlockedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the authentication profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the authentication profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PeriodicSessionDuration. 
        /// <para>
        /// The short lived session duration configuration for users logged in to Connect Customer,
        /// in minutes. This value determines the maximum possible time before an agent is authenticated.
        /// For more information, For more information on how to configure IP addresses, see <a
        /// href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// session timeouts</a> in the <i>Connect Customer Administrator Guide</i>. 
        /// </para>
        /// </summary>
        [Obsolete("PeriodicSessionDuration is deprecated. Use SessionInactivityDuration instead.")]
        [AWSProperty(Min = 10, Max = 60)]
        public int? PeriodicSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the PeriodicSessionDuration property is set.
        /// </summary>
        internal bool IsSetPeriodicSessionDuration() => this.PeriodicSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SessionInactivityDuration. 
        /// <para>
        /// The period, in minutes, before an agent is automatically signed out of the contact
        /// center when they go inactive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 720)]
        public int? SessionInactivityDuration { get; set; }

        /// <summary>
        /// Checks to see if the SessionInactivityDuration property is set.
        /// </summary>
        internal bool IsSetSessionInactivityDuration() => this.SessionInactivityDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SessionInactivityHandlingEnabled. 
        /// <para>
        /// Determines if automatic logout on user inactivity is enabled.
        /// </para>
        /// </summary>
        public bool? SessionInactivityHandlingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionInactivityHandlingEnabled property is set.
        /// </summary>
        internal bool IsSetSessionInactivityHandlingEnabled() => this.SessionInactivityHandlingEnabled.HasValue;
    }
}
