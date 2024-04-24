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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JsonLists Request Marshaller
    /// </summary>       
    public class JsonListsRequestMarshaller : IMarshaller<IRequest, JsonListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/JsonLists";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBooleanList())
                {
                    context.Writer.WritePropertyName("booleanList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBooleanListListValue in publicRequest.BooleanList)
                    {
                            context.Writer.Write(publicRequestBooleanListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEnumList())
                {
                    context.Writer.WritePropertyName("enumList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEnumListListValue in publicRequest.EnumList)
                    {
                            context.Writer.Write(publicRequestEnumListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIntegerList())
                {
                    context.Writer.WritePropertyName("integerList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIntegerListListValue in publicRequest.IntegerList)
                    {
                            context.Writer.Write(publicRequestIntegerListListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetNestedStringList())
                {
                    context.Writer.WritePropertyName("nestedStringList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNestedStringListListValue in publicRequest.NestedStringList)
                    {
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestNestedStringListListValueListValue in publicRequestNestedStringListListValue)
                        {
                                context.Writer.Write(publicRequestNestedStringListListValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStringList())
                {
                    context.Writer.WritePropertyName("stringList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStringListListValue in publicRequest.StringList)
                    {
                            context.Writer.Write(publicRequestStringListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStringSet())
                {
                    context.Writer.WritePropertyName("stringSet");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStringSetListValue in publicRequest.StringSet)
                    {
                            context.Writer.Write(publicRequestStringSetListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStructureList())
                {
                    context.Writer.WritePropertyName("myStructureList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStructureListListValue in publicRequest.StructureList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StructureListMemberMarshaller.Instance;
                        marshaller.Marshall(publicRequestStructureListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimestampList())
                {
                    context.Writer.WritePropertyName("timestampList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTimestampListListValue in publicRequest.TimestampList)
                    {
                            context.Writer.Write(publicRequestTimestampListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static JsonListsRequestMarshaller _instance = new JsonListsRequestMarshaller();        

        internal static JsonListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}