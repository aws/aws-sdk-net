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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTable operation
    /// </summary>  
    public class GetTableResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            GetTableResponse response = new GetTableResponse();
            var reader = context.Reader;
            context.AddPathSegment("GetTable");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "capacitySpecification":
                        {
                            context.AddPathSegment("CapacitySpecification");
                            var unmarshaller = CapacitySpecificationSummaryUnmarshaller.Instance;
                            response.CapacitySpecification = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "cdcSpecification":
                        {
                            context.AddPathSegment("CdcSpecification");
                            var unmarshaller = CdcSpecificationSummaryUnmarshaller.Instance;
                            response.CdcSpecification = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "clientSideTimestamps":
                        {
                            context.AddPathSegment("ClientSideTimestamps");
                            var unmarshaller = ClientSideTimestampsUnmarshaller.Instance;
                            response.ClientSideTimestamps = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "comment":
                        {
                            context.AddPathSegment("Comment");
                            var unmarshaller = CommentUnmarshaller.Instance;
                            response.Comment = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTimestamp":
                        {
                            context.AddPathSegment("CreationTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            response.CreationTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "defaultTimeToLive":
                        {
                            context.AddPathSegment("DefaultTimeToLive");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.DefaultTimeToLive = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "encryptionSpecification":
                        {
                            context.AddPathSegment("EncryptionSpecification");
                            var unmarshaller = EncryptionSpecificationUnmarshaller.Instance;
                            response.EncryptionSpecification = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "keyspaceName":
                        {
                            context.AddPathSegment("KeyspaceName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.KeyspaceName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "latestStreamArn":
                        {
                            context.AddPathSegment("LatestStreamArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.LatestStreamArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "pointInTimeRecovery":
                        {
                            context.AddPathSegment("PointInTimeRecovery");
                            var unmarshaller = PointInTimeRecoverySummaryUnmarshaller.Instance;
                            response.PointInTimeRecovery = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "replicaSpecifications":
                        {
                            context.AddPathSegment("ReplicaSpecifications");
                            var unmarshaller = new CborListUnmarshaller<ReplicaSpecificationSummary, ReplicaSpecificationSummaryUnmarshaller>(ReplicaSpecificationSummaryUnmarshaller.Instance);
                            response.ReplicaSpecifications = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.ResourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "schemaDefinition":
                        {
                            context.AddPathSegment("SchemaDefinition");
                            var unmarshaller = SchemaDefinitionUnmarshaller.Instance;
                            response.SchemaDefinition = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "tableName":
                        {
                            context.AddPathSegment("TableName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.TableName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ttl":
                        {
                            context.AddPathSegment("Ttl");
                            var unmarshaller = TimeToLiveUnmarshaller.Instance;
                            response.Ttl = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "warmThroughputSpecification":
                        {
                            context.AddPathSegment("WarmThroughputSpecification");
                            var unmarshaller = WarmThroughputSpecificationSummaryUnmarshaller.Instance;
                            response.WarmThroughputSpecification = unmarshaller.Unmarshall(context);
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
            return new AmazonKeyspacesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTableResponseUnmarshaller _instance = new GetTableResponseUnmarshaller();        

        internal static GetTableResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTableResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}