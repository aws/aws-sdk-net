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
    /// Specifies the serverless update concurrency configuration for an endpoint variant.
    /// </summary>
    public partial class ProductionVariantServerlessUpdateConfig
    {
        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The updated maximum number of concurrent invocations your serverless endpoint can
        /// process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedConcurrency. 
        /// <para>
        /// The updated amount of provisioned concurrency to allocate for the serverless endpoint.
        /// Should be less than or equal to <c>MaxConcurrency</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? ProvisionedConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedConcurrency property is set.
        /// </summary>
        internal bool IsSetProvisionedConcurrency() => this.ProvisionedConcurrency.HasValue;
    }
}
