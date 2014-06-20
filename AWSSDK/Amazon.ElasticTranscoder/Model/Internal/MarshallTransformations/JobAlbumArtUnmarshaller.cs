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
    /// Response Unmarshaller for JobAlbumArt Object
    /// </summary>  
    public class JobAlbumArtUnmarshaller : IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>, IUnmarshaller<JobAlbumArt, JsonUnmarshallerContext>
    {
        JobAlbumArt IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public JobAlbumArt Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new JobAlbumArt();
            unmarshalledObject.Artwork = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Artwork", targetDepth))
                    {
                        unmarshalledObject.Artwork = new List<Artwork>();
                        var unmarshaller = ArtworkUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Artwork.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("MergePolicy", targetDepth))
                    {
                        unmarshalledObject.MergePolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
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


        private static JobAlbumArtUnmarshaller instance;
        public static JobAlbumArtUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new JobAlbumArtUnmarshaller();
            }
            return instance;
        }

    }
}