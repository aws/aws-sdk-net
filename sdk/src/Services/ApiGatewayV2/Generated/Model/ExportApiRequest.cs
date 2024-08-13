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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the ExportApi operation.
    /// 
    /// </summary>
    public partial class ExportApiRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _exportVersion;
        private bool? _includeExtensions;
        private string _outputType;
        private string _specification;
        private string _stageName;

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
        /// Gets and sets the property ExportVersion. 
        /// <para>
        /// The version of the API Gateway export algorithm. API Gateway uses the latest version
        /// by default. Currently, the only supported version is 1.0.
        /// </para>
        /// </summary>
        public string ExportVersion
        {
            get { return this._exportVersion; }
            set { this._exportVersion = value; }
        }

        // Check to see if ExportVersion property is set
        internal bool IsSetExportVersion()
        {
            return this._exportVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeExtensions. 
        /// <para>
        /// Specifies whether to include <a href="https://docs.aws.amazon.com//apigateway/latest/developerguide/api-gateway-swagger-extensions.html">API
        /// Gateway extensions</a> in the exported API definition. API Gateway extensions are
        /// included by default.
        /// </para>
        /// </summary>
        public bool? IncludeExtensions
        {
            get { return this._includeExtensions; }
            set { this._includeExtensions = value; }
        }

        // Check to see if IncludeExtensions property is set
        internal bool IsSetIncludeExtensions()
        {
            return this._includeExtensions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The output type of the exported definition file. Valid values are JSON and YAML.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputType
        {
            get { return this._outputType; }
            set { this._outputType = value; }
        }

        // Check to see if OutputType property is set
        internal bool IsSetOutputType()
        {
            return this._outputType != null;
        }

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// The version of the API specification to use. OAS30, for OpenAPI 3.0, is the only supported
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the API stage to export. If you don't specify this property, a representation
        /// of the latest API configuration is exported.
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