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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModifySnapshotSchedule operation.
    /// </summary>
    public partial class ModifySnapshotScheduleResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ModifySnapshotScheduleResponse response = new ModifySnapshotScheduleResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("ModifySnapshotScheduleResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ModifySnapshotScheduleResponse unmarshalledObject)
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
                    if (context.TestExpression("AssociatedClusterCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AssociatedClusterCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("AssociatedClusters/ClusterAssociatedToSchedule", targetDepth))
                    {
                        if (unmarshalledObject.AssociatedClusters == null)
                        {
                            unmarshalledObject.AssociatedClusters = new List<ClusterAssociatedToSchedule>();
                        }
                        var unmarshaller = ClusterAssociatedToScheduleUnmarshaller.Instance;
                        unmarshalledObject.AssociatedClusters.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("NextInvocations/SnapshotTime", targetDepth))
                    {
                        if (unmarshalledObject.NextInvocations == null)
                        {
                            unmarshalledObject.NextInvocations = new List<DateTime>();
                        }
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.NextInvocations.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ScheduleDefinitions/ScheduleDefinition", targetDepth))
                    {
                        if (unmarshalledObject.ScheduleDefinitions == null)
                        {
                            unmarshalledObject.ScheduleDefinitions = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ScheduleDefinitions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ScheduleDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ScheduleDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ScheduleIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ScheduleIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSchedule"))
                    {
                        return InvalidScheduleExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("SnapshotScheduleNotFound"))
                    {
                        return SnapshotScheduleNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("SnapshotScheduleUpdateInProgress"))
                    {
                        return SnapshotScheduleUpdateInProgressExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ModifySnapshotScheduleResponseUnmarshaller _instance = new ModifySnapshotScheduleResponseUnmarshaller();

        internal static ModifySnapshotScheduleResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifySnapshotScheduleResponseUnmarshaller Instance => _instance;
    }
}
