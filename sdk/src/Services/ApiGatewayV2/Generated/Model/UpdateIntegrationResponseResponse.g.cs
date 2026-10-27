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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateIntegrationResponse operation.
    /// </summary>
    public partial class UpdateIntegrationResponseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContentHandlingStrategy. 
        /// <para>
        /// Supported only for WebSocket APIs. Specifies how to handle response payload content
        /// type conversions. Supported values are CONVERT_TO_BINARY and CONVERT_TO_TEXT, with
        /// the following behaviors:
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_BINARY: Converts a response payload from a Base64-encoded string to the
        /// corresponding binary blob.
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_TEXT: Converts a response payload from a binary blob to a Base64-encoded
        /// string.
        /// </para>
        ///  
        /// <para>
        /// If this property is not defined, the response payload will be passed through from
        /// the integration response to the route response or method response without modification.
        /// </para>
        /// </summary>
        public ContentHandlingStrategy ContentHandlingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ContentHandlingStrategy property is set.
        /// </summary>
        internal bool IsSetContentHandlingStrategy() => this.ContentHandlingStrategy != null;

        /// <summary>
        /// Gets and sets the property IntegrationResponseId. 
        /// <para>
        /// The integration response ID.
        /// </para>
        /// </summary>
        public string IntegrationResponseId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationResponseId property is set.
        /// </summary>
        internal bool IsSetIntegrationResponseId() => this.IntegrationResponseId != null;

        /// <summary>
        /// Gets and sets the property IntegrationResponseKey. 
        /// <para>
        /// The integration response key.
        /// </para>
        /// </summary>
        public string IntegrationResponseKey { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationResponseKey property is set.
        /// </summary>
        internal bool IsSetIntegrationResponseKey() => this.IntegrationResponseKey != null;

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// A key-value map specifying response parameters that are passed to the method response
        /// from the backend. The key is a method response header parameter name and the mapped
        /// value is an integration response header value, a static value enclosed within a pair
        /// of single quotes, or a JSON expression from the integration response body. The mapping
        /// key must match the pattern of method.response.header.{name}, where name is a valid
        /// and unique header name. The mapped non-static value must match the pattern of integration.response.header.{name}
        /// or integration.response.body.{JSON-expression}, where name is a valid and unique response
        /// header name and JSON-expression is a valid JSON expression without the $ prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResponseParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResponseParameters property is set.
        /// </summary>
        internal bool IsSetResponseParameters() => this.ResponseParameters != null && (this.ResponseParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseTemplates. 
        /// <para>
        /// The collection of response templates for the integration response as a string-to-string
        /// map of key-value pairs. Response templates are represented as a key/value map, with
        /// a content-type as the key and a template as the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResponseTemplates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResponseTemplates property is set.
        /// </summary>
        internal bool IsSetResponseTemplates() => this.ResponseTemplates != null && (this.ResponseTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateSelectionExpression. 
        /// <para>
        /// The template selection expressions for the integration response.
        /// </para>
        /// </summary>
        public string TemplateSelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSelectionExpression property is set.
        /// </summary>
        internal bool IsSetTemplateSelectionExpression() => this.TemplateSelectionExpression != null;
    }
}
