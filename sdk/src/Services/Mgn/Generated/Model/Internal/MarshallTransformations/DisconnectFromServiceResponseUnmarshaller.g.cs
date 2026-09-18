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
    /// Response Unmarshaller for DisconnectFromService operation.
    /// </summary>
    public partial class DisconnectFromServiceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DisconnectFromServiceResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("applicationID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("arn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("connectorAction", targetDepth, ref reader))
                {
                    var unmarshaller = SourceServerConnectorActionUnmarshaller.Instance;
                    unmarshalledObject.ConnectorAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dataReplicationInfo", targetDepth, ref reader))
                {
                    var unmarshaller = DataReplicationInfoUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("fqdnForActionFramework", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FqdnForActionFramework = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("isArchived", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsArchived = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("launchedInstance", targetDepth, ref reader))
                {
                    var unmarshaller = LaunchedInstanceUnmarshaller.Instance;
                    unmarshalledObject.LaunchedInstance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lifeCycle", targetDepth, ref reader))
                {
                    var unmarshaller = LifeCycleUnmarshaller.Instance;
                    unmarshalledObject.LifeCycle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("replicationType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sourceProperties", targetDepth, ref reader))
                {
                    var unmarshaller = SourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.SourceProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sourceServerID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceServerID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("userProvidedID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserProvidedID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("vcenterClientID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VcenterClientID = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                    {
                        return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("UninitializedAccountException"))
                    {
                        return UninitializedAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonMgnException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DisconnectFromServiceResponseUnmarshaller _instance = new DisconnectFromServiceResponseUnmarshaller();

        internal static DisconnectFromServiceResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DisconnectFromServiceResponseUnmarshaller Instance => _instance;
    }
}
