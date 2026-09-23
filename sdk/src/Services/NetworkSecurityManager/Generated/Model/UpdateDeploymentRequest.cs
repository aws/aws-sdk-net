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
    /// Container for the parameters to the UpdateDeployment operation.
    /// Updates the specified deployment. To prevent conflicting concurrent updates, provide
    /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
    /// the deployment as a draft.
    /// </summary>
    public partial class UpdateDeploymentRequest : AmazonNetworkSecurityManagerRequest
    {
        private List<PolicyReference> _associatedPolicyList = AWSConfigs.InitializeCollections ? new List<PolicyReference>() : null;
        private List<ScopeReference> _associatedScopeList = AWSConfigs.InitializeCollections ? new List<ScopeReference>() : null;
        private string _clientToken;
        private DeploymentConfiguration _deploymentConfiguration;
        private string _deploymentDescription;
        private string _deploymentIdentifier;
        private bool? _isPublished;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property AssociatedPolicyList. 
        /// <para>
        /// The policies associated with the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<PolicyReference> AssociatedPolicyList
        {
            get { return this._associatedPolicyList; }
            set { this._associatedPolicyList = value; }
        }

        // Check to see if AssociatedPolicyList property is set
        internal bool IsSetAssociatedPolicyList()
        {
            return this._associatedPolicyList != null && (this._associatedPolicyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssociatedScopeList. 
        /// <para>
        /// The scope associated with the deployment. A deployment has exactly one scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ScopeReference> AssociatedScopeList
        {
            get { return this._associatedScopeList; }
            set { this._associatedScopeList = value; }
        }

        // Check to see if AssociatedScopeList property is set
        internal bool IsSetAssociatedScopeList()
        {
            return this._associatedScopeList != null && (this._associatedScopeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The configuration settings for the deployment.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentDescription. 
        /// <para>
        /// A description of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DeploymentDescription
        {
            get { return this._deploymentDescription; }
            set { this._deploymentDescription = value; }
        }

        // Check to see if DeploymentDescription property is set
        internal bool IsSetDeploymentDescription()
        {
            return this._deploymentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentIdentifier. 
        /// <para>
        /// The identifier of the deployment. This is the deployment's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1010)]
        public string DeploymentIdentifier
        {
            get { return this._deploymentIdentifier; }
            set { this._deploymentIdentifier = value; }
        }

        // Check to see if DeploymentIdentifier property is set
        internal bool IsSetDeploymentIdentifier()
        {
            return this._deploymentIdentifier != null;
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