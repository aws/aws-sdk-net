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

#pragma warning disable CS0612,CS0618
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConversionProperties Object
    /// </summary>  
    public class ConversionPropertiesUnmarshaller : IUnmarshaller<ConversionProperties, XmlUnmarshallerContext>, IUnmarshaller<ConversionProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConversionProperties IUnmarshaller<ConversionProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConversionProperties Unmarshall(JsonUnmarshallerContext context)
        {
            ConversionProperties unmarshalledObject = new ConversionProperties();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dataTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceUefi", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceUefi = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rootVolumeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RootVolumeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeToConversionMap", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.VolumeToConversionMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeToProductCodes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<ProductCode>, StringUnmarshaller, ListUnmarshaller<ProductCode, ProductCodeUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<ProductCode, ProductCodeUnmarshaller>(ProductCodeUnmarshaller.Instance));
                    unmarshalledObject.VolumeToProductCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("volumeToVolumeSize", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, long, StringUnmarshaller, LongUnmarshaller>(StringUnmarshaller.Instance, LongUnmarshaller.Instance);
                    unmarshalledObject.VolumeToVolumeSize = unmarshaller.Unmarshall(context);
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