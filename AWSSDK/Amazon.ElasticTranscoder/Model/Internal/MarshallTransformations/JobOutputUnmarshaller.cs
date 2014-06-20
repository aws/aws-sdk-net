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
    /// Response Unmarshaller for JobOutput Object
    /// </summary>  
    public class JobOutputUnmarshaller : IUnmarshaller<JobOutput, XmlUnmarshallerContext>, IUnmarshaller<JobOutput, JsonUnmarshallerContext>
    {
        JobOutput IUnmarshaller<JobOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public JobOutput Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new JobOutput();
            unmarshalledObject.Composition = null;
            unmarshalledObject.Watermarks = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("AlbumArt", targetDepth))
                    {
                        unmarshalledObject.AlbumArt = JobAlbumArtUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Captions", targetDepth))
                    {
                        unmarshalledObject.Captions = CaptionsUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Composition", targetDepth))
                    {
                        unmarshalledObject.Composition = new List<Clip>();
                        var unmarshaller = ClipUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Composition.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Duration", targetDepth))
                    {
                        unmarshalledObject.Duration = LongUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Height", targetDepth))
                    {
                        unmarshalledObject.Height = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        unmarshalledObject.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        unmarshalledObject.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PresetId", targetDepth))
                    {
                        unmarshalledObject.PresetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Rotate", targetDepth))
                    {
                        unmarshalledObject.Rotate = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SegmentDuration", targetDepth))
                    {
                        unmarshalledObject.SegmentDuration = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        unmarshalledObject.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusDetail", targetDepth))
                    {
                        unmarshalledObject.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ThumbnailPattern", targetDepth))
                    {
                        unmarshalledObject.ThumbnailPattern = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Watermarks", targetDepth))
                    {
                        unmarshalledObject.Watermarks = new List<JobWatermark>();
                        var unmarshaller = JobWatermarkUnmarshaller.GetInstance();
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
                    if (context.TestExpression("Width", targetDepth))
                    {
                        unmarshalledObject.Width = IntUnmarshaller.GetInstance().Unmarshall(context);
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


        private static JobOutputUnmarshaller instance;
        public static JobOutputUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new JobOutputUnmarshaller();
            }
            return instance;
        }

    }
}