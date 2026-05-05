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
    /// Details about the model package in a recommendation.
    /// </summary>
    public partial class AIRecommendationModelDetails
    {
        private string _inferenceSpecificationName;
        private List<AIRecommendationInstanceDetail> _instanceDetails = AWSConfigs.InitializeCollections ? new List<AIRecommendationInstanceDetail>() : null;
        private string _modelPackageArn;

        /// <summary>
        /// Gets and sets the property InferenceSpecificationName. 
        /// <para>
        /// The name of the inference specification within the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string InferenceSpecificationName
        {
            get { return this._inferenceSpecificationName; }
            set { this._inferenceSpecificationName = value; }
        }

        // Check to see if InferenceSpecificationName property is set
        internal bool IsSetInferenceSpecificationName()
        {
            return this._inferenceSpecificationName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// The instance details for this recommendation, including instance type, count, and
        /// model copies per instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AIRecommendationInstanceDetail> InstanceDetails
        {
            get { return this._instanceDetails; }
            set { this._instanceDetails = value; }
        }

        // Check to see if InstanceDetails property is set
        internal bool IsSetInstanceDetails()
        {
            return this._instanceDetails != null && (this._instanceDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageArn
        {
            get { return this._modelPackageArn; }
            set { this._modelPackageArn = value; }
        }

        // Check to see if ModelPackageArn property is set
        internal bool IsSetModelPackageArn()
        {
            return this._modelPackageArn != null;
        }

    }
}