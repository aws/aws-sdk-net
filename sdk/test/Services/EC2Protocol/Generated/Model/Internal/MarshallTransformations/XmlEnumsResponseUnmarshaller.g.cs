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
    /// Response Unmarshaller for XmlEnums operation.
    /// </summary>
    public partial class XmlEnumsResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlEnumsResponse unmarshalledObject = new XmlEnumsResponse();

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
                    if (context.TestExpression("fooEnum1", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FooEnum1 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fooEnum2", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FooEnum2 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fooEnum3", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FooEnum3 = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("fooEnumList/member", targetDepth))
                    {
                        if (unmarshalledObject.FooEnumList == null)
                        {
                            unmarshalledObject.FooEnumList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FooEnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("fooEnumMap/entry", targetDepth))
                    {
                        if (unmarshalledObject.FooEnumMap == null)
                        {
                            unmarshalledObject.FooEnumMap = new Dictionary<string, string>();
                        }
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.FooEnumMap.Add(item.Key, item.Value);
                        continue;
                    }

                    if (context.TestExpression("fooEnumSet/member", targetDepth))
                    {
                        if (unmarshalledObject.FooEnumSet == null)
                        {
                            unmarshalledObject.FooEnumSet = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FooEnumSet.Add(unmarshaller.Unmarshall(context));
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

        private static XmlEnumsResponseUnmarshaller _instance = new XmlEnumsResponseUnmarshaller();

        internal static XmlEnumsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static XmlEnumsResponseUnmarshaller Instance => _instance;
    }
}
