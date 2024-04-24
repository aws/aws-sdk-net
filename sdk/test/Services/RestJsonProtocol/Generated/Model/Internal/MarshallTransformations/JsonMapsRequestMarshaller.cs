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
    /// JsonMaps Request Marshaller
    /// </summary>       
    public class JsonMapsRequestMarshaller : IMarshaller<IRequest, JsonMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((JsonMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(JsonMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/JsonMaps";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDenseBooleanMap())
                {
                    context.Writer.WritePropertyName("denseBooleanMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDenseBooleanMapKvp in publicRequest.DenseBooleanMap)
                    {
                        context.Writer.WritePropertyName(publicRequestDenseBooleanMapKvp.Key);
                        var publicRequestDenseBooleanMapValue = publicRequestDenseBooleanMapKvp.Value;

                            context.Writer.Write(publicRequestDenseBooleanMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDenseNumberMap())
                {
                    context.Writer.WritePropertyName("denseNumberMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDenseNumberMapKvp in publicRequest.DenseNumberMap)
                    {
                        context.Writer.WritePropertyName(publicRequestDenseNumberMapKvp.Key);
                        var publicRequestDenseNumberMapValue = publicRequestDenseNumberMapKvp.Value;

                            context.Writer.Write(publicRequestDenseNumberMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDenseSetMap())
                {
                    context.Writer.WritePropertyName("denseSetMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDenseSetMapKvp in publicRequest.DenseSetMap)
                    {
                        context.Writer.WritePropertyName(publicRequestDenseSetMapKvp.Key);
                        var publicRequestDenseSetMapValue = publicRequestDenseSetMapKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestDenseSetMapValueListValue in publicRequestDenseSetMapValue)
                        {
                                context.Writer.Write(publicRequestDenseSetMapValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDenseStringMap())
                {
                    context.Writer.WritePropertyName("denseStringMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDenseStringMapKvp in publicRequest.DenseStringMap)
                    {
                        context.Writer.WritePropertyName(publicRequestDenseStringMapKvp.Key);
                        var publicRequestDenseStringMapValue = publicRequestDenseStringMapKvp.Value;

                            context.Writer.Write(publicRequestDenseStringMapValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDenseStructMap())
                {
                    context.Writer.WritePropertyName("denseStructMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDenseStructMapKvp in publicRequest.DenseStructMap)
                    {
                        context.Writer.WritePropertyName(publicRequestDenseStructMapKvp.Key);
                        var publicRequestDenseStructMapValue = publicRequestDenseStructMapKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = GreetingStructMarshaller.Instance;
                        marshaller.Marshall(publicRequestDenseStructMapValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static JsonMapsRequestMarshaller _instance = new JsonMapsRequestMarshaller();        

        internal static JsonMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JsonMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}