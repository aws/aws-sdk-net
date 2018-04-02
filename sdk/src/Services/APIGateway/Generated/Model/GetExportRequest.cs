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
    /// Container for the parameters to the GetExport operation.
    /// Exports a deployed version of a <a>RestApi</a> in a specified format.
    /// </summary>
    public partial class GetExportRequest : AmazonAPIGatewayRequest
    {
        private string _accepts;
        private string _exportType;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _restApiId;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property Accepts. 
        /// <para>
        /// The content-type of the export, for example <code>application/json</code>. Currently
        /// <code>application/json</code> and <code>application/yaml</code> are supported for
        /// <code>exportType</code> of <code>swagger</code>. This should be specified in the <code>Accept</code>
        /// header for direct API requests.
        /// </para>
        /// </summary>
        public string Accepts
        {
            get { return this._accepts; }
            set { this._accepts = value; }
        }

        // Check to see if Accepts property is set
        internal bool IsSetAccepts()
        {
            return this._accepts != null;
        }

        /// <summary>
        /// Gets and sets the property ExportType. 
        /// <para>
        /// [Required] The type of export. Currently only 'swagger' is supported.
        /// </para>
        /// </summary>
        public string ExportType
        {
            get { return this._exportType; }
            set { this._exportType = value; }
        }

        // Check to see if ExportType property is set
        internal bool IsSetExportType()
        {
            return this._exportType != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map of query string parameters that specify properties of the export,
        /// depending on the requested <code>exportType</code>. For <code>exportType</code> <code>swagger</code>,
        /// any combination of the following parameters are supported: <code>integrations</code>
        /// will export the API with x-amazon-apigateway-integration extensions. <code>authorizers</code>
        /// will export the API with x-amazon-apigateway-authorizer extensions. <code>postman</code>
        /// will export the API with Postman extensions, allowing for import to the Postman tool
        /// </para>
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

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
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

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// [Required] The name of the <a>Stage</a> that will be exported.
        /// </para>
        /// </summary>
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}