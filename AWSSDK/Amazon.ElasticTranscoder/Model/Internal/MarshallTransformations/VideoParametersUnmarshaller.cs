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
    /// Response Unmarshaller for VideoParameters Object
    /// </summary>  
    public class VideoParametersUnmarshaller : IUnmarshaller<VideoParameters, XmlUnmarshallerContext>, IUnmarshaller<VideoParameters, JsonUnmarshallerContext>
    {
        VideoParameters IUnmarshaller<VideoParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public VideoParameters Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new VideoParameters();
            unmarshalledObject.CodecOptions = null;
            unmarshalledObject.Watermarks = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("AspectRatio", targetDepth))
                    {
                        unmarshalledObject.AspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BitRate", targetDepth))
                    {
                        unmarshalledObject.BitRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Codec", targetDepth))
                    {
                        unmarshalledObject.Codec = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CodecOptions", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.CodecOptions =  null;
                            continue;
                        }
                        unmarshalledObject.CodecOptions = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.CodecOptions.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("DisplayAspectRatio", targetDepth))
                    {
                        unmarshalledObject.DisplayAspectRatio = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FixedGOP", targetDepth))
                    {
                        unmarshalledObject.FixedGOP = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FrameRate", targetDepth))
                    {
                        unmarshalledObject.FrameRate = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KeyframesMaxDist", targetDepth))
                    {
                        unmarshalledObject.KeyframesMaxDist = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxFrameRate", targetDepth))
                    {
                        unmarshalledObject.MaxFrameRate = StringUnmarshaller.GetInstance().Unmarshall(context);
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
                    if (context.TestExpression("PaddingPolicy", targetDepth))
                    {
                        unmarshalledObject.PaddingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Resolution", targetDepth))
                    {
                        unmarshalledObject.Resolution = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SizingPolicy", targetDepth))
                    {
                        unmarshalledObject.SizingPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Watermarks", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Watermarks =  null;
                            continue;
                        }
                        unmarshalledObject.Watermarks = new List<PresetWatermark>();
                        var unmarshaller = PresetWatermarkUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Watermarks.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
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


        private static VideoParametersUnmarshaller instance;
        public static VideoParametersUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new VideoParametersUnmarshaller();
            }
            return instance;
        }

    }
}