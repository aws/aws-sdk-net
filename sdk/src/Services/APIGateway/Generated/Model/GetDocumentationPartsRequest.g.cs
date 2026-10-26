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
    /// Container for the parameters to the GetDocumentationParts operation. Gets documentation
    /// parts.
    /// </summary>
    public partial class GetDocumentationPartsRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property LocationStatus. 
        /// <para>
        /// The status of the API documentation parts to retrieve. Valid values are <c>DOCUMENTED</c>
        /// for retrieving DocumentationPart resources with content and <c>UNDOCUMENTED</c> for
        /// DocumentationPart resources without content.
        /// </para>
        /// </summary>
        public LocationStatusType LocationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LocationStatus property is set.
        /// </summary>
        internal bool IsSetLocationStatus() => this.LocationStatus != null;

        /// <summary>
        /// Gets and sets the property NameQuery. 
        /// <para>
        /// The name of API entities of the to-be-retrieved documentation parts.
        /// </para>
        /// </summary>
        public string NameQuery { get; set; }

        /// <summary>
        /// Checks to see if the NameQuery property is set.
        /// </summary>
        internal bool IsSetNameQuery() => this.NameQuery != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of API entities of the to-be-retrieved documentation parts.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of API entities of the to-be-retrieved documentation parts. 
        /// </para>
        /// </summary>
        public DocumentationPartType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
