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
    /// Container for the parameters to the ImportRestApi operation.
    /// A feature of the API Gateway control service for creating a new API from an external
    /// API definition file.
    /// </summary>
    public partial class ImportRestApiRequest : AmazonAPIGatewayRequest
    {
        private MemoryStream _body;
        private bool? _failOnWarnings;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// [Required] The POST request body containing external API definitions. Currently, only
        /// Swagger definition JSON files are supported. The maximum size of the API definition
        /// file is 2MB.
        /// </para>
        /// </summary>
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// A query parameter to indicate whether to rollback the API creation (<code>true</code>)
        /// or not (<code>false</code>) when a warning is encountered. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool FailOnWarnings
        {
            get { return this._failOnWarnings.GetValueOrDefault(); }
            set { this._failOnWarnings = value; }
        }

        // Check to see if FailOnWarnings property is set
        internal bool IsSetFailOnWarnings()
        {
            return this._failOnWarnings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map of context-specific query string parameters specifying the behavior
        /// of different API importing operations. The following shows operation-specific parameters
        /// and their supported values.
        /// </para>
        ///  
        /// <para>
        ///  To exclude <a>DocumentationParts</a> from the import, set <code>parameters</code>
        /// as <code>ignore=documentation</code>.
        /// </para>
        ///  
        /// <para>
        ///  To configure the endpoint type, set <code>parameters</code> as <code>endpointConfigurationTypes=EDGE</code>
        /// or<code>endpointConfigurationTypes=REGIONAL</code>. The default endpoint type is <code>EDGE</code>.
        /// </para>
        ///  
        /// <para>
        ///  To handle imported <code>basePath</code>, set <code>parameters</code> as <code>basePath=ignore</code>,
        /// <code>basePath=prepend</code> or <code>basePath=split</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, the AWS CLI command to exclude documentation from the imported API is:
        /// </para>
        ///  <pre><code>aws apigateway import-rest-api --parameters ignore=documentation --body
        /// 'file:///path/to/imported-api-body.json</code></pre> 
        /// <para>
        /// The AWS CLI command to set the regional endpoint on the imported API is:
        /// </para>
        ///  <pre><code>aws apigateway import-rest-api --parameters endpointConfigurationTypes=REGIONAL
        /// --body 'file:///path/to/imported-api-body.json</code></pre>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}