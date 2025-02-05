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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
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
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSourceServerAction Request Marshaller
    /// </summary>       
    public class PutSourceServerActionRequestMarshaller : IMarshaller<IRequest, PutSourceServerActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSourceServerActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSourceServerActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mgn");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/PutSourceServerAction";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountID())
            {
                context.Writer.WritePropertyName("accountID");
                context.Writer.WriteStringValue(publicRequest.AccountID);
            }

            if(publicRequest.IsSetActionID())
            {
                context.Writer.WritePropertyName("actionID");
                context.Writer.WriteStringValue(publicRequest.ActionID);
            }

            if(publicRequest.IsSetActionName())
            {
                context.Writer.WritePropertyName("actionName");
                context.Writer.WriteStringValue(publicRequest.ActionName);
            }

            if(publicRequest.IsSetActive())
            {
                context.Writer.WritePropertyName("active");
                context.Writer.WriteBooleanValue(publicRequest.Active.Value);
            }

            if(publicRequest.IsSetCategory())
            {
                context.Writer.WritePropertyName("category");
                context.Writer.WriteStringValue(publicRequest.Category);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDocumentIdentifier())
            {
                context.Writer.WritePropertyName("documentIdentifier");
                context.Writer.WriteStringValue(publicRequest.DocumentIdentifier);
            }

            if(publicRequest.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("documentVersion");
                context.Writer.WriteStringValue(publicRequest.DocumentVersion);
            }

            if(publicRequest.IsSetExternalParameters())
            {
                context.Writer.WritePropertyName("externalParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExternalParametersKvp in publicRequest.ExternalParameters)
                {
                    context.Writer.WritePropertyName(publicRequestExternalParametersKvp.Key);
                    var publicRequestExternalParametersValue = publicRequestExternalParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SsmExternalParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestExternalParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMustSucceedForCutover())
            {
                context.Writer.WritePropertyName("mustSucceedForCutover");
                context.Writer.WriteBooleanValue(publicRequest.MustSucceedForCutover.Value);
            }

            if(publicRequest.IsSetOrder())
            {
                context.Writer.WritePropertyName("order");
                context.Writer.WriteNumberValue(publicRequest.Order.Value);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = SsmParameterStoreParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestParametersValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceServerID())
            {
                context.Writer.WritePropertyName("sourceServerID");
                context.Writer.WriteStringValue(publicRequest.SourceServerID);
            }

            if(publicRequest.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.TimeoutSeconds.Value);
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
        private static PutSourceServerActionRequestMarshaller _instance = new PutSourceServerActionRequestMarshaller();        

        internal static PutSourceServerActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSourceServerActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}