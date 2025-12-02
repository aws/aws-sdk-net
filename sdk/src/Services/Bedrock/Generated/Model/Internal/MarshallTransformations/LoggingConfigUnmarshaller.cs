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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LoggingConfig Object
    /// </summary>  
    public class LoggingConfigUnmarshaller : IUnmarshaller<LoggingConfig, XmlUnmarshallerContext>, IUnmarshaller<LoggingConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LoggingConfig IUnmarshaller<LoggingConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LoggingConfig Unmarshall(JsonUnmarshallerContext context)
        {
            LoggingConfig unmarshalledObject = new LoggingConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDataDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AudioDataDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cloudWatchConfig", targetDepth))
                {
                    var unmarshaller = CloudWatchConfigUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("embeddingDataDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EmbeddingDataDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageDataDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ImageDataDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Config", targetDepth))
                {
                    var unmarshaller = S3ConfigUnmarshaller.Instance;
                    unmarshalledObject.S3Config = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("textDataDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.TextDataDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoDataDeliveryEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.VideoDataDeliveryEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LoggingConfigUnmarshaller _instance = new LoggingConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LoggingConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}