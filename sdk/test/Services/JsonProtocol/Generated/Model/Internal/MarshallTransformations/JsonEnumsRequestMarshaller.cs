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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.JsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JsonEnums Request Marshaller
    /// </summary>       
    public class JsonEnumsRequestMarshaller : IMarshaller<IRequest, JsonEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonEnumsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonProtocol");
            string target = "JsonProtocol.JsonEnums";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFooEnum1())
                {
                    context.Writer.WritePropertyName("fooEnum1");
                    context.Writer.Write(publicRequest.FooEnum1);
                }

                if(publicRequest.IsSetFooEnum2())
                {
                    context.Writer.WritePropertyName("fooEnum2");
                    context.Writer.Write(publicRequest.FooEnum2);
                }

                if(publicRequest.IsSetFooEnum3())
                {
                    context.Writer.WritePropertyName("fooEnum3");
                    context.Writer.Write(publicRequest.FooEnum3);
                }

                if(publicRequest.IsSetFooEnumList())
                {
                    context.Writer.WritePropertyName("fooEnumList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFooEnumListListValue in publicRequest.FooEnumList)
                    {
                            context.Writer.Write(publicRequestFooEnumListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFooEnumMap())
                {
                    context.Writer.WritePropertyName("fooEnumMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFooEnumMapKvp in publicRequest.FooEnumMap)
                    {
                        context.Writer.WritePropertyName(publicRequestFooEnumMapKvp.Key);
                        var publicRequestFooEnumMapValue = publicRequestFooEnumMapKvp.Value;

                            context.Writer.Write(publicRequestFooEnumMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFooEnumSet())
                {
                    context.Writer.WritePropertyName("fooEnumSet");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFooEnumSetListValue in publicRequest.FooEnumSet)
                    {
                            context.Writer.Write(publicRequestFooEnumSetListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static JsonEnumsRequestMarshaller _instance = new JsonEnumsRequestMarshaller();        

        internal static JsonEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}