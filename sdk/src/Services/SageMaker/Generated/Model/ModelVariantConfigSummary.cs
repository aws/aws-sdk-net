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
    /// Summary of the deployment configuration of a model.
    /// </summary>
    public partial class ModelVariantConfigSummary
    {
        private ModelInfrastructureConfig _infrastructureConfig;
        private string _modelName;
        private ModelVariantStatus _status;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property InfrastructureConfig. 
        /// <para>
        /// The configuration of the infrastructure that the model has been deployed to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInfrastructureConfig InfrastructureConfig
        {
            get { return this._infrastructureConfig; }
            set { this._infrastructureConfig = value; }
        }

        // Check to see if InfrastructureConfig property is set
        internal bool IsSetInfrastructureConfig()
        {
            return this._infrastructureConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the Amazon SageMaker Model entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of deployment for the model variant on the hosted inference endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Creating</code> - Amazon SageMaker is preparing the model variant on the hosted
        /// inference endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InService</code> - The model variant is running on the hosted inference endpoint.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Updating</code> - Amazon SageMaker is updating the model variant on the hosted
        /// inference endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleting</code> - Amazon SageMaker is deleting the model variant on the hosted
        /// inference endpoint. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleted</code> - The model variant has been deleted on the hosted inference
        /// endpoint. This can only happen after stopping the experiment. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelVariantStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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