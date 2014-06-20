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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PresetWatermark Object
    /// </summary>  
    public class PresetWatermarkUnmarshaller : IUnmarshaller<PresetWatermark, XmlUnmarshallerContext>, IUnmarshaller<PresetWatermark, JsonUnmarshallerContext>
    {
        PresetWatermark IUnmarshaller<PresetWatermark, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public PresetWatermark Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new PresetWatermark();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("HorizontalAlign", targetDepth))
                    {
                        unmarshalledObject.HorizontalAlign = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HorizontalOffset", targetDepth))
                    {
                        unmarshalledObject.HorizontalOffset = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        unmarshalledObject.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxHeight", targetDepth))
                    {
                        unmarshalledObject.MaxHeight = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxWidth", targetDepth))
                    {
                        unmarshalledObject.MaxWidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Opacity", targetDepth))
                    {
                        unmarshalledObject.Opacity = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SizingPolicy", targetDepth))
                    {
                        unmarshalledObject.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Target", targetDepth))
                    {
                        unmarshalledObject.Target = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VerticalAlign", targetDepth))
                    {
                        unmarshalledObject.VerticalAlign = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VerticalOffset", targetDepth))
                    {
                        unmarshalledObject.VerticalOffset = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static PresetWatermarkUnmarshaller instance;
        public static PresetWatermarkUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new PresetWatermarkUnmarshaller();
            }
            return instance;
        }

    }
}