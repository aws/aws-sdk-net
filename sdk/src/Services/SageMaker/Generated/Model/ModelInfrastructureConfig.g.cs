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
    /// The configuration for the infrastructure that the model will be deployed to.
    /// </summary>
    public partial class ModelInfrastructureConfig
    {
        /// <summary>
        /// Gets and sets the property InfrastructureType. 
        /// <para>
        /// The inference option to which to deploy your model. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RealTime</c>: Deploy to real-time inference.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelInfrastructureType InfrastructureType { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureType property is set.
        /// </summary>
        internal bool IsSetInfrastructureType() => this.InfrastructureType != null;

        /// <summary>
        /// Gets and sets the property RealTimeInferenceConfig. 
        /// <para>
        /// The infrastructure configuration for deploying the model to real-time inference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RealTimeInferenceConfig RealTimeInferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the RealTimeInferenceConfig property is set.
        /// </summary>
        internal bool IsSetRealTimeInferenceConfig() => this.RealTimeInferenceConfig != null;
    }
}
