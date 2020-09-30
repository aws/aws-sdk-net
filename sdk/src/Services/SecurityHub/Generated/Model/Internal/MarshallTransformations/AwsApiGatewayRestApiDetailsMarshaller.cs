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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsApiGatewayRestApiDetails Marshaller
    /// </summary>       
    public class AwsApiGatewayRestApiDetailsMarshaller : IRequestMarshaller<AwsApiGatewayRestApiDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsApiGatewayRestApiDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApiKeySource())
            {
                context.Writer.WritePropertyName("ApiKeySource");
                context.Writer.Write(requestObject.ApiKeySource);
            }

            if(requestObject.IsSetBinaryMediaTypes())
            {
                context.Writer.WritePropertyName("BinaryMediaTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBinaryMediaTypesListValue in requestObject.BinaryMediaTypes)
                {
                        context.Writer.Write(requestObjectBinaryMediaTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreatedDate())
            {
                context.Writer.WritePropertyName("CreatedDate");
                context.Writer.Write(requestObject.CreatedDate);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEndpointConfiguration())
            {
                context.Writer.WritePropertyName("EndpointConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayEndpointConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EndpointConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetMinimumCompressionSize())
            {
                context.Writer.WritePropertyName("MinimumCompressionSize");
                context.Writer.Write(requestObject.MinimumCompressionSize);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.Write(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsApiGatewayRestApiDetailsMarshaller Instance = new AwsApiGatewayRestApiDetailsMarshaller();

    }
}