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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetReplicationConfiguration operation
    /// </summary>  
    public class GetReplicationConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetReplicationConfigurationResponse response = new GetReplicationConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associateDefaultSecurityGroup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AssociateDefaultSecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoReplicateNewDisks", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AutoReplicateNewDisks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bandwidthThrottling", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BandwidthThrottling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createPublicIP", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.CreatePublicIP = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataPlaneRouting", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataPlaneRouting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultLargeStagingDiskType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DefaultLargeStagingDiskType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsEncryption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EbsEncryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsEncryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EbsEncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pitPolicy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PITPolicyRule, PITPolicyRuleUnmarshaller>(PITPolicyRuleUnmarshaller.Instance);
                    response.PitPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicatedDisks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ReplicationConfigurationReplicatedDisk, ReplicationConfigurationReplicatedDiskUnmarshaller>(ReplicationConfigurationReplicatedDiskUnmarshaller.Instance);
                    response.ReplicatedDisks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationServerInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReplicationServerInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationServersSecurityGroupsIDs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ReplicationServersSecurityGroupsIDs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServerID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceServerID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stagingAreaSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StagingAreaSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stagingAreaTags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.StagingAreaTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useDedicatedReplicationServer", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.UseDedicatedReplicationServer = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UninitializedAccountException"))
                {
                    return UninitializedAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDrsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetReplicationConfigurationResponseUnmarshaller _instance = new GetReplicationConfigurationResponseUnmarshaller();        

        internal static GetReplicationConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReplicationConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}