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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorksCM.Model;
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
namespace Amazon.OpsWorksCM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateNode Request Marshaller
    /// </summary>       
    public class DisassociateNodeRequestMarshaller : IMarshaller<IRequest, DisassociateNodeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateNodeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateNodeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorksCM");
            string target = "OpsWorksCM_V2016_11_01.DisassociateNode";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEngineAttributes())
            {
                context.Writer.WritePropertyName("EngineAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEngineAttributesListValue in publicRequest.EngineAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EngineAttributeMarshaller.Instance;
                    marshaller.Marshall(publicRequestEngineAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNodeName())
            {
                context.Writer.WritePropertyName("NodeName");
                context.Writer.WriteStringValue(publicRequest.NodeName);
            }

            if(publicRequest.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(publicRequest.ServerName);
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
        private static DisassociateNodeRequestMarshaller _instance = new DisassociateNodeRequestMarshaller();        

        internal static DisassociateNodeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateNodeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}