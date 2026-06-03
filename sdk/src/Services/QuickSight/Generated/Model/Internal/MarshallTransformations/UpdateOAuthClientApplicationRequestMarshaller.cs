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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateOAuthClientApplication Request Marshaller
    /// </summary>       
    public class UpdateOAuthClientApplicationRequestMarshaller : IMarshaller<IRequest, UpdateOAuthClientApplicationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOAuthClientApplicationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOAuthClientApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetOAuthClientApplicationId())
                throw new AmazonQuickSightException("Request object does not have required field OAuthClientApplicationId set");
            request.AddPathResource("{OAuthClientApplicationId}", StringUtils.FromString(publicRequest.OAuthClientApplicationId));
            request.ResourcePath = "/accounts/{AwsAccountId}/oauth-client-applications/{OAuthClientApplicationId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
            }

            if(publicRequest.IsSetClientSecret())
            {
                context.Writer.WritePropertyName("ClientSecret");
                context.Writer.WriteStringValue(publicRequest.ClientSecret);
            }

            if(publicRequest.IsSetDataSourceType())
            {
                context.Writer.WritePropertyName("DataSourceType");
                context.Writer.WriteStringValue(publicRequest.DataSourceType);
            }

            if(publicRequest.IsSetIdentityProviderVpcConnectionProperties())
            {
                context.Writer.WritePropertyName("IdentityProviderVpcConnectionProperties");
                context.Writer.WriteStartObject();

                var marshaller = VpcConnectionPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityProviderVpcConnectionProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOAuthAuthorizationEndpointUrl())
            {
                context.Writer.WritePropertyName("OAuthAuthorizationEndpointUrl");
                context.Writer.WriteStringValue(publicRequest.OAuthAuthorizationEndpointUrl);
            }

            if(publicRequest.IsSetOAuthScopes())
            {
                context.Writer.WritePropertyName("OAuthScopes");
                context.Writer.WriteStringValue(publicRequest.OAuthScopes);
            }

            if(publicRequest.IsSetOAuthTokenEndpointUrl())
            {
                context.Writer.WritePropertyName("OAuthTokenEndpointUrl");
                context.Writer.WriteStringValue(publicRequest.OAuthTokenEndpointUrl);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateOAuthClientApplicationRequestMarshaller _instance = new UpdateOAuthClientApplicationRequestMarshaller();        

        internal static UpdateOAuthClientApplicationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOAuthClientApplicationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}