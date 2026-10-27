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
    /// Details of the resource that is not protected by the policy.
    /// </summary>
    public partial class ComplianceViolator
    {
        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the resource that doesn't comply with the policy scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. This is in the format shown in the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services Resource Types Reference</a>. For example: <c>AWS::ElasticLoadBalancingV2::LoadBalancer</c>,
        /// <c>AWS::CloudFront::Distribution</c>, or <c>AWS::NetworkFirewall::FirewallPolicy</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ViolationReason. 
        /// <para>
        /// The reason that the resource is not protected by the policy.
        /// </para>
        /// </summary>
        public ViolationReason ViolationReason { get; set; }

        /// <summary>
        /// Checks to see if the ViolationReason property is set.
        /// </summary>
        internal bool IsSetViolationReason() => this.ViolationReason != null;
    }
}
