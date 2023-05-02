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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImageScanFindingAggregation Object
    /// </summary>  
    public class ImageScanFindingAggregationUnmarshaller : IUnmarshaller<ImageScanFindingAggregation, XmlUnmarshallerContext>, IUnmarshaller<ImageScanFindingAggregation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImageScanFindingAggregation IUnmarshaller<ImageScanFindingAggregation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ImageScanFindingAggregation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ImageScanFindingAggregation unmarshalledObject = new ImageScanFindingAggregation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountAggregation", targetDepth))
                {
                    var unmarshaller = AccountAggregationUnmarshaller.Instance;
                    unmarshalledObject.AccountAggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageAggregation", targetDepth))
                {
                    var unmarshaller = ImageAggregationUnmarshaller.Instance;
                    unmarshalledObject.ImageAggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imagePipelineAggregation", targetDepth))
                {
                    var unmarshaller = ImagePipelineAggregationUnmarshaller.Instance;
                    unmarshalledObject.ImagePipelineAggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vulnerabilityIdAggregation", targetDepth))
                {
                    var unmarshaller = VulnerabilityIdAggregationUnmarshaller.Instance;
                    unmarshalledObject.VulnerabilityIdAggregation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ImageScanFindingAggregationUnmarshaller _instance = new ImageScanFindingAggregationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImageScanFindingAggregationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}