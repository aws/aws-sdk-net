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
    /// SimpleScalarProperties Request Marshaller
    /// </summary>       
    public class SimpleScalarPropertiesRequestMarshaller : IMarshaller<IRequest, SimpleScalarPropertiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SimpleScalarPropertiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SimpleScalarPropertiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/SimpleScalarProperties";
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new InvariantCultureStreamWriter(memoryStream))
                {
                    JsonWriter writer = new JsonWriter(streamWriter);
                    writer.Validate = false;
                    writer.WriteObjectStart();
                    var context = new JsonMarshallerContext(request, writer);
                    if(publicRequest.IsSetByteValue())
                    {
                        context.Writer.WritePropertyName("byteValue");
                        context.Writer.Write(publicRequest.ByteValue.Value);
                    }

                    if(publicRequest.IsSetDoubleValue())
                    {
                        context.Writer.WritePropertyName("DoubleDribble");
                        if(StringUtils.IsSpecialDoubleValue(publicRequest.DoubleValue.Value))
                        {
                            context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.DoubleValue.Value));
                        }
                        else
                        {
                            context.Writer.Write(publicRequest.DoubleValue.Value);
                        }
                    }

                    if(publicRequest.IsSetFalseBooleanValue())
                    {
                        context.Writer.WritePropertyName("falseBooleanValue");
                        context.Writer.Write(publicRequest.FalseBooleanValue.Value);
                    }

                    if(publicRequest.IsSetFloatValue())
                    {
                        context.Writer.WritePropertyName("floatValue");
                        if(StringUtils.IsSpecialFloatValue(publicRequest.FloatValue.Value))
                        {
                            context.Writer.Write(StringUtils.FromSpecialFloatValue(publicRequest.FloatValue.Value));
                        }
                        else
                        {
                            context.Writer.Write(publicRequest.FloatValue.Value);
                        }
                    }

                    if(publicRequest.IsSetIntegerValue())
                    {
                        context.Writer.WritePropertyName("integerValue");
                        context.Writer.Write(publicRequest.IntegerValue.Value);
                    }

                    if(publicRequest.IsSetLongValue())
                    {
                        context.Writer.WritePropertyName("longValue");
                        context.Writer.Write(publicRequest.LongValue.Value);
                    }

                    if(publicRequest.IsSetShortValue())
                    {
                        context.Writer.WritePropertyName("shortValue");
                        context.Writer.Write(publicRequest.ShortValue.Value);
                    }

                    if(publicRequest.IsSetStringValue())
                    {
                        context.Writer.WritePropertyName("stringValue");
                        context.Writer.Write(publicRequest.StringValue);
                    }

                    if(publicRequest.IsSetTrueBooleanValue())
                    {
                        context.Writer.WritePropertyName("trueBooleanValue");
                        context.Writer.Write(publicRequest.TrueBooleanValue.Value);
                    }

                    writer.WriteObjectEnd();
                }

                request.Content = memoryStream.ToArray();
            }

        
            if (publicRequest.IsSetFoo()) 
            {
                request.Headers["X-Foo"] = publicRequest.Foo;
            }

            return request;
        }
        private static SimpleScalarPropertiesRequestMarshaller _instance = new SimpleScalarPropertiesRequestMarshaller();        

        internal static SimpleScalarPropertiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarPropertiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}