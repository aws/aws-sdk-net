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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLifecyclePolicy operation. Updates the specified
    /// lifecycle policy. The request replaces the existing policy configuration rather than
    /// merging changes, so re-specify every setting that you want to keep. The <c>resourceType</c>
    /// must match the existing policy's value.
    /// </summary>
    public partial class UpdateLifecyclePolicyRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for the lifecycle policy. Because the update replaces the entire
        /// configuration, omitting this property removes any existing description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the IAM role you create that grants Image
        /// Builder access to run lifecycle actions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string LifecyclePolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicyArn property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicyArn() => this.LifecyclePolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration details for a lifecycle policy resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public List<LifecyclePolicyDetail> PolicyDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyDetail>() : null;

        /// <summary>
        /// Checks to see if the PolicyDetails property is set.
        /// </summary>
        internal bool IsSetPolicyDetails() => this.PolicyDetails != null && (this.PolicyDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceSelection. 
        /// <para>
        /// Selection criteria for resources that the lifecycle policy applies to. You must specify
        /// exactly one selection criteria: either recipes or a tag map, not both.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifecyclePolicyResourceSelection ResourceSelection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSelection property is set.
        /// </summary>
        internal bool IsSetResourceSelection() => this.ResourceSelection != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of image resource that the lifecycle policy applies to. The value must match
        /// the policy's existing resource type. You can't change the resource type of an existing
        /// lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifecyclePolicyResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether the lifecycle policy resource is enabled. Defaults to <c>ENABLED</c>
        /// when omitted, so updating a disabled policy without setting this property re-enables
        /// it.
        /// </para>
        /// </summary>
        public LifecyclePolicyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
