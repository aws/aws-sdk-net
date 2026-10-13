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
    /// This is the response object from the DescribeInferenceComponent operation.
    /// </summary>
    public partial class DescribeInferenceComponentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the inference component was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the inference component status is <c>Failed</c>, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InferenceComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string InferenceComponentArn { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponentArn property is set.
        /// </summary>
        internal bool IsSetInferenceComponentArn() => this.InferenceComponentArn != null;

        /// <summary>
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// The name of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string InferenceComponentName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponentName property is set.
        /// </summary>
        internal bool IsSetInferenceComponentName() => this.InferenceComponentName != null;

        /// <summary>
        /// Gets and sets the property InferenceComponentStatus. 
        /// <para>
        /// The status of the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentStatus InferenceComponentStatus { get; set; }

        /// <summary>
        /// Checks to see if the InferenceComponentStatus property is set.
        /// </summary>
        internal bool IsSetInferenceComponentStatus() => this.InferenceComponentStatus != null;

        /// <summary>
        /// Gets and sets the property LastDeploymentConfig. 
        /// <para>
        /// The deployment and rollback settings that you assigned to the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentDeploymentConfig LastDeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentConfig property is set.
        /// </summary>
        internal bool IsSetLastDeploymentConfig() => this.LastDeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the inference component was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// Details about the runtime settings for the model that is deployed with the inference
        /// component.
        /// </para>
        /// </summary>
        public InferenceComponentRuntimeConfigSummary RuntimeConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeConfig property is set.
        /// </summary>
        internal bool IsSetRuntimeConfig() => this.RuntimeConfig != null;

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// Details about the resources that are deployed with this inference component.
        /// </para>
        /// </summary>
        public InferenceComponentSpecificationSummary Specification { get; set; }

        /// <summary>
        /// Checks to see if the Specification property is set.
        /// </summary>
        internal bool IsSetSpecification() => this.Specification != null;

        /// <summary>
        /// Gets and sets the property Specifications. 
        /// <para>
        /// A list of specification summaries for the inference component, one per instance type.
        /// This parameter is populated when the inference component was created with multiple
        /// specifications. When this parameter is populated, the singular <c>Specification</c>
        /// parameter is not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<InferenceComponentSpecificationSummary> Specifications { get; set; } = AWSConfigs.InitializeCollections ? new List<InferenceComponentSpecificationSummary>() : null;

        /// <summary>
        /// Checks to see if the Specifications property is set.
        /// </summary>
        internal bool IsSetSpecifications() => this.Specifications != null && (this.Specifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;
    }
}
