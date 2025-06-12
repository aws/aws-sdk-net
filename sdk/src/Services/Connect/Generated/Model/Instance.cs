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
    /// The Amazon Connect instance.
    /// </summary>
    public partial class Instance
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _id;
        private DirectoryType _identityManagementType;
        private bool? _inboundCallsEnabled;
        private string _instanceAccessUrl;
        private string _instanceAlias;
        private InstanceStatus _instanceStatus;
        private bool? _outboundCallsEnabled;
        private string _serviceRole;
        private InstanceStatusReason _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the instance was created.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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
        /// Gets and sets the property IdentityManagementType. 
        /// <para>
        /// The identity management type.
        /// </para>
        /// </summary>
        public DirectoryType IdentityManagementType
        {
            get { return this._identityManagementType; }
            set { this._identityManagementType = value; }
        }

        // Check to see if IdentityManagementType property is set
        internal bool IsSetIdentityManagementType()
        {
            return this._identityManagementType != null;
        }

        /// <summary>
        /// Gets and sets the property InboundCallsEnabled. 
        /// <para>
        /// Whether inbound calls are enabled.
        /// </para>
        /// </summary>
        public bool? InboundCallsEnabled
        {
            get { return this._inboundCallsEnabled; }
            set { this._inboundCallsEnabled = value; }
        }

        // Check to see if InboundCallsEnabled property is set
        internal bool IsSetInboundCallsEnabled()
        {
            return this._inboundCallsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceAccessUrl. 
        /// <para>
        /// This URL allows contact center users to access the Amazon Connect admin website.
        /// </para>
        /// </summary>
        public string InstanceAccessUrl
        {
            get { return this._instanceAccessUrl; }
            set { this._instanceAccessUrl = value; }
        }

        // Check to see if InstanceAccessUrl property is set
        internal bool IsSetInstanceAccessUrl()
        {
            return this._instanceAccessUrl != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceAlias. 
        /// <para>
        /// The alias of instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=45)]
        public string InstanceAlias
        {
            get { return this._instanceAlias; }
            set { this._instanceAlias = value; }
        }

        // Check to see if InstanceAlias property is set
        internal bool IsSetInstanceAlias()
        {
            return this._instanceAlias != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The state of the instance.
        /// </para>
        /// </summary>
        public InstanceStatus InstanceStatus
        {
            get { return this._instanceStatus; }
            set { this._instanceStatus = value; }
        }

        // Check to see if InstanceStatus property is set
        internal bool IsSetInstanceStatus()
        {
            return this._instanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallsEnabled. 
        /// <para>
        /// Whether outbound calls are enabled.
        /// </para>
        /// </summary>
        public bool? OutboundCallsEnabled
        {
            get { return this._outboundCallsEnabled; }
            set { this._outboundCallsEnabled = value; }
        }

        // Check to see if OutboundCallsEnabled property is set
        internal bool IsSetOutboundCallsEnabled()
        {
            return this._outboundCallsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The service role of the instance.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Relevant details why the instance was not successfully created. 
        /// </para>
        /// </summary>
        public InstanceStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of an instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}