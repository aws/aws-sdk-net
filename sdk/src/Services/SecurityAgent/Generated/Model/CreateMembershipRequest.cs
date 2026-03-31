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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembership operation.
    /// Adds a single member to an agent space with specified role
    /// </summary>
    public partial class CreateMembershipRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private string _applicationId;
        private MembershipConfig _config;
        private string _membershipId;
        private MembershipType _memberType;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Agent space identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// Application identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Membership details (user or agent specific)
        /// </para>
        /// </summary>
        public MembershipConfig Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// Member identifier (userId or agentSpaceId)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// Type of member (USER or AGENT_SPACE)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipType MemberType
        {
            get { return this._memberType; }
            set { this._memberType = value; }
        }

        // Check to see if MemberType property is set
        internal bool IsSetMemberType()
        {
            return this._memberType != null;
        }

    }
}