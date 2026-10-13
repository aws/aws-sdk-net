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
    /// The name and sampling percentage of a shadow variant.
    /// </summary>
    public partial class ShadowModelVariantConfig
    {
        /// <summary>
        /// Gets and sets the property SamplingPercentage. 
        /// <para>
        ///  The percentage of inference requests that Amazon SageMaker replicates from the production
        /// variant to the shadow variant. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public int? SamplingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SamplingPercentage property is set.
        /// </summary>
        internal bool IsSetSamplingPercentage() => this.SamplingPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property ShadowModelVariantName. 
        /// <para>
        /// The name of the shadow variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string ShadowModelVariantName { get; set; }

        /// <summary>
        /// Checks to see if the ShadowModelVariantName property is set.
        /// </summary>
        internal bool IsSetShadowModelVariantName() => this.ShadowModelVariantName != null;
    }
}
