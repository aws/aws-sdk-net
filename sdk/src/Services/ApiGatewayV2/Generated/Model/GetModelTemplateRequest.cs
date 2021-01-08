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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetModelTemplate operation.
    /// Gets a model template.
    /// </summary>
    public partial class GetModelTemplateRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _modelId;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

    }
}