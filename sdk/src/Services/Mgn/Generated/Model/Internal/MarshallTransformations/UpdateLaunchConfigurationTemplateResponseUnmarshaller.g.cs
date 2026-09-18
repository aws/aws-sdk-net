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
    /// Response Unmarshaller for UpdateLaunchConfigurationTemplate operation.
    /// </summary>
    public partial class UpdateLaunchConfigurationTemplateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new UpdateLaunchConfigurationTemplateResponse();
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

                if (context.TestExpression("associatePublicIpAddress", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("bootMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BootMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("copyPrivateIp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CopyPrivateIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("copyTags", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ec2LaunchTemplateID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2LaunchTemplateID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("enableMapAutoTagging", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableMapAutoTagging = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("enableParametersEncryption", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.EnableParametersEncryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("largeVolumeConf", targetDepth, ref reader))
                {
                    var unmarshaller = LaunchTemplateDiskConfUnmarshaller.Instance;
                    unmarshalledObject.LargeVolumeConf = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("launchConfigurationTemplateID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchConfigurationTemplateID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("launchDisposition", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchDisposition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("licensing", targetDepth, ref reader))
                {
                    var unmarshaller = LicensingUnmarshaller.Instance;
                    unmarshalledObject.Licensing = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("mapAutoTaggingMpeID", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MapAutoTaggingMpeID = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("parametersEncryptionKey", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParametersEncryptionKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("postLaunchActions", targetDepth, ref reader))
                {
                    var unmarshaller = PostLaunchActionsUnmarshaller.Instance;
                    unmarshalledObject.PostLaunchActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("smallVolumeConf", targetDepth, ref reader))
                {
                    var unmarshaller = LaunchTemplateDiskConfUnmarshaller.Instance;
                    unmarshalledObject.SmallVolumeConf = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("smallVolumeMaxSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.SmallVolumeMaxSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("targetInstanceTypeRightSizingMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetInstanceTypeRightSizingMethod = unmarshaller.Unmarshall(context, ref reader);
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

        private static UpdateLaunchConfigurationTemplateResponseUnmarshaller _instance = new UpdateLaunchConfigurationTemplateResponseUnmarshaller();

        internal static UpdateLaunchConfigurationTemplateResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateLaunchConfigurationTemplateResponseUnmarshaller Instance => _instance;
    }
}
