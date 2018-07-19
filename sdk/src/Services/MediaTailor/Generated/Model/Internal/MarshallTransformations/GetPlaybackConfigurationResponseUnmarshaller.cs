/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetPlaybackConfiguration operation
    /// </summary>  
    public class GetPlaybackConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetPlaybackConfigurationResponse response = new GetPlaybackConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdDecisionServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AdDecisionServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdnConfiguration", targetDepth))
                {
                    var unmarshaller = CdnConfigurationUnmarshaller.Instance;
                    response.CdnConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HlsConfiguration", targetDepth))
                {
                    var unmarshaller = HlsConfigurationUnmarshaller.Instance;
                    response.HlsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaybackEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaybackEndpointPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SessionInitializationEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SessionInitializationEndpointPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SlateAdUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SlateAdUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VideoContentSourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VideoContentSourceUrl = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonMediaTailorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetPlaybackConfigurationResponseUnmarshaller _instance = new GetPlaybackConfigurationResponseUnmarshaller();        

        internal static GetPlaybackConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPlaybackConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}