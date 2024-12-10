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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QueryProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
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

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("XmlListsResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlListsResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("booleanList/member", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        if (response.BooleanList == null)
                        {
                            response.BooleanList = new List<bool>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.BooleanList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("enumList/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.EnumList == null)
                        {
                            response.EnumList = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.EnumList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("flattenedList", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.FlattenedList == null)
                        {
                            response.FlattenedList = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.FlattenedList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("customName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.FlattenedList2 == null)
                        {
                            response.FlattenedList2 = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.FlattenedList2.Add(item);
                        continue;
                    }
                    if (context.TestExpression("flattenedListWithMemberNamespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.FlattenedListWithMemberNamespace == null)
                        {
                            response.FlattenedListWithMemberNamespace = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.FlattenedListWithMemberNamespace.Add(item);
                        continue;
                    }
                    if (context.TestExpression("flattenedListWithNamespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.FlattenedListWithNamespace == null)
                        {
                            response.FlattenedListWithNamespace = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.FlattenedListWithNamespace.Add(item);
                        continue;
                    }
                    if (context.TestExpression("integerList/member", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        if (response.IntegerList == null)
                        {
                            response.IntegerList = new List<int>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.IntegerList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("intEnumList/member", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        if (response.IntEnumList == null)
                        {
                            response.IntEnumList = new List<int>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.IntEnumList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("nestedStringList/member", targetDepth))
                    {
                        var unmarshaller = new XmlListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                        if (response.NestedStringList == null)
                        {
                            response.NestedStringList = new List<List<string>>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.NestedStringList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("renamed/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.RenamedListMembers == null)
                        {
                            response.RenamedListMembers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.RenamedListMembers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("stringList/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.StringList == null)
                        {
                            response.StringList = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.StringList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("stringSet/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.StringSet == null)
                        {
                            response.StringSet = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.StringSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("myStructureList/item", targetDepth))
                    {
                        var unmarshaller = StructureListMemberUnmarshaller.Instance;
                        if (response.StructureList == null)
                        {
                            response.StructureList = new List<StructureListMember>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.StructureList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("timestampList/member", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        if (response.TimestampList == null)
                        {
                            response.TimestampList = new List<DateTime>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.TimestampList.Add(item);
                        continue;
                    }
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
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonQueryProtocolException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
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