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
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Echo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Echo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EchoOperation Request Marshaller
    /// </summary>       
    public class EchoOperationRequestMarshaller : IMarshaller<IRequest, EchoOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EchoOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EchoOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Echo");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/Echoservice/operation/EchoOperation";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-02";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBlobMember())
                {
                    context.Writer.WriteTextString("blobMember");
                    context.Writer.WriteByteString(publicRequest.BlobMember.ToArray());
                }
                if (publicRequest.IsSetBooleanMember())
                {
                    context.Writer.WriteTextString("booleanMember");
                    context.Writer.WriteBoolean(publicRequest.BooleanMember.Value);
                }
                if (publicRequest.IsSetComplexStructMember())
                {
                    context.Writer.WriteTextString("complexStructMember");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ComplexStructureMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComplexStructMember, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDoubleMember())
                {
                    context.Writer.WriteTextString("doubleMember");
                    context.Writer.WriteOptimizedNumber(publicRequest.DoubleMember.Value);
                }
                if (publicRequest.IsSetFloatMember())
                {
                    context.Writer.WriteTextString("floatMember");
                    context.Writer.WriteOptimizedNumber(publicRequest.FloatMember.Value);
                }
                if (publicRequest.IsSetIntegerMember())
                {
                    context.Writer.WriteTextString("integerMember");
                    context.Writer.WriteInt32(publicRequest.IntegerMember.Value);
                }
                if (publicRequest.IsSetListOfComplexObjectMember())
                {
                    context.Writer.WriteTextString("listOfComplexObjectMember");
                    context.Writer.WriteStartArray(publicRequest.ListOfComplexObjectMember.Count);
                    foreach(var publicRequestListOfComplexObjectMemberListValue in publicRequest.ListOfComplexObjectMember)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ComplexStructureMarshaller.Instance;
                        marshaller.Marshall(publicRequestListOfComplexObjectMemberListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetListOfStringsMember())
                {
                    context.Writer.WriteTextString("listOfStringsMember");
                    context.Writer.WriteStartArray(publicRequest.ListOfStringsMember.Count);
                    foreach(var publicRequestListOfStringsMemberListValue in publicRequest.ListOfStringsMember)
                    {
                            context.Writer.WriteTextString(publicRequestListOfStringsMemberListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLongMember())
                {
                    context.Writer.WriteTextString("longMember");
                    context.Writer.WriteInt64(publicRequest.LongMember.Value);
                }
                if (publicRequest.IsSetMapOfStringToStringMember())
                {
                    context.Writer.WriteTextString("mapOfStringToStringMember");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestMapOfStringToStringMemberKvp in publicRequest.MapOfStringToStringMember)
                    {
                        context.Writer.WriteTextString(publicRequestMapOfStringToStringMemberKvp.Key);
                        var publicRequestMapOfStringToStringMemberValue = publicRequestMapOfStringToStringMemberKvp.Value;

                            context.Writer.WriteTextString(publicRequestMapOfStringToStringMemberValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStringMember())
                {
                    context.Writer.WriteTextString("stringMember");
                    context.Writer.WriteTextString(publicRequest.StringMember);
                }
                if (publicRequest.IsSetTimestampMember())
                {
                    context.Writer.WriteTextString("timestampMember");
                    context.Writer.WriteDateTime(publicRequest.TimestampMember.Value);
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
        private static EchoOperationRequestMarshaller _instance = new EchoOperationRequestMarshaller();        

        internal static EchoOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EchoOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}