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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsApiGatewayV2ApiDetails Marshaller
    /// </summary>
    public class AwsApiGatewayV2ApiDetailsMarshaller : IRequestMarshaller<AwsApiGatewayV2ApiDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayV2ApiDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiEndpoint())
            {
                context.Writer.WritePropertyName("ApiEndpoint");
                context.Writer.WriteStringValue(requestObject.ApiEndpoint);
            }

            if(requestObject.IsSetApiId())
            {
                context.Writer.WritePropertyName("ApiId");
                context.Writer.WriteStringValue(requestObject.ApiId);
            }

            if(requestObject.IsSetApiKeySelectionExpression())
            {
                context.Writer.WritePropertyName("ApiKeySelectionExpression");
                context.Writer.WriteStringValue(requestObject.ApiKeySelectionExpression);
            }

            if(requestObject.IsSetCorsConfiguration())
            {
                context.Writer.WritePropertyName("CorsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsCorsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CorsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreatedDate())
            {
                context.Writer.WritePropertyName("CreatedDate");
                context.Writer.WriteStringValue(requestObject.CreatedDate);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetProtocolType())
            {
                context.Writer.WritePropertyName("ProtocolType");
                context.Writer.WriteStringValue(requestObject.ProtocolType);
            }

            if(requestObject.IsSetRouteSelectionExpression())
            {
                context.Writer.WritePropertyName("RouteSelectionExpression");
                context.Writer.WriteStringValue(requestObject.RouteSelectionExpression);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsApiGatewayV2ApiDetailsMarshaller Instance = new AwsApiGatewayV2ApiDetailsMarshaller();

    }
}