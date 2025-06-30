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
    /// JsonIntEnums Request Marshaller
    /// </summary>       
    public class JsonIntEnumsRequestMarshaller : IMarshaller<IRequest, JsonIntEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonIntEnumsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonIntEnumsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JsonProtocol");
            string target = "JsonProtocol.JsonIntEnums";
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
                if(publicRequest.IsSetIntEnum1())
                {
                    context.Writer.WritePropertyName("intEnum1");
                    context.Writer.Write(publicRequest.IntEnum1);
                }

                if(publicRequest.IsSetIntEnum2())
                {
                    context.Writer.WritePropertyName("intEnum2");
                    context.Writer.Write(publicRequest.IntEnum2);
                }

                if(publicRequest.IsSetIntEnum3())
                {
                    context.Writer.WritePropertyName("intEnum3");
                    context.Writer.Write(publicRequest.IntEnum3);
                }

                if(publicRequest.IsSetIntEnumList())
                {
                    context.Writer.WritePropertyName("intEnumList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIntEnumListListValue in publicRequest.IntEnumList)
                    {
                            context.Writer.Write(publicRequestIntEnumListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIntEnumMap())
                {
                    context.Writer.WritePropertyName("intEnumMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestIntEnumMapKvp in publicRequest.IntEnumMap)
                    {
                        context.Writer.WritePropertyName(publicRequestIntEnumMapKvp.Key);
                        var publicRequestIntEnumMapValue = publicRequestIntEnumMapKvp.Value;

                            context.Writer.Write(publicRequestIntEnumMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIntEnumSet())
                {
                    context.Writer.WritePropertyName("intEnumSet");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIntEnumSetListValue in publicRequest.IntEnumSet)
                    {
                            context.Writer.Write(publicRequestIntEnumSetListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static JsonIntEnumsRequestMarshaller _instance = new JsonIntEnumsRequestMarshaller();        

        internal static JsonIntEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonIntEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}