/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetModel operation.
    /// Describes an existing model defined for a <a>RestApi</a> resource.
    /// </summary>
    public partial class GetModelRequest : AmazonAPIGatewayRequest
    {
        private bool? _flatten;
        private string _modelName;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property Flatten. 
        /// <para>
        /// A query parameter of a Boolean value to resolve (<code>true</code>) all external model
        /// references and returns a flattened model schema or not (<code>false</code>) The default
        /// is <code>false</code>.
        /// </para>
        /// </summary>
        public bool Flatten
        {
            get { return this._flatten.GetValueOrDefault(); }
            set { this._flatten = value; }
        }

        // Check to see if Flatten property is set
        internal bool IsSetFlatten()
        {
            return this._flatten.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// [Required] The name of the model as an identifier.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The <a>RestApi</a> identifier under which the <a>Model</a> exists.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

    }
}