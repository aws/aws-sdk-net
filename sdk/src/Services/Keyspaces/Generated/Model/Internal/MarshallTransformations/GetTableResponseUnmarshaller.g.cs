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

using Amazon.Keyspaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTable operation.
    /// </summary>
    public partial class GetTableResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new GetTableResponse();
            var reader = context.Reader;

            context.AddPathSegment("GetTable");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "capacitySpecification":
                        context.AddPathSegment("CapacitySpecification");
                        unmarshalledObject.CapacitySpecification = CapacitySpecificationSummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "cdcSpecification":
                        context.AddPathSegment("CdcSpecification");
                        unmarshalledObject.CdcSpecification = CdcSpecificationSummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "clientSideTimestamps":
                        context.AddPathSegment("ClientSideTimestamps");
                        unmarshalledObject.ClientSideTimestamps = ClientSideTimestampsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "comment":
                        context.AddPathSegment("Comment");
                        unmarshalledObject.Comment = CommentUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "creationTimestamp":
                        context.AddPathSegment("CreationTimestamp");
                        unmarshalledObject.CreationTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "defaultTimeToLive":
                        context.AddPathSegment("DefaultTimeToLive");
                        unmarshalledObject.DefaultTimeToLive = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "encryptionSpecification":
                        context.AddPathSegment("EncryptionSpecification");
                        unmarshalledObject.EncryptionSpecification = EncryptionSpecificationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "keyspaceName":
                        context.AddPathSegment("KeyspaceName");
                        unmarshalledObject.KeyspaceName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "latestStreamArn":
                        context.AddPathSegment("LatestStreamArn");
                        unmarshalledObject.LatestStreamArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "pointInTimeRecovery":
                        context.AddPathSegment("PointInTimeRecovery");
                        unmarshalledObject.PointInTimeRecovery = PointInTimeRecoverySummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "replicaSpecifications":
                        context.AddPathSegment("ReplicaSpecifications");
                        unmarshalledObject.ReplicaSpecifications = new CborListUnmarshaller<ReplicaSpecificationSummary, ReplicaSpecificationSummaryUnmarshaller>(ReplicaSpecificationSummaryUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceArn":
                        context.AddPathSegment("ResourceArn");
                        unmarshalledObject.ResourceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "schemaDefinition":
                        context.AddPathSegment("SchemaDefinition");
                        unmarshalledObject.SchemaDefinition = SchemaDefinitionUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "tableName":
                        context.AddPathSegment("TableName");
                        unmarshalledObject.TableName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ttl":
                        context.AddPathSegment("Ttl");
                        unmarshalledObject.Ttl = TimeToLiveUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "warmThroughputSpecification":
                        context.AddPathSegment("WarmThroughputSpecification");
                        unmarshalledObject.WarmThroughputSpecification = WarmThroughputSpecificationSummaryUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                    {
                        return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonKeyspacesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTableResponseUnmarshaller _instance = new GetTableResponseUnmarshaller();

        internal static GetTableResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTableResponseUnmarshaller Instance => _instance;
    }
}
