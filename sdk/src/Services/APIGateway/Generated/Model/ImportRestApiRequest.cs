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
    /// Container for the parameters to the ImportRestApi operation.
    /// A feature of the API Gateway control service for creating a new API from an external
    /// API definition file.
    /// </summary>
    public partial class ImportRestApiRequest : AmazonAPIGatewayRequest
    {
        private MemoryStream _body;
        private bool? _failOnWarnings;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The POST request body containing external API definitions. Currently, only OpenAPI
        /// definition JSON/YAML files are supported. The maximum size of the API definition file
        /// is 6MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A query parameter to indicate whether to rollback the API creation (<c>true</c>) or
        /// not (<c>false</c>) when a warning is encountered. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? FailOnWarnings
        {
            get { return this._failOnWarnings; }
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
        ///  To exclude DocumentationParts from the import, set <c>parameters</c> as <c>ignore=documentation</c>.
        /// </para>
        ///  
        /// <para>
        ///  To configure the endpoint type, set <c>parameters</c> as <c>endpointConfigurationTypes=EDGE</c>,
        /// <c>endpointConfigurationTypes=REGIONAL</c>, or <c>endpointConfigurationTypes=PRIVATE</c>.
        /// The default endpoint type is <c>EDGE</c>.
        /// </para>
        ///  
        /// <para>
        ///  To handle imported <c>basepath</c>, set <c>parameters</c> as <c>basepath=ignore</c>,
        /// <c>basepath=prepend</c> or <c>basepath=split</c>.
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

    }
}