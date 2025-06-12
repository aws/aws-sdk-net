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
    /// Container for the parameters to the GetExport operation.
    /// Exports a deployed version of a RestApi in a specified format.
    /// </summary>
    public partial class GetExportRequest : AmazonAPIGatewayRequest
    {
        private string _accepts;
        private string _exportType;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _restApiId;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property Accepts. 
        /// <para>
        /// The content-type of the export, for example <c>application/json</c>. Currently <c>application/json</c>
        /// and <c>application/yaml</c> are supported for <c>exportType</c> of<c>oas30</c> and
        /// <c>swagger</c>. This should be specified in the <c>Accept</c> header for direct API
        /// requests.
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
        /// The type of export. Acceptable values are 'oas30' for OpenAPI 3.0.x and 'swagger'
        /// for Swagger/OpenAPI 2.0.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// depending on the requested <c>exportType</c>. For <c>exportType</c> <c>oas30</c> and
        /// <c>swagger</c>, any combination of the following parameters are supported: <c>extensions='integrations'</c>
        /// or <c>extensions='apigateway'</c> will export the API with x-amazon-apigateway-integration
        /// extensions. <c>extensions='authorizers'</c> will export the API with x-amazon-apigateway-authorizer
        /// extensions. <c>postman</c> will export the API with Postman extensions, allowing for
        /// import to the Postman tool
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the Stage that will be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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