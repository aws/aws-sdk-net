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
    /// Response Unmarshaller for XmlLists operation.
    /// </summary>
    public partial class XmlListsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            XmlListsResponse response = new XmlListsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("XmlListsResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, XmlListsResponse unmarshalledObject)
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
                    if (context.TestExpression("booleanList/member", targetDepth))
                    {
                        if (unmarshalledObject.BooleanList == null)
                        {
                            unmarshalledObject.BooleanList = new List<bool>();
                        }
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.BooleanList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("enumList/member", targetDepth))
                    {
                        if (unmarshalledObject.EnumList == null)
                        {
                            unmarshalledObject.EnumList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EnumList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("flattenedList", targetDepth))
                    {
                        if (unmarshalledObject.FlattenedList == null)
                        {
                            unmarshalledObject.FlattenedList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlattenedList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("customName", targetDepth))
                    {
                        if (unmarshalledObject.FlattenedList2 == null)
                        {
                            unmarshalledObject.FlattenedList2 = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlattenedList2.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("flattenedListWithMemberNamespace", targetDepth))
                    {
                        if (unmarshalledObject.FlattenedListWithMemberNamespace == null)
                        {
                            unmarshalledObject.FlattenedListWithMemberNamespace = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlattenedListWithMemberNamespace.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("flattenedListWithNamespace", targetDepth))
                    {
                        if (unmarshalledObject.FlattenedListWithNamespace == null)
                        {
                            unmarshalledObject.FlattenedListWithNamespace = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlattenedListWithNamespace.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("integerList/member", targetDepth))
                    {
                        if (unmarshalledObject.IntegerList == null)
                        {
                            unmarshalledObject.IntegerList = new List<int>();
                        }
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.IntegerList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("nestedStringList/member", targetDepth))
                    {
                        if (unmarshalledObject.NestedStringList == null)
                        {
                            unmarshalledObject.NestedStringList = new List<List<string>>();
                        }
                        var unmarshaller = new XmlListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                        unmarshalledObject.NestedStringList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("renamed/item", targetDepth))
                    {
                        if (unmarshalledObject.RenamedListMembers == null)
                        {
                            unmarshalledObject.RenamedListMembers = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RenamedListMembers.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("stringList/member", targetDepth))
                    {
                        if (unmarshalledObject.StringList == null)
                        {
                            unmarshalledObject.StringList = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StringList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("stringSet/member", targetDepth))
                    {
                        if (unmarshalledObject.StringSet == null)
                        {
                            unmarshalledObject.StringSet = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StringSet.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("myStructureList/item", targetDepth))
                    {
                        if (unmarshalledObject.StructureList == null)
                        {
                            unmarshalledObject.StructureList = new List<StructureListMember>();
                        }
                        var unmarshaller = StructureListMemberUnmarshaller.Instance;
                        unmarshalledObject.StructureList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("timestampList/member", targetDepth))
                    {
                        if (unmarshalledObject.TimestampList == null)
                        {
                            unmarshalledObject.TimestampList = new List<DateTime>();
                        }
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.TimestampList.Add(unmarshaller.Unmarshall(context));
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

        private static XmlListsResponseUnmarshaller _instance = new XmlListsResponseUnmarshaller();

        internal static XmlListsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static XmlListsResponseUnmarshaller Instance => _instance;
    }
}
