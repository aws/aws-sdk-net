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
    /// Specifies additional configuration for hosting multi-model endpoints.
    /// </summary>
    public partial class MultiModelConfig
    {
        private ModelCacheSetting _modelCacheSetting;

        /// <summary>
        /// Gets and sets the property ModelCacheSetting. 
        /// <para>
        /// Whether to cache models for a multi-model endpoint. By default, multi-model endpoints
        /// cache models so that a model does not have to be loaded into memory each time it is
        /// invoked. Some use cases do not benefit from model caching. For example, if an endpoint
        /// hosts a large number of models that are each invoked infrequently, the endpoint might
        /// perform better if you disable model caching. To disable model caching, set the value
        /// of this parameter to <c>Disabled</c>.
        /// </para>
        /// </summary>
        public ModelCacheSetting ModelCacheSetting
        {
            get { return this._modelCacheSetting; }
            set { this._modelCacheSetting = value; }
        }

        // Check to see if ModelCacheSetting property is set
        internal bool IsSetModelCacheSetting()
        {
            return this._modelCacheSetting != null;
        }

    }
}