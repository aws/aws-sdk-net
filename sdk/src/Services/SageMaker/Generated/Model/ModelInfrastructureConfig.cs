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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for the infrastructure that the model will be deployed to.
    /// </summary>
    public partial class ModelInfrastructureConfig
    {
        private ModelInfrastructureType _infrastructureType;
        private RealTimeInferenceConfig _realTimeInferenceConfig;

        /// <summary>
        /// Gets and sets the property InfrastructureType. 
        /// <para>
        /// The inference option to which to deploy your model. Possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RealTime</code>: Deploy to real-time inference.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInfrastructureType InfrastructureType
        {
            get { return this._infrastructureType; }
            set { this._infrastructureType = value; }
        }

        // Check to see if InfrastructureType property is set
        internal bool IsSetInfrastructureType()
        {
            return this._infrastructureType != null;
        }

        /// <summary>
        /// Gets and sets the property RealTimeInferenceConfig. 
        /// <para>
        /// The infrastructure configuration for deploying the model to real-time inference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RealTimeInferenceConfig RealTimeInferenceConfig
        {
            get { return this._realTimeInferenceConfig; }
            set { this._realTimeInferenceConfig = value; }
        }

        // Check to see if RealTimeInferenceConfig property is set
        internal bool IsSetRealTimeInferenceConfig()
        {
            return this._realTimeInferenceConfig != null;
        }

    }
}