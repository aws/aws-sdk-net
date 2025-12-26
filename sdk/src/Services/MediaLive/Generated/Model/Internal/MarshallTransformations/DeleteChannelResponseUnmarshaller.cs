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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeleteChannel operation
    /// </summary>  
    public class DeleteChannelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DeleteChannelResponse response = new DeleteChannelResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("anywhereSettings", targetDepth))
                {
                    var unmarshaller = DescribeAnywhereSettingsUnmarshaller.Instance;
                    response.AnywhereSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cdiInputSpecification", targetDepth))
                {
                    var unmarshaller = CdiInputSpecificationUnmarshaller.Instance;
                    response.CdiInputSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChannelClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelEngineVersion", targetDepth))
                {
                    var unmarshaller = ChannelEngineVersionResponseUnmarshaller.Instance;
                    response.ChannelEngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputDestination, OutputDestinationUnmarshaller>(OutputDestinationUnmarshaller.Instance);
                    response.Destinations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("egressEndpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChannelEgressEndpoint, ChannelEgressEndpointUnmarshaller>(ChannelEgressEndpointUnmarshaller.Instance);
                    response.EgressEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encoderSettings", targetDepth))
                {
                    var unmarshaller = EncoderSettingsUnmarshaller.Instance;
                    response.EncoderSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputAttachments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputAttachment, InputAttachmentUnmarshaller>(InputAttachmentUnmarshaller.Instance);
                    response.InputAttachments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputSpecification", targetDepth))
                {
                    var unmarshaller = InputSpecificationUnmarshaller.Instance;
                    response.InputSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linkedChannelSettings", targetDepth))
                {
                    var unmarshaller = DescribeLinkedChannelSettingsUnmarshaller.Instance;
                    response.LinkedChannelSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LogLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenance", targetDepth))
                {
                    var unmarshaller = MaintenanceStatusUnmarshaller.Instance;
                    response.Maintenance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PipelineDetail, PipelineDetailUnmarshaller>(PipelineDetailUnmarshaller.Instance);
                    response.PipelineDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelinesRunningCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.PipelinesRunningCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpc", targetDepth))
                {
                    var unmarshaller = VpcOutputSettingsDescriptionUnmarshaller.Instance;
                    response.Vpc = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadGatewayException"))
                {
                    return BadGatewayExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
                {
                    return ForbiddenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("GatewayTimeoutException"))
                {
                    return GatewayTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonMediaLiveException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DeleteChannelResponseUnmarshaller _instance = new DeleteChannelResponseUnmarshaller();        

        internal static DeleteChannelResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteChannelResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}