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
    /// Specifies the target API entity to which the documentation applies.
    /// </summary>
    public partial class DocumentationPartLocation
    {
        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The HTTP verb of a method. It is a valid field for the API entity types of <c>METHOD</c>,
        /// <c>PATH_PARAMETER</c>, <c>QUERY_PARAMETER</c>, <c>REQUEST_HEADER</c>, <c>REQUEST_BODY</c>,
        /// <c>RESPONSE</c>, <c>RESPONSE_HEADER</c>, and <c>RESPONSE_BODY</c>. The default value
        /// is <c>*</c> for any method. When an applicable child entity inherits the content of
        /// an entity of the same type with more general specifications of the other <c>location</c>
        /// attributes, the child entity's <c>method</c> attribute must match that of the parent
        /// entity exactly.
        /// </para>
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the targeted API entity. It is a valid and required field for the API
        /// entity types of <c>AUTHORIZER</c>, <c>MODEL</c>, <c>PATH_PARAMETER</c>, <c>QUERY_PARAMETER</c>,
        /// <c>REQUEST_HEADER</c>, <c>REQUEST_BODY</c> and <c>RESPONSE_HEADER</c>. It is an invalid
        /// field for any other entity type.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL path of the target. It is a valid field for the API entity types of <c>RESOURCE</c>,
        /// <c>METHOD</c>, <c>PATH_PARAMETER</c>, <c>QUERY_PARAMETER</c>, <c>REQUEST_HEADER</c>,
        /// <c>REQUEST_BODY</c>, <c>RESPONSE</c>, <c>RESPONSE_HEADER</c>, and <c>RESPONSE_BODY</c>.
        /// The default value is <c>/</c> for the root resource. When an applicable child entity
        /// inherits the content of another entity of the same type with more general specifications
        /// of the other <c>location</c> attributes, the child entity's <c>path</c> attribute
        /// must match that of the parent entity as a prefix.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code of a response. It is a valid field for the API entity types of
        /// <c>RESPONSE</c>, <c>RESPONSE_HEADER</c>, and <c>RESPONSE_BODY</c>. The default value
        /// is <c>*</c> for any status code. When an applicable child entity inherits the content
        /// of an entity of the same type with more general specifications of the other <c>location</c>
        /// attributes, the child entity's <c>statusCode</c> attribute must match that of the
        /// parent entity exactly.
        /// </para>
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of API entity to which the documentation content applies. Valid values are
        /// <c>API</c>, <c>AUTHORIZER</c>, <c>MODEL</c>, <c>RESOURCE</c>, <c>METHOD</c>, <c>PATH_PARAMETER</c>,
        /// <c>QUERY_PARAMETER</c>, <c>REQUEST_HEADER</c>, <c>REQUEST_BODY</c>, <c>RESPONSE</c>,
        /// <c>RESPONSE_HEADER</c>, and <c>RESPONSE_BODY</c>. Content inheritance does not apply
        /// to any entity of the <c>API</c>, <c>AUTHORIZER</c>, <c>METHOD</c>, <c>MODEL</c>, <c>REQUEST_BODY</c>,
        /// or <c>RESOURCE</c> type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentationPartType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
