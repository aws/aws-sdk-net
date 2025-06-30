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
    /// SparseJsonMaps Request Marshaller
    /// </summary>       
    public class SparseJsonMapsRequestMarshaller : IMarshaller<IRequest, SparseJsonMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SparseJsonMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SparseJsonMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/SparseJsonMaps";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);

                if (publicRequest.IsSetSparseBooleanMap())
                {
                    context.Writer.WritePropertyName("sparseBooleanMap");
                    context.Writer.WriteObjectStart();
                    foreach (var kvp in publicRequest.SparseBooleanMap)
                    {
                        context.Writer.WritePropertyName(kvp.Key);
                        if (kvp.Value == null)
                            context.Writer.WriteRaw("null");
                        else
                            context.Writer.Write(kvp.Value.Value);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if (publicRequest.IsSetSparseNumberMap())
                {
                    context.Writer.WritePropertyName("sparseNumberMap");
                    context.Writer.WriteObjectStart();
                    foreach (var kvp in publicRequest.SparseNumberMap)
                    {
                        context.Writer.WritePropertyName(kvp.Key);
                        if (kvp.Value == null)
                            context.Writer.WriteRaw("null");
                        else
                            context.Writer.Write(kvp.Value.Value);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if (publicRequest.IsSetSparseSetMap())
                {
                    context.Writer.WritePropertyName("sparseSetMap");
                    context.Writer.WriteObjectStart();
                    foreach (var kvp in publicRequest.SparseSetMap)
                    {
                        context.Writer.WritePropertyName(kvp.Key);
                        if (kvp.Value == null)
                        {
                            context.Writer.WriteRaw("null");
                        }
                        else
                        {
                            context.Writer.WriteArrayStart();
                            foreach (var val in kvp.Value)
                            {
                                context.Writer.Write(val);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                    }
                    context.Writer.WriteObjectEnd();
                }

                if (publicRequest.IsSetSparseStringMap())
                {
                    context.Writer.WritePropertyName("sparseStringMap");
                    context.Writer.WriteObjectStart();
                    foreach (var kvp in publicRequest.SparseStringMap)
                    {
                        context.Writer.WritePropertyName(kvp.Key);
                        if (kvp.Value == null)
                            context.Writer.WriteRaw("null");
                        else
                            context.Writer.Write(kvp.Value);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if (publicRequest.IsSetSparseStructMap())
                {
                    context.Writer.WritePropertyName("sparseStructMap");
                    context.Writer.WriteObjectStart();
                    foreach (var kvp in publicRequest.SparseStructMap)
                    {
                        context.Writer.WritePropertyName(kvp.Key);
                        if (kvp.Value == null)
                        {
                            context.Writer.WriteRaw("null");
                        }
                        else
                        {
                            context.Writer.WriteObjectStart();
                            var marshaller = GreetingStructMarshaller.Instance;
                            marshaller.Marshall(kvp.Value, context);
                            context.Writer.WriteObjectEnd();
                        }
                    }
                    context.Writer.WriteObjectEnd();
                }
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }



            return request;
        }
        private static SparseJsonMapsRequestMarshaller _instance = new SparseJsonMapsRequestMarshaller();        

        internal static SparseJsonMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SparseJsonMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}