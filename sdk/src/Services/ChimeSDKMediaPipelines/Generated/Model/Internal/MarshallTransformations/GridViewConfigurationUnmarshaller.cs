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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GridViewConfiguration Object
    /// </summary>  
    public class GridViewConfigurationUnmarshaller : IUnmarshaller<GridViewConfiguration, XmlUnmarshallerContext>, IUnmarshaller<GridViewConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GridViewConfiguration IUnmarshaller<GridViewConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GridViewConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GridViewConfiguration unmarshalledObject = new GridViewConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActiveSpeakerOnlyConfiguration", targetDepth))
                {
                    var unmarshaller = ActiveSpeakerOnlyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ActiveSpeakerOnlyConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CanvasOrientation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CanvasOrientation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContentShareLayout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentShareLayout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HorizontalLayoutConfiguration", targetDepth))
                {
                    var unmarshaller = HorizontalLayoutConfigurationUnmarshaller.Instance;
                    unmarshalledObject.HorizontalLayoutConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PresenterOnlyConfiguration", targetDepth))
                {
                    var unmarshaller = PresenterOnlyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PresenterOnlyConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerticalLayoutConfiguration", targetDepth))
                {
                    var unmarshaller = VerticalLayoutConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VerticalLayoutConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VideoAttribute", targetDepth))
                {
                    var unmarshaller = VideoAttributeUnmarshaller.Instance;
                    unmarshalledObject.VideoAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GridViewConfigurationUnmarshaller _instance = new GridViewConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GridViewConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}