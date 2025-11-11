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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Container for the parameters to the UpdateAuthenticationProfile operation.
    /// This API is in preview release for Amazon Connect and is subject to change. To request
    /// access to this API, contact Amazon Web Services Support.
    /// 
    ///  
    /// <para>
    /// Updates the selected authentication profile.
    /// </para>
    /// </summary>
    public partial class UpdateAuthenticationProfileRequest : AmazonConnectRequest
    {
        private List<string> _allowedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _authenticationProfileId;
        private List<string> _blockedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _instanceId;
        private string _name;
        private int? _periodicSessionDuration;

        /// <summary>
        /// Gets and sets the property AllowedIps. 
        /// <para>
        /// A list of IP address range strings that are allowed to access the instance. For more
        /// information on how to configure IP addresses, see<a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// session timeouts</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedIps
        {
            get { return this._allowedIps; }
            set { this._allowedIps = value; }
        }

        // Check to see if AllowedIps property is set
        internal bool IsSetAllowedIps()
        {
            return this._allowedIps != null && (this._allowedIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationProfileId. 
        /// <para>
        /// A unique identifier for the authentication profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AuthenticationProfileId
        {
            get { return this._authenticationProfileId; }
            set { this._authenticationProfileId = value; }
        }

        // Check to see if AuthenticationProfileId property is set
        internal bool IsSetAuthenticationProfileId()
        {
            return this._authenticationProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedIps. 
        /// <para>
        /// A list of IP address range strings that are blocked from accessing the instance. For
        /// more information on how to configure IP addresses, For more information on how to
        /// configure IP addresses, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-ip-based-ac">Configure
        /// IP-based access control</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockedIps
        {
            get { return this._blockedIps; }
            set { this._blockedIps = value; }
        }

        // Check to see if BlockedIps property is set
        internal bool IsSetBlockedIps()
        {
            return this._blockedIps != null && (this._blockedIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the authentication profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the authentication profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodicSessionDuration. 
        /// <para>
        /// The short lived session duration configuration for users logged in to Amazon Connect,
        /// in minutes. This value determines the maximum possible time before an agent is authenticated.
        /// For more information, For more information on how to configure IP addresses, see <a
        /// href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// session timeouts</a> in the <i>Amazon Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=60)]
        public int? PeriodicSessionDuration
        {
            get { return this._periodicSessionDuration; }
            set { this._periodicSessionDuration = value; }
        }

        // Check to see if PeriodicSessionDuration property is set
        internal bool IsSetPeriodicSessionDuration()
        {
            return this._periodicSessionDuration.HasValue; 
        }

    }
}