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
    /// Defines a training job and a batch transform job that SageMaker runs to validate your
    /// algorithm.
    /// 
    ///  
    /// <para>
    /// The data provided in the validation profile is made available to your buyers on Amazon
    /// Web Services Marketplace.
    /// </para>
    /// </summary>
    public partial class AlgorithmValidationProfile
    {
        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the profile for the algorithm. The name must have 1 to 63 characters.
        /// Valid characters are a-z, A-Z, 0-9, and - (hyphen).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property TrainingJobDefinition. 
        /// <para>
        /// The <c>TrainingJobDefinition</c> object that describes the training job that SageMaker
        /// runs to validate your algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingJobDefinition TrainingJobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobDefinition property is set.
        /// </summary>
        internal bool IsSetTrainingJobDefinition() => this.TrainingJobDefinition != null;

        /// <summary>
        /// Gets and sets the property TransformJobDefinition. 
        /// <para>
        /// The <c>TransformJobDefinition</c> object that describes the transform job that SageMaker
        /// runs to validate your algorithm.
        /// </para>
        /// </summary>
        public TransformJobDefinition TransformJobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TransformJobDefinition property is set.
        /// </summary>
        internal bool IsSetTransformJobDefinition() => this.TransformJobDefinition != null;
    }
}
