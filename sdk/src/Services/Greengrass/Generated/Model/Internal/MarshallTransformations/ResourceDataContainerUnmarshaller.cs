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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDataContainer Object
    /// </summary>  
    public class ResourceDataContainerUnmarshaller : IUnmarshaller<ResourceDataContainer, XmlUnmarshallerContext>, IUnmarshaller<ResourceDataContainer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceDataContainer IUnmarshaller<ResourceDataContainer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDataContainer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceDataContainer unmarshalledObject = new ResourceDataContainer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LocalDeviceResourceData", targetDepth))
                {
                    var unmarshaller = LocalDeviceResourceDataUnmarshaller.Instance;
                    unmarshalledObject.LocalDeviceResourceData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalVolumeResourceData", targetDepth))
                {
                    var unmarshaller = LocalVolumeResourceDataUnmarshaller.Instance;
                    unmarshalledObject.LocalVolumeResourceData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3MachineLearningModelResourceData", targetDepth))
                {
                    var unmarshaller = S3MachineLearningModelResourceDataUnmarshaller.Instance;
                    unmarshalledObject.S3MachineLearningModelResourceData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SageMakerMachineLearningModelResourceData", targetDepth))
                {
                    var unmarshaller = SageMakerMachineLearningModelResourceDataUnmarshaller.Instance;
                    unmarshalledObject.SageMakerMachineLearningModelResourceData = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceDataContainerUnmarshaller _instance = new ResourceDataContainerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDataContainerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}