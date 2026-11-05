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

using Amazon.EC2Protocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for XmlIntEnums operation.
    /// </summary>
    public partial class XmlIntEnumsResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlIntEnumsResponse unmarshalledObject = new XmlIntEnumsResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth = 2;
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

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2ProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static XmlIntEnumsResponseUnmarshaller _instance = new XmlIntEnumsResponseUnmarshaller();

        internal static XmlIntEnumsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static XmlIntEnumsResponseUnmarshaller Instance => _instance;
    }
}
