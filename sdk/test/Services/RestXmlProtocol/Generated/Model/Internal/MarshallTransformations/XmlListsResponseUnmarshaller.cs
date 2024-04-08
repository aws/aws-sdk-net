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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for XmlLists operation
    /// </summary>  
    public class XmlListsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlListsResponse response = new XmlListsResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlListsResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if(context.Stream.Length == 0)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("booleanList/member", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.BooleanList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("enumList/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("flattenedList/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FlattenedList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("customName/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FlattenedList2.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("flattenedListWithMemberNamespace/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FlattenedListWithMemberNamespace.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("flattenedListWithNamespace/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.FlattenedListWithNamespace.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("flattenedStructureList/item", targetDepth))
                    {
                        var unmarshaller = StructureListMemberUnmarshaller.Instance;
                        response.FlattenedStructureList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("integerList/member", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntegerList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("intEnumList/member", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.IntEnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("nestedStringList/member", targetDepth))
                    {
                        var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                        response.NestedStringList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("renamed/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.RenamedListMembers.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("stringList/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StringList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("stringSet/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StringSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("myStructureList/item", targetDepth))
                    {
                        var unmarshaller = StructureListMemberUnmarshaller.Instance;
                        response.StructureList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("timestampList/member", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.TimestampList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonRestXmlProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static XmlListsResponseUnmarshaller _instance = new XmlListsResponseUnmarshaller();        

        internal static XmlListsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlListsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}