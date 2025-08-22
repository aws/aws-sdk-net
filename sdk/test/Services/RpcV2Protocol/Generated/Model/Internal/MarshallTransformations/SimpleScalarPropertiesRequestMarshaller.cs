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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using AWSSDK.Extensions.CborProtocol;
using AWSSDK.Extensions.CborProtocol.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcV2Protocol");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/RpcV2Protocol/operation/SimpleScalarProperties";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBlobValue())
                {
                    context.Writer.WriteTextString("blobValue");
                    context.Writer.WriteByteString(publicRequest.BlobValue.ToArray());
                }
                if (publicRequest.IsSetByteValue())
                {
                    context.Writer.WriteTextString("byteValue");
                    context.Writer.WriteInt32(publicRequest.ByteValue.Value);
                }
                if (publicRequest.IsSetDoubleValue())
                {
                    context.Writer.WriteTextString("doubleValue");
                    context.Writer.WriteOptimizedNumber(publicRequest.DoubleValue.Value);
                }
                if (publicRequest.IsSetFalseBooleanValue())
                {
                    context.Writer.WriteTextString("falseBooleanValue");
                    context.Writer.WriteBoolean(publicRequest.FalseBooleanValue.Value);
                }
                if (publicRequest.IsSetFloatValue())
                {
                    context.Writer.WriteTextString("floatValue");
                    context.Writer.WriteOptimizedNumber(publicRequest.FloatValue.Value);
                }
                if (publicRequest.IsSetIntegerValue())
                {
                    context.Writer.WriteTextString("integerValue");
                    context.Writer.WriteInt32(publicRequest.IntegerValue.Value);
                }
                if (publicRequest.IsSetLongValue())
                {
                    context.Writer.WriteTextString("longValue");
                    context.Writer.WriteInt64(publicRequest.LongValue.Value);
                }
                if (publicRequest.IsSetShortValue())
                {
                    context.Writer.WriteTextString("shortValue");
                    context.Writer.WriteInt32(publicRequest.ShortValue.Value);
                }
                if (publicRequest.IsSetStringValue())
                {
                    context.Writer.WriteTextString("stringValue");
                    context.Writer.WriteTextString(publicRequest.StringValue);
                }
                if (publicRequest.IsSetTrueBooleanValue())
                {
                    context.Writer.WriteTextString("trueBooleanValue");
                    context.Writer.WriteBoolean(publicRequest.TrueBooleanValue.Value);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
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