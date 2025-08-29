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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Echo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Echo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EchoOperation operation
    /// </summary>  
    public class EchoOperationResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            EchoOperationResponse response = new EchoOperationResponse();
            var reader = context.Reader;
            context.AddPathSegment("EchoOperation");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobMember":
                        {
                            context.AddPathSegment("BlobMember");
                            var unmarshaller = CborMemoryStreamUnmarshaller.Instance;
                            response.BlobMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "booleanMember":
                        {
                            context.AddPathSegment("BooleanMember");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            response.BooleanMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "complexStructMember":
                        {
                            context.AddPathSegment("ComplexStructMember");
                            var unmarshaller = ComplexStructureUnmarshaller.Instance;
                            response.ComplexStructMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "doubleMember":
                        {
                            context.AddPathSegment("DoubleMember");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            response.DoubleMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "floatMember":
                        {
                            context.AddPathSegment("FloatMember");
                            var unmarshaller = CborNullableFloatUnmarshaller.Instance;
                            response.FloatMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "integerMember":
                        {
                            context.AddPathSegment("IntegerMember");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.IntegerMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "listOfComplexObjectMember":
                        {
                            context.AddPathSegment("ListOfComplexObjectMember");
                            var unmarshaller = new CborListUnmarshaller<ComplexStructure, ComplexStructureUnmarshaller>(ComplexStructureUnmarshaller.Instance);
                            response.ListOfComplexObjectMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "listOfStringsMember":
                        {
                            context.AddPathSegment("ListOfStringsMember");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.ListOfStringsMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "longMember":
                        {
                            context.AddPathSegment("LongMember");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.LongMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "mapOfStringToStringMember":
                        {
                            context.AddPathSegment("MapOfStringToStringMember");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            response.MapOfStringToStringMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stringMember":
                        {
                            context.AddPathSegment("StringMember");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.StringMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "timestampMember":
                        {
                            context.AddPathSegment("TimestampMember");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.TimestampMember = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
            }
            return new AmazonEchoException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static EchoOperationResponseUnmarshaller _instance = new EchoOperationResponseUnmarshaller();        

        internal static EchoOperationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EchoOperationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}