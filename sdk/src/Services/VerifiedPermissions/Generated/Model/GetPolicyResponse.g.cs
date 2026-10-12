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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the GetPolicy operation.
    /// </summary>
    public partial class GetPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The action that a policy permits or forbids. For example, <c>{"actions": [{"actionId":
        /// "ViewPhoto", "actionType": "PhotoFlash::Action"}, {"entityID": "SharePhoto", "entityType":
        /// "PhotoFlash::Action"}]}</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ActionIdentifier> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the policy was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the requested policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyDefinitionDetail Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the decision that a policy returns to an authorization request. For
        /// example, <c>"effect": "Permit"</c>.
        /// </para>
        /// </summary>
        public PolicyEffect Effect { get; set; }

        /// <summary>
        /// Checks to see if the Effect property is set.
        /// </summary>
        internal bool IsSetEffect() => this.Effect != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the policy was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the policy, if one was assigned when the policy was created or last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique ID of the policy that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store that contains the policy that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal specified in the policy's scope. This element isn't included in the
        /// response when <c>Principal</c> isn't present in the policy content.
        /// </para>
        /// </summary>
        public EntityIdentifier Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource specified in the policy's scope. This element isn't included in the response
        /// when <c>Resource</c> isn't present in the policy content.
        /// </para>
        /// </summary>
        public EntityIdentifier Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
