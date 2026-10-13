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
    /// A summary of the properties of an inference component.
    /// </summary>
    public partial class InferenceComponentSummary
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
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;
    }
}
