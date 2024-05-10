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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetApiKey operation.
    /// Gets information about the current ApiKey resource.
    /// </summary>
    public partial class GetApiKeyRequest : AmazonAPIGatewayRequest
    {
        private string _apiKey;
        private bool? _includeValue;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The identifier of the ApiKey resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeValue. 
        /// <para>
        /// A boolean flag to specify whether (<c>true</c>) or not (<c>false</c>) the result contains
        /// the key value.
        /// </para>
        /// </summary>
        public bool? IncludeValue
        {
            get { return this._includeValue; }
            set { this._includeValue = value; }
        }

        // Check to see if IncludeValue property is set
        internal bool IsSetIncludeValue()
        {
            return this._includeValue.HasValue; 
        }

    }
}