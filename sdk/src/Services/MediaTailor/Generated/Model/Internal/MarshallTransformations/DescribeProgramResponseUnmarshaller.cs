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

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeProgram operation
    /// </summary>  
    public class DescribeProgramResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeProgramResponse response = new DescribeProgramResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdBreaks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AdBreak, AdBreakUnmarshaller>(AdBreakUnmarshaller.Instance);
                    response.AdBreaks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChannelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChannelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClipRange", targetDepth))
                {
                    var unmarshaller = ClipRangeUnmarshaller.Instance;
                    response.ClipRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DurationMillis", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.DurationMillis = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LiveSourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LiveSourceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProgramName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProgramName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ScheduledStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceLocationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceLocationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VodSourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VodSourceName = unmarshaller.Unmarshall(context);
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

        private static DescribeProgramResponseUnmarshaller _instance = new DescribeProgramResponseUnmarshaller();        

        internal static DescribeProgramResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProgramResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}