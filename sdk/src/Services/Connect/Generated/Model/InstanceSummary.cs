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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the instance.
    /// </summary>
    public partial class InstanceSummary
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _id;
        private DirectoryType _identityManagementType;
        private bool? _inboundCallsEnabled;
        private string _instanceAlias;
        private InstanceStatus _instanceStatus;
        private bool? _outboundCallsEnabled;
        private string _serviceRole;

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
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// The identifier of the instance.
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
        /// The identity management type of the instance.
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
        public bool InboundCallsEnabled
        {
            get { return this._inboundCallsEnabled.GetValueOrDefault(); }
            set { this._inboundCallsEnabled = value; }
        }

        // Check to see if InboundCallsEnabled property is set
        internal bool IsSetInboundCallsEnabled()
        {
            return this._inboundCallsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceAlias. 
        /// <para>
        /// The alias of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=62)]
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
        public bool OutboundCallsEnabled
        {
            get { return this._outboundCallsEnabled.GetValueOrDefault(); }
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

    }
}