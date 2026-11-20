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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGlobalInferenceGateway operation. Creates
    /// a global inference gateway. This operation is asynchronous: the global inference gateway
    /// starts in the `CREATING` status. To check its status, call `DescribeGlobalInferenceGateway`
    /// until the status is `ACTIVE` or `FAILED`. The operation fails with `ResourceInUse`
    /// if the name is already in use, or if one of the in-cluster inference gateways in `Gateways`
    /// already belongs to another global inference gateway.
    /// </summary>
    public partial class CreateGlobalInferenceGatewayRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. An idempotent operation completes no more than one time. If you don't
        /// specify a client token, the Amazon Web Services SDKs and the Amazon Web Services CLI
        /// generate one for you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the global inference gateway assumes
        /// to access your SageMaker HyperPod clusters. The role must be in your account and partition,
        /// and you must have <c>iam:PassRole</c> permission for it. You can't change the role
        /// after you create the global inference gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Gateways. The 1 to 10 in-cluster inference gateways to
        /// add to the global inference gateway. A global inference gateway must always have at
        /// least one in-cluster inference gateway, so `RemoveInferenceGateway` can't remove the
        /// last one.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<GlobalInferenceGatewayMember> Gateways { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalInferenceGatewayMember>() : null;

        /// <summary>
        /// Checks to see if the Gateways property is set.
        /// </summary>
        internal bool IsSetGateways() => this.Gateways != null && (this.Gateways.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the global inference gateway. The name must be unique in your account
        /// in the current Region, and is case-sensitive. The name can't be exactly 12 lowercase
        /// letters or digits, because the global inference gateway ID uses that format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Routing. The routing configuration of the global inference
        /// gateway. If you omit it, the global inference gateway uses default routing weights.
        /// </summary>
        public GlobalInferenceGatewayRouting Routing { get; set; }

        /// <summary>
        /// Checks to see if the Routing property is set.
        /// </summary>
        internal bool IsSetRouting() => this.Routing != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Custom tags for managing the global inference gateway as an Amazon Web Services resource.
        /// You can add tags to your global inference gateway in the same way you add them in
        /// other Amazon Web Services services that support tagging. For more information about
        /// tagging Amazon Web Services resources, see <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services resources</a> in the <i>Tagging Amazon Web Services Resources
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The global inference gateway doesn't return tags in its responses. To read the tags,
        /// use <c>ListTags</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
