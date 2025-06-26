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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
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
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociatePermission Request Marshaller
    /// </summary>       
    public class AssociatePermissionRequestMarshaller : IMarshaller<IRequest, AssociatePermissionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociatePermissionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociatePermissionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/policy";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionsListValue in publicRequest.Actions)
                {
                        context.Writer.WriteStringValue(publicRequestActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConditions())
            {
                context.Writer.WritePropertyName("conditions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestConditionsListValue in publicRequest.Conditions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PermissionConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequestConditionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("principal");
                context.Writer.WriteStringValue(publicRequest.Principal);
            }

            if(publicRequest.IsSetStatementId())
            {
                context.Writer.WritePropertyName("statementId");
                context.Writer.WriteStringValue(publicRequest.StatementId);
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
        private static AssociatePermissionRequestMarshaller _instance = new AssociatePermissionRequestMarshaller();        

        internal static AssociatePermissionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociatePermissionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}