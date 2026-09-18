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

using Amazon.Mgn.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UpdateReplicationConfigurationTemplate operation.
    /// </summary>
    public partial class UpdateReplicationConfigurationTemplateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new UpdateReplicationConfigurationTemplateResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("associateDefaultSecurityGroup", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AssociateDefaultSecurityGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bandwidthThrottling", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BandwidthThrottling = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("createPublicIP", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CreatePublicIP = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dataPlaneRouting", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataPlaneRouting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("defaultLargeStagingDiskType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultLargeStagingDiskType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ebsEncryption", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ebsEncryptionKeyArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsEncryptionKeyArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("internetProtocol", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InternetProtocol = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("replicationConfigurationTemplateID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationConfigurationTemplateID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("replicationServerInstanceType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationServerInstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("replicationServersSecurityGroupsIDs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReplicationServersSecurityGroupsIDs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("stagingAreaSubnetId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StagingAreaSubnetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("stagingAreaTags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StagingAreaTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("storageConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = StorageConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StorageConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("storeSnapshotOnLocalZone", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.StoreSnapshotOnLocalZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("useDedicatedReplicationServer", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UseDedicatedReplicationServer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("useFipsEndpoint", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UseFipsEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("UninitializedAccountException"))
                    {
                        return UninitializedAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonMgnException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static UpdateReplicationConfigurationTemplateResponseUnmarshaller _instance = new UpdateReplicationConfigurationTemplateResponseUnmarshaller();

        internal static UpdateReplicationConfigurationTemplateResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateReplicationConfigurationTemplateResponseUnmarshaller Instance => _instance;
    }
}
