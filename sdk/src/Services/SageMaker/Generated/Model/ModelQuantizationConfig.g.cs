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
    /// Settings for the model quantization technique that's applied by a model optimization
    /// job.
    /// </summary>
    public partial class ModelQuantizationConfig
    {
        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The URI of an LMI DLC in Amazon ECR. SageMaker uses this image to run the optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property OverrideEnvironment. 
        /// <para>
        /// Environment variables that override the default ones in the model container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public Dictionary<string, string> OverrideEnvironment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the OverrideEnvironment property is set.
        /// </summary>
        internal bool IsSetOverrideEnvironment() => this.OverrideEnvironment != null && (this.OverrideEnvironment.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
