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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signin.Model;
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
namespace Amazon.Signin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutResourcePermissionStatement Request Marshaller
    /// </summary>       
    public class PutResourcePermissionStatementRequestMarshaller : IMarshaller<IRequest, PutResourcePermissionStatementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutResourcePermissionStatementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutResourcePermissionStatementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/put-resource-permission-statement";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConsoleSourceVpce())
            {
                context.Writer.WritePropertyName("consoleSourceVpce");
                context.Writer.WriteStringValue(publicRequest.ConsoleSourceVpce);
            }

            if(publicRequest.IsSetExcludedPrincipal())
            {
                context.Writer.WritePropertyName("excludedPrincipal");
                context.Writer.WriteStringValue(publicRequest.ExcludedPrincipal);
            }

            if(publicRequest.IsSetRequestedRegion())
            {
                context.Writer.WritePropertyName("requestedRegion");
                context.Writer.WriteStringValue(publicRequest.RequestedRegion);
            }

            if(publicRequest.IsSetSigninSourceVpce())
            {
                context.Writer.WritePropertyName("signinSourceVpce");
                context.Writer.WriteStringValue(publicRequest.SigninSourceVpce);
            }

            if(publicRequest.IsSetSourceIp())
            {
                context.Writer.WritePropertyName("sourceIp");
                context.Writer.WriteStringValue(publicRequest.SourceIp);
            }

            if(publicRequest.IsSetSourceVpc())
            {
                context.Writer.WritePropertyName("sourceVpc");
                context.Writer.WriteStringValue(publicRequest.SourceVpc);
            }

            if(publicRequest.IsSetVpcSourceIp())
            {
                context.Writer.WritePropertyName("vpcSourceIp");
                context.Writer.WriteStringValue(publicRequest.VpcSourceIp);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static PutResourcePermissionStatementRequestMarshaller _instance = new PutResourcePermissionStatementRequestMarshaller();        

        internal static PutResourcePermissionStatementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutResourcePermissionStatementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}