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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutRestApi operation. A feature of the API Gateway
    /// control service for updating an existing API with an input of external API definitions.
    /// The update can take the form of merging the supplied definition into the existing
    /// API or overwriting the existing API.
    /// </summary>
    public partial class PutRestApiRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The PUT request body containing external API definitions. Currently, only OpenAPI
        /// definition JSON/YAML files are supported. The maximum size of the API definition file
        /// is 6MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// A query parameter to indicate whether to rollback the API update (<c>true</c>) or
        /// not (<c>false</c>) when a warning is encountered. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? FailOnWarnings { get; set; }

        /// <summary>
        /// Checks to see if the FailOnWarnings property is set.
        /// </summary>
        internal bool IsSetFailOnWarnings() => this.FailOnWarnings.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The <c>mode</c> query parameter to specify the update mode. Valid values are "merge"
        /// and "overwrite". By default, the update mode is "merge".
        /// </para>
        /// </summary>
        public PutMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Custom header parameters as part of the request. For example, to exclude DocumentationParts
        /// from an imported API, set <c>ignore=documentation</c> as a <c>parameters</c> value,
        /// as in the AWS CLI command of <c>aws apigateway import-rest-api --parameters ignore=documentation
        /// --body 'file:///path/to/imported-api-body.json'</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;
    }
}
