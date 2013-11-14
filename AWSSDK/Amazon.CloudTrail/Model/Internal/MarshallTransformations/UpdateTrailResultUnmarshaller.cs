/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.CloudTrail.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// UpdateTrailResultUnmarshaller
      /// </summary>
      internal class UpdateTrailResultUnmarshaller : IUnmarshaller<UpdateTrailResult, XmlUnmarshallerContext>, IUnmarshaller<UpdateTrailResult, JsonUnmarshallerContext>
      {
        UpdateTrailResult IUnmarshaller<UpdateTrailResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public UpdateTrailResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            UpdateTrailResult updateTrailResult = new UpdateTrailResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Trail", targetDepth))
              {
                updateTrailResult.Trail = TrailUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return updateTrailResult;
                }
            }
          

            return updateTrailResult;
        }

        private static UpdateTrailResultUnmarshaller instance;
        public static UpdateTrailResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new UpdateTrailResultUnmarshaller();
            return instance;
        }
    }
}
  
