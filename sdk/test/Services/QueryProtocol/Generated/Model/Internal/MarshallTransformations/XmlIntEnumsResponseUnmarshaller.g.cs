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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QueryProtocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for XmlIntEnums operation.
    /// </summary>
    public partial class XmlIntEnumsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlIntEnumsResponse response = new XmlIntEnumsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("XmlIntEnumsResult", 2))
                    {
                        UnmarshallResult(context, response);
                        continue;
                    }

                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlIntEnumsResponse unmarshalledObject)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("intEnum1", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.IntEnum1 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("intEnum2", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.IntEnum2 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("intEnum3", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.IntEnum3 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("intEnumList/member", targetDepth))
                    {
                        if (unmarshalledObject.IntEnumList == null)
                        {
                            unmarshalledObject.IntEnumList = new List<int>();
                        }
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.IntEnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("intEnumMap/entry", targetDepth))
                    {
                        if (unmarshalledObject.IntEnumMap == null)
                        {
                            unmarshalledObject.IntEnumMap = new Dictionary<string, int>();
                        }
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance, "key", "value");
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.IntEnumMap.Add(item.Key, item.Value);
                        continue;
                    }

                    if (context.TestExpression("intEnumSet/member", targetDepth))
                    {
                        if (unmarshalledObject.IntEnumSet == null)
                        {
                            unmarshalledObject.IntEnumSet = new List<int>();
                        }
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.IntEnumSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                }
            }

            return;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                }
            }
            return new AmazonQueryProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static XmlIntEnumsResponseUnmarshaller _instance = new XmlIntEnumsResponseUnmarshaller();

        internal static XmlIntEnumsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static XmlIntEnumsResponseUnmarshaller Instance => _instance;
    }
}
