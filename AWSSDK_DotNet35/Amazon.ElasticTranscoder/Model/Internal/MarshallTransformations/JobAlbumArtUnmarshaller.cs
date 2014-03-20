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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobAlbumArtUnmarshaller
      /// </summary>
      internal class JobAlbumArtUnmarshaller : IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>, IUnmarshaller<JobAlbumArt, JsonUnmarshallerContext>
      {
        JobAlbumArt IUnmarshaller<JobAlbumArt, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobAlbumArt Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            JobAlbumArt jobAlbumArt = new JobAlbumArt();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("MergePolicy", targetDepth))
              {
                jobAlbumArt.MergePolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Artwork", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Artwork,ArtworkUnmarshaller>(
                    ArtworkUnmarshaller.GetInstance());                  
                jobAlbumArt.Artwork = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return jobAlbumArt;
        }

        private static JobAlbumArtUnmarshaller instance;
        public static JobAlbumArtUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobAlbumArtUnmarshaller();
            return instance;
        }
    }
}
  
