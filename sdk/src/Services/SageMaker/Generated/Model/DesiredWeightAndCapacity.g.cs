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
    /// Specifies weight and capacity values for a production variant.
    /// </summary>
    public partial class DesiredWeightAndCapacity
    {
        /// <summary>
        /// Gets and sets the property DesiredInstanceCount. 
        /// <para>
        /// The variant's capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DesiredInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInstanceCount property is set.
        /// </summary>
        internal bool IsSetDesiredInstanceCount() => this.DesiredInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredWeight. 
        /// <para>
        /// The variant's weight.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? DesiredWeight { get; set; }

        /// <summary>
        /// Checks to see if the DesiredWeight property is set.
        /// </summary>
        internal bool IsSetDesiredWeight() => this.DesiredWeight.HasValue;

        /// <summary>
        /// Gets and sets the property ServerlessUpdateConfig. 
        /// <para>
        /// Specifies the serverless update concurrency configuration for an endpoint variant.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessUpdateConfig ServerlessUpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessUpdateConfig property is set.
        /// </summary>
        internal bool IsSetServerlessUpdateConfig() => this.ServerlessUpdateConfig != null;

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant to update.
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
