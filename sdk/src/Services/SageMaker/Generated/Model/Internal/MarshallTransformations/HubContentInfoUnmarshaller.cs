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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HubContentInfo Object
    /// </summary>  
    public class HubContentInfoUnmarshaller : IJsonUnmarshaller<HubContentInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HubContentInfo Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HubContentInfo unmarshalledObject = new HubContentInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DocumentSchemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentSchemaVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentDisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentSearchKeywords", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.HubContentSearchKeywords = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HubContentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HubContentVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OriginalCreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.OriginalCreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SageMakerPublicHubContentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SageMakerPublicHubContentArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SupportStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SupportStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HubContentInfoUnmarshaller _instance = new HubContentInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HubContentInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}