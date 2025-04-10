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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigureLogsForPlaybackConfiguration operation
    /// </summary>  
    public class ConfigureLogsForPlaybackConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ConfigureLogsForPlaybackConfigurationResponse response = new ConfigureLogsForPlaybackConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdsInteractionLog", targetDepth))
                {
                    var unmarshaller = AdsInteractionLogUnmarshaller.Instance;
                    response.AdsInteractionLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnabledLoggingStrategies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.EnabledLoggingStrategies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestServiceInteractionLog", targetDepth))
                {
                    var unmarshaller = ManifestServiceInteractionLogUnmarshaller.Instance;
                    response.ManifestServiceInteractionLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PercentEnabled", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.PercentEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaybackConfigurationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaybackConfigurationName = unmarshaller.Unmarshall(context);
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
            }
            return new AmazonMediaTailorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static ConfigureLogsForPlaybackConfigurationResponseUnmarshaller _instance = new ConfigureLogsForPlaybackConfigurationResponseUnmarshaller();        

        internal static ConfigureLogsForPlaybackConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigureLogsForPlaybackConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}