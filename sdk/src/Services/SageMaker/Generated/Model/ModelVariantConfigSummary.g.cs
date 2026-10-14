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
    /// Summary of the deployment configuration of a model.
    /// </summary>
    public partial class ModelVariantConfigSummary
    {
        /// <summary>
        /// Gets and sets the property InfrastructureConfig. 
        /// <para>
        /// The configuration of the infrastructure that the model has been deployed to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelInfrastructureConfig InfrastructureConfig { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfig property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfig() => this.InfrastructureConfig != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the Amazon SageMaker Model entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of deployment for the model variant on the hosted inference endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Amazon SageMaker is preparing the model variant on the hosted inference
        /// endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InService</c> - The model variant is running on the hosted inference endpoint.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c> - Amazon SageMaker is updating the model variant on the hosted inference
        /// endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c> - Amazon SageMaker is deleting the model variant on the hosted inference
        /// endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleted</c> - The model variant has been deleted on the hosted inference endpoint.
        /// This can only happen after stopping the experiment. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelVariantStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant.
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
