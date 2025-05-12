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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private DateTime? _creationTime;
        private string _endpointArn;
        private string _endpointName;
        private string _failureReason;
        private string _inferenceComponentArn;
        private string _inferenceComponentName;
        private InferenceComponentStatus _inferenceComponentStatus;
        private InferenceComponentDeploymentConfig _lastDeploymentConfig;
        private DateTime? _lastModifiedTime;
        private InferenceComponentRuntimeConfigSummary _runtimeConfig;
        private InferenceComponentSpecificationSummary _specification;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the inference component was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the inference component status is <c>Failed</c>, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string InferenceComponentArn
        {
            get { return this._inferenceComponentArn; }
            set { this._inferenceComponentArn = value; }
        }

        // Check to see if InferenceComponentArn property is set
        internal bool IsSetInferenceComponentArn()
        {
            return this._inferenceComponentArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceComponentName. 
        /// <para>
        /// The name of the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string InferenceComponentName
        {
            get { return this._inferenceComponentName; }
            set { this._inferenceComponentName = value; }
        }

        // Check to see if InferenceComponentName property is set
        internal bool IsSetInferenceComponentName()
        {
            return this._inferenceComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceComponentStatus. 
        /// <para>
        /// The status of the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentStatus InferenceComponentStatus
        {
            get { return this._inferenceComponentStatus; }
            set { this._inferenceComponentStatus = value; }
        }

        // Check to see if InferenceComponentStatus property is set
        internal bool IsSetInferenceComponentStatus()
        {
            return this._inferenceComponentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentConfig. 
        /// <para>
        /// The deployment and rollback settings that you assigned to the inference component.
        /// </para>
        /// </summary>
        public InferenceComponentDeploymentConfig LastDeploymentConfig
        {
            get { return this._lastDeploymentConfig; }
            set { this._lastDeploymentConfig = value; }
        }

        // Check to see if LastDeploymentConfig property is set
        internal bool IsSetLastDeploymentConfig()
        {
            return this._lastDeploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the inference component was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// Details about the runtime settings for the model that is deployed with the inference
        /// component.
        /// </para>
        /// </summary>
        public InferenceComponentRuntimeConfigSummary RuntimeConfig
        {
            get { return this._runtimeConfig; }
            set { this._runtimeConfig = value; }
        }

        // Check to see if RuntimeConfig property is set
        internal bool IsSetRuntimeConfig()
        {
            return this._runtimeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// Details about the resources that are deployed with this inference component.
        /// </para>
        /// </summary>
        public InferenceComponentSpecificationSummary Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the production variant that hosts the inference component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string VariantName
        {
            get { return this._variantName; }
            set { this._variantName = value; }
        }

        // Check to see if VariantName property is set
        internal bool IsSetVariantName()
        {
            return this._variantName != null;
        }

    }
}