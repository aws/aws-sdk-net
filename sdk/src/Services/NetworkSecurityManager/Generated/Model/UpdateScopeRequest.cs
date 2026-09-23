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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScope operation.
    /// Updates the specified scope. To prevent conflicting concurrent updates, provide the
    /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
    /// scope as a draft.
    /// </summary>
    public partial class UpdateScopeRequest : AmazonNetworkSecurityManagerRequest
    {
        private string _clientToken;
        private bool? _isPublished;
        private ScopeConfiguration _scopeConfiguration;
        private string _scopeDescription;
        private string _scopeIdentifier;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsPublished
        {
            get { return this._isPublished; }
            set { this._isPublished = value; }
        }

        // Check to see if IsPublished property is set
        internal bool IsSetIsPublished()
        {
            return this._isPublished.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The configuration that defines which accounts and resources are in scope. If you don't
        /// include this member, the scope keeps its existing configuration.
        /// </para>
        ///  
        /// <para>
        /// A new configuration can change which accounts and resources are selected, but it can't
        /// add or remove the account filter itself: a scope created for multi-account use stays
        /// multi-account, and a scope created for single-account use stays single-account.
        /// </para>
        /// </summary>
        public ScopeConfiguration ScopeConfiguration
        {
            get { return this._scopeConfiguration; }
            set { this._scopeConfiguration = value; }
        }

        // Check to see if ScopeConfiguration property is set
        internal bool IsSetScopeConfiguration()
        {
            return this._scopeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeDescription. 
        /// <para>
        /// A description of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ScopeDescription
        {
            get { return this._scopeDescription; }
            set { this._scopeDescription = value; }
        }

        // Check to see if ScopeDescription property is set
        internal bool IsSetScopeDescription()
        {
            return this._scopeDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeIdentifier. 
        /// <para>
        /// The identifier of the scope. This is the scope's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1010)]
        public string ScopeIdentifier
        {
            get { return this._scopeIdentifier; }
            set { this._scopeIdentifier = value; }
        }

        // Check to see if ScopeIdentifier property is set
        internal bool IsSetScopeIdentifier()
        {
            return this._scopeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}