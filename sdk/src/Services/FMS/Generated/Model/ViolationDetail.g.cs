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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violations for a resource based on the specified Firewall Manager policy and Amazon
    /// Web Services account.
    /// </summary>
    public partial class ViolationDetail
    {
        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The Amazon Web Services account that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string MemberAccount { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccount property is set.
        /// </summary>
        internal bool IsSetMemberAccount() => this.MemberAccount != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the Firewall Manager policy that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property ResourceDescription. 
        /// <para>
        /// Brief description for the requested resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDescription property is set.
        /// </summary>
        internal bool IsSetResourceDescription() => this.ResourceDescription != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The <c>ResourceTag</c> objects associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ResourceViolations. 
        /// <para>
        /// List of violations for the requested resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ResourceViolation> ResourceViolations { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceViolation>() : null;

        /// <summary>
        /// Checks to see if the ResourceViolations property is set.
        /// </summary>
        internal bool IsSetResourceViolations() => this.ResourceViolations != null && (this.ResourceViolations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
