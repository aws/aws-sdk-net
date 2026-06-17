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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains summary information about a gateway target. A target represents an endpoint
    /// that the gateway can connect to.
    /// </summary>
    public partial class TargetSummary
    {
        private AuthorizationData _authorizationData;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastSynchronizedAt;
        private ListingMode _listingMode;
        private string _name;
        private int? _resourcePriority;
        private TargetStatus _status;
        private string _targetId;
        private TargetType _targetType;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AuthorizationData.
        /// </summary>
        public AuthorizationData AuthorizationData
        {
            get { return this._authorizationData; }
            set { this._authorizationData = value; }
        }

        // Check to see if AuthorizationData property is set
        internal bool IsSetAuthorizationData()
        {
            return this._authorizationData != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the target was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property LastSynchronizedAt. 
        /// <para>
        /// The timestamp when the target was last synchronized.
        /// </para>
        /// </summary>
        public DateTime? LastSynchronizedAt
        {
            get { return this._lastSynchronizedAt; }
            set { this._lastSynchronizedAt = value; }
        }

        // Check to see if LastSynchronizedAt property is set
        internal bool IsSetLastSynchronizedAt()
        {
            return this._lastSynchronizedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListingMode. 
        /// <para>
        /// The listing mode for the target. MCP resources for <c>DEFAULT</c> targets are cached
        /// at the control plane for faster access. MCP resources for <c>DYNAMIC</c> targets are
        /// retrieved dynamically when listing tools.
        /// </para>
        /// </summary>
        public ListingMode ListingMode
        {
            get { return this._listingMode; }
            set { this._listingMode = value; }
        }

        // Check to see if ListingMode property is set
        internal bool IsSetListingMode()
        {
            return this._listingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property ResourcePriority. 
        /// <para>
        /// Priority for resolving resource URI conflicts across targets. Lower values take precedence.
        /// Defaults to 1000 when not set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? ResourcePriority
        {
            get { return this._resourcePriority; }
            set { this._resourcePriority = value; }
        }

        // Check to see if ResourcePriority property is set
        internal bool IsSetResourcePriority()
        {
            return this._resourcePriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target.
        /// </para>
        /// </summary>
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the target was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}