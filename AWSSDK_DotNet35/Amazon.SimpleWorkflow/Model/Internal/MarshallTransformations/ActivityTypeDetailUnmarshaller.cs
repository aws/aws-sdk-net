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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ActivityTypeDetailUnmarshaller
      /// </summary>
      internal class ActivityTypeDetailUnmarshaller : IUnmarshaller<ActivityTypeDetail, XmlUnmarshallerContext>, IUnmarshaller<ActivityTypeDetail, JsonUnmarshallerContext>
      {
        ActivityTypeDetail IUnmarshaller<ActivityTypeDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTypeDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTypeDetail activityTypeDetail = new ActivityTypeDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("typeInfo", targetDepth))
              {
                activityTypeDetail.TypeInfo = ActivityTypeInfoUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("configuration", targetDepth))
              {
                activityTypeDetail.Configuration = ActivityTypeConfigurationUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return activityTypeDetail;
        }

        private static ActivityTypeDetailUnmarshaller instance;
        public static ActivityTypeDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTypeDetailUnmarshaller();
            return instance;
        }
    }
}
  
