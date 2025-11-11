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
    /// This API is in preview release for Amazon Connect and is subject to change. To request
    /// access to this API, contact Amazon Web Services Support.
    /// 
    ///  
    /// <para>
    /// Information about an authentication profile. An authentication profile is a resource
    /// that stores the authentication settings for users in your contact center. You use
    /// authentication profiles to set up IP address range restrictions and session timeouts.
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html">Set
    /// IP address restrictions or session timeouts</a>. 
    /// </para>
    /// </summary>
    public partial class AuthenticationProfile
    {
        private List<string> _allowedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private List<string> _blockedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdTime;
        private string _description;
        private string _id;
        private bool? _isDefault;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private int? _maxSessionDuration;
        private string _name;
        private int? _periodicSessionDuration;

        /// <summary>
        /// Gets and sets the property AllowedIps. 
        /// <para>
        /// A list of IP address range strings that are allowed to access the Amazon Connect instance.
        /// For more information about how to configure IP addresses, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-ip-based-ac">Configure
        /// IP address based access control</a> in the <i>Amazon Connect Administrator Guide</i>.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the authentication profile.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BlockedIps. 
        /// <para>
        /// A list of IP address range strings that are blocked from accessing the Amazon Connect
        /// instance. For more information about how to configure IP addresses, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-ip-based-ac">Configure
        /// IP address based access control</a> in the <i>Amazon Connect Administrator Guide</i>.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the authentication profile was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the authentication profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Shows whether the authentication profile is the default authentication profile for
        /// the Amazon Connect instance. The default authentication profile applies to all agents
        /// in an Amazon Connect instance, unless overridden by another authentication profile.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where the authentication profile was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the authentication profile was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The long lived session duration for users logged in to Amazon Connect, in minutes.
        /// After this time period, users must log in again. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// the session duration</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=360, Max=720)]
        public int? MaxSessionDuration
        {
            get { return this._maxSessionDuration; }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
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
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/authentication-profiles.html#configure-session-timeouts">Configure
        /// the session duration</a> in the <i>Amazon Connect Administrator Guide</i>.
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