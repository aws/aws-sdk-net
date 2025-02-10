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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipelineActivity Object
    /// </summary>  
    public class PipelineActivityUnmarshaller : IJsonUnmarshaller<PipelineActivity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PipelineActivity Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PipelineActivity unmarshalledObject = new PipelineActivity();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("addAttributes", targetDepth))
                {
                    var unmarshaller = AddAttributesActivityUnmarshaller.Instance;
                    unmarshalledObject.AddAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("channel", targetDepth))
                {
                    var unmarshaller = ChannelActivityUnmarshaller.Instance;
                    unmarshalledObject.Channel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("datastore", targetDepth))
                {
                    var unmarshaller = DatastoreActivityUnmarshaller.Instance;
                    unmarshalledObject.Datastore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deviceRegistryEnrich", targetDepth))
                {
                    var unmarshaller = DeviceRegistryEnrichActivityUnmarshaller.Instance;
                    unmarshalledObject.DeviceRegistryEnrich = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deviceShadowEnrich", targetDepth))
                {
                    var unmarshaller = DeviceShadowEnrichActivityUnmarshaller.Instance;
                    unmarshalledObject.DeviceShadowEnrich = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filter", targetDepth))
                {
                    var unmarshaller = FilterActivityUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambda", targetDepth))
                {
                    var unmarshaller = LambdaActivityUnmarshaller.Instance;
                    unmarshalledObject.Lambda = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("math", targetDepth))
                {
                    var unmarshaller = MathActivityUnmarshaller.Instance;
                    unmarshalledObject.Math = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("removeAttributes", targetDepth))
                {
                    var unmarshaller = RemoveAttributesActivityUnmarshaller.Instance;
                    unmarshalledObject.RemoveAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("selectAttributes", targetDepth))
                {
                    var unmarshaller = SelectAttributesActivityUnmarshaller.Instance;
                    unmarshalledObject.SelectAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipelineActivityUnmarshaller _instance = new PipelineActivityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipelineActivityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}