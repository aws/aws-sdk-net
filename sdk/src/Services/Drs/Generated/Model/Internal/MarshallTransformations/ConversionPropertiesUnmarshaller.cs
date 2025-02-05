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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConversionProperties Object
    /// </summary>  
    public class ConversionPropertiesUnmarshaller : IJsonUnmarshaller<ConversionProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConversionProperties Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConversionProperties unmarshalledObject = new ConversionProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("dataTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forceUefi", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ForceUefi = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rootVolumeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootVolumeName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumeToConversionMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.VolumeToConversionMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumeToProductCodes", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<ProductCode>, StringUnmarshaller, JsonListUnmarshaller<ProductCode,ProductCodeUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<ProductCode, ProductCodeUnmarshaller>(ProductCodeUnmarshaller.Instance));
                    unmarshalledObject.VolumeToProductCodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumeToVolumeSize", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance);
                    unmarshalledObject.VolumeToVolumeSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConversionPropertiesUnmarshaller _instance = new ConversionPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConversionPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}